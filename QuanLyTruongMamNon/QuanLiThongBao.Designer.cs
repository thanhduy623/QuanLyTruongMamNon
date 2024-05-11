namespace QuanLyTruongMamNon
{
    partial class QuanLiThongBao
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.duLieu = new System.Windows.Forms.DataGridView();
            this.barTieuDe = new System.Windows.Forms.Panel();
            this.btnNguoiDung = new System.Windows.Forms.PictureBox();
            this.btnDangXuat = new System.Windows.Forms.PictureBox();
            this.lbDuongDan = new System.Windows.Forms.Label();
            this.txtTieuDe = new System.Windows.Forms.Label();
            this.barThongTinThongBao = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.noiDung = new System.Windows.Forms.TextBox();
            this.labelNoiDung = new System.Windows.Forms.Label();
            this.tieuDe = new System.Windows.Forms.TextBox();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.maThongBao = new System.Windows.Forms.TextBox();
            this.labelThoiGian = new System.Windows.Forms.Label();
            this.thoiGian = new System.Windows.Forms.DateTimePicker();
            this.labelMaThongBao = new System.Windows.Forms.Label();
            this.labelNhap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).BeginInit();
            this.barTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDangXuat)).BeginInit();
            this.barThongTinThongBao.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.SteelBlue;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(489, 1106);
            this.menu.TabIndex = 14;
            // 
            // duLieu
            // 
            this.duLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.duLieu.Location = new System.Drawing.Point(1404, 208);
            this.duLieu.Margin = new System.Windows.Forms.Padding(45, 0, 0, 46);
            this.duLieu.Name = "duLieu";
            this.duLieu.RowHeadersWidth = 62;
            this.duLieu.Size = new System.Drawing.Size(600, 928);
            this.duLieu.TabIndex = 18;
            // 
            // barTieuDe
            // 
            this.barTieuDe.Controls.Add(this.btnNguoiDung);
            this.barTieuDe.Controls.Add(this.btnDangXuat);
            this.barTieuDe.Controls.Add(this.lbDuongDan);
            this.barTieuDe.Controls.Add(this.txtTieuDe);
            this.barTieuDe.Location = new System.Drawing.Point(534, 46);
            this.barTieuDe.Margin = new System.Windows.Forms.Padding(45, 46, 45, 46);
            this.barTieuDe.Name = "barTieuDe";
            this.barTieuDe.Size = new System.Drawing.Size(1470, 115);
            this.barTieuDe.TabIndex = 102;
            // 
            // btnNguoiDung
            // 
            this.btnNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.btnNguoiDung.Image = global::QuanLyTruongMamNon.Properties.Resources.icon_person;
            this.btnNguoiDung.Location = new System.Drawing.Point(1298, 0);
            this.btnNguoiDung.Margin = new System.Windows.Forms.Padding(0, 0, 22, 0);
            this.btnNguoiDung.Name = "btnNguoiDung";
            this.btnNguoiDung.Size = new System.Drawing.Size(75, 77);
            this.btnNguoiDung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNguoiDung.TabIndex = 19;
            this.btnNguoiDung.TabStop = false;
            this.btnNguoiDung.Click += new System.EventHandler(this.btnNguoiDung_click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Image = global::QuanLyTruongMamNon.Properties.Resources.icon_exit;
            this.btnDangXuat.Location = new System.Drawing.Point(1395, 0);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(0);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(75, 77);
            this.btnDangXuat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDangXuat.TabIndex = 18;
            this.btnDangXuat.TabStop = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_click);
            // 
            // lbDuongDan
            // 
            this.lbDuongDan.BackColor = System.Drawing.Color.Transparent;
            this.lbDuongDan.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbDuongDan.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbDuongDan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDuongDan.Location = new System.Drawing.Point(2, 75);
            this.lbDuongDan.Margin = new System.Windows.Forms.Padding(0);
            this.lbDuongDan.Name = "lbDuongDan";
            this.lbDuongDan.Size = new System.Drawing.Size(597, 38);
            this.lbDuongDan.TabIndex = 15;
            this.lbDuongDan.Text = " Trang chủ ● Quản lí thông báo";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.txtTieuDe.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTieuDe.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtTieuDe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTieuDe.Location = new System.Drawing.Point(2, 3);
            this.txtTieuDe.Margin = new System.Windows.Forms.Padding(0);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(596, 74);
            this.txtTieuDe.TabIndex = 5;
            this.txtTieuDe.Text = "QUẢN LÍ THÔNG BÁO";
            // 
            // barThongTinThongBao
            // 
            this.barThongTinThongBao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barThongTinThongBao.Controls.Add(this.btnXoa);
            this.barThongTinThongBao.Controls.Add(this.btnThem);
            this.barThongTinThongBao.Controls.Add(this.noiDung);
            this.barThongTinThongBao.Controls.Add(this.labelNoiDung);
            this.barThongTinThongBao.Controls.Add(this.tieuDe);
            this.barThongTinThongBao.Controls.Add(this.labelTieuDe);
            this.barThongTinThongBao.Controls.Add(this.maThongBao);
            this.barThongTinThongBao.Controls.Add(this.labelThoiGian);
            this.barThongTinThongBao.Controls.Add(this.thoiGian);
            this.barThongTinThongBao.Controls.Add(this.labelMaThongBao);
            this.barThongTinThongBao.Controls.Add(this.labelNhap);
            this.barThongTinThongBao.Location = new System.Drawing.Point(534, 208);
            this.barThongTinThongBao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barThongTinThongBao.Name = "barThongTinThongBao";
            this.barThongTinThongBao.Size = new System.Drawing.Size(824, 927);
            this.barThongTinThongBao.TabIndex = 103;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnXoa.Location = new System.Drawing.Point(492, 832);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(300, 77);
            this.btnXoa.TabIndex = 59;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThem.Location = new System.Drawing.Point(30, 832);
            this.btnThem.Margin = new System.Windows.Forms.Padding(15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(300, 77);
            this.btnThem.TabIndex = 58;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_click);
            // 
            // noiDung
            // 
            this.noiDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noiDung.Location = new System.Drawing.Point(30, 295);
            this.noiDung.Margin = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.noiDung.Multiline = true;
            this.noiDung.Name = "noiDung";
            this.noiDung.Size = new System.Drawing.Size(761, 516);
            this.noiDung.TabIndex = 57;
            // 
            // labelNoiDung
            // 
            this.labelNoiDung.BackColor = System.Drawing.Color.Transparent;
            this.labelNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelNoiDung.Location = new System.Drawing.Point(26, 258);
            this.labelNoiDung.Margin = new System.Windows.Forms.Padding(45, 15, 15, 5);
            this.labelNoiDung.Name = "labelNoiDung";
            this.labelNoiDung.Size = new System.Drawing.Size(270, 28);
            this.labelNoiDung.TabIndex = 56;
            this.labelNoiDung.Text = "Nội dung thông báo";
            this.labelNoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tieuDe
            // 
            this.tieuDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tieuDe.Location = new System.Drawing.Point(30, 198);
            this.tieuDe.Margin = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.tieuDe.Name = "tieuDe";
            this.tieuDe.Size = new System.Drawing.Size(762, 35);
            this.tieuDe.TabIndex = 55;
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.labelTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTieuDe.Location = new System.Drawing.Point(26, 162);
            this.labelTieuDe.Margin = new System.Windows.Forms.Padding(45, 15, 15, 5);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(300, 28);
            this.labelTieuDe.TabIndex = 54;
            this.labelTieuDe.Text = "Tiêu đề";
            this.labelTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maThongBao
            // 
            this.maThongBao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maThongBao.Location = new System.Drawing.Point(30, 102);
            this.maThongBao.Margin = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.maThongBao.Name = "maThongBao";
            this.maThongBao.Size = new System.Drawing.Size(299, 35);
            this.maThongBao.TabIndex = 53;
            // 
            // labelThoiGian
            // 
            this.labelThoiGian.BackColor = System.Drawing.Color.Transparent;
            this.labelThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThoiGian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelThoiGian.Location = new System.Drawing.Point(489, 65);
            this.labelThoiGian.Margin = new System.Windows.Forms.Padding(45, 15, 15, 5);
            this.labelThoiGian.Name = "labelThoiGian";
            this.labelThoiGian.Size = new System.Drawing.Size(300, 28);
            this.labelThoiGian.TabIndex = 52;
            this.labelThoiGian.Text = "Thời gian";
            this.labelThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // thoiGian
            // 
            this.thoiGian.Enabled = false;
            this.thoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.thoiGian.Location = new System.Drawing.Point(494, 102);
            this.thoiGian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thoiGian.Name = "thoiGian";
            this.thoiGian.Size = new System.Drawing.Size(298, 35);
            this.thoiGian.TabIndex = 49;
            this.thoiGian.Value = new System.DateTime(2024, 4, 21, 1, 15, 43, 0);
            // 
            // labelMaThongBao
            // 
            this.labelMaThongBao.BackColor = System.Drawing.Color.Transparent;
            this.labelMaThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaThongBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMaThongBao.Location = new System.Drawing.Point(26, 65);
            this.labelMaThongBao.Margin = new System.Windows.Forms.Padding(45, 15, 15, 5);
            this.labelMaThongBao.Name = "labelMaThongBao";
            this.labelMaThongBao.Size = new System.Drawing.Size(300, 28);
            this.labelMaThongBao.TabIndex = 48;
            this.labelMaThongBao.Text = "Mã thông báo";
            this.labelMaThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNhap
            // 
            this.labelNhap.BackColor = System.Drawing.Color.Transparent;
            this.labelNhap.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhap.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelNhap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNhap.Location = new System.Drawing.Point(0, 0);
            this.labelNhap.Margin = new System.Windows.Forms.Padding(0);
            this.labelNhap.Name = "labelNhap";
            this.labelNhap.Size = new System.Drawing.Size(825, 49);
            this.labelNhap.TabIndex = 17;
            this.labelNhap.Text = "NHẬP THÔNG TIN THÔNG BÁO MỚI";
            this.labelNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuanLiThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.ControlBox = false;
            this.Controls.Add(this.barThongTinThongBao);
            this.Controls.Add(this.barTieuDe);
            this.Controls.Add(this.duLieu);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QuanLiThongBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí thông báo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).EndInit();
            this.barTieuDe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDangXuat)).EndInit();
            this.barThongTinThongBao.ResumeLayout(false);
            this.barThongTinThongBao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.DataGridView duLieu;
        private System.Windows.Forms.Panel barTieuDe;
        private System.Windows.Forms.Label lbDuongDan;
        private System.Windows.Forms.Label txtTieuDe;
        private System.Windows.Forms.Panel barThongTinThongBao;
        private System.Windows.Forms.Label labelNhap;
        private System.Windows.Forms.DateTimePicker thoiGian;
        private System.Windows.Forms.Label labelMaThongBao;
        private System.Windows.Forms.Label labelThoiGian;
        private System.Windows.Forms.TextBox maThongBao;
        private System.Windows.Forms.TextBox noiDung;
        private System.Windows.Forms.Label labelNoiDung;
        private System.Windows.Forms.TextBox tieuDe;
        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.PictureBox btnNguoiDung;
        private System.Windows.Forms.PictureBox btnDangXuat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}