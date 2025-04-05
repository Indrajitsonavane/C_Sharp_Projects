using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Shop_Billing_System.Forms.Staff_Details
{
    public partial class frm_View_Staff_Details : Form
    {
        public frm_View_Staff_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Staff_Details_Load(object sender, EventArgs e)
        {
            this.dgv_Staff_View.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11);

            if (Shared_Class.User_Role == 3)
            {
                Shared_Class.Bind_Grid(dgv_Staff_View, "Select  Staff_ID, Staff_Name , Mobile_No , Alt_Mobile_No , Joining_Date , Adhar_card_No , Current_Address , Note From  Staff_Details where Status = '1' ");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Staff_View, "Select  Staff_ID, Staff_Name , Mobile_No , Alt_Mobile_No , Joining_Date , Adhar_card_No , Current_Address , Note , Enterd_User From   Staff_Details where Status = '1' ");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            dgv_Staff_View.DataSource = null;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            if (Shared_Class.User_Role == 3)
            {
                Shared_Class.Bind_Grid(dgv_Staff_View, "Select  Staff_ID, Staff_Name , Mobile_No , Alt_Mobile_No , Joining_Date , Adhar_card_No , Current_Address , Note From  Staff_Details where Status = '1' ");
            }
            else
            {
                Shared_Class.Bind_Grid(dgv_Staff_View, "Select  Staff_ID, Staff_Name , Mobile_No , Alt_Mobile_No , Joining_Date , Adhar_card_No , Current_Address , Note , Enterd_User From   Staff_Details where Status = '1' ");
            }
        }
    }
}
