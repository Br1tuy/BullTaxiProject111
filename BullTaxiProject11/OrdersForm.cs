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
    public partial class OrdersForm : Form
    {
        DateTime date;
        Timer timer;
        bool isTimerRunning;
        Dictionary<string, string> dict;
        Dictionary<string, Dictionary<string, string>> active_orders;
        Dictionary<string, Dictionary<string, string>> completed_orders;

        public OrdersForm()
        {
            InitializeComponent();
        }
        const int TABLE_ROW_COUNT = 10;
        const int TABLE_COLUMN_COUNT = 10;

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
            for(int c =0; c < TABLE_COLUMN_COUNT; c++)
            {
                dataGridView1.Columns.Add(c.ToString(), c.ToString ());

            }
            for(int r = 0; r < TABLE_ROW_COUNT - 1; r++)
            {
                dataGridView1.Rows.Add();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            }
            catch
            {
                dict = JsonSerializer.Deserialize<Dictionary<string, string>>(answer.Content.ReadAsStringAsync().Result);
                MessageBox.Show(dict["Message"]);
            }
        }
    }
}
