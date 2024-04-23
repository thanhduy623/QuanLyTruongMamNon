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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
            formLoad();
        }

        private void formLoad()
        {
            MainMenu.SetupMainMenu(menu);
            MainFunc.basicFormLoad(this);
        }
    }

    internal static class MainFunc
    {
        public static void basicFormLoad(Form sender)
        {
            senderExit(sender);
        }

        public static void senderExit(Form sender)
        {
            //Code khúc này để gán click cho btnDangXuat để tắt form
        }
    }
}
