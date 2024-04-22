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
using ZXing;

namespace QuanLyTruongMamNon
{
    public partial class TheHocSinh : Form
    {
        public TheHocSinh()
        {
            InitializeComponent();
            maVach.Image = creatBarcode(maHocSinh.Text ,maVach.Width, maVach.Height);
        }

        static Bitmap creatBarcode(string barcodeText, int width, int height)
        {
            BarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new ZXing.Common.EncodingOptions
                {
                    Width = width,
                    Height = height,
                    PureBarcode = true
                }
            };
            Bitmap barcodeBitmap = writer.Write(barcodeText);

            return barcodeBitmap;
        }
    }
}
