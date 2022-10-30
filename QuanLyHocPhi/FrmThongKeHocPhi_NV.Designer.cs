
namespace QuanLyHocPhi
{
    partial class FrmThongKeHocPhi_NV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKeHocPhi_NV));
            this.cboTKHocKy = new System.Windows.Forms.ComboBox();
            this.grpBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.cboTKNamHoc = new System.Windows.Forms.ComboBox();
            this.cboTKTinhTrang = new System.Windows.Forms.ComboBox();
            this.txtTKMaSV = new System.Windows.Forms.TextBox();
            this.chkTKTinhTrang = new System.Windows.Forms.CheckBox();
            this.chkTKMaSV = new System.Windows.Forms.CheckBox();
            this.chkTKHocKy = new System.Windows.Forms.CheckBox();
            this.chkTKNamHoc = new System.Windows.Forms.CheckBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtConNo = new System.Windows.Forms.TextBox();
            this.txtCanDong = new System.Windows.Forms.TextBox();
            this.txtMienGiam = new System.Windows.Forms.TextBox();
            this.txtMaL = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.lblconno = new System.Windows.Forms.Label();
            this.lblmiengiam = new System.Windows.Forms.Label();
            this.lblcandong = new System.Windows.Forms.Label();
            this.lblmalop = new System.Windows.Forms.Label();
            this.lblmsv = new System.Windows.Forms.Label();
            this.lblhocky = new System.Windows.Forms.Label();
            this.btnXemchitiet = new System.Windows.Forms.Button();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.lblnamhoc = new System.Windows.Forms.Label();
            this.dataGVThongKeHocPhi = new System.Windows.Forms.DataGridView();
            this.lbltkhp = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpBoxTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVThongKeHocPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTKHocKy
            // 
            this.cboTKHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTKHocKy.FormattingEnabled = true;
            this.cboTKHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboTKHocKy.Location = new System.Drawing.Point(112, 66);
            this.cboTKHocKy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTKHocKy.Name = "cboTKHocKy";
            this.cboTKHocKy.Size = new System.Drawing.Size(125, 21);
            this.cboTKHocKy.TabIndex = 35;
            // 
            // grpBoxTimKiem
            // 
            this.grpBoxTimKiem.Controls.Add(this.cboTKNamHoc);
            this.grpBoxTimKiem.Controls.Add(this.cboTKTinhTrang);
            this.grpBoxTimKiem.Controls.Add(this.cboTKHocKy);
            this.grpBoxTimKiem.Controls.Add(this.txtTKMaSV);
            this.grpBoxTimKiem.Controls.Add(this.chkTKTinhTrang);
            this.grpBoxTimKiem.Controls.Add(this.chkTKMaSV);
            this.grpBoxTimKiem.Controls.Add(this.chkTKHocKy);
            this.grpBoxTimKiem.Controls.Add(this.chkTKNamHoc);
            this.grpBoxTimKiem.Controls.Add(this.btnTimkiem);
            this.grpBoxTimKiem.Location = new System.Drawing.Point(626, 264);
            this.grpBoxTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxTimKiem.Name = "grpBoxTimKiem";
            this.grpBoxTimKiem.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxTimKiem.Size = new System.Drawing.Size(251, 233);
            this.grpBoxTimKiem.TabIndex = 57;
            this.grpBoxTimKiem.TabStop = false;
            this.grpBoxTimKiem.Text = "Tìm kiếm";
            // 
            // cboTKNamHoc
            // 
            this.cboTKNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTKNamHoc.FormattingEnabled = true;
            this.cboTKNamHoc.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboTKNamHoc.Location = new System.Drawing.Point(112, 31);
            this.cboTKNamHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTKNamHoc.Name = "cboTKNamHoc";
            this.cboTKNamHoc.Size = new System.Drawing.Size(125, 21);
            this.cboTKNamHoc.TabIndex = 37;
            // 
            // cboTKTinhTrang
            // 
            this.cboTKTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTKTinhTrang.FormattingEnabled = true;
            this.cboTKTinhTrang.Items.AddRange(new object[] {
            "Còn nợ",
            "Đã đóng",
            "Dư tiền"});
            this.cboTKTinhTrang.Location = new System.Drawing.Point(112, 137);
            this.cboTKTinhTrang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTKTinhTrang.Name = "cboTKTinhTrang";
            this.cboTKTinhTrang.Size = new System.Drawing.Size(125, 21);
            this.cboTKTinhTrang.TabIndex = 36;
            // 
            // txtTKMaSV
            // 
            this.txtTKMaSV.Location = new System.Drawing.Point(112, 102);
            this.txtTKMaSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTKMaSV.Name = "txtTKMaSV";
            this.txtTKMaSV.Size = new System.Drawing.Size(125, 20);
            this.txtTKMaSV.TabIndex = 32;
            // 
            // chkTKTinhTrang
            // 
            this.chkTKTinhTrang.AutoSize = true;
            this.chkTKTinhTrang.Location = new System.Drawing.Point(22, 139);
            this.chkTKTinhTrang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkTKTinhTrang.Name = "chkTKTinhTrang";
            this.chkTKTinhTrang.Size = new System.Drawing.Size(77, 17);
            this.chkTKTinhTrang.TabIndex = 31;
            this.chkTKTinhTrang.Text = "Tình trạng:";
            this.chkTKTinhTrang.UseVisualStyleBackColor = true;
            // 
            // chkTKMaSV
            // 
            this.chkTKMaSV.AutoSize = true;
            this.chkTKMaSV.Location = new System.Drawing.Point(22, 104);
            this.chkTKMaSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkTKMaSV.Name = "chkTKMaSV";
            this.chkTKMaSV.Size = new System.Drawing.Size(89, 17);
            this.chkTKMaSV.TabIndex = 30;
            this.chkTKMaSV.Text = "Mã sinh viên:";
            this.chkTKMaSV.UseVisualStyleBackColor = true;
            // 
            // chkTKHocKy
            // 
            this.chkTKHocKy.AutoSize = true;
            this.chkTKHocKy.Location = new System.Drawing.Point(22, 67);
            this.chkTKHocKy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkTKHocKy.Name = "chkTKHocKy";
            this.chkTKHocKy.Size = new System.Drawing.Size(63, 17);
            this.chkTKHocKy.TabIndex = 29;
            this.chkTKHocKy.Text = "Học kỳ:";
            this.chkTKHocKy.UseVisualStyleBackColor = true;
            // 
            // chkTKNamHoc
            // 
            this.chkTKNamHoc.AutoSize = true;
            this.chkTKNamHoc.Location = new System.Drawing.Point(22, 31);
            this.chkTKNamHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkTKNamHoc.Name = "chkTKNamHoc";
            this.chkTKNamHoc.Size = new System.Drawing.Size(72, 17);
            this.chkTKNamHoc.TabIndex = 27;
            this.chkTKNamHoc.Text = "Năm học:";
            this.chkTKNamHoc.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTimkiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimkiem.Location = new System.Drawing.Point(156, 176);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(80, 32);
            this.btnTimkiem.TabIndex = 8;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtConNo
            // 
            this.txtConNo.Location = new System.Drawing.Point(543, 218);
            this.txtConNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConNo.Name = "txtConNo";
            this.txtConNo.ReadOnly = true;
            this.txtConNo.Size = new System.Drawing.Size(179, 20);
            this.txtConNo.TabIndex = 54;
            // 
            // txtCanDong
            // 
            this.txtCanDong.Location = new System.Drawing.Point(543, 184);
            this.txtCanDong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCanDong.Name = "txtCanDong";
            this.txtCanDong.ReadOnly = true;
            this.txtCanDong.Size = new System.Drawing.Size(179, 20);
            this.txtCanDong.TabIndex = 53;
            // 
            // txtMienGiam
            // 
            this.txtMienGiam.Location = new System.Drawing.Point(543, 149);
            this.txtMienGiam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMienGiam.Name = "txtMienGiam";
            this.txtMienGiam.ReadOnly = true;
            this.txtMienGiam.Size = new System.Drawing.Size(179, 20);
            this.txtMienGiam.TabIndex = 52;
            // 
            // txtMaL
            // 
            this.txtMaL.Location = new System.Drawing.Point(151, 216);
            this.txtMaL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaL.Name = "txtMaL";
            this.txtMaL.ReadOnly = true;
            this.txtMaL.Size = new System.Drawing.Size(250, 20);
            this.txtMaL.TabIndex = 51;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(151, 183);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(250, 20);
            this.txtMaSV.TabIndex = 50;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(151, 149);
            this.txtNamHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.ReadOnly = true;
            this.txtNamHoc.Size = new System.Drawing.Size(124, 20);
            this.txtNamHoc.TabIndex = 48;
            // 
            // lblconno
            // 
            this.lblconno.AutoSize = true;
            this.lblconno.Location = new System.Drawing.Point(432, 219);
            this.lblconno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblconno.Name = "lblconno";
            this.lblconno.Size = new System.Drawing.Size(44, 13);
            this.lblconno.TabIndex = 45;
            this.lblconno.Text = "Còn nợ:";
            // 
            // lblmiengiam
            // 
            this.lblmiengiam.AutoSize = true;
            this.lblmiengiam.Location = new System.Drawing.Point(432, 151);
            this.lblmiengiam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmiengiam.Name = "lblmiengiam";
            this.lblmiengiam.Size = new System.Drawing.Size(58, 13);
            this.lblmiengiam.TabIndex = 44;
            this.lblmiengiam.Text = "Miễn giảm:";
            // 
            // lblcandong
            // 
            this.lblcandong.AutoSize = true;
            this.lblcandong.Location = new System.Drawing.Point(432, 184);
            this.lblcandong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcandong.Name = "lblcandong";
            this.lblcandong.Size = new System.Drawing.Size(92, 13);
            this.lblcandong.TabIndex = 43;
            this.lblcandong.Text = "Số tiền cần đóng:";
            // 
            // lblmalop
            // 
            this.lblmalop.AutoSize = true;
            this.lblmalop.Location = new System.Drawing.Point(58, 219);
            this.lblmalop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmalop.Name = "lblmalop";
            this.lblmalop.Size = new System.Drawing.Size(42, 13);
            this.lblmalop.TabIndex = 42;
            this.lblmalop.Text = "Mã lớp:";
            // 
            // lblmsv
            // 
            this.lblmsv.AutoSize = true;
            this.lblmsv.Location = new System.Drawing.Point(58, 184);
            this.lblmsv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmsv.Name = "lblmsv";
            this.lblmsv.Size = new System.Drawing.Size(70, 13);
            this.lblmsv.TabIndex = 41;
            this.lblmsv.Text = "Mã sinh viên:";
            // 
            // lblhocky
            // 
            this.lblhocky.AutoSize = true;
            this.lblhocky.Location = new System.Drawing.Point(297, 151);
            this.lblhocky.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhocky.Name = "lblhocky";
            this.lblhocky.Size = new System.Drawing.Size(44, 13);
            this.lblhocky.TabIndex = 40;
            this.lblhocky.Text = "Học kỳ:";
            // 
            // btnXemchitiet
            // 
            this.btnXemchitiet.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnXemchitiet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXemchitiet.Location = new System.Drawing.Point(782, 165);
            this.btnXemchitiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXemchitiet.Name = "btnXemchitiet";
            this.btnXemchitiet.Size = new System.Drawing.Size(80, 32);
            this.btnXemchitiet.TabIndex = 39;
            this.btnXemchitiet.Text = "Xem chi tiết";
            this.btnXemchitiet.UseVisualStyleBackColor = false;
            this.btnXemchitiet.Click += new System.EventHandler(this.btnXemchitiet_Click);
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(355, 149);
            this.txtHocKy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.ReadOnly = true;
            this.txtHocKy.Size = new System.Drawing.Size(46, 20);
            this.txtHocKy.TabIndex = 49;
            // 
            // lblnamhoc
            // 
            this.lblnamhoc.AutoSize = true;
            this.lblnamhoc.Location = new System.Drawing.Point(58, 149);
            this.lblnamhoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnamhoc.Name = "lblnamhoc";
            this.lblnamhoc.Size = new System.Drawing.Size(53, 13);
            this.lblnamhoc.TabIndex = 37;
            this.lblnamhoc.Text = "Năm học:";
            // 
            // dataGVThongKeHocPhi
            // 
            this.dataGVThongKeHocPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVThongKeHocPhi.Location = new System.Drawing.Point(9, 271);
            this.dataGVThongKeHocPhi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGVThongKeHocPhi.Name = "dataGVThongKeHocPhi";
            this.dataGVThongKeHocPhi.RowHeadersWidth = 51;
            this.dataGVThongKeHocPhi.RowTemplate.Height = 24;
            this.dataGVThongKeHocPhi.Size = new System.Drawing.Size(613, 226);
            this.dataGVThongKeHocPhi.TabIndex = 38;
            // 
            // lbltkhp
            // 
            this.lbltkhp.AutoSize = true;
            this.lbltkhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbltkhp.Location = new System.Drawing.Point(159, 65);
            this.lbltkhp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltkhp.Name = "lbltkhp";
            this.lbltkhp.Size = new System.Drawing.Size(608, 26);
            this.lbltkhp.TabIndex = 36;
            this.lbltkhp.Text = "TỔNG QUÁT TÌNH TRẠNG ĐÓNG HỌC PHÍ SINH VIÊN";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnThoat.Location = new System.Drawing.Point(782, 203);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 32);
            this.btnThoat.TabIndex = 58;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmThongKeHocPhi_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(886, 518);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grpBoxTimKiem);
            this.Controls.Add(this.txtConNo);
            this.Controls.Add(this.txtCanDong);
            this.Controls.Add(this.txtMienGiam);
            this.Controls.Add(this.txtMaL);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.txtNamHoc);
            this.Controls.Add(this.lblconno);
            this.Controls.Add(this.lblmiengiam);
            this.Controls.Add(this.lblcandong);
            this.Controls.Add(this.lblmalop);
            this.Controls.Add(this.lblmsv);
            this.Controls.Add(this.lblhocky);
            this.Controls.Add(this.btnXemchitiet);
            this.Controls.Add(this.txtHocKy);
            this.Controls.Add(this.lblnamhoc);
            this.Controls.Add(this.dataGVThongKeHocPhi);
            this.Controls.Add(this.lbltkhp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmThongKeHocPhi_NV";
            this.Text = "FrmThongKeHocPhi_NV";
            this.Load += new System.EventHandler(this.FrmThongKeHocPhi_NV_Load);
            this.grpBoxTimKiem.ResumeLayout(false);
            this.grpBoxTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVThongKeHocPhi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTKHocKy;
        private System.Windows.Forms.GroupBox grpBoxTimKiem;
        private System.Windows.Forms.ComboBox cboTKTinhTrang;
        private System.Windows.Forms.TextBox txtTKMaSV;
        private System.Windows.Forms.CheckBox chkTKTinhTrang;
        private System.Windows.Forms.CheckBox chkTKMaSV;
        private System.Windows.Forms.CheckBox chkTKHocKy;
        private System.Windows.Forms.CheckBox chkTKNamHoc;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtConNo;
        private System.Windows.Forms.TextBox txtCanDong;
        private System.Windows.Forms.TextBox txtMienGiam;
        private System.Windows.Forms.TextBox txtMaL;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.Label lblconno;
        private System.Windows.Forms.Label lblmiengiam;
        private System.Windows.Forms.Label lblcandong;
        private System.Windows.Forms.Label lblmalop;
        private System.Windows.Forms.Label lblmsv;
        private System.Windows.Forms.Label lblhocky;
        private System.Windows.Forms.Button btnXemchitiet;
        private System.Windows.Forms.TextBox txtHocKy;
        private System.Windows.Forms.Label lblnamhoc;
        private System.Windows.Forms.DataGridView dataGVThongKeHocPhi;
        private System.Windows.Forms.Label lbltkhp;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboTKNamHoc;
    }
}