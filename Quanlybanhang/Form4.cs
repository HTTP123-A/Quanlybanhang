using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quanlybanhang
{
    public partial class Form4 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd;
        MySqlDataAdapter data_ThanhPho = null;
        DataTable dtThanhPho = null;

        string strconn = "Server = localhost; Database = qlkh_db; UId = root; Pwd = 4793@@; Pooling=false; Character Set=utf8";

        bool Them = false;

        public Form4()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                conn = new MySqlConnection(strconn);
                data_ThanhPho = new MySqlDataAdapter("SELECT * FROM thanh_pho", conn);
                dtThanhPho = new DataTable();
                dtThanhPho.Clear();
                data_ThanhPho.Fill(dtThanhPho);

                dgvThanhPho.DataSource = dtThanhPho;
                dgvThanhPho.AutoResizeColumns();

                this.textBox1.ResetText();
                this.textBox2.ResetText();

                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                this.Data.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTrove.Enabled = true;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Không tải được dữ liệu về thành phố từ database!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtThanhPho.Dispose();
            dtThanhPho = null;
            conn = null;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTrove_Click(object sender, EventArgs e) => this.Close();

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            this.textBox1.ResetText();
            this.textBox2.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTrove.Enabled = true;
            this.Data.Enabled = true;
            this.textBox1.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;

            this.Data.Enabled = true;

            int r = dgvThanhPho.CurrentCell.RowIndex;
            this.textBox1.Text = dgvThanhPho.Rows[r].Cells[0].Value.ToString();
            this.textBox2.Text = dgvThanhPho.Rows[r].Cells[1].Value.ToString();
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.Data.Enabled = true;
            this.textBox1.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            conn.Open();

            try
            {
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                int r = dgvThanhPho.CurrentCell.RowIndex;
                string strThanhPho = dgvThanhPho.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("DELETE FROM thanh_pho WHERE thanh_pho='" + strThanhPho + "'");

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                LoadData();
                MessageBox.Show("Đã xoá xong!");
            }
            catch(MySqlException)
            {
                MessageBox.Show("Không xoá được!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
    }
}
