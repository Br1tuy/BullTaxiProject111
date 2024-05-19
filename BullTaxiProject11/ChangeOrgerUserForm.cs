using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullTaxiProject11
{
    public partial class ChangeOrgerUserForm : Form
    {
        private const string PlaceholderText = "Ім'я";
        private const string PlaceholderText1 = "Прізвище";
        private const string PlaceholderText2 = "По батькові";
        public ChangeOrgerUserForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox6.Text = PlaceholderText;
            textBox13.Text = PlaceholderText1;
            textBox12.Text = PlaceholderText2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                textBox6.Text = PlaceholderText;
                textBox6.ForeColor = Color.Gray;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == PlaceholderText)
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }

        private void textBox13_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox13.Text))
            {
                textBox13.Text = PlaceholderText1;
                textBox13.ForeColor = Color.Gray;
            }
        }

        private void textBox13_Enter(object sender, EventArgs e)
        {
            if (textBox13.Text == PlaceholderText1)
            {
                textBox13.Text = "";
                textBox13.ForeColor = Color.Black;
            }
        }

        private void textBox12_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox12.Text))
            {
                textBox12.Text = PlaceholderText2;
                textBox12.ForeColor = Color.Gray;
            }
        }

        private void textBox12_Enter(object sender, EventArgs e)
        {
            if (textBox12.Text == PlaceholderText2)
            {
                textBox12.Text = "";
                textBox12.ForeColor = Color.Black;
            }
        }
    }
}
