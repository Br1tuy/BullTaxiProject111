﻿using System;
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
    public partial class OrdersForm : Form
    {
        Dictionary<string, string> dict;
        Dictionary<string, Dictionary<string, string>> active_orders;
        Dictionary<string, Dictionary<string, string>> completed_orders;

        public OrdersForm()
        {
            InitializeComponent();
        }
        string[] table_active_columns = new string[] { "Id", "OpeningTime", "StartingAddress", "FinalAddress" };
        string[] table_active_headers = new string[] { "Id", "Час відкриття", "Початкова адреса", "Кінцева адреса" };
        string[] table_completed_columns = new string[] { "Id", "Driver", "OpeningTime", "ClosingTime", "StartingAddress", "FinalAddress", "Price" };
        string[] table_completed_headers = new string[] { "Id", "Водій", "Час відкриття", "Час закриття", "Початкова адреса", "Кінцева адреса", "Ціна" };

        private void AddActiveOrderButton_Click(object sender, EventArgs e)
        {
            AddOrders AddOrdersForm = new AddOrders();

            AddOrdersForm.ShowDialog();
        }

        private void ChangeActiveOrderButton_Click(object sender, EventArgs e)
        {
            ChangeActiveOrderForm changeActiveOrderForm = new ChangeActiveOrderForm();

            changeActiveOrderForm.ShowDialog();
        }

        private void ChangeCompletedOrderButton_Click(object sender, EventArgs e)
        {
            ChangingCompletedOrderForm changingCompletedOrderForm = new ChangingCompletedOrderForm();

            changingCompletedOrderForm.ShowDialog();
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


                if (active_orders != null)
                {
                    foreach (var items in active_orders)
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

        private void AddCompletedOrderButton_Click(object sender, EventArgs e)
        {
            AddCompletedOrderForm addCompletedOrderForm = new AddCompletedOrderForm();

            addCompletedOrderForm.ShowDialog();
        }

        private void Table_Load(object sender, EventArgs e)
        {
            for (int c = 0; c < 4; c++)
            {
                Table.Columns.Add(table_active_columns[c], table_active_headers[c]);
            }
        }


        private void DeleteActiveOrderButton_Click(object sender, EventArgs e)
        {
            DeleteActiveOrderForm deleteActiveOrderForm = new DeleteActiveOrderForm();

            deleteActiveOrderForm.ShowDialog();
        }

        private void DeleteCompletedOrderButton_Click(object sender, EventArgs e)
        {
            DeleteCompletedOrderForm deleteCompletedOrder = new DeleteCompletedOrderForm();

            deleteCompletedOrder.ShowDialog();
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

        private void ActiveOrdersMapButton_Click(object sender, EventArgs e)
        {
            ActiveOrdersMapForm activeOrdersMapForm = new ActiveOrdersMapForm();
            activeOrdersMapForm.Show();
        }
    }
}
