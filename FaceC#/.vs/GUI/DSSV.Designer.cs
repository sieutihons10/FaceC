﻿namespace GUI
{
    partial class DSSV
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
            this.btnXuatEX = new System.Windows.Forms.Button();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.cboTim = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNhapMSSV = new System.Windows.Forms.Label();
            this.btnNhapEX = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSSV = new System.Windows.Forms.DataGridView();
            this.Ma_SV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_SV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayVang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXuatEX
            // 
            this.btnXuatEX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatEX.ForeColor = System.Drawing.Color.Black;
            this.btnXuatEX.Location = new System.Drawing.Point(231, 39);
            this.btnXuatEX.Margin = new System.Windows.Forms.Padding(5);
            this.btnXuatEX.Name = "btnXuatEX";
            this.btnXuatEX.Size = new System.Drawing.Size(170, 55);
            this.btnXuatEX.TabIndex = 11;
            this.btnXuatEX.Text = "Xuất Excel";
            this.btnXuatEX.UseVisualStyleBackColor = true;
            this.btnXuatEX.Click += new System.EventHandler(this.btnXuatEX_Click);
            // 
            // cboLop
            // 
            this.cboLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(98, 228);
            this.cboLop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(318, 31);
            this.cboLop.TabIndex = 12;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(250, 113);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(166, 40);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhat.Location = new System.Drawing.Point(286, 266);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(130, 43);
            this.btnCapNhat.TabIndex = 14;
            this.btnCapNhat.Text = "Cập Nhật Khuôn Mặt";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Location = new System.Drawing.Point(250, 65);
            this.btnStop.Margin = new System.Windows.Forms.Padding(5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(165, 40);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Dừng";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(250, 19);
            this.btnStart.Margin = new System.Windows.Forms.Padding(5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(166, 39);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Bật Camera";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(152, 267);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 43);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(10, 266);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 43);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(134, 39);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTim.MaxLength = 10;
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(250, 27);
            this.txtTim.TabIndex = 5;
            this.txtTim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTim_KeyPress);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Location = new System.Drawing.Point(392, 37);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(111, 30);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cboTim
            // 
            this.cboTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTim.FormattingEnabled = true;
            this.cboTim.Location = new System.Drawing.Point(134, 73);
            this.cboTim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTim.Name = "cboTim";
            this.cboTim.Size = new System.Drawing.Size(250, 31);
            this.cboTim.TabIndex = 7;
            this.cboTim.SelectedIndexChanged += new System.EventHandler(this.cboTim_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Chọn lớp:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNhapMSSV
            // 
            this.lblNhapMSSV.AutoSize = true;
            this.lblNhapMSSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapMSSV.ForeColor = System.Drawing.Color.Black;
            this.lblNhapMSSV.Location = new System.Drawing.Point(8, 39);
            this.lblNhapMSSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapMSSV.Name = "lblNhapMSSV";
            this.lblNhapMSSV.Size = new System.Drawing.Size(118, 23);
            this.lblNhapMSSV.TabIndex = 8;
            this.lblNhapMSSV.Text = "Nhập MSSV:";
            this.lblNhapMSSV.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnNhapEX
            // 
            this.btnNhapEX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapEX.ForeColor = System.Drawing.Color.Black;
            this.btnNhapEX.Location = new System.Drawing.Point(29, 39);
            this.btnNhapEX.Margin = new System.Windows.Forms.Padding(5);
            this.btnNhapEX.Name = "btnNhapEX";
            this.btnNhapEX.Size = new System.Drawing.Size(170, 55);
            this.btnNhapEX.TabIndex = 12;
            this.btnNhapEX.Text = "Nhập Excel";
            this.btnNhapEX.UseVisualStyleBackColor = true;
            this.btnNhapEX.Click += new System.EventHandler(this.btnNhapEX_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnLamMoi);
            this.groupBox5.Controls.Add(this.txtTim);
            this.groupBox5.Controls.Add(this.btnTim);
            this.groupBox5.Controls.Add(this.cboTim);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.lblNhapMSSV);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Red;
            this.groupBox5.Location = new System.Drawing.Point(12, 335);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(510, 124);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm Kiếm Và Làm Mới Danh Sách";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Location = new System.Drawing.Point(392, 73);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(111, 31);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picBox);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 317);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camera";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnNhapEX);
            this.groupBox4.Controls.Add(this.btnXuatEX);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(541, 335);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(426, 124);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nhập Xuất File Excel";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSSV.ForeColor = System.Drawing.Color.Black;
            this.txtMSSV.Location = new System.Drawing.Point(98, 195);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(5);
            this.txtMSSV.MaxLength = 10;
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(319, 30);
            this.txtMSSV.TabIndex = 7;
            this.txtMSSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMSSV_KeyPress);
            // 
            // txtHoten
            // 
            this.txtHoten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.ForeColor = System.Drawing.Color.Black;
            this.txtHoten.Location = new System.Drawing.Point(98, 163);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(5);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(319, 30);
            this.txtHoten.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "MSSV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ Tên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboLop);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.picBox2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(541, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(426, 319);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm Sinh Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lớp:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.dgvDSSV);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 465);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(955, 218);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Sinh Viên";
            // 
            // dgvDSSV
            // 
            this.dgvDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_SV,
            this.Ten_SV,
            this.MaLop,
            this.SoNgayHoc,
            this.SoNgayVang,
            this.TrangThai});
            this.dgvDSSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSSV.Location = new System.Drawing.Point(4, 23);
            this.dgvDSSV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDSSV.Name = "dgvDSSV";
            this.dgvDSSV.RowTemplate.Height = 24;
            this.dgvDSSV.Size = new System.Drawing.Size(947, 192);
            this.dgvDSSV.TabIndex = 0;
            // 
            // Ma_SV
            // 
            this.Ma_SV.DataPropertyName = "Ma_SV";
            this.Ma_SV.HeaderText = "Mã SV";
            this.Ma_SV.Name = "Ma_SV";
            this.Ma_SV.Width = 150;
            // 
            // Ten_SV
            // 
            this.Ten_SV.DataPropertyName = "Ten_SV";
            this.Ten_SV.HeaderText = "Tên SV";
            this.Ten_SV.Name = "Ten_SV";
            this.Ten_SV.Width = 200;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "Ma_Lop";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.Width = 150;
            // 
            // SoNgayHoc
            // 
            this.SoNgayHoc.DataPropertyName = "SoNgayHoc";
            this.SoNgayHoc.HeaderText = "Số Ngày Học";
            this.SoNgayHoc.Name = "SoNgayHoc";
            this.SoNgayHoc.Width = 120;
            // 
            // SoNgayVang
            // 
            this.SoNgayVang.DataPropertyName = "SoNgayVang";
            this.SoNgayVang.HeaderText = "Số Ngày Vắng";
            this.SoNgayVang.Name = "SoNgayVang";
            this.SoNgayVang.Width = 120;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(8, 24);
            this.picBox.Margin = new System.Windows.Forms.Padding(5);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(494, 283);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 4;
            this.picBox.TabStop = false;
            // 
            // picBox2
            // 
            this.picBox2.Location = new System.Drawing.Point(9, 21);
            this.picBox2.Margin = new System.Windows.Forms.Padding(5);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(233, 132);
            this.picBox2.TabIndex = 0;
            this.picBox2.TabStop = false;
            // 
            // DSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 695);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "DSSV";
            this.Text = "DSSV";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DSSV_FormClosed);
            this.Load += new System.EventHandler(this.DSSV_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXuatEX;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cboTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNhapMSSV;
        private System.Windows.Forms.Button btnNhapEX;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_SV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_SV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayVang;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThai;
    }
}