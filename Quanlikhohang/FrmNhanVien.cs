using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlikhohang
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
            dataGridView1.DataSource = danhsach().Tables[0];
            biding();
        }
        private void biding()
        {
            tb_Manv.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Mã nhân viên", true, DataSourceUpdateMode.Never));
            tb_Hovaten.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Họ tên nhân viên", true, DataSourceUpdateMode.Never));
            tb_Ngaysinhh.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never));
            tb_diachii.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
            tb_SoDienThoai.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Số điện thoại", true, DataSourceUpdateMode.Never));
        }
        private DataSet danhsach()
        {
            DataSet dt = new DataSet();
            string query = "select MaNV N'Mã nhân viên',HoTen N'Họ tên nhân viên',NgaySinh N'Ngày sinh',DiaChi N'Địa chỉ',SDT N'Số điện thoại' from dbo.NhanVien";
            using (SqlConnection connection = new SqlConnection(@"data source=DESKTOP-P1109GO\SQLEXPRESS;initial catalog=TTN_Quanlykho;integrated security=True"))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
                connection.Close();
            }
            return dt;
        }
        private DataSet Timkiem()
        {
            DataSet dt = new DataSet();
            string query = "select MaNV N'Mã nhân viên',HoTen N'Họ tên nhân viên',NgaySinh N'Ngày sinh',DiaChi N'Địa chỉ',SDT N'Số điện thoại' from dbo.NhanVien where MaNV like '" + tb_timkiem.Text + "%' or HoTen like N'" + tb_timkiem.Text + "%'";
            using (SqlConnection connection = new SqlConnection(@"data source=DESKTOP-P1109GO\SQLEXPRESS;initial catalog=TTN_Quanlykho;integrated security=True"))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
                connection.Close();
            }
            return dt;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDanhmuc f = new FrmDanhmuc();
            this.Visible = false;
            f.ShowDialog();
        }

        private void cmdTimkiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Timkiem().Tables[0];
        }

        private void bn_quaylai_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = danhsach().Tables[0];
        }

        private void btnChucnang_Click(object sender, EventArgs e)
        {
            ThemNV f = new ThemNV();
            this.Visible = false;
            f.ShowDialog();
        }

      
    }
}
