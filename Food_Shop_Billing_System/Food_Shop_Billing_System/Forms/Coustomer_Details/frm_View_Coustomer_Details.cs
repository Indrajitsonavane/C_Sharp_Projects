using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Shop_Billing_System.Forms.Coustomer_Details
{
    public partial class frm_View_Coustomer_Details : Form
    {
        public frm_View_Coustomer_Details()
        {
            InitializeComponent();
        }


        private void frm_View_Coustomer_Details_Load(object sender, EventArgs e)
        {
            this.dgv_Coustomer_View.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11);

            if (Shared_Class.User_Role == 3)
            {
                Shared_Class.Bind_Grid(dgv_Coustomer_View, "Select  Customer_Details.Coustomer_ID , Customer_Details.Date , Customer_Details.Coustomer_Name , Purchase_Details.Product_Name  ,Purchase_Details.Quentity  , Purchase_Details.Sales_Price , Customer_Details.Discount , Purchase_Details.Product_Total_Bill ,  Customer_Details.Final_Bill , Customer_Details.Entered_User  From Customer_Details Inner join Purchase_Details on Customer_Details.Coustomer_ID =  Purchase_Details.Coustomer_ID");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Coustomer_View, "Select Customer_Details.Coustomer_ID ,Customer_Details.Date , Customer_Details.Coustomer_Name , Purchase_Details.Product_Name  ,Purchase_Details.Quentity  , Purchase_Details.Sales_Price , Customer_Details.Discount , Purchase_Details.Product_Total_Bill ,  Customer_Details.Final_Bill  From Customer_Details Inner join Purchase_Details on Customer_Details.Coustomer_ID =  Purchase_Details.Coustomer_ID");
            } 
           
            Shared_Class.Bind_ComboBox("Coustomer_Name", cmb_Coustomer_Name, "Select Coustomer_Name From Customer_Details ");

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            dgv_Coustomer_View.DataSource = null;
        }

        private void cmb_Coustomer_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_Grid(dgv_Coustomer_View, "select * from Customer_Details where Coustomer_Name = '"+cmb_Coustomer_Name.Text+"'");

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Shared_Class.Bind_Grid(dgv_Coustomer_View, "Select Customer_Details.Coustomer_ID ,Customer_Details.Date , Customer_Details.Coustomer_Name , Purchase_Details.Product_Name  ,Purchase_Details.Quentity  , Purchase_Details.Sales_Price , Customer_Details.Discount , Purchase_Details.Product_Total_Bill ,  Customer_Details.Final_Bill  From Customer_Details Inner join Purchase_Details on Customer_Details.Coustomer_ID =  Purchase_Details.Coustomer_ID");
        }

        private void dgv_Coustomer_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Shared_Class.Index = Convert.ToInt32(dgv_Coustomer_View.CurrentRow.Cells[0].Value);

            Reports.Reports_Form.frm_Customer_Bill obj = new Reports.Reports_Form.frm_Customer_Bill();
            obj.Show();
        }

        private void dgv_Coustomer_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Shared_Class.Index = Convert.ToInt32(dgv_Coustomer_View.CurrentRow.Cells[0].Value);

            Reports.Reports_Form.frm_Customer_Bill obj = new Reports.Reports_Form.frm_Customer_Bill();
            obj.Show();
        }
    }
}
