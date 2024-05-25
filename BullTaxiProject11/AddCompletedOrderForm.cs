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
    public partial class AddCompletedOrderForm : Form
    {
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;

        public AddCompletedOrderForm()
        {
            InitializeComponent();
        }

        private void TurnButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (StartingAddress.Text == "")
            {
                MessageBox.Show("Введіть початкову адресу.");
            }
            else if (FinalAddress.Text == "")
            {
                MessageBox.Show("Введіть кінцеву адресу.");
            }
            else if (TaxiDriver.Text == "")
            {
                MessageBox.Show("Введіть водія.");
            }
            else if (OpeningTime.Text == "")
            {
                MessageBox.Show("Введіть час відкриття замовлення.");
            }
            else if (ClosingTime.Text == "")
            {
                MessageBox.Show("Введіть час закриття замовлення.");
            }
            else if (Price.Text == "")
            {
                MessageBox.Show("Введіть ціну.");
            }
            else
            {    
                Uri uri = new Uri("http://127.0.0.1:8000/completed_orders_add/");

                Dictionary<string, string> parameters = new Dictionary<string, string>()
                {
                    {"taxi driver", TaxiDriver.Text},
                    {"opening time", OpeningTime.Text},
                    {"closing time", ClosingTime.Text},
                    {"starting address", StartingAddress.Text},
                    {"final address", FinalAddress.Text},
                    {"price", Price.Text}
                };

                FormUrlEncodedContent form = new FormUrlEncodedContent(parameters);

                var answer = ProgramClient.Client.PostAsync(uri, form).Result;
                Dictionary<string, string> dict = JsonSerializer.Deserialize<Dictionary<string, string>>(answer.Content.ReadAsStringAsync().Result);

                if (dict["Status"] == "Success")
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show(dict["Message"]);
                }
            }
        }

       
    }
}
