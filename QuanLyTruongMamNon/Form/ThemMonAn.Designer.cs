﻿namespace QuanLyTruongMamNon
{
    partial class ThemMonAn
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
            this.lbDuongDan = new System.Windows.Forms.Label();
            this.barTieuDe = new System.Windows.Forms.Panel();
            this.txtTieuDe = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.duLieu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbnHuy = new System.Windows.Forms.Button();
            this.dinhDuong = new System.Windows.Forms.TextBox();
            this.labelDinhDuong = new System.Windows.Forms.Label();
            this.tenMonAn = new System.Windows.Forms.TextBox();
            this.labelTenMonAn = new System.Windows.Forms.Label();
            this.labelNhap = new System.Windows.Forms.Label();
            this.maMonAn = new System.Windows.Forms.TextBox();
            this.labelMaMonAn = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.barTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDuongDan
            // 
            this.lbDuongDan.BackColor = System.Drawing.Color.Transparent;
            this.lbDuongDan.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbDuongDan.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbDuongDan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDuongDan.Location = new System.Drawing.Point(1, 51);
            this.lbDuongDan.Margin = new System.Windows.Forms.Padding(0);
            this.lbDuongDan.Name = "lbDuongDan";
            this.lbDuongDan.Size = new System.Drawing.Size(398, 23);
            this.lbDuongDan.TabIndex = 15;
            this.lbDuongDan.Text = " Trang chủ ● Thêm món ăn";
            this.lbDuongDan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // barTieuDe
            // 
            this.barTieuDe.Controls.Add(this.lbDuongDan);
            this.barTieuDe.Controls.Add(this.txtTieuDe);
            this.barTieuDe.Location = new System.Drawing.Point(356, 39);
            this.barTieuDe.Margin = new System.Windows.Forms.Padding(30);
            this.barTieuDe.Name = "barTieuDe";
            this.barTieuDe.Size = new System.Drawing.Size(981, 75);
            this.barTieuDe.TabIndex = 15;
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.txtTieuDe.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.txtTieuDe.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtTieuDe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTieuDe.Location = new System.Drawing.Point(1, 2);
            this.txtTieuDe.Margin = new System.Windows.Forms.Padding(0);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(397, 47);
            this.txtTieuDe.TabIndex = 5;
            this.txtTieuDe.Text = "THÊM MÓN ĂN";
            this.txtTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.SteelBlue;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(326, 768);
            this.menu.TabIndex = 14;
            // 
            // duLieu
            // 
            this.duLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.duLieu.Location = new System.Drawing.Point(356, 144);
            this.duLieu.Margin = new System.Windows.Forms.Padding(30, 0, 0, 30);
            this.duLieu.Name = "duLieu";
            this.duLieu.Size = new System.Drawing.Size(661, 596);
            this.duLieu.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tbnHuy);
            this.panel2.Controls.Add(this.dinhDuong);
            this.panel2.Controls.Add(this.labelDinhDuong);
            this.panel2.Controls.Add(this.tenMonAn);
            this.panel2.Controls.Add(this.labelTenMonAn);
            this.panel2.Controls.Add(this.labelNhap);
            this.panel2.Controls.Add(this.maMonAn);
            this.panel2.Controls.Add(this.labelMaMonAn);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(1047, 144);
            this.panel2.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 596);
            this.panel2.TabIndex = 19;
            // 
            // tbnHuy
            // 
            this.tbnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tbnHuy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbnHuy.Location = new System.Drawing.Point(20, 473);
            this.tbnHuy.Margin = new System.Windows.Forms.Padding(10, 3, 10, 20);
            this.tbnHuy.Name = "tbnHuy";
            this.tbnHuy.Size = new System.Drawing.Size(248, 100);
            this.tbnHuy.TabIndex = 44;
            this.tbnHuy.Text = "Hủy";
            this.tbnHuy.UseVisualStyleBackColor = true;
            // 
            // dinhDuong
            // 
            this.dinhDuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dinhDuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinhDuong.Location = new System.Drawing.Point(20, 261);
            this.dinhDuong.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.dinhDuong.Name = "dinhDuong";
            this.dinhDuong.Size = new System.Drawing.Size(248, 26);
            this.dinhDuong.TabIndex = 41;
            // 
            // labelDinhDuong
            // 
            this.labelDinhDuong.BackColor = System.Drawing.Color.Transparent;
            this.labelDinhDuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDinhDuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDinhDuong.Location = new System.Drawing.Point(17, 237);
            this.labelDinhDuong.Margin = new System.Windows.Forms.Padding(30, 10, 10, 3);
            this.labelDinhDuong.Name = "labelDinhDuong";
            this.labelDinhDuong.Size = new System.Drawing.Size(182, 18);
            this.labelDinhDuong.TabIndex = 40;
            this.labelDinhDuong.Text = "Hàm lượng dinh dưỡng";
            this.labelDinhDuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tenMonAn
            // 
            this.tenMonAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenMonAn.Location = new System.Drawing.Point(20, 199);
            this.tenMonAn.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.tenMonAn.Name = "tenMonAn";
            this.tenMonAn.Size = new System.Drawing.Size(248, 26);
            this.tenMonAn.TabIndex = 39;
            // 
            // labelTenMonAn
            // 
            this.labelTenMonAn.BackColor = System.Drawing.Color.Transparent;
            this.labelTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenMonAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTenMonAn.Location = new System.Drawing.Point(17, 175);
            this.labelTenMonAn.Margin = new System.Windows.Forms.Padding(30, 10, 10, 3);
            this.labelTenMonAn.Name = "labelTenMonAn";
            this.labelTenMonAn.Size = new System.Drawing.Size(182, 18);
            this.labelTenMonAn.TabIndex = 38;
            this.labelTenMonAn.Text = "Tên món ăn";
            this.labelTenMonAn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNhap
            // 
            this.labelNhap.BackColor = System.Drawing.Color.Transparent;
            this.labelNhap.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhap.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelNhap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNhap.Location = new System.Drawing.Point(0, 2);
            this.labelNhap.Margin = new System.Windows.Forms.Padding(0);
            this.labelNhap.Name = "labelNhap";
            this.labelNhap.Size = new System.Drawing.Size(288, 101);
            this.labelNhap.TabIndex = 16;
            this.labelNhap.Text = "NHẬP \r\nTHÔNG TIN \r\nMÓN ĂN MỚI";
            this.labelNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maMonAn
            // 
            this.maMonAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maMonAn.Enabled = false;
            this.maMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maMonAn.Location = new System.Drawing.Point(20, 137);
            this.maMonAn.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.maMonAn.Name = "maMonAn";
            this.maMonAn.Size = new System.Drawing.Size(248, 26);
            this.maMonAn.TabIndex = 37;
            // 
            // labelMaMonAn
            // 
            this.labelMaMonAn.BackColor = System.Drawing.Color.Transparent;
            this.labelMaMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaMonAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMaMonAn.Location = new System.Drawing.Point(17, 113);
            this.labelMaMonAn.Margin = new System.Windows.Forms.Padding(30, 10, 10, 3);
            this.labelMaMonAn.Name = "labelMaMonAn";
            this.labelMaMonAn.Size = new System.Drawing.Size(182, 18);
            this.labelMaMonAn.TabIndex = 36;
            this.labelMaMonAn.Text = "Mã món ăn";
            this.labelMaMonAn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThem.Location = new System.Drawing.Point(20, 330);
            this.btnThem.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(248, 100);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // ThemMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.duLieu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.barTieuDe);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm món ăn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.barTieuDe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.duLieu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbDuongDan;
        private System.Windows.Forms.Panel barTieuDe;
        private System.Windows.Forms.Label txtTieuDe;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.DataGridView duLieu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label labelNhap;
        private System.Windows.Forms.TextBox maMonAn;
        private System.Windows.Forms.Label labelMaMonAn;
        private System.Windows.Forms.Button tbnHuy;
        private System.Windows.Forms.TextBox dinhDuong;
        private System.Windows.Forms.Label labelDinhDuong;
        private System.Windows.Forms.TextBox tenMonAn;
        private System.Windows.Forms.Label labelTenMonAn;
    }
}