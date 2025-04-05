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
    public partial class frm_Update_Category_Details : Form
    {
        public frm_Update_Category_Details()
        {
            InitializeComponent();
        }
        private void tb_Category_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Text(sender, e);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Shared_Class.Con_Open();

            SqlCommand cmd = new SqlCommand("Select * From Category_Details Where Category_id = '" + tb_Category_ID.Text + "' And Status = 0 ", Shared_Class.Con);

            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Category_Name.Text = obj.GetString(obj.GetOrdinal("Category_Name"));
            }
            else
            {
                MessageBox.Show("Invalide Category Id ");
            }

            Shared_Class.Con_Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Category_ID.Text != ""  && tb_Category_Name.Text != "")
            {
                Shared_Class.Con_Open();

                SqlCommand cmd = new SqlCommand("Update Category_Details set Category_Name = @Catnm", Shared_Class.Con);

                cmd.Parameters.Add("@Catnm", SqlDbType.VarChar).Value = tb_Category_Name.Text;
                cmd.Parameters.Add("@mnm", SqlDbType.VarChar).Value = tb_Merchant_Name.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Update Successfully " ,"Update" , MessageBoxButtons.OK , MessageBoxIcon.Information);


                Shared_Class.Con_Close();
            }
            else
            {
                MessageBox.Show("Fill All The Filds", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_Update_Category_Details_Load(object sender, EventArgs e)
        {
            tb_Category_ID.Focus();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Category_ID.Text = "";
            tb_Category_Name.Text = "";
        }

  
    }
}
