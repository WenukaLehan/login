using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class qrcode : Form
    {
        public qrcode()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(tbx.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(data);
            ptx.Image = qrCode.GetGraphic(5);
        }
    }
}
