using Quanlikhohang.Models;
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
    public partial class Themncc : Form
    {
        KhoHangContext context = new KhoHangContext();
        private string luachon, tenxoa;
        public Themncc()
        {
            InitializeComponent();
            loadten();
        }
        private void loadten()
        {
            var model1 = context.NhaCungCaps.ToList();
            foreach(var item in model1)
            {
                cb_luachon.Items.Add(item.TenNCC);
                cb_maxoa.Items.Add(item.TenNCC);
            }
        }
        private void add()
        {
            string con = @"data source=DESKTOP-P1109GO\SQLEXPRESS;initial catalog=TTN_Quanlykho;integrated security=True";
            string query = "exec dbo.themNCC N'" + tb_nhacc.Text + "',N'" + tb_diachi.Text + "',N'" + tb_sdt.Text + "'";
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private void sua()
        {
            string con = @"data source=DESKTOP-P1109GO\SQLEXPRESS;initial catalog=TTN_Quanlykho;integrated security=True";
            string query = "exec dbo.suathongtinNCC N'" + luachon + "',N'" + tb_diachisua.Text + "',N'" + tb_sdtsua.Text + "'";
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }

        }
        
        
        private void Xoa()
        {
            string con = @"data source=DESKTOP-P1109GO\SQLEXPRESS;initial catalog=TTN_Quanlykho;integrated security=True";
            string query = "delete dbo.NhaCungCap where TenNCC=N'" + tenxoa + "'";
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }

        }
        
        private void bt_them_Click(object sender, EventArgs e)
        {
            if (tb_nhacc.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đủ thông tin", "Thông báo", MessageBoxButtons.OKCancel);
            }
            else
            {
                add();
                MessageBox.Show("Bạn vừa thêm thành công nhà cung cấp: " + tb_nhacc.Text, "Thông báo", MessageBoxButtons.OKCancel);
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            sua();
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OKCancel);
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);
            switch (result)
            {
                case DialogResult.OK:
                    {
                        Xoa();
                        MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK);
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        break;
                    }

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tb_nhacc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_diachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_luachon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox com = sender as ComboBox;
            luachon = com.SelectedItem.ToString();
        }

        private void cb_maxoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox com = sender as ComboBox;
            tenxoa = com.SelectedItem.ToString();
        }

        private void bn_Thoat_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap f = new FrmNhaCungCap();
            this.Visible = false;
            f.ShowDialog();
        }

    }
}
