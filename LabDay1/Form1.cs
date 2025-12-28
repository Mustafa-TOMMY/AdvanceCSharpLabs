using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LabDay1
{
    public partial class Form1 : Form
    {
        string _emailPlaceHolder = "Enter your name";
        string _passwordPlaceHolder = "Enter your Password";

        public Form1()
        {
            InitializeComponent();

            textBox1.Text = _emailPlaceHolder;
            textBox2.Text = _passwordPlaceHolder;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void btn_Registr_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == _emailPlaceHolder || textBox1.Text == "")
            {
                MessageBox.Show("Please enter your name");
                return;
            }
            if (textBox2.Text == _passwordPlaceHolder || textBox2.Text == "")
            {
                MessageBox.Show("Please enter your Pass");
                return;
            }
            MessageBox.Show($"Welcome {textBox1.Text}");
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ForeColor = Color.Black;
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.ForeColor = Color.Black;
            textBox2.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_Registr_Click(sender, e);
            }
        }

        private void btn_Registr_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btn_Registr_MouseLeave(object sender, EventArgs e)
        {

            Cursor = Cursors.Default;
        }
    }
}
