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

        const int TABLE_ROW_COUNT = 10;
        const int TABLE_COLUMN_COUNT = 10;
        Dictionary<string, string> dict;
        Dictionary<string, Dictionary<string, string>> users;

        private void Table_Load(object sender, EventArgs e)
        {
            
                for (int c = 0; c < TABLE_COLUMN_COUNT; c++)
                {
                    Table.Columns.Add(c.ToString(), c.ToString());

                }
                for (int r = 0; r < TABLE_ROW_COUNT - 1; r++)
                {
                    Table.Rows.Add();
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
            }
            catch
            {
                dict = JsonSerializer.Deserialize<Dictionary<string, string>>(answer.Content.ReadAsStringAsync().Result);
                MessageBox.Show(dict["Message"]);
            }
        }
    }
}
