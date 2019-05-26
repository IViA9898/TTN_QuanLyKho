namespace Quanlikhohang
{
    partial class FrmDanhmuc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnThem = new System.Windows.Forms.Button();
            this.cmdTimkiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.btnDanhMucKhoHang = new System.Windows.Forms.Label();
            this.lb_thongtin = new System.Windows.Forms.Label();
            this.lb_ghichu = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.lb_ten = new System.Windows.Forms.Label();
            this.lb_stt = new System.Windows.Forms.Label();
            this.tb_soluong = new System.Windows.Forms.TextBox();
            this.tb_gia = new System.Windows.Forms.TextBox();
            this.tb_loai = new System.Windows.Forms.TextBox();
            this.tb_nguyenlieu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bn_quaylai = new System.Windows.Forms.Button();
            this.btn_NghiepVu = new System.Windows.Forms.Button();
            this.bt_nhacc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.cb_donvi = new System.Windows.Forms.ComboBox();
            this.bt_xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(19, 262);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 45);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmdTimkiem
            // 
            this.cmdTimkiem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmdTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdTimkiem.Location = new System.Drawing.Point(798, 132);
            this.cmdTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.cmdTimkiem.Name = "cmdTimkiem";
            this.cmdTimkiem.Size = new System.Drawing.Size(81, 28);
            this.cmdTimkiem.TabIndex = 3;
            this.cmdTimkiem.Text = "Tìm kiếm";
            this.cmdTimkiem.UseVisualStyleBackColor = true;
            this.cmdTimkiem.Click += new System.EventHandler(this.cmdTimkiem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(13, 170);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(866, 408);
            this.dataGridView1.TabIndex = 4;
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timkiem.Location = new System.Drawing.Point(212, 133);
            this.tb_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.tb_timkiem.Multiline = true;
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(566, 27);
            this.tb_timkiem.TabIndex = 6;
            // 
            // btnDanhMucKhoHang
            // 
            this.btnDanhMucKhoHang.AutoSize = true;
            this.btnDanhMucKhoHang.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMucKhoHang.ForeColor = System.Drawing.Color.DarkSalmon;
            this.btnDanhMucKhoHang.Location = new System.Drawing.Point(440, 36);
            this.btnDanhMucKhoHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnDanhMucKhoHang.Name = "btnDanhMucKhoHang";
            this.btnDanhMucKhoHang.Size = new System.Drawing.Size(338, 46);
            this.btnDanhMucKhoHang.TabIndex = 6;
            this.btnDanhMucKhoHang.Text = "Quản Lý Kho Hàng";
            this.btnDanhMucKhoHang.Click += new System.EventHandler(this.btnDanhMucKhoHang_Click);
            // 
            // lb_thongtin
            // 
            this.lb_thongtin.AutoSize = true;
            this.lb_thongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thongtin.Location = new System.Drawing.Point(13, 133);
            this.lb_thongtin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_thongtin.Name = "lb_thongtin";
            this.lb_thongtin.Size = new System.Drawing.Size(191, 20);
            this.lb_thongtin.TabIndex = 7;
            this.lb_thongtin.Text = "Danh sách nguyên liệu";
            // 
            // lb_ghichu
            // 
            this.lb_ghichu.AutoSize = true;
            this.lb_ghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ghichu.Location = new System.Drawing.Point(16, 221);
            this.lb_ghichu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ghichu.Name = "lb_ghichu";
            this.lb_ghichu.Size = new System.Drawing.Size(45, 16);
            this.lb_ghichu.TabIndex = 20;
            this.lb_ghichu.Text = "Đơn vị";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sdt.Location = new System.Drawing.Point(15, 172);
            this.lb_sdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(61, 16);
            this.lb_sdt.TabIndex = 19;
            this.lb_sdt.Text = "Số lượng";
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diachi.Location = new System.Drawing.Point(15, 126);
            this.lb_diachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(53, 16);
            this.lb_diachi.TabIndex = 18;
            this.lb_diachi.Text = "Giá tiền";
            // 
            // lb_ten
            // 
            this.lb_ten.AutoSize = true;
            this.lb_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten.Location = new System.Drawing.Point(15, 81);
            this.lb_ten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(83, 16);
            this.lb_ten.TabIndex = 17;
            this.lb_ten.Text = "Loại tươi khô";
            // 
            // lb_stt
            // 
            this.lb_stt.AutoSize = true;
            this.lb_stt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stt.Location = new System.Drawing.Point(12, 35);
            this.lb_stt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_stt.Name = "lb_stt";
            this.lb_stt.Size = new System.Drawing.Size(103, 16);
            this.lb_stt.TabIndex = 16;
            this.lb_stt.Text = "Tên nguyên liệu";
            // 
            // tb_soluong
            // 
            this.tb_soluong.Location = new System.Drawing.Point(133, 170);
            this.tb_soluong.Margin = new System.Windows.Forms.Padding(4);
            this.tb_soluong.Name = "tb_soluong";
            this.tb_soluong.Size = new System.Drawing.Size(251, 26);
            this.tb_soluong.TabIndex = 15;
            // 
            // tb_gia
            // 
            this.tb_gia.Location = new System.Drawing.Point(133, 124);
            this.tb_gia.Margin = new System.Windows.Forms.Padding(4);
            this.tb_gia.Name = "tb_gia";
            this.tb_gia.Size = new System.Drawing.Size(251, 26);
            this.tb_gia.TabIndex = 14;
            // 
            // tb_loai
            // 
            this.tb_loai.Location = new System.Drawing.Point(133, 79);
            this.tb_loai.Margin = new System.Windows.Forms.Padding(4);
            this.tb_loai.Name = "tb_loai";
            this.tb_loai.Size = new System.Drawing.Size(251, 26);
            this.tb_loai.TabIndex = 13;
            // 
            // tb_nguyenlieu
            // 
            this.tb_nguyenlieu.Location = new System.Drawing.Point(133, 33);
            this.tb_nguyenlieu.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nguyenlieu.Name = "tb_nguyenlieu";
            this.tb_nguyenlieu.Size = new System.Drawing.Size(251, 26);
            this.tb_nguyenlieu.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bt_xoa);
            this.groupBox1.Controls.Add(this.cb_donvi);
            this.groupBox1.Controls.Add(this.bt_sua);
            this.groupBox1.Controls.Add(this.lb_stt);
            this.groupBox1.Controls.Add(this.tb_nguyenlieu);
            this.groupBox1.Controls.Add(this.lb_ghichu);
            this.groupBox1.Controls.Add(this.tb_loai);
            this.groupBox1.Controls.Add(this.lb_sdt);
            this.groupBox1.Controls.Add(this.tb_gia);
            this.groupBox1.Controls.Add(this.lb_diachi);
            this.groupBox1.Controls.Add(this.tb_soluong);
            this.groupBox1.Controls.Add(this.lb_ten);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(892, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(405, 320);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết nguyên liệu";
            // 
            // bn_quaylai
            // 
            this.bn_quaylai.Location = new System.Drawing.Point(17, 53);
            this.bn_quaylai.Margin = new System.Windows.Forms.Padding(4);
            this.bn_quaylai.Name = "bn_quaylai";
            this.bn_quaylai.Size = new System.Drawing.Size(143, 28);
            this.bn_quaylai.TabIndex = 23;
            this.bn_quaylai.Text = "Quay lại";
            this.bn_quaylai.UseVisualStyleBackColor = true;
            this.bn_quaylai.Click += new System.EventHandler(this.bn_quaylai_Click);
            // 
            // btn_NghiepVu
            // 
            this.btn_NghiepVu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NghiepVu.Location = new System.Drawing.Point(1101, 457);
            this.btn_NghiepVu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NghiepVu.Name = "btn_NghiepVu";
            this.btn_NghiepVu.Size = new System.Drawing.Size(196, 121);
            this.btn_NghiepVu.TabIndex = 24;
            this.btn_NghiepVu.Text = "Nghiệp vụ";
            this.btn_NghiepVu.UseVisualStyleBackColor = true;
            this.btn_NghiepVu.Click += new System.EventHandler(this.btn_NghiepVu_Click);
            // 
            // bt_nhacc
            // 
            this.bt_nhacc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_nhacc.Location = new System.Drawing.Point(892, 522);
            this.bt_nhacc.Margin = new System.Windows.Forms.Padding(4);
            this.bt_nhacc.Name = "bt_nhacc";
            this.bt_nhacc.Size = new System.Drawing.Size(185, 56);
            this.bt_nhacc.TabIndex = 25;
            this.bt_nhacc.Text = "Nhà cung cấp";
            this.bt_nhacc.UseVisualStyleBackColor = true;
            this.bt_nhacc.Click += new System.EventHandler(this.bt_nhacc_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(892, 457);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 56);
            this.button1.TabIndex = 26;
            this.button1.Text = "Nhân viên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(156, 273);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 23);
            this.bt_sua.TabIndex = 22;
            this.bt_sua.Text = "button2";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // cb_donvi
            // 
            this.cb_donvi.FormattingEnabled = true;
            this.cb_donvi.Items.AddRange(new object[] {
            "Cân",
            "Lạng",
            "lít",
            "Thùng"});
            this.cb_donvi.Location = new System.Drawing.Point(133, 216);
            this.cb_donvi.Name = "cb_donvi";
            this.cb_donvi.Size = new System.Drawing.Size(251, 28);
            this.cb_donvi.TabIndex = 27;
            this.cb_donvi.SelectedIndexChanged += new System.EventHandler(this.cb_donvi_SelectedIndexChanged);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(275, 273);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 23);
            this.bt_xoa.TabIndex = 28;
            this.bt_xoa.Text = "button2";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // FrmDanhmuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1320, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_nhacc);
            this.Controls.Add(this.btn_NghiepVu);
            this.Controls.Add(this.bn_quaylai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_thongtin);
            this.Controls.Add(this.btnDanhMucKhoHang);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdTimkiem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDanhmuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Kho";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button cmdTimkiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.Label btnDanhMucKhoHang;
        private System.Windows.Forms.Label lb_thongtin;
        private System.Windows.Forms.Label lb_ghichu;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_diachi;
        private System.Windows.Forms.Label lb_ten;
        private System.Windows.Forms.Label lb_stt;
        private System.Windows.Forms.TextBox tb_soluong;
        private System.Windows.Forms.TextBox tb_gia;
        private System.Windows.Forms.TextBox tb_loai;
        private System.Windows.Forms.TextBox tb_nguyenlieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bn_quaylai;
        private System.Windows.Forms.Button btn_NghiepVu;
        private System.Windows.Forms.Button bt_nhacc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.ComboBox cb_donvi;
        private System.Windows.Forms.Button bt_xoa;
    }
}

