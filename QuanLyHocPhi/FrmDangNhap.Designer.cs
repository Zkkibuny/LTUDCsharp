
namespace QuanLyHocPhi
{
    partial class FrmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            this.lblTenDN = new System.Windows.Forms.Label();
            this.lblTitleDangNhap = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.radNS = new System.Windows.Forms.RadioButton();
            this.radSV = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDN = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenDN
            // 
            this.lblTenDN.AutoSize = true;
            this.lblTenDN.BackColor = System.Drawing.Color.White;
            this.lblTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenDN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTenDN.Location = new System.Drawing.Point(90, 243);
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.Size = new System.Drawing.Size(120, 20);
            this.lblTenDN.TabIndex = 10;
            this.lblTenDN.Text = "Tên đăng nhập:";
            // 
            // lblTitleDangNhap
            // 
            this.lblTitleDangNhap.AutoSize = true;
            this.lblTitleDangNhap.BackColor = System.Drawing.Color.White;
            this.lblTitleDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDangNhap.Location = new System.Drawing.Point(63, 173);
            this.lblTitleDangNhap.Name = "lblTitleDangNhap";
            this.lblTitleDangNhap.Size = new System.Drawing.Size(554, 31);
            this.lblTitleDangNhap.TabIndex = 9;
            this.lblTitleDangNhap.Text = "TRƯỜNG ĐẠI HỌC KINH TẾ QUỐC DÂN";
            this.lblTitleDangNhap.Click += new System.EventHandler(this.lblTitleDangNhap_Click);
            // 
            // radNS
            // 
            this.radNS.AutoSize = true;
            this.radNS.BackColor = System.Drawing.Color.White;
            this.radNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radNS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radNS.Location = new System.Drawing.Point(424, 338);
            this.radNS.Name = "radNS";
            this.radNS.Size = new System.Drawing.Size(86, 24);
            this.radNS.TabIndex = 4;
            this.radNS.Text = "Nhân sự";
            this.radNS.UseVisualStyleBackColor = false;
            // 
            // radSV
            // 
            this.radSV.AutoSize = true;
            this.radSV.BackColor = System.Drawing.Color.White;
            this.radSV.Checked = true;
            this.radSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radSV.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radSV.Location = new System.Drawing.Point(278, 338);
            this.radSV.Name = "radSV";
            this.radSV.Size = new System.Drawing.Size(91, 24);
            this.radSV.TabIndex = 3;
            this.radSV.TabStop = true;
            this.radSV.Text = "Sinh viên";
            this.radSV.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(455, 400);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 39);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDN
            // 
            this.btnDN.BackColor = System.Drawing.Color.Red;
            this.btnDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDN.Location = new System.Drawing.Point(185, 400);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(107, 39);
            this.btnDN.TabIndex = 5;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = false;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(216, 285);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(366, 29);
            this.txtMatKhau.TabIndex = 2;
            // 
            // txtTenDN
            // 
            this.txtTenDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN.Location = new System.Drawing.Point(216, 237);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(366, 29);
            this.txtTenDN.TabIndex = 1;
            this.txtTenDN.TextChanged += new System.EventHandler(this.txtTenDN_TextChanged);
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.BackColor = System.Drawing.Color.White;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMatKhau.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMatKhau.Location = new System.Drawing.Point(131, 294);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(79, 20);
            this.lblMatKhau.TabIndex = 11;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyHocPhi.Properties.Resources.MicrosoftTeams_image__2_;
            this.pictureBox1.Location = new System.Drawing.Point(262, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmDangNhap
            // 
            this.AcceptButton = this.btnDN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QuanLyHocPhi.Properties.Resources._288750993_1013143999566155_1970788115881377936_n;
            this.ClientSize = new System.Drawing.Size(698, 472);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTenDN);
            this.Controls.Add(this.lblTitleDangNhap);
            this.Controls.Add(this.radNS);
            this.Controls.Add(this.radSV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.lblMatKhau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDangNhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenDN;
        private System.Windows.Forms.Label lblTitleDangNhap;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton radNS;
        private System.Windows.Forms.RadioButton radSV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}