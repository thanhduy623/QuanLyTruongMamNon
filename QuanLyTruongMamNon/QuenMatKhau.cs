using QuanLyTruongMamNon.DAO;
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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnXacNhan_click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text;
            string password = TxtNewPasss.Text;

            if (btnForgotPassword(username, password) == true)
            {
                MessageBox.Show("Đổi mật khẩu mới thành công");
            }
            else
            {
                MessageBox.Show("Tài khoản không hợp lệ");
            }

        }
        bool btnForgotPassword(string username, string newPassword)
        {
            return AccountDAO.Instance.ForgotPassword(username, newPassword);
        }

        private void btnThoat_click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap d = new DangNhap();
            d.Show();
        }
    }
}
