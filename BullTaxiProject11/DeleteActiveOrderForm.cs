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
    public partial class DeleteActiveOrderForm : Form
    {
        public DeleteActiveOrderForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TurnButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {
                MessageBox.Show("Введіть id.");
            }
            else
            {
                Uri uri = new Uri("http://127.0.0.1:8000/active_orders_delete/");

                Dictionary<string, string> parameters = new Dictionary<string, string>()
                {
                    {"id", ID.Text},
                };

                FormUrlEncodedContent form = new FormUrlEncodedContent(parameters);

                var answer = ProgramClient.Client.PostAsync(uri, form).Result;
                Dictionary<string, string> dict = JsonSerializer.Deserialize<Dictionary<string, string>>(answer.Content.ReadAsStringAsync().Result);

                if (dict["Status"] == "Success")
                {
                    this.Hide();
                    BullTaxiMainForm bullTaxiMainForm = new BullTaxiMainForm();
                    bullTaxiMainForm.Show();
                }
                else
                {
                    MessageBox.Show(dict["Message"]);
                }
            }
        }
    }
}
