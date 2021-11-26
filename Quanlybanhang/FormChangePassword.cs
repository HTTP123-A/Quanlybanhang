using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybanhang
{
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void Password_change_label_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Null username is not accepted!");
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Null password is not acctepted!");
                textBox2.Focus();
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("You did not type in your new password!");
                textBox3.Focus();
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("You did not repeat yoru new password!");
                textBox4.Focus();
            }
            MessageBox.Show("Password changed successfully!", "Notification:", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void FormChangePassword_Load(object sender, EventArgs e)
        {
            if (textBox1.Text == Login_Data.Global_username)
            {
                if (textBox2.Text == Login_Data.Global_password)
                {
                    if (textBox3.Text == textBox4.Text)
                    {
                        MessageBox.Show("Change Password Succesfully!");
                        Login_Data.Global_password = textBox3.Text;
                    }
                    else
                    {
                        textBox4.Focus();
                        MessageBox.Show("The repeated password is wrong!");
                    }
                }
                else
                {
                    textBox2.Focus();
                    MessageBox.Show("Wrong password!");
                }
            }
            else
            {
                textBox1.Focus();
                MessageBox.Show("This username does not exist!");
            }
        }

        private void Nhap_lai_mat_khau_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
