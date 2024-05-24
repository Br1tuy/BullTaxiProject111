using BullTaxi;
using MainFormBullTaxi;
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
    public partial class MainOperatorForm : Form
    {
        Point dragCursorPoint;
        Point dragFormPoint;
        bool dragging = false;
        bool sidebarExpand = true;
        FormUser user;
        OrdersOperatorForm orders;
        public MainOperatorForm()
        {
            InitializeComponent();
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                SidebarPanel.Width -= 5;
                if (SidebarPanel.Width <= 45)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    OrdersButton.Width = SidebarPanel.Width;
                    

                    ExitButton.Width = SidebarPanel.Width;
                }
            }
            else
            {
                SidebarPanel.Width += 5;
                if (SidebarPanel.Width >= 198)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                    OrdersButton.Width = SidebarPanel.Width;
                   

                    ExitButton.Width = SidebarPanel.Width;

                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TurnButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                user.Hide();
            }
            if (orders == null)
            {
                orders = new OrdersOperatorForm();
                orders.FormClosed += OrderOperator_FormClosed;
                orders.MdiParent = this; 
                orders.Show();
            }
            else
            {
                orders.Show();
            }
        }
        private void OrderOperator_FormClosed(object sender, FormClosedEventArgs e)
        {
            orders = null;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
