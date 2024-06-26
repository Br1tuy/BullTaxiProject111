﻿using MainFormBullTaxi;
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
    public partial class ChangingCompletedOrderForm : Form
    {
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;
        public ChangingCompletedOrderForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void panel2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
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

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TurnButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {
                MessageBox.Show("Введіть id.");
            }
            else
            {
                Uri uri = new Uri("http://127.0.0.1:8000/completed_orders_change_information/");

                Dictionary<string, string> parameters = new Dictionary<string, string>()
                {
                    {"id", ID.Text},
                    {"new taxi driver", NewDriver.Text},
                    {"new opening time", NewOpeningTime.Text},
                    {"new closing time", NewClosingTime.Text},
                    {"new starting address", NewStartingAddress.Text},
                    {"new final address", NewFinalAddress.Text},
                    {"new price", NewPrice.Text},
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
