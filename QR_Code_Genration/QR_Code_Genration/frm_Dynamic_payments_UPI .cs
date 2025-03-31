using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Code_Genration
{
    public partial class frm_Dynamic_Payments_UPI : Form
    {
        public frm_Dynamic_Payments_UPI()
        {
            InitializeComponent();
        }

        private void btn_Genrate_QR_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator Qgen = new QRCoder.QRCodeGenerator();
            var QRdata = Qgen.CreateQrCode("upi://pay?pa=" + tb_upi_id.Text + "&pn=" + tb_name.Text + "&am=" + Convert.ToDecimal(tb_Amount.Text), QRCoder.QRCodeGenerator.ECCLevel.H);
            var QRcode = new QRCoder.QRCode(QRdata);

            pb_QRCODE.Image = QRcode.GetGraphic(50);
           
        }
    }
}
