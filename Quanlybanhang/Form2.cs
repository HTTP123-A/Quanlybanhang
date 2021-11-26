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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((this.txt_User.Text == Login_Data.Global_username) && (this.txt_Pass.Text == Login_Data.Global_password))
            {
                MessageBox.Show("Log In Successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username/Password!");
                this.txt_User.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_Butt_Click(object sender, EventArgs e)
        {
            DialogResult Feedback;
            Feedback = MessageBox.Show("Are you sure?", "Select:", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Feedback == DialogResult.OK)
                Application.Exit();
        }

        private void txt_User_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
