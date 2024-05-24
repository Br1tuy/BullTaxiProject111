using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullTaxiProject11
{
    public partial class OrdersOperatorForm : Form
    {
        Dictionary<string, string> dict;
        Dictionary<string, Dictionary<string, string>> active_orders;
        Dictionary<string, Dictionary<string, string>> completed_orders;
        DriversMapForm driversMapForm;
        ActiveOrdersMapForm activeOrdersMapForm;
        AddOrders AddOrdersForm;
        AddCompletedOrderForm addCompletedOrderForm;
        ChangeActiveOrderForm changeActiveOrderForm;
        DeleteActiveOrderForm deleteActiveOrderForm;

        public OrdersOperatorForm()
        {
            InitializeComponent();

            for (int c = 0; c < 4; c++)
            {
                Table.Columns.Add(table_active_columns[c], table_active_headers[c]);
            }
        }
        string[] table_active_columns = new string[] { "Id", "OpeningTime", "StartingAddress", "FinalAddress" };
        string[] table_active_headers = new string[] { "Id", "Час відкриття", "Початкова адреса", "Кінцева адреса" };
        string[] table_completed_columns = new string[] { "Id", "Driver", "OpeningTime", "ClosingTime", "StartingAddress", "FinalAddress", "Price" };
        string[] table_completed_headers = new string[] { "Id", "Водій", "Час відкриття", "Час закриття", "Початкова адреса", "Кінцева адреса", "Ціна" };


        private void AddActiveOrderButton_Click(object sender, EventArgs e)
        {
            if (AddOrdersForm == null || !AddOrdersForm.Created)
            {
                AddOrdersForm = new AddOrders();
                AddOrdersForm.Show();
            }
            else
            {
                AddOrdersForm.WindowState = FormWindowState.Normal;
            }
        }

        private void AddCompletedOrderButton_Click(object sender, EventArgs e)
        {
            if (addCompletedOrderForm == null || !addCompletedOrderForm.Created)
            {
                addCompletedOrderForm = new AddCompletedOrderForm();
                addCompletedOrderForm.Show();
            }
            else
            {
                addCompletedOrderForm.WindowState = FormWindowState.Normal;
            }
        }

        private void ChangeActiveOrderButton_Click(object sender, EventArgs e)
        {
            if (changeActiveOrderForm == null || !changeActiveOrderForm.Created)
            {
                changeActiveOrderForm = new ChangeActiveOrderForm();
                changeActiveOrderForm.Show();
            }
            else
            {
                changeActiveOrderForm.WindowState = FormWindowState.Normal;
            }
        }

        private void DeleteActiveOrderButton_Click(object sender, EventArgs e)
        {
            if (deleteActiveOrderForm == null || !deleteActiveOrderForm.Created)
            {
                deleteActiveOrderForm = new DeleteActiveOrderForm();
                deleteActiveOrderForm.Show();
            }
            else
            {
                deleteActiveOrderForm.WindowState = FormWindowState.Normal;
            }
        }

        private void ActiveOrdersMapButton_Click(object sender, EventArgs e)
        {
            if (activeOrdersMapForm == null || !activeOrdersMapForm.Created)
            {
                activeOrdersMapForm = new ActiveOrdersMapForm();
                activeOrdersMapForm.Show();
            }
            else
            {
                activeOrdersMapForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void DriversMapButton_Click(object sender, EventArgs e)
        {
            if (driversMapForm == null || !driversMapForm.Created)
            {
                driversMapForm = new DriversMapForm();
                driversMapForm.Show();
            }
            else
            {
                driversMapForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void ViewActiveOrderButton_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri("http://127.0.0.1:8000/active_orders_view/");

            var answer = ProgramClient.Client.GetAsync(uri).Result;

            try
            {
                active_orders = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(answer.Content.ReadAsStringAsync().Result);

                Table.Rows.Clear();
                Table.Columns.Clear();

                for (int c = 0; c < 4; c++)
                {
                    Table.Columns.Add(table_active_columns[c], table_active_headers[c]);
                }


                if (active_orders != null)
                {
                    foreach (var items in active_orders)
                    {
                        Table.Invoke(new MethodInvoker(() => Table.Rows.Add(items.Key, items.Value["opening time"], items.Value["starting address"], items.Value["final address"])));
                    }

                    Table.Refresh();
                }
            }
            catch
            {
                dict = JsonSerializer.Deserialize<Dictionary<string, string>>(answer.Content.ReadAsStringAsync().Result);
                MessageBox.Show(dict["Message"]);
            }
        }

        private void ViewCompletedOrderButton_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri("http://127.0.0.1:8000/completed_orders_view/");

            var answer = ProgramClient.Client.GetAsync(uri).Result;

            try
            {
                completed_orders = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(answer.Content.ReadAsStringAsync().Result);

                Table.Rows.Clear();
                Table.Columns.Clear();

                for (int c = 0; c < 7; c++)
                {
                    Table.Columns.Add(table_completed_columns[c], table_completed_headers[c]);
                }


                if (completed_orders != null)
                {
                    foreach (var items in completed_orders)
                    {
                        Table.Invoke(new MethodInvoker(() => Table.Rows.Add(items.Key, items.Value["taxi driver"], items.Value["opening time"], items.Value["closing time"], items.Value["starting address"], items.Value["final address"], items.Value["price"])));
                    }

                    Table.Refresh();
                }
            }
            catch
            {
                dict = JsonSerializer.Deserialize<Dictionary<string, string>>(answer.Content.ReadAsStringAsync().Result);
                MessageBox.Show(dict["Message"]);
            }
        }
    }
}
