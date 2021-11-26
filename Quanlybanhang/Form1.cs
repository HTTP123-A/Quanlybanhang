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
    public partial class General_Form : Form
    {
        public General_Form()
        {
            InitializeComponent();
            Form form_of_login = new Login_Form();
            form_of_login.ShowDialog();
        }

        void XemDanhMuc(int intDanhMuc)
        {
            Form frm = new Customer_List();
            frm.Text = intDanhMuc.ToString();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void App_Name_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormChangePassword();
            frm.Text = "Change password";
            frm.ShowDialog();
        }

        private void Data_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void citiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(1);
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(2);
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(3);
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(4);
        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(5);
        }

        private void billDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(6);
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form4();
            frm.Text = "Quản lý Thành Phố";
            frm.ShowDialog();
        }
    }
}
