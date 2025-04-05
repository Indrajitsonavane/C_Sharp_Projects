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
    public partial class frm_Update_Product_Details : Form
    {
        public frm_Update_Product_Details()
        {
            InitializeComponent();
        }

        private void tb_Product_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }

        private void tb_Product_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Text(sender, e);
        }

        private void tb_Seals_Prise_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }

        private void tb_Parchase_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }

        void Clear_Controls()
        {
            tb_Product_ID.Clear();
            tb_Product_Name.Clear();
            tb_Category.Clear();
            tb_Product_Name.Clear();
            tb_Merchant_Name.Clear();
            tb_Seals_Prise.Clear();
            tb_Parchase_Price.Clear();
            tb_Note.Clear();
        }


        private void btn_Search_Click(object sender, EventArgs e)
        {
            Shared_Class.Con_Open();

            SqlCommand cmd = new SqlCommand("Select * From Product_Details Where Product_Id = '" + tb_Product_ID.Text + "' ", Shared_Class.Con);

            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Category.Text = obj.GetString(obj.GetOrdinal("Category"));
                tb_Product_Name.Text = obj.GetString(obj.GetOrdinal("Product_Name"));
                tb_Parchase_Price.Text = (obj["Purchase_Prise"].ToString());
                tb_Seals_Prise.Text= (obj["Sales_Price"].ToString());
                tb_Merchant_Name.Text = obj.GetString(obj.GetOrdinal("Merchant_Name"));
                tb_Note.Text = obj.GetString(obj.GetOrdinal("Note"));

            }
            else
            {
                MessageBox.Show("Invalide Id ");
            }

            Shared_Class.Con_Close();


        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tb_Product_Name.Text != "" && tb_Category.Text != ""  && tb_Parchase_Price.Text != "" && tb_Seals_Prise.Text != "" && tb_Merchant_Name.Text != ""  )
            {
                Shared_Class.Con_Open();

                SqlCommand cmd = new SqlCommand("Update Product_Details set Product_Name = @pnm , Purchase_Prise = @pp , Sales_Price = @sp , Note = @not  ", Shared_Class.Con);

                
                cmd.Parameters.Add("@pnm", SqlDbType.VarChar).Value = tb_Product_Name.Text;
                cmd.Parameters.Add("@pp", SqlDbType.VarChar).Value = tb_Parchase_Price.Text;
                cmd.Parameters.Add("@sp", SqlDbType.VarChar).Value = tb_Seals_Prise.Text;
                cmd.Parameters.Add("@not", SqlDbType.VarChar).Value = tb_Note.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Update Successfully ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Shared_Class.Con_Close();
            }
            else
            {
                MessageBox.Show("Fill All The Filds", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear_Controls();
        }

        private void frm_Update_Product_Details_Load(object sender, EventArgs e)
        {
            tb_Product_ID.Focus();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
