using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Shop_Billing_System.Forms.Payment_Details
{
    public partial class frm_View_Payment_Details : Form
    {
        public frm_View_Payment_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Payment_Details_Load(object sender, EventArgs e)
        {
            this.dgv_Payment_View.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11);

            Shared_Class.Bind_Grid(dgv_Payment_View, "Select Merchant_Name, Date, Remaning_Bill , Paid_Bill , Total_Bill , Payment_Method  From  Payment_Details");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Shared_Class.Bind_Grid(dgv_Payment_View, "Select Merchant_Name, Date, Remaning_Bill , Paid_Bill , Total_Bill , Payment_Method  From  Payment_Details");
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            dgv_Payment_View.DataSource = null;
        }
    }
}
