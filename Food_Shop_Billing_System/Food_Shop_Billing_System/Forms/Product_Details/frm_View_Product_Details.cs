using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Shop_Billing_System.Forms.Product_Details
{
    public partial class frm_View_Product_Details : Form
    {
        public frm_View_Product_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Product_Details_Load(object sender, EventArgs e)
        {
            this.dgv_Product_View.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11);

            Shared_Class.Bind_ComboBox("Category_Name", cmb_Category_Name, "Select Category_Name From Category_Details");

            Shared_Class.Bind_ComboBox("Merchant_Name", cmb_Merchant_Name, "Select Merchant_Name From Merchant_Details");
            
            if (Shared_Class.User_Role == 3)
            {
                Shared_Class.Bind_Grid(dgv_Product_View, " Select  Product_Name ,Category , Purchase_Prise , Sales_Price , Current_Stock , Merchant_Name  From  Product_Details where status = 1");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Product_View, " Select  Product_Name ,Category , Purchase_Prise , Sales_Price , Current_Stock , Merchant_Name , Entered_User  From  Product_Details where status = 1");
            }

           
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            if (Shared_Class.User_Role == 3)
            {
                Shared_Class.Bind_Grid(dgv_Product_View, " Select  Product_Name ,Category , Purchase_Prise , Sales_Price , Current_Stock , Merchant_Name From  Product_Details where status = 1");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Product_View, " Select  Product_Name ,Category , Purchase_Prise , Sales_Price , Current_Stock , Merchant_Name , Entered_User  From  Product_Details where status = 1");
            }

            cmb_Category_Name.SelectedIndex = -1;
            cmb_Merchant_Name.SelectedIndex = -1;
        }

        private void cmb_Category_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_Grid(dgv_Product_View, " Select  Product_Name ,Category , Purchase_Prise , Sales_Price , Merchant_Name  From  Product_Details where  Category = '" + cmb_Category_Name.Text + "'");
        }

        private void cmb_Merchant_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_Grid(dgv_Product_View, " Select  Product_Name ,  Merchant_Name  From  Product_Details where  Merchant_Name = '" + cmb_Merchant_Name.Text + "'");
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            dgv_Product_View.DataSource = null;
            cmb_Category_Name.SelectedIndex = -1;
            cmb_Merchant_Name.SelectedIndex = -1;
        }
    }
}
