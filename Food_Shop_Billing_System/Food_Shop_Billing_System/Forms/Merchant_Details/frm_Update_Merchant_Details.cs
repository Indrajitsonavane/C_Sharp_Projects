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

namespace Food_Shop_Billing_System.Forms.Merchant_Details
{
    public partial class frm_Update_Merchant_Details : Form
    {
        public frm_Update_Merchant_Details()
        {
            InitializeComponent();
        }

        private void frm_Update_Merchant_Details_Load(object sender, EventArgs e)
        {
            tb_Marchant_ID.Focus();
        }

        void Clear_Controls()
        {
            tb_Marchant_ID.Clear();
            tb_Merchant_Name.Clear();
            tb_Owner_Mobile_No.Clear();
            tb_Bink_Details.Clear();
            tb_Merchant_Address.Clear();

           
        }
        private void tb_Marchant_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }

        private void tb_Shop_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Text(sender, e);
        }

        private void tb_Shop_Phone_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }

        private void tb_Owner_Mobile_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Shared_Class.Con_Open();

            SqlCommand cmd = new SqlCommand("Select * From Merchant_Details Where Merchant_id = '" + tb_Marchant_ID.Text + "' ", Shared_Class.Con);

            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Merchant_Name.Text = obj.GetString(obj.GetOrdinal("Merchant_Name"));
               tb_Owner_Mobile_No.Text = (obj["Mearchant_Mob_No"].ToString());
                tb_Bink_Details.Text = obj.GetString(obj.GetOrdinal("Bink_Details"));
                tb_Merchant_Address.Text = obj.GetString(obj.GetOrdinal("Mearchant_Address"));
            }
            else
            {
                MessageBox.Show("Invalide Id ");
            }

            Shared_Class.Con_Close();

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Marchant_ID.Text != "" && tb_Merchant_Name.Text  != ""  && tb_Owner_Mobile_No.Text != "" && tb_Bink_Details.Text != "" && tb_Merchant_Address.Text != "" )
            {
                Shared_Class.Con_Open();

                SqlCommand cmd = new SqlCommand("Update Merchant_Details set Merchant_Name = @mnm , Mearchant_Mob_No = @mno , Bink_Details = @bd , Mearchant_Address = @madd ", Shared_Class.Con);

                cmd.Parameters.Add("@mnm", SqlDbType.VarChar).Value =  tb_Merchant_Name.Text;
                cmd.Parameters.Add("@mno", SqlDbType.VarChar).Value =  tb_Owner_Mobile_No.Text;
                cmd.Parameters.Add("@bd", SqlDbType.VarChar).Value =   tb_Bink_Details.Text ;
                cmd.Parameters.Add("@madd", SqlDbType.VarChar).Value =  tb_Merchant_Address.Text;

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

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
