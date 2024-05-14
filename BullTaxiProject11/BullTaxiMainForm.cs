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
        
        

        public BullTaxiMainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BullTaxiMainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (orders == null)
            {
                orders = new OrdersForm();
                orders.FormClosed += Orders_FormClosed;
                orders.MdiParent = this;
                orders.Show();
            }
            else
            {
                orders.Activate();
            }
        }

        private void Orders_FormClosed(object sender, FormClosedEventArgs e)
        {
            orders = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        bool sidebarExpand = true;
        private object esle;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 45)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    pnorder.Width = sidebar.Width;
                    users.Width = sidebar.Width;
                    settings.Width = sidebar.Width;
                    Exit.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 198)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                    pnorder.Width = sidebar.Width;
                    users.Width = sidebar.Width;
                    settings.Width = sidebar.Width;
                    Exit.Width = sidebar.Width;

                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void users_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                user = new FormUser();
                user.FormClosed += User_FormClosed;
                user.MdiParent = this;
                user.Show();
            }
            else
            {
                user.Activate();
            }
        }



        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            user = null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;

            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void settings_Click(object sender, EventArgs e)
        {

        }

        private void pnorder_Click(object sender, EventArgs e)
        {
            if (orders == null)
            {
                orders = new OrdersForm();
                orders.FormClosed += Orders_FormClosed;
                orders.MdiParent = this;
                orders.Show();
            }
            else
            {
                orders.Activate();
            }
        }

        private void users_Click_1(object sender, EventArgs e)
        {
            if (user == null)
            {
                user = new FormUser();
                user.FormClosed += User_FormClosed;
                user.MdiParent = this;
                user.Show();
            }
            else
            {
                user.Activate();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
        }

        private void closebtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHam_Click_1(object sender, EventArgs e)
        {

        }



        private void btnHam_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnHam_Click_2(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void sidebarTransition_Tick_1(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 45)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    pnorder.Width = sidebar.Width;
                    users.Width = sidebar.Width;
                    settings.Width = sidebar.Width;
                    Exit.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 198)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                    pnorder.Width = sidebar.Width;
                    users.Width = sidebar.Width;
                    settings.Width = sidebar.Width;
                    Exit.Width = sidebar.Width;

                }
            }
        }

        private void users_Click_2(object sender, EventArgs e)
        {

            if (user == null)
            {
                user = new FormUser();
                user.FormClosed += User_FormClosed;
                user.MdiParent = this;
                user.Show();
            }
            else
            {
                user.Activate();
            }
        }
    }
}
    
