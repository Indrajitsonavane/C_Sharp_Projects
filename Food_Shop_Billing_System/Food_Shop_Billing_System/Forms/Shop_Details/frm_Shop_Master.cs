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

namespace Food_Shop_Billing_System.Forms.Shop_Details
{
    public partial class frm_Shop_Master : Form
    {
        public frm_Shop_Master()
        {
            InitializeComponent();
        }
        private void frm_Shop_Master_Load(object sender, EventArgs e)
        {
            tb_Shop_ID.Text = Convert.ToString(Shared_Class.Auto_Incr("Shop_Details", "Shop_ID", 1));

            Shared_Class.Bind_ComboBox("Shop_Name", cmb_Shop_Name, "Select Shop_Name From Shop_Details");

            
        }
        private void tb_Shop_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }

        private void tb_Shop_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Text(sender, e);
        }

        private void tb_Owner_Name_KeyPress(object sender, KeyPressEventArgs e)
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
        void clear_Controls()
        {
            tb_Shop_ID.Clear();
            tb_Shop_Name.Clear();
            tb_Owner_Name.Clear();
            tb_Owner_Mobile_No.Clear();
            tb_Bink_Details.Clear();
            tb_Shop_Address.Clear();
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clear_Controls();
        }


        private void tb_U_Shop_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Text(sender, e);
        }

        private void tb_U_Owner_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Text(sender, e);
        }

        private void tb_U_Shop_Phone_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }

        private void tb_U_Owner_Mobile_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }
 

        private void btn_Update_Click(object sender, EventArgs e)
        {

            if (cmb_Shop_Name.Text != "" && tb_U_Owner_Name.Text != "" && tb_U_Owner_Mobile_No.Text != "" && tb_U_Bink_Details.Text != "" && tb_U_Shop_Address.Text != "")
            {
                Shared_Class.Con_Open();

                SqlCommand cmd = new SqlCommand("Update Shop_Details set Shop_Name = @snm , Owner_Name = @onm , Shop_Phone_Name = @spno , Owner_Mobile_No = @omno , Bink_Details = @bdet , Shop_Address = @sadd ", Shared_Class.Con);

                cmd.Parameters.Add("@snm", SqlDbType.VarChar).Value = cmb_Shop_Name.Text ;
                cmd.Parameters.Add("@onm", SqlDbType.VarChar).Value = tb_U_Owner_Name.Text;
                cmd.Parameters.Add("@spno", SqlDbType.VarChar).Value = tb_U_Shop_Phone_No.Text;
                cmd.Parameters.Add("@omno", SqlDbType.VarChar).Value = tb_U_Owner_Mobile_No.Text;
                cmd.Parameters.Add("@bdet", SqlDbType.VarChar).Value = tb_U_Bink_Details.Text;
                cmd.Parameters.Add("@sadd", SqlDbType.VarChar).Value = tb_U_Shop_Address.Text;
             

                cmd.ExecuteNonQuery();

                MessageBox.Show("Update Successfully ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Shared_Class.Con_Close();
            }
            else
            {
                MessageBox.Show("Fill All The Filds", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        private void Lode_Details()
        {
            Shared_Class.Con_Open();

            SqlCommand cmd = new SqlCommand("Select * From Shop_Details ", Shared_Class.Con);

            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_U_Owner_Name.Text = obj.GetString(obj.GetOrdinal("Owner_Name"));
                tb_U_Shop_Phone_No.Text = (obj["Shop_Phone_Name"].ToString());
                tb_U_Owner_Mobile_No.Text = (obj["Owner_Mobile_No"].ToString());
                tb_U_Bink_Details.Text = obj.GetString(obj.GetOrdinal("Bink_Details"));
                tb_U_Shop_Address.Text = obj.GetString(obj.GetOrdinal("Shop_Address"));
            }
            else
            {
                MessageBox.Show("Invalide Id ");
            }

            Shared_Class.Con_Close();

        }

        private void cmb_Shop_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lode_Details();
        }

 

        private void cmb_Shop_Name_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Lode_Details();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            Shared_Class.Con_Open();

            if (tb_Shop_ID.Text != "" && tb_Shop_Name.Text != "" && tb_Owner_Name.Text != "" && tb_Owner_Mobile_No.Text != "" && tb_Bink_Details.Text != "" && tb_Shop_Address.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Insert Into Shop_Details values (@sid ,@snm ,@on ,@spno, @omno ,@bd , @sadd) ", Shared_Class.Con);

                Cmd.Parameters.Add("@sid", SqlDbType.Int).Value = tb_Shop_ID.Text;
                Cmd.Parameters.Add("@snm", SqlDbType.VarChar).Value = tb_Shop_Name.Text;
                Cmd.Parameters.Add("@on", SqlDbType.VarChar).Value = tb_Owner_Name.Text;
                Cmd.Parameters.Add("@spno", SqlDbType.Decimal).Value = tb_Shop_Phone_No.Text;
                Cmd.Parameters.Add("@omno", SqlDbType.Decimal).Value = tb_Owner_Mobile_No.Text;
                Cmd.Parameters.Add("@bd", SqlDbType.NVarChar).Value = tb_Bink_Details.Text;
                Cmd.Parameters.Add("@sadd", SqlDbType.NVarChar).Value = tb_Shop_Address.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Shop Details Saved Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Refresh.PerformClick();

            }
            else
            {
                MessageBox.Show("Fill All The Filds", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            Shared_Class.Con_Close();
        }

        private void btn_Refresh_Click_1(object sender, EventArgs e)
        {
            tb_Shop_Name.Text = "";
            tb_Owner_Name.Text = "";
            tb_Shop_Phone_No.Text = "";
            tb_Shop_Address.Text = "";
            tb_Owner_Mobile_No.Text = "";
            tb_Bink_Details.Text = "";
            tb_Shop_Address.Text = "";
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {

        }
    }
}
