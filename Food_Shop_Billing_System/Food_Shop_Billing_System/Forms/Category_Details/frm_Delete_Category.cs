using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Shop_Billing_System.Forms.Category_Details
{
    public partial class frm_Delete_Category : Form
    {
        public frm_Delete_Category()
        {
            InitializeComponent();
        }

        private void frm_Delete_Category_Load(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("Category", cmb_Category_Name, "Select Category From Product_Details  ");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            if (cmb_Category_Name.Text != "" )
            {
                Shared_Class.Con_Open();

                SqlCommand cmd = new SqlCommand("Update Category_Details set Status = '0' where Category_Name = '" + cmb_Category_Name.Text + "' ", Shared_Class.Con);

                cmd.ExecuteScalar();

                MessageBox.Show("Delete Successfully ", "Detete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmb_Category_Name.Items.Clear();

                Shared_Class.Con_Close();
            }
            else
            {
                MessageBox.Show("Fill All The Filds", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_Category_Name.Items.Clear();
        }
    }
}
