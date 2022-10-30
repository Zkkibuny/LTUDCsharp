
namespace QuanLyHocPhi
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.qUẢNLÝHỌCPHÍToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLiTienTin_NV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiemTienTin_NV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBienLai_NV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKeHocPhi_NV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChiTietHocPhi_NV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCaoThongKe_NV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXemHocPhi_SV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblHello = new System.Windows.Forms.Label();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.txtHomeName = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qUẢNLÝHỌCPHÍToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(911, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // qUẢNLÝHỌCPHÍToolStripMenuItem
            // 
            this.qUẢNLÝHỌCPHÍToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanLiTienTin_NV,
            this.mnuTimKiemTienTin_NV,
            this.mnuBienLai_NV,
            this.mnuThongKeHocPhi_NV,
            this.mnuChiTietHocPhi_NV,
            this.mnuBaoCaoThongKe_NV,
            this.mnuXemHocPhi_SV,
            this.mnuLogout});
            this.qUẢNLÝHỌCPHÍToolStripMenuItem.Name = "qUẢNLÝHỌCPHÍToolStripMenuItem";
            this.qUẢNLÝHỌCPHÍToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.qUẢNLÝHỌCPHÍToolStripMenuItem.Text = "QUẢN LÝ HỌC PHÍ";
            // 
            // mnuQuanLiTienTin_NV
            // 
            this.mnuQuanLiTienTin_NV.Name = "mnuQuanLiTienTin_NV";
            this.mnuQuanLiTienTin_NV.Size = new System.Drawing.Size(216, 22);
            this.mnuQuanLiTienTin_NV.Text = "Quản lý tiền tín";
            this.mnuQuanLiTienTin_NV.Click += new System.EventHandler(this.mnuQuanLiTienTin_NV_Click);
            // 
            // mnuTimKiemTienTin_NV
            // 
            this.mnuTimKiemTienTin_NV.Name = "mnuTimKiemTienTin_NV";
            this.mnuTimKiemTienTin_NV.Size = new System.Drawing.Size(216, 22);
            this.mnuTimKiemTienTin_NV.Text = "Tìm kiếm tiền tín";
            this.mnuTimKiemTienTin_NV.Click += new System.EventHandler(this.mnuTimKiemTienTin_NV_Click);
            // 
            // mnuBienLai_NV
            // 
            this.mnuBienLai_NV.Name = "mnuBienLai_NV";
            this.mnuBienLai_NV.Size = new System.Drawing.Size(216, 22);
            this.mnuBienLai_NV.Text = "Biên lai";
            this.mnuBienLai_NV.Click += new System.EventHandler(this.mnuBienLai_NV_Click);
            // 
            // mnuThongKeHocPhi_NV
            // 
            this.mnuThongKeHocPhi_NV.Name = "mnuThongKeHocPhi_NV";
            this.mnuThongKeHocPhi_NV.Size = new System.Drawing.Size(216, 22);
            this.mnuThongKeHocPhi_NV.Text = "Thống kê học phí sinh viên";
            this.mnuThongKeHocPhi_NV.Click += new System.EventHandler(this.mnuThongKeHocPhi_NV_Click);
            // 
            // mnuChiTietHocPhi_NV
            // 
            this.mnuChiTietHocPhi_NV.Name = "mnuChiTietHocPhi_NV";
            this.mnuChiTietHocPhi_NV.Size = new System.Drawing.Size(216, 22);
            this.mnuChiTietHocPhi_NV.Text = "Chi tiết học phí sinh viên";
            this.mnuChiTietHocPhi_NV.Click += new System.EventHandler(this.mnuChiTietHocPhi_NV_Click);
            // 
            // mnuBaoCaoThongKe_NV
            // 
            this.mnuBaoCaoThongKe_NV.Name = "mnuBaoCaoThongKe_NV";
            this.mnuBaoCaoThongKe_NV.Size = new System.Drawing.Size(216, 22);
            this.mnuBaoCaoThongKe_NV.Text = "Báo cáo thống kê";
            this.mnuBaoCaoThongKe_NV.Click += new System.EventHandler(this.mnuBaoCaoThongKe_NV_Click);
            // 
            // mnuXemHocPhi_SV
            // 
            this.mnuXemHocPhi_SV.Name = "mnuXemHocPhi_SV";
            this.mnuXemHocPhi_SV.Size = new System.Drawing.Size(216, 22);
            this.mnuXemHocPhi_SV.Text = "Xem học phí";
            this.mnuXemHocPhi_SV.Click += new System.EventHandler(this.mnuXemHocPhi_SV_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(216, 22);
            this.mnuLogout.Text = "Đăng xuất";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(911, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(911, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHello.Location = new System.Drawing.Point(432, 3);
            this.lblHello.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(58, 15);
            this.lblHello.TabIndex = 7;
            this.lblHello.Text = "Xin chào,";
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNameUser.Location = new System.Drawing.Point(494, 3);
            this.lblNameUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(45, 15);
            this.lblNameUser.TabIndex = 9;
            this.lblNameUser.Text = "Name";
            // 
            // txtHomeName
            // 
            this.txtHomeName.Location = new System.Drawing.Point(686, 4);
            this.txtHomeName.Margin = new System.Windows.Forms.Padding(2);
            this.txtHomeName.Name = "txtHomeName";
            this.txtHomeName.ReadOnly = true;
            this.txtHomeName.Size = new System.Drawing.Size(218, 20);
            this.txtHomeName.TabIndex = 8;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 453);
            this.ControlBox = false;
            this.Controls.Add(this.lblNameUser);
            this.Controls.Add(this.txtHomeName);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMain";
            this.Text = "Hệ thống Quản lý học phí";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem qUẢNLÝHỌCPHÍToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiemTienTin_NV;
        private System.Windows.Forms.ToolStripMenuItem mnuBienLai_NV;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKeHocPhi_NV;
        private System.Windows.Forms.ToolStripMenuItem mnuChiTietHocPhi_NV;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCaoThongKe_NV;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLiTienTin_NV;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.TextBox txtHomeName;
        private System.Windows.Forms.ToolStripMenuItem mnuXemHocPhi_SV;
    }
}



