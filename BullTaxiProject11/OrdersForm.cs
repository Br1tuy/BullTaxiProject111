using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullTaxiProject11
{
    public partial class OrdersForm : Form
    {
        DateTime date;
        Timer timer;
        bool isTimerRunning;
        public OrdersForm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 10; // Set the interval here if it's constant
            timer.Tick += new EventHandler(timerTick);
            this.StartPosition = FormStartPosition.CenterScreen;


        }
        const int TABLE_ROW_COUNT = 10;
        const int TABLE_COLUMN_COUNT = 10;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AddOrders AddOrdersForm = new AddOrders();

            AddOrdersForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangeActiveOrderForm changeActiveOrderForm = new ChangeActiveOrderForm();

            changeActiveOrderForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangingCompletedOrderForm changingCompletedOrderForm = new ChangingCompletedOrderForm();

            changingCompletedOrderForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            date = DateTime.Now;
            timer.Interval = 10; // Set the interval here if it's constant
            timer.Tick += new EventHandler(timerTick); // Correct event handler assignment
            
        }

        private void timerTick(object sender, EventArgs e)
        {
            long tick = DateTime.Now.Ticks - date.Ticks;
            DateTime stopWatch = new DateTime();
            stopWatch = stopWatch.AddTicks(tick);
            label1.Text = String.Format("{0:HH:mm:ss:ff}", stopWatch);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!isTimerRunning)
            {
                timer.Start();
                isTimerRunning = true;
            }
            else
            {
                timer.Stop();
                isTimerRunning = false;
            }   
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangingCompletedOrderForm changingCompletedOrderForm = new ChangingCompletedOrderForm();
            changingCompletedOrderForm.Show();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
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
    }
}
