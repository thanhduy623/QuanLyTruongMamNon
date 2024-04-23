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
    public partial class HoSoHocSinh : Form
    {
        public HoSoHocSinh()
        {
            InitializeComponent();
            formLoad();
        }

        private void formLoad()
        {
            MainFunc.basicFormLoad(this);
            MainMenu.SetupMainMenu(menu);
        }
    }
}
