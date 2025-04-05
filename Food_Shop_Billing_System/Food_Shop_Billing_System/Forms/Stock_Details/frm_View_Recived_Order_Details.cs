using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Shop_Billing_System.Forms.Stock_Details
{
    public partial class frm_View_Recived_Order_Details : Form
    {
        public frm_View_Recived_Order_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Recived_Order_Details_Load(object sender, EventArgs e)
        {
            this.dgv_Stock_View.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11);

            Shared_Class.Bind_ComboBox("Product_Name", cmb_Product_Name, "Select Product_Name From Product_Details where Status = 1 ");

            Shared_Class.Bind_ComboBox("Category_Name", cmb_category, "Select Category_Name From Category_Details ");

            if (Shared_Class.User_Role == 3 )
            {
                Shared_Class.Bind_Grid(dgv_Stock_View, "select  od.Date , od.Order_ID , rd.Merchant_Name , rd.Caregory_Details, rd.Product_Name , rd.Quantity , rd.Purchase_Price ,rd.Sales_Price , od.Product_Total_Bill  from Order_Details As od Inner join Recived_Order_Details As rd on od.Order_ID = rd.Order_ID");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Stock_View, "select  od.Date , od.Order_ID , rd.Merchant_Name , rd.Caregory_Details, rd.Product_Name , rd.Quantity , rd.Purchase_Price ,rd.Sales_Price , od.Product_Total_Bill , od.Entered_User  from Order_Details As od Inner join Recived_Order_Details As rd on od.Order_ID = rd.Order_ID");
            }

        }

        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_Grid(dgv_Stock_View, "Select  Product_Name ,Category , Purchase_Prise , Sales_Price , Merchant_Name From  Product_Details where Product_Name = '" + cmb_Product_Name.Text+"'");
        }

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_Grid(dgv_Stock_View, "Select  Product_Name ,Category , Purchase_Prise , Sales_Price , Merchant_Name From  Product_Details where Category = '" + cmb_category.Text + "'");

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            dgv_Stock_View.DataSource = null;
            cmb_category.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dgv_Stock_View.DataSource = null;
            cmb_category.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;

            Shared_Class.Bind_Grid(dgv_Stock_View, "select  od.Date , od.Order_ID , rd.Merchant_Name , rd.Caregory_Details, rd.Product_Name , rd.Quantity , rd.Purchase_Price ,rd.Sales_Price , od.Product_Total_Bill  from Order_Details As od Inner join Recived_Order_Details As rd on od.Order_ID = rd.Order_ID");
        }

      
    }
}
