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
    public partial class ChangeOrgerUserForm : Form
    {
        public ChangeOrgerUserForm()
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

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (Login.Text == "")
            {
                MessageBox.Show("Введіть логін.");
            }
            else
            {
                Uri uri = new Uri("http://127.0.0.1:8000/user_change_information/");

                Dictionary<string, string> parameters = new Dictionary<string, string>()
                {
                    {"username", Login.Text},
                    {"new username", NewLogin.Text},
                    {"new password", NewPassword.Text},
                    {"new status", NewStatusBox.Text},
                    {"new first name", NewFirstName.Text},
                    {"new patronymic", NewPatronymic.Text},
                    {"new last name", NewLastName.Text},
                    {"new sex", NewSex.Text},
                    {"new date of birth", NewBirthday.Text},
                    {"new email", NewEmail.Text},
                    {"new phone number", NewPhoneNumber.Text},
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
