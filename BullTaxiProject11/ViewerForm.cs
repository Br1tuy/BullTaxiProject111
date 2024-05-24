using BullTaxi;
using MainFormBullTaxi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullTaxiProject11
{
    public partial class ViewerForm : Form
    {
        Dictionary<string, string> dict;
        Dictionary<string, Dictionary<string, string>> completed_orders;
        public ViewerForm()
        {
            InitializeComponent();

            for (int c = 0; c < 7; c++)
            {
                Table.Columns.Add(table_completed_columns[c], table_completed_headers[c]);
            }
        }
        string[] table_completed_columns = new string[] { "Id", "Driver", "OpeningTime", "ClosingTime", "StartingAddress", "FinalAddress", "Price" };
        string[] table_completed_headers = new string[] { "Id", "Водій", "Час відкриття", "Час закриття", "Початкова адреса", "Кінцева адреса", "Ціна" };

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri("http://127.0.0.1:8000/logaut/");
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            FormUrlEncodedContent form = new FormUrlEncodedContent(parameters);

            var answer = ProgramClient.Client.PostAsync(uri, form).Result;
            Dictionary<string, string> dict = JsonSerializer.Deserialize<Dictionary<string, string>>(answer.Content.ReadAsStringAsync().Result);

            if (dict["Status"] == "Success")
            {
                this.Close();
                LoginForm LoginForm = new LoginForm();
                LoginForm.Show();
            }
            else
            {
                MessageBox.Show(dict["Message"]);
            }
        }

        private void TurnButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
