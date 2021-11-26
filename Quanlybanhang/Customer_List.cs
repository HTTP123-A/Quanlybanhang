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
    public partial class Customer_List : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd;
        MySqlDataAdapter data_adapter = null;
        DataTable dtTable = null;

        string strconn = "Server = localhost; Database = qlkh_db; UId = root; Pwd = 4793@@; Pooling=false; Character Set=utf8";
        //server=localhost;user id=root;password=4793@@;persistsecurityinfo=True;database=qlkh_db
        public Customer_List()
        {
            InitializeComponent();
        }

        private void Customer_List_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(strconn);
                int intDM = Convert.ToInt32(this.Text);

                switch(intDM)
                {
                    case 1:
                        label1.Text = "Danh mục thành phố:";
                        data_adapter = new MySqlDataAdapter("SELECT ThanhPho, TenThanhPho FROM thanh_pho", conn);
                        break;
                    case 2:
                        label1.Text = "Danh mục khách hàng:";
                        data_adapter = new MySqlDataAdapter("SELECT MaKH, TenCTy FROM khach_hang" ,conn);
                        break;
                    case 3:
                        label1.Text = "Danh mục nhân viên:";
                        data_adapter = new MySqlDataAdapter("SELECT MaNV, Holot, Ten FROM nhan_vien", conn);
                        break;
                    case 4:
                        label1.Text = "Danh mục sản phẩm:";
                        data_adapter = new MySqlDataAdapter("SELECT MaSP, TenSP, Donvitinh, Dongia FROM san_pham", conn);
                        break;
                    case 5:
                        label1.Text = "Danh mục hoá đơn:";
                        data_adapter = new MySqlDataAdapter("SELECT MaHD, MaKH, MaNV FROM hoa_don", conn);
                        break;
                    case 6:
                        label1.Text = "Danh mục chi tiết hoá đơn:";
                        data_adapter = new MySqlDataAdapter("SELECT * FROM chi_tiet_hoa_don", conn);
                        break;
                    default:
                        break;
                }

                dtTable = new DataTable();
                dtTable.Clear();
                data_adapter.Fill(dtTable); //Đưa dữ liệu lên biên bảng
                dgvList.DataSource = dtTable; //Đưa dữ liệu lên bảng grid
                dgvList.AutoResizeColumns();
            }
            catch(MySqlException)
            {
                MessageBox.Show("Lỗi rồi thằng chó! Thử lại đi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Return_Click(object sender, EventArgs e) => this.Close();
    }
}
