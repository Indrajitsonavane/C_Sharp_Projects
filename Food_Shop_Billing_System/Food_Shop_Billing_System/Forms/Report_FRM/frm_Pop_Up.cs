using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Shop_Billing_System.Forms.Report_FRM
{
    public partial class frm_Pop_Up : Form
    {
        int flag = -1;
        public frm_Pop_Up(int val)
        {
            InitializeComponent();

           flag = val;

        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            Shared_Class.Fdt = Convert.ToDateTime(dtp_From_dt.Text);
            Shared_Class.Tdt = Convert.ToDateTime(dtp_To_dt.Text);

            if (flag == 1)
            {
                Food_Shop_Billing_System.Reports.Reports_Form.frm_Customer_Monthly_Sales obj = new Food_Shop_Billing_System.Reports.Reports_Form.frm_Customer_Monthly_Sales();

                obj.Show();
                this.Hide();

            }
            else 
            {

                Food_Shop_Billing_System.Reports.Reports_Form.frm_Monthly_Payments obj = new Food_Shop_Billing_System.Reports.Reports_Form.frm_Monthly_Payments();

                obj.Show();
                this.Hide();
            }

        }

        private void frm_Pop_Up_Load(object sender, EventArgs e)
        {

            if (flag  == 1)
            {
                lbl_Header.Text = "";

                lbl_Header.Text = "MONTHLY PAYMENTS";
            }
            else
            {
                lbl_Header.Text = "";

                lbl_Header.Text = "CUSTOMER MONTHLY REPORT";
            }
        }
    }
}
