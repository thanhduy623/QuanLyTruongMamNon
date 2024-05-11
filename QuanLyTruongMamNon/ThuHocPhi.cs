﻿using QuanLyTruongMamNon.DAO;
using QuanLyTruongMamNon.DT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongMamNon
{
    public partial class ThuHocPhi : Form
    {
        public ThuHocPhi()
        {
            InitializeComponent();
            formLoad();
        }
        private void formLoad()
        {
            MainMenu.SetupMainMenu(menu);
            MainFunc.basicFormLoad(this);
        }
        private void btnNguoiDung_click(object sender, EventArgs e)
        {
            this.Hide();
            HoSoNHanVien hs = new HoSoNHanVien();
            hs.ShowDialog();

        }
        private void btnDangXuat_click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất hay không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                DangNhap d = new DangNhap();
                d.Show();
            }
        }

        private void btnTruy_click (object sender, EventArgs e)
        {
            string idStudent = maHocSinh.Text;
            if (!(string.IsNullOrEmpty(idStudent)))
            {
                try
                {
                    Student s = SevicesDAO.Instance.loadStudent(idStudent);
                    lbTen.Text = s.NameStudent;
                    lopHoc.Text = s.Classes;
                    maHocSinh2.Text = s.IdStudent;
                    soTien.Text = "2.000.000 đồng";
                    bangChu.Text = "2 triệu đồng";
                    noiDung.Text = "Học phí năm học " + s.YearSchool;
                    DateTime date = DateTime.Now;
                    lbNgay.Text = "TP. Hồ Chí Minh, ngày " + date.Day + " tháng " + date.Month + " năm " + date.Year;
                }
                catch 
                {
                    MessageBox.Show("ID Không tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Không để trống dữ liệu");
            }
        }
    }
}
