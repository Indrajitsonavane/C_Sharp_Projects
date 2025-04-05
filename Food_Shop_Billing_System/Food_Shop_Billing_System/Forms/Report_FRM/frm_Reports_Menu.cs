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
    public partial class frm_Reports_Menu : Form
    {
        public frm_Reports_Menu()
        {
            InitializeComponent();
        }

        private void pb_Customer_Monthly_Sales_Click(object sender, EventArgs e)
        {
            Food_Shop_Billing_System.Forms.Report_FRM.frm_Pop_Up obj = new Food_Shop_Billing_System.Forms.Report_FRM.frm_Pop_Up(1);
            
            obj.Show();
            this.Hide();
        }

        private void pb_Expence_Reports_Click(object sender, EventArgs e)
        {
            Food_Shop_Billing_System.Reports.Reports_Form.frm_Expence_List obj = new Food_Shop_Billing_System.Reports.Reports_Form.frm_Expence_List();

            obj.Show();
            this.Hide();
        }

        private void pb_Monthly_Payment_Reports_Click(object sender, EventArgs e)
        {
            Food_Shop_Billing_System.Forms.Report_FRM.frm_Pop_Up obj = new Food_Shop_Billing_System.Forms.Report_FRM.frm_Pop_Up(0);

            obj.Show();
            this.Hide();

        }

        private void pb_payent_Report_Click(object sender, EventArgs e)
        {
            Food_Shop_Billing_System.Reports.Reports_Form.frm_Payments_List obj = new Food_Shop_Billing_System.Reports.Reports_Form.frm_Payments_List();

            obj.Show();
            this.Hide();

        }

        private void pb_Product_list_Click(object sender, EventArgs e)
        {

            Food_Shop_Billing_System.Reports.Reports_Form.frm_Product_List obj = new Food_Shop_Billing_System.Reports.Reports_Form.frm_Product_List();

            obj.Show();
            this.Hide();
        }

    }
}
