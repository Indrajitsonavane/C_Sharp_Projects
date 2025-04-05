using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Food_Shop_Billing_System.Forms.Category_Details
{
    public partial class frm_Add_Category_Details : Form
    {
        public frm_Add_Category_Details()
        {
            InitializeComponent();
        }

        private void frm_Add_Category_Details_Load(object sender, EventArgs e)
        {
            btn_Refresh.PerformClick();

            Shared_Class.Bind_ComboBox("Merchant_Name", cmb_Merchant_Name, "Select Merchant_Name From Merchant_Details ");
        }
        private void tb_Catagory_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }

        private void tb_Category_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Text(sender, e);
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        { 
            Shared_Class.Con_Open();

            if (tb_Catagory_ID.Text != "" && tb_Category_Name.Text != "")
            {

                SqlCommand Cmd = new SqlCommand("Insert Into Category_Details values (@cid , @cnm ,@mnm ,@Status ) ", Shared_Class.Con);

                Cmd.Parameters.Add("@cid", SqlDbType.Int).Value = tb_Catagory_ID.Text;
                Cmd.Parameters.Add("@cnm", SqlDbType.VarChar).Value = tb_Category_Name.Text;
                Cmd.Parameters.Add("@mnm", SqlDbType.VarChar).Value = cmb_Merchant_Name.Text;
                Cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = 1;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Category Details Saved Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btn_Refresh.PerformClick();

            }
            else
            {
                MessageBox.Show("Fill All The Filds", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            Shared_Class.Con_Close();
        }

       

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Category_Name.Clear();
            cmb_Merchant_Name.SelectedIndex = -1;
            tb_Catagory_ID.Text = Convert.ToString(Shared_Class.Auto_Incr("Category_Details", "Category_id", 1));
        }

      
    }
}
