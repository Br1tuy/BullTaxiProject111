using BullTaxiProject11;
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
        private void FormUser_Load(object sender, EventArgs e)
        {
            
                for (int c = 0; c < TABLE_COLUMN_COUNT; c++)
                {
                    dataGridView1.Columns.Add(c.ToString(), c.ToString());

                }
                for (int r = 0; r < TABLE_ROW_COUNT - 1; r++)
                {
                    dataGridView1.Rows.Add();
                }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AddNewUserForm AddNewUserForm = new AddNewUserForm();
            
            AddNewUserForm.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangeOrgerUserForm changeOrgerUserForm = new ChangeOrgerUserForm();
            changeOrgerUserForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
