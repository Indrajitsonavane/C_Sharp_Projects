using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Shop_Billing_System.Forms.Merchant_Details
{
    public partial class frm_View_Merchant_Details : Form
    {
        public frm_View_Merchant_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Merchant_Details_Load(object sender, EventArgs e)
        {
            this.dgv_Merchant_View.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11);

            if (Shared_Class.User_Role == 3)
            {
                Shared_Class.Bind_Grid(dgv_Merchant_View, "Select Merchant_id , Merchant_Name ,  Mearchant_Mob_No , Bink_Details , Bink_Details , Remening_Amount , Merchant_Date  From   Merchant_Details");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Merchant_View, "Select Merchant_id , Merchant_Name ,  Mearchant_Mob_No , Bink_Details , Bink_Details , Remening_Amount , Merchant_Date , Entered_User  From   Merchant_Details");
            }

            

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dgv_Merchant_View.Rows.Clear();

            Shared_Class.Bind_Grid(dgv_Merchant_View, "Select * From  Merchant_Details");
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            dgv_Merchant_View.DataSource = null;
        }
    }
}
