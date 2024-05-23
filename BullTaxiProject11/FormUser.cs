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
        public FormUser()
        {
            InitializeComponent();
        }

        string[] table_columns = new string[] { "Login", "Status", "FirstName", "Patronymic", "LastName", "Sex", "Birthday", "Email", "PhoneNumber"};
        string[] table_headers = new string[] { "Логін", "Статус", "Ім'я", "По батькові", "Фамілія", "Стать", "День народження", "Пошта", "Номер телефону"};
        Dictionary<string, string> dict;
        Dictionary<string, Dictionary<string, string>> users;

        private void Table_Load(object sender, EventArgs e)
        {
            for (int c = 0; c < 9; c++)
            {
                Table.Columns.Add(table_columns[c], table_headers[c]);
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            AddNewUserForm AddNewUserForm = new AddNewUserForm();
          
            AddNewUserForm.ShowDialog();
            
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            ChangeOrgerUserForm changeOrgerUserForm = new ChangeOrgerUserForm();

            changeOrgerUserForm.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteUserForm deleteUserForm = new DeleteUserForm();

            deleteUserForm.ShowDialog();
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
    }
}
