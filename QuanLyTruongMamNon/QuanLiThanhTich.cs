using QuanLyTruongMamNon.DAO;
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
    public partial class QuanLiThanhTich : Form
    {
        public QuanLiThanhTich()
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

        private void btnThem_click(object sender, EventArgs e)
        {
            string maHS = maHocSinh.Text;
            DateTime date = thoiGian.Value;
            string tt = thanhTich.Text;
            List<Tuple<string>> st = new List<Tuple<string>>();
            foreach (var item in StudentDAO.Instance.getAllStudents())
            {
                st.Add(new Tuple<string>(item.IdStudent));
            }

            bool idTonTai = false;
            foreach (var tuple in st)
            {
                if (tuple.Item1 == maHS)
                {
                    idTonTai = true;
                    break;
                }
            }

            if (tt.Length <= 50 && !(string.IsNullOrEmpty(maHS)) && (DateTime.Now).Subtract(date).Days > 0 && idTonTai == true)
            {
                bool check = StudentDAO.Instance.AddAchieve(maHS , date , tt);
                if (check)
                {
                    MessageBox.Show("Thêm thành tích thành công");
                }
                else
                {
                    MessageBox.Show("Không thêm được nha");
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ");
            }

        }
    }
}
