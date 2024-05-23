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
using BullTaxiProject11;
using System.Net.Http;
using System.Text.Json;
using System.Diagnostics;

namespace BullTaxi
{
    public partial class AddNewUserForm : Form
    {
        public AddNewUserForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            BullTaxiMainForm bullTaxiMainForm = new BullTaxiMainForm();
            
        }

        private void TurnButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (Login.Text == "")
            {
                MessageBox.Show("Введіть логін.");
            }
            else if (Password.Text == "")
            {
                MessageBox.Show("Введіть пароль.");
            }
            else if (FirstName.Text == "")
            {
                MessageBox.Show("Введіть ім'я.");
            }
            else if (LastName.Text == "")
            {
                MessageBox.Show("Введіть прізвище.");
            }
            else if (Status.Text == "")
            {
                MessageBox.Show("Введіть статус.");
            }
            else if (Birthday.Text == "")
            {
                MessageBox.Show("Введіть день народження.");
            }
            else if (Sex.Text == "")
            {
                MessageBox.Show("Введіть стать.");
            }
            else if (Email.Text == "")
            {
                MessageBox.Show("Введіть пошту.");
            }
            else if (PhoneNumber.Text == "")
            {
                MessageBox.Show("Введіть номер телефону.");
            }
            else
            {
                Uri uri = new Uri("http://127.0.0.1:8000/registration/");

                Dictionary<string, string> parameters = new Dictionary<string, string>()
                {
                    {"username", Login.Text},
                    {"password", Password.Text},
                    {"status", Status.Text},
                    {"first name", FirstName.Text},
                    {"patronymic", Patronymic.Text},
                    {"last name", LastName.Text},
                    {"sex", Sex.Text},
                    {"date of birth", Birthday.Text},
                    {"email", Email.Text},
                    {"phone number", PhoneNumber.Text},
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
