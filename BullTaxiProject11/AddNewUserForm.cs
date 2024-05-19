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
    public partial class AddNewUserForm : Form
    {
        private const string PlaceholderText = "Ім'я";
        private const string PlaceholderText1 = "Прізвище";
        private const string PlaceholderText2 = "По батькові";
        public AddNewUserForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox6.Text = PlaceholderText;
            textBox13.Text = PlaceholderText1;
            textBox12.Text = PlaceholderText2;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {

            this.Close();
            BullTaxiMainForm BullTaxiMainForm = new BullTaxiMainForm();
            /*
            BullTaxiMainForm.Show();
            */

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            BullTaxiMainForm bullTaxiMainForm = new BullTaxiMainForm();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

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

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                textBox6.Text = PlaceholderText;
                textBox6.ForeColor = Color.Gray;
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_Enter(object sender, EventArgs e)
        {
            if (textBox13.Text == PlaceholderText1)
            {
                textBox13.Text = "";
                textBox13.ForeColor = Color.Black;
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

        private void textBox12_Enter(object sender, EventArgs e)
        {
            if (textBox12.Text == PlaceholderText2)
            {
                textBox12.Text = "";
                textBox12.ForeColor = Color.Black;
            }
        }

        private void textBox12_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox12.Text))
            {
                textBox6.Text = PlaceholderText2;
                textBox6.ForeColor = Color.Gray;
            }
        }
    }
}
