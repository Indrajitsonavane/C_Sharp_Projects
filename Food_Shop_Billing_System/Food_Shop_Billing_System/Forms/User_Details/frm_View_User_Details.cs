using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Shop_Billing_System.Forms.User_Details
{
    public partial class frm_View_User_Details : Form
    {
        public frm_View_User_Details()
        {
            InitializeComponent();
        }

        private void frm_View_User_Details_Load(object sender, EventArgs e)
        {
            this.dgv_User_View.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11);

            cmb_User_Role.Focus();

            if (Shared_Class.User_Role == 3)
            {
                cmb_User_Role.Items.RemoveAt(0);
            }
          
        }

        private void cmb_User_Role_SelectedIndexChanged(object sender, EventArgs e)
        {

            Shared_Class.Bind_Grid(dgv_User_View, "Select User_Id, User_Name ,User_Role  From Login where User_Role =  '" + cmb_User_Role.Text + "'");

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            dgv_User_View.DataSource = null;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Shared_Class.Bind_Grid(dgv_User_View, "Select User_Id, User_Name ,User_Role  From Login where User_Role =  '" + cmb_User_Role.Text + "'");
        }
    }
}
