using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Shop_Billing_System.Forms.Category_Details
{
    public partial class frm_View_Category_Details : Form
    {
        public frm_View_Category_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Category_Details_Load(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("Merchant_Name", cmb_Merchant_Name, "Select Merchant_Name From Merchant_Details ");

            this.dgv_Category_View.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11);

            if (Shared_Class.User_Role == 1)
            {
                Shared_Class.Bind_Grid(dgv_Category_View, "Select Category_id, Category_Name  , Merchant_Name From  Category_Details Where Status = 1 ");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Category_View, "Select Category_id, Category_Name  , Merchant_Name From  Category_Details Where Status = 1  ");
            }
           
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dgv_Category_View.DataSource = null;
            Shared_Class.Bind_Grid(dgv_Category_View, "Select Category_id, Category_Name , Merchant_Name From  Category_Details Where Status = 1 ");
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            dgv_Category_View.DataSource = null;
            cmb_Merchant_Name.SelectedIndex = -1;
        }

        private void cmb_Merchant_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_Grid(dgv_Category_View, "Select Category_id, Category_Name  From  Category_Details Where Merchant_Name = '" + cmb_Merchant_Name.Text + "' ");
        }
    }
}
