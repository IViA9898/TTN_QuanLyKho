using Quanlikhohang.NghiepVu;
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
    public partial class FrmDanhmuc : Form
    {
        N11_QLNguyenLieuNhaHang_T5Entities dta = new N11_QLNguyenLieuNhaHang_T5Entities();
        private string donvi;
        public FrmDanhmuc()
        {
            InitializeComponent();
            dataGridView1.DataSource = Show().Tables[0];
            biding();
        }
        private void biding()
        {
                tb_nguyenlieu.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Tên nguyên liệu", true, DataSourceUpdateMode.Never));
                tb_loai.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Loại tươi khô", true, DataSourceUpdateMode.Never));
                tb_gia.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Giá tiền", true, DataSourceUpdateMode.Never));
                tb_soluong.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Số lượng", true, DataSourceUpdateMode.Never));
                cb_donvi.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Tên đơn vị", true, DataSourceUpdateMode.Never));
        }
        private DataSet Show()
        {
            DataSet dt = new DataSet();
            string query = "select MaNL N'Mã NL',TenNL N'Tên nguyên liệu',LoaiTuoiKho N'Loại tươi khô',GiaTien N'Giá tiền',SoLuong N'Số lượng',TenDonVi N'Tên đơn vị' from dbo.NguyenLieu";
            using (SqlConnection connection = new SqlConnection(@"data source=DESKTOP-P1109GO\SQLEXPRESS;initial catalog=TTN_Quanlykho;integrated security=True"))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
                connection.Close();
            }
            return dt;
        }
        SqlConnection con = new SqlConnection(@"data source=DESKTOP-P1109GO\SQLEXPRESS;initial catalog=TTN_Quanlykho;integrated security=True");
        void ViewData()
        {
            con.Open();
            MessageBox.Show("Ket noi thanh cong");
            SqlDataAdapter da = new SqlDataAdapter("select *from Hocsinh", con); // lay tat ca du lieu tu bang hoc sinh luu vao bien da, con dan duong
                                                                                 // gio can datatable de luu du lieu;
            DataTable dt = new DataTable();
            da.Fill(dt); // đổ dữ liệu vào bảng
                         // gio cần treo lên datagridview
            dataGridView1.DataSource = dt;    // Thông tin đã đc hiển thị trong daraGridView.
            con.Close(); // đóng kết nối
        }
        private DataSet Nhacungcap()
        {
            DataSet dt = new DataSet();
            string query = "select MaNCC N'Mã nhà cung cấp',TenNCC N'Tên nhà cung cấp',DiaChi N'Địa chỉ',SDT N'Số điện thoại' from dbo.NhaCungCap";
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
            string a= "select* from NguyenLieu where TenNL like N'" + tb_timkiem.Text + "%' or TenNL like N'%"+tb_timkiem.Text+"'";
            string query = "select MaNL N'Mã NL',TenNL N'Tên nguyên liệu',LoaiTuoiKho N'Loại tươi khô',GiaTien N'Giá tiền',SoLuong N'Số lượng',TenDonVi N'Tên đơn vị' from dbo.NguyenLieu where MaNL like N'" + tb_timkiem.Text + "%' or TenNL like N'%'" + tb_timkiem.Text + "%'";  //N'%'"+ textBox1.Text+"%'"
            using (SqlConnection connection = new SqlConnection(@"data source=DESKTOP-P1109GO\SQLEXPRESS;initial catalog=TTN_Quanlykho;integrated security=True"))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(a, connection);
                adapter.Fill(dt);
                connection.Close();
            }
            return dt;
        }
        //private void tb_timkiem_TextChanged(object sender, EventArgs e)
        //{
        //    ViewData("select *from NguyenLieu where Ten like N'" + tb_timkiem.Text + "%' or Ten like N'%"+tb_timkiem.Text+"'");  //N'%abc' phia tric abc la gi cung duoc
        //}

        private void ViewData(string v)
        {
            throw new NotImplementedException();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemNL f = new ThemNL();
            this.Visible = false;
            f.ShowDialog();
        }

        private void cmdTimkiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Timkiem().Tables[0];
        }

        private void bn_quaylai_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Show().Tables[0];
            
        }
        private void btnDanhMucKhoHang_Click(object sender, EventArgs e)
        {

        }

        private void btn_NghiepVu_Click(object sender, EventArgs e)
        {
            new frmNghiepVu().Show();
        }
        private void bt_nhacc_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap f = new FrmNhaCungCap();
            this.Visible = false;
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmNhanVien f = new FrmNhanVien();
            this.Visible = false;
            f.ShowDialog();
        }
        private bool kiemtra(string a)
        {
            bool luachon = true;
            if (a == "0")
            {
                luachon = false;
            }
            else
                luachon = true;
            return luachon;
        }
        private void sua()
        {
            string con = @"data source=DESKTOP-P1109GO\SQLEXPRESS;initial catalog=TTN_Quanlykho;integrated security=True";
            string query = "exec dbo.Suanguyenlieu N'" + tb_nguyenlieu.Text+ "'," +kiemtra(tb_loai.Text) + "," + tb_gia.Text + "," + tb_soluong.Text + ", N'" + donvi + "'";
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }

        }
        private void bt_sua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("thành công");
            sua();
            dataGridView1.DataSource = Show().Tables[0];
        }

        private void cb_donvi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox com = sender as ComboBox;
            donvi = com.SelectedItem.ToString();
        }
        private void Xoa()
        {
            string con = @"data source=DESKTOP-P1109GO\SQLEXPRESS;initial catalog=TTN_Quanlykho;integrated security=True";
            string query = "delete dbo.NguyenLieu where MaNL in (select MaNL from dbo.NguyenLieu where TenNL=N'" + tb_nguyenlieu.Text + "')";
            string a = "exec dbo.xoanl N'"+tb_nguyenlieu.Text+"'";
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(a, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);
            switch (result)
            {
                case DialogResult.OK:
                    {
                        Xoa();
                        MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK);
                        dataGridView1.DataSource = Show().Tables[0];
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        break;
                    }

            }
        }
    }
}
