using BullTaxiProject11;
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

namespace BullTaxi
{
    public partial class FormUser : Form
    {
        DriversMapForm driversMapForm;
        public FormUser()
        {
            InitializeComponent();
        }

        string[] table_columns = new string[] { "Login", "Status", "FirstName", "Patronymic", "LastName", "Sex", "Birthday", "Email", "PhoneNumber"};
        string[] table_headers = new string[] { "Логін", "Статус", "Ім'я", "По батькові", "Фамілія", "Стать", "День народження", "Пошта", "Номер телефону"};
        Dictionary<string, string> dict;
        Dictionary<string, Dictionary<string, string>> users;
        AddNewUserForm addNewUserForm;
        ChangeOrgerUserForm changeOrgerUserForm;
        DeleteUserForm deleteUserForm;

        private void Table_Load(object sender, EventArgs e)
        {
            for (int c = 0; c < 9; c++)
            {
                Table.Columns.Add(table_columns[c], table_headers[c]);
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (addNewUserForm == null || !addNewUserForm.Created)
            {
                addNewUserForm = new AddNewUserForm();
                addNewUserForm.Show();
            }
            else
            {
                addNewUserForm.WindowState = FormWindowState.Normal;
            }            
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (changeOrgerUserForm == null || !changeOrgerUserForm.Created)
            {
                changeOrgerUserForm = new ChangeOrgerUserForm();
                changeOrgerUserForm.Show();
            }
            else
            {
                changeOrgerUserForm.WindowState = FormWindowState.Normal;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (deleteUserForm == null || !deleteUserForm.Created)
            {
                deleteUserForm = new DeleteUserForm();
                deleteUserForm.Show();
            }
            else
            {
                deleteUserForm.WindowState = FormWindowState.Normal;
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri("http://127.0.0.1:8000/users_view/");

            var answer = ProgramClient.Client.GetAsync(uri).Result;

            try
            {
                users = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(answer.Content.ReadAsStringAsync().Result);

                Table.Rows.Clear();

                if (users != null)
                {
                    foreach (var items in users)
                    {
                        Table.Invoke(new MethodInvoker(() => Table.Rows.Add(items.Value["username"], items.Value["status"], items.Value["first name"], items.Value["patronymic"], items.Value["last name"], items.Value["sex"], items.Value["date of birth"], items.Value["email"], items.Value["phone number"])));
                    }

                    Table.Refresh();
                }
            }
            catch
            {
                dict = JsonSerializer.Deserialize<Dictionary<string, string>>(answer.Content.ReadAsStringAsync().Result);
                MessageBox.Show(dict["Message"]);
            }
        }

        private void DriversMapButton_Click(object sender, EventArgs e)
        {
            if (driversMapForm == null || !driversMapForm.Created)
            {
                driversMapForm = new DriversMapForm();
                driversMapForm.Show();
            }
            else
            {
                driversMapForm.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
