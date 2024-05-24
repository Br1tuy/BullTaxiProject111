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
    public partial class MainOperatorForm : Form
    {
        
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

        private void FullSizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                Size = Screen.PrimaryScreen.WorkingArea.Size;
                WindowState = FormWindowState.Normal;
            }
        }
    }
}
