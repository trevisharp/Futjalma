using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Futjalma
{
    public partial class PhotoPicker : UserControl
    {
        private byte[] data = null;
        public byte[] Photo
        {
            get => data;
            set
            {
                if (value == null)
                {
                    data = null;
                    return;
                }

                this.data = value;
                using (MemoryStream ms = new MemoryStream(value))
                {
                    pbImage.Image = Image.FromStream(ms);
                }
            }
        }

        public PhotoPicker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var img = Image.FromFile(ofd.FileName);
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, ImageFormat.Jpeg);
                    data = ms.GetBuffer();
                }
                pbImage.Image = img;
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            data = null;
            pbImage.Image = null;
        }
    }
}
