using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConvertImage.PictureDbSetTableAdapters;

namespace ConvertImage
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private Image img_secilen;
        private PictureDbSet pbset = new PictureDbSet();
        private PictureDbSetTableAdapters.PictureEditTableAdapter adapter = new PictureEditTableAdapter();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            var pic_db = imagetobyte(img_secilen);
            adapter.InsertQuery("Araba",pic_db);
        }

        private void btn_sec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya =new OpenFileDialog();
            dosya.ShowDialog();
            var filename = dosya.FileName;
            Bitmap b1 = new Bitmap(filename);
            pb_secilen.Image = (Image) b1;
            img_secilen = (Image)b1;
        }

        public static byte[] imagetobyte(Image img)
        {
            byte[] byteArray = new byte[0];
            MemoryStream stream = new MemoryStream();
            
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                stream.Close();

                byteArray = stream.ToArray();
            
            return byteArray;
        }

        private void btn_sifirla_Click(object sender, EventArgs e)
        {
            pb_secilen.Image = null;
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            var gelen_byte = adapter.GetPicture("Araba");
            Image gelen_img = byteArrayToImage(gelen_byte);
            pb_secilen.Image = gelen_img;
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
                MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
