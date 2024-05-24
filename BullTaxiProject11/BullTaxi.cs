using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Net.Http;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.Json;
using BullTaxiProject11;

namespace MainFormBullTaxi
{

    public partial class LoginForm : Form
    {
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;


        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BullTaxiMainForm bullTaxiMainForm = new BullTaxiMainForm();
            bullTaxiMainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void EntryButton_Click(object sender, EventArgs e)
        {
            /*
             Uri uri = new Uri("http://127.0.0.1:8000/login/");

             if (Login.Text == "") MessageBox.Show("Введіть логін.");
             else if (Password.Text == "") MessageBox.Show("Введіть пароль.");
             else
             {
                 Dictionary<string, string> parameters = new Dictionary<string, string>()
                 {
                     {"username", Login.Text},
                     {"password", Password.Text},
                 };

                 FormUrlEncodedContent form = new FormUrlEncodedContent(parameters);

                 var answer = ProgramClient.Client.PostAsync(uri, form).Result;
                 Dictionary<string, string> dict = JsonSerializer.Deserialize<Dictionary<string, string>>(answer.Content.ReadAsStringAsync().Result);
                 var csrfToken = ProgramClient.Cookies.GetCookies(uri).Cast<System.Net.Cookie>().FirstOrDefault(c => c.Name == "csrftoken")?.Value;

                 ProgramClient.Client.DefaultRequestHeaders.Add("X-Csrftoken", csrfToken);

                 if (dict["Status"] == "Success")
                 {
                     if (dict["User group"] == "Admin")
                     {
                         this.Hide();
                         BullTaxiMainForm bullTaxiMainForm = new BullTaxiMainForm();
                         bullTaxiMainForm.Show();
                     }
                     else if (dict["User group"] == "Operator")
                     {

                     }
                     else if (dict["User group"] == "Spectator")
                     {

                     }
                 }
                 else
                 {
                     MessageBox.Show(dict["Message"]);
                 }
            

             }
            
            this.Hide();
            BullTaxiMainForm bullTaxiMainForm = new BullTaxiMainForm();
            bullTaxiMainForm.Show();
            */
            this.Hide();
            MainOperatorForm mainOperatorForm = new MainOperatorForm();
            mainOperatorForm.Show();
            
        }

        private void EmailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://mail.google.com/mail/u/1/#inbox?compose=CllgCJvkXrBZtQCtKmLwDWBtZBsvJqqbkVqcXwCWxHCxJssBcBsQmTbwVZCMnMhcpmJLrTjkBrL");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TurnButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (Password.UseSystemPasswordChar)
            {
                
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }

        private void panel6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel6_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
            }
        }
    }
}
