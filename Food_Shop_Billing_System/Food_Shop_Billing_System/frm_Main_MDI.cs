using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Shop_Billing_System
{
    public partial class frm_Main_MDI : Form
    {
        public frm_Main_MDI()
        {
            InitializeComponent();
        }

        private void frm_Main_MDI_Load(object sender, EventArgs e)
        {
            ts_User.Text = "User = " + Shared_Class.Username;

            if (Shared_Class.User_Role == 2)
            {
                mnu_User.Visible = false;
                mnu_Staff.Visible = false;
                mnu_Shop.Visible = false;
                mnu_Mearchant.Visible = false;
                mnu_Expence.Visible = false;
                mnu_Category.Visible = false;
                mnu_Payment.Visible = false;



            }
            else if (Shared_Class.User_Role == 3)
            {
                mnu_Shop.Visible = false;
            }

  

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_Container.Controls.Clear();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Coustomer_Details.frm_Add_Coustomer_Details obj = new Forms.Coustomer_Details.frm_Add_Coustomer_Details() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void viewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Coustomer_Details.frm_View_Coustomer_Details obj = new Forms.Coustomer_Details.frm_View_Coustomer_Details() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Product_Details.frm_Add_Product_Details obj = new Forms.Product_Details.frm_Add_Product_Details() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void updateProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Product_Details.frm_Update_Product_Details obj = new Forms.Product_Details.frm_Update_Product_Details() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void viewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Product_Details.frm_View_Product_Details obj = new Forms.Product_Details.frm_View_Product_Details() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Product_Details.frm_Delete_Product obj = new Forms.Product_Details.frm_Delete_Product() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void addCetegoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Category_Details.frm_Add_Category_Details obj = new Forms.Category_Details.frm_Add_Category_Details() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void updateCetegoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Category_Details.frm_Update_Category_Details obj = new Forms.Category_Details.frm_Update_Category_Details() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void viewCAtegoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Category_Details.frm_View_Category_Details obj = new Forms.Category_Details.frm_View_Category_Details() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void deleteCetegoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Category_Details.frm_Delete_Category obj = new Forms.Category_Details.frm_Delete_Category() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Stock_Details.frm_Add_Recived_Order obj = new Forms.Stock_Details.frm_Add_Recived_Order() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void viewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Stock_Details.frm_View_Recived_Order_Details obj = new Forms.Stock_Details.frm_View_Recived_Order_Details() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void addMearchamtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Merchant_Details.frm_Add_Merchant_Details obj = new Forms.Merchant_Details.frm_Add_Merchant_Details() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void updateMearchantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Merchant_Details.frm_Update_Merchant_Details obj = new Forms.Merchant_Details.frm_Update_Merchant_Details() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void viewMearchantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Merchant_Details.frm_View_Merchant_Details obj = new Forms.Merchant_Details.frm_View_Merchant_Details() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Staff_Details.frm_Staff_Master obj = new Forms.Staff_Details.frm_Staff_Master() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void ViewStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Forms.Staff_Details.frm_View_Staff_Details obj = new Forms.Staff_Details.frm_View_Staff_Details() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void addExpenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Expence_Details.frm_Add_Expance_Details obj = new Forms.Expence_Details.frm_Add_Expance_Details() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void viewExpenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Expence_Details.frm_View_Expance_Details obj = new Forms.Expence_Details.frm_View_Expance_Details() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.User_Details.frm_User_Master obj = new Forms.User_Details.frm_User_Master() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.User_Details.frm_View_User_Details obj = new Forms.User_Details.frm_View_User_Details() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void addShopToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Forms.Shop_Details.frm_Shop_Master obj = new Forms.Shop_Details.frm_Shop_Master() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void viewShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Shop_Details.frm_View_Shop_Details obj = new Forms.Shop_Details.frm_View_Shop_Details() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void addPymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Payment_Details.frm_Payment_Details obj = new Forms.Payment_Details.frm_Payment_Details() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void viewPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Payment_Details.frm_View_Payment_Details obj = new Forms.Payment_Details.frm_View_Payment_Details() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        private void reportMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Report_FRM.frm_Reports_Menu obj = new Forms.Report_FRM.frm_Reports_Menu() { TopLevel = false, TopMost = true };

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(obj);
            obj.Show();

        }

     
    }


    
}
