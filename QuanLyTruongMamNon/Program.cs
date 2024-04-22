﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using System.IO;

namespace QuanLyTruongMamNon
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DiemDanh());
        }
    }
    internal static class MainMenu
    {
        public static void SetupMainMenu(MenuStrip mainMenu)
        {
            mainMenu.Items.Clear();
            mainMenu.AutoSize = false;
            mainMenu.BackColor = System.Drawing.Color.SteelBlue;
            mainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            mainMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            mainMenu.Font = new Font("Segoe UI", 16);
            mainMenu.Padding = new Padding(15, 0, 0, 0);


            //Khởi tạo các item
            //CreateMenuItem(mainMenu, "mnuTB", "QUẢN LÍ THÔNG BÁO", Properties.Resources.icon_ThongBao);
            //CreateMenuItem(mainMenu, "mnuGV", "QUẢN LÍ GIÁO VỤ", Properties.Resources.icon_GiaoVu);
            CreateMenuItem(mainMenu, "mnuHS", "QUẢN LÍ HỌC SINH", Properties.Resources.icon_HocSinh, typeof(QuanLyTruongMamNon.QuanLiHocSinh).FullName);
            CreateMenuItem(mainMenu, "mnuNV", "QUẢN LÍ NHÂN VIÊN", Properties.Resources.icon_GiaoVien, typeof(QuanLyTruongMamNon.QuanLiNhanVien).FullName);
            //CreateMenuItem(mainMenu, "mnuVC", "QUẢN LÍ VẬT CHẤT ", Properties.Resources.icon_VatChat);
            //CreateMenuItem(mainMenu, "mnuNS", "QUẢN LÍ NGÂN SÁCH", Properties.Resources.icon_NganSach, typeof(QuanLyTruongMamNon.ThemMonAn).FullName);
            CreateMenuItem(mainMenu, "mnuDD", "QUẢN LÍ ĐIỂM DANH", Properties.Resources.icon_DiemDanh, typeof(QuanLyTruongMamNon.DiemDanh).FullName);
            //CreateMenuItem(mainMenu, "mnuTT", "QUẢN LÍ THÀNH TÍCH", Properties.Resources.icon_ThanhTich, typeof(QuanLyTruongMamNon.ThemMonAn).FullName);
            CreateMenuItem(mainMenu, "mnuTD", "QUẢN LÍ THỰC ĐƠN", Properties.Resources.icon_ThucDon, typeof(QuanLyTruongMamNon.ThemThucDon).FullName);
            CreateMenuItem(mainMenu, "mnuMA", "QUẢN LÍ MÓN ĂN", Properties.Resources.icon_MonAn, typeof(QuanLyTruongMamNon.ThemMonAn).FullName);
        }

        private static void CreateMenuItem(MenuStrip menuStrip, string name, string text, Image icon, string formPath)
        {
            //Thuộc tính cơ bản
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Name = name;
            item.Text = text;
            item.Size = new Size(300, 40);
            item.TextAlign = ContentAlignment.MiddleLeft;
            item.ImageAlign = ContentAlignment.MiddleLeft;
            item.Padding = new Padding(0, 10, 0, 10);

            //Định dạng ICON
            if (icon != null)
            {
                item.Image = icon;
                item.ImageScaling = ToolStripItemImageScaling.SizeToFit;
                item.TextImageRelation = TextImageRelation.ImageBeforeText;
            }

            if (!string.IsNullOrEmpty(formPath) && menuStrip.FindForm().GetType().FullName != formPath)
            {
                item.Click += (sender, e) =>
                {
                    Form currentForm = menuStrip.FindForm();
                    Form newForm = (Form)Activator.CreateInstance(Type.GetType(formPath));

                    // Đăng ký sự kiện Shown của form mới
                    newForm.Shown += (s, args) =>
                    {
                        // Sau khi form mới được hiển thị, ẩn form hiện tại
                        currentForm.Hide();

                        // Sau khi form mới đã đóng, giải phóng tài nguyên của form hiện tại
                        newForm.FormClosed += (s2, args2) => currentForm.Dispose();
                    };

                    // Hiển thị form mới
                    newForm.Show();
                };
            }

            menuStrip.Items.Add(item);
        }
    }
}
