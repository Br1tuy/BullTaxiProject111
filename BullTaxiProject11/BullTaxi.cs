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
using System.Net;
using System.Net.Http;
using System.Text.Json;

namespace MainFormBullTaxi
{

    public partial class LoginForm : Form
    {
        bool drag = false;
        private HttpClient client;
        private CookieContainer cookies;


        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cookies = new CookieContainer();
            var handler = new HttpClientHandler();
            handler.CookieContainer = cookies;

            HttpClient client = new HttpClient(handler);
        }

        

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1(object sender, EventArgs e)
        {

            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://mail.google.com/mail/u/1/#inbox?compose=CllgCJvkXrBZtQCtKmLwDWBtZBsvJqqbkVqcXwCWxHCxJssBcBsQmTbwVZCMnMhcpmJLrTjkBrL");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>()
{
{"username", ""},
{"password", ""},
};
            Uri uri = new Uri("http://127.0.0.1:8000/login/");
            FormUrlEncodedContent form = new FormUrlEncodedContent(parameters);
            var answer = client.PostAsync(uri, form).Result;
            Dictionary<string, string> dict = JsonSerializer.Deserialize<Dictionary<string,
            string>>(answer.Content.ReadAsStringAsync().Result);
            var csrfToken = cookies.GetCookies(uri).Cast<System.Net.Cookie>().FirstOrDefault(c => c.Name == "csrftoken")?.Value;
            client.DefaultRequestHeaders.Add("X-Csrftoken", csrfToken);

            this.Hide();
            BullTaxiMainForm bullTaxiMainForm = new BullTaxiMainForm();
            bullTaxiMainForm.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://mail.google.com/mail/u/1/#inbox?compose=CllgCJvkXrBZtQCtKmLwDWBtZBsvJqqbkVqcXwCWxHCxJssBcBsQmTbwVZCMnMhcpmJLrTjkBrL");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
