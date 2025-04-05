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

namespace Food_Shop_Billing_System.Forms.Product_Details
{
    public partial class frm_Delete_Product : Form
    {
        public frm_Delete_Product()
        {
            InitializeComponent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (cmb_Category_Name.Text != ""  && cmb_Product_Name.Text != "")
            {
                Shared_Class.Con_Open();

                SqlCommand cmd = new SqlCommand("Update Product_Details set Status = '0' where Product_Name = '" + cmb_Product_Name.Text + "' ", Shared_Class.Con);

                cmd.ExecuteScalar();

                MessageBox.Show("Delete Successfully ", "Detete", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Shared_Class.Con_Close();
            }
            else
            {
                MessageBox.Show("Fill All The Filds", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_Product_Name.SelectedIndex = -1;
            cmb_Category_Name.SelectedIndex = -1;
        }

        private void frm_Delete_Product_Load(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("Category", cmb_Category_Name, "Select Category From Product_Details  ");
        }

        private void cmb_Category_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("Product_Name", cmb_Product_Name, "Select Product_Name From Product_Details Where Category = '" + cmb_Category_Name.Text + "' ");
        }

       
    }
}
