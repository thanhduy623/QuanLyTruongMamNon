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
    public partial class QuanLiNhanVien : Form
    {
        public QuanLiNhanVien()
        {
            InitializeComponent();
            formLoad();
        }
        private void formLoad()
        {
            MainMenu.SetupMainMenu(menu);
            MainFunc.basicFormLoad(this);

            List<Tuple<string, string, string, string, string, string>> listStu = new List<Tuple<string, string, string, string, string, string>>();
            foreach (var i in AccountDAO.Instance.getAllStaffs())
            {
                string sex;
                if (i.Gender.ToString() == "True")
                {
                    sex = "Nam";
                }
                else
                {
                    sex = "Nữ";
                }
                listStu.Add(new Tuple<string, string, string, string, string, string>(i.IdStaff, i.NameStaff, sex, i.DateBirth.ToString("dd/MM/yyyy"), i.Roled, i.Phone));
            }
            duLieu.DataSource = listStu;
            duLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            duLieu.Columns["Item1"].HeaderText = "IDStudents";
            duLieu.Columns["Item2"].HeaderText = "Tên học sinh";
            duLieu.Columns["Item3"].HeaderText = "Giới tính";
            duLieu.Columns["Item4"].HeaderText = "Ngày sinh";
            duLieu.Columns["Item5"].HeaderText = "Chức vụ";
            duLieu.Columns["Item6"].HeaderText = "Sô điện thoại";
        }

        public static T GetCurrentInstance<T>(Form form) where T : Form
        {
            return form as T;
        }

        private void btnNguoiDung_click(object sender, EventArgs e)
        {
            this.Hide();
            HoSoNHanVien hs = new HoSoNHanVien(null);
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

        private void btnTim_click(object sender, EventArgs e)
        {
            string id = boxTimKiem.Text;
            List<Tuple<string, string, string, string, string, string>> listStu = new List<Tuple<string, string, string, string, string, string>>();
            foreach (var i in AccountDAO.Instance.getAllStaffs())
            {
                string sex;
                if (i.Gender.ToString() == "True")
                {
                    sex = "Nam";
                }
                else
                {
                    sex = "Nữ";
                }
                if (i.IdStaff.ToLower().Contains(id.ToLower()))
                {
                    listStu.Add(new Tuple<string, string, string, string, string, string>(i.IdStaff, i.NameStaff, sex, i.DateBirth.ToString("dd/MM/yyyy"), i.Roled, i.Phone));
                }
            }
            duLieu.DataSource = listStu;
            duLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            duLieu.Columns["Item1"].HeaderText = "IDStudents";
            duLieu.Columns["Item2"].HeaderText = "Tên học sinh";
            duLieu.Columns["Item3"].HeaderText = "Giới tính";
            duLieu.Columns["Item4"].HeaderText = "Ngày sinh";
            duLieu.Columns["Item5"].HeaderText = "Chức vụ";
            duLieu.Columns["Item6"].HeaderText = "Sô điện thoại";
        }
    }
}
