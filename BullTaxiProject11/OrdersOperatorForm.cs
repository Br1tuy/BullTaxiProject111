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
    public partial class OrdersOperatorForm : Form
    {
        public OrdersOperatorForm()
        {
            InitializeComponent();
        }

       

        private void AddActiveOrderButton_Click(object sender, EventArgs e)
        {
            AddOrders AddOrdersForm = new AddOrders();

            AddOrdersForm.ShowDialog();
        }

        private void AddCompletedOrderButton_Click(object sender, EventArgs e)
        {
            AddCompletedOrderForm addCompletedOrderForm = new AddCompletedOrderForm();

            addCompletedOrderForm.ShowDialog();
        }

        private void ChangeActiveOrderButton_Click(object sender, EventArgs e)
        {
            ChangeActiveOrderForm changeActiveOrderForm = new ChangeActiveOrderForm();

            changeActiveOrderForm.ShowDialog();
        }

        private void DeleteActiveOrderButton_Click(object sender, EventArgs e)
        {
            DeleteActiveOrderForm deleteActiveOrderForm = new DeleteActiveOrderForm();

            deleteActiveOrderForm.ShowDialog();
        }

        private void ActiveOrdersMapButton_Click(object sender, EventArgs e)
        {
            ActiveOrdersMapForm activeOrdersMapForm = new ActiveOrdersMapForm();
            activeOrdersMapForm.Show();
        }

        private void DriversMapButton_Click(object sender, EventArgs e)
        {
            DriversMapForm driversMapForm = new DriversMapForm();
            driversMapForm.Show();
        }
    }
}
