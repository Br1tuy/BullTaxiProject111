using BullTaxi;
using BullTaxiProject11;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFormBullTaxi
{
    public partial class BullTaxiMainForm : Form
    {
        FormUser user;
        OrdersForm orders;
        Point dragCursorPoint;
        Point dragFormPoint;
        bool dragging = false;


        public BullTaxiMainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Orders_FormClosed(object sender, FormClosedEventArgs e)
        {
            orders = null;
        }

        bool sidebarExpand = true;
        private object esle;


        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            user = null;
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                user.Hide();
            }
            if (orders == null)
            {
                orders = new OrdersForm();
                orders.FormClosed += Orders_FormClosed;
                orders.MdiParent = this;
                orders.Show();
            }
            else
            {
                orders.Show();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
        }

        private void btnHam_Click_2(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void sidebarTransition_Tick_1(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                SidebarPanel.Width -= 5;
                if (SidebarPanel.Width <= 45)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    OrdersButton.Width = SidebarPanel.Width;
                    UsersButton.Width = SidebarPanel.Width;
                    
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
                    UsersButton.Width = SidebarPanel.Width;
                    
                    ExitButton.Width = SidebarPanel.Width;

                }
            }
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            if (orders != null)
            {
                orders.Hide();
            }    
            if (user == null)
            {
                user = new FormUser();
                user.FormClosed += User_FormClosed;
                user.MdiParent = this;
                user.Show();
            }
            else
            {
                user.Show();
            }
        }

        private void TurnButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
            }
        }


        private void FullSizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
    }
}
    
