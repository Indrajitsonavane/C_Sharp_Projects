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



namespace Food_Shop_Billing_System.Forms.Staff_Details
{
    public partial class frm_Staff_Master : Form
    {
        public frm_Staff_Master()
        {
            InitializeComponent();
        }

        void Clear_Controls()
        {
            tb_Staff_ID.Clear();
            tb_Staff_Name.Clear();
            cmb_Staff_Role.Items.Clear();
            tb_Mobile_No.Clear();
            tb_alt_Mobile_No.Clear();
            tb_Adhar_Card_No.Clear();
            tb_current_Address.Clear();
            tb_Note.Clear();

            tb_Staff_ID.Text = Convert.ToString(Shared_Class.Auto_Incr("Staff_Details", "Staff_ID", 1));

        }
        private void frm_Staff_Master_Load(object sender, EventArgs e)
        {
            tb_Staff_ID.Text = Convert.ToString(Shared_Class.Auto_Incr("Staff_Details", "Staff_ID", 1));
        }

        private void tb_Staff_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }

        private void tb_Staff_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Text(sender, e);
        }

        private void tb_Mobile_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }

        private void tb_alt_Mobile_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }

        private void tb_Adhar_Card_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            Shared_Class.Con_Open();

            if (tb_Staff_ID.Text != "" && cmb_Staff_Role.Text != "" && tb_Staff_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Adhar_Card_No.Text != "" && tb_current_Address.Text != "" && tb_current_Address.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Insert Into Staff_Details values (@sid ,@srole ,@snm ,@mno, @amno ,@jd ,@adno ,@cadd ,@not , @Stus ,@User) ", Shared_Class.Con);

                Cmd.Parameters.Add("@sid", SqlDbType.Int).Value = tb_Staff_ID.Text;
                Cmd.Parameters.Add("@srole", SqlDbType.VarChar).Value = cmb_Staff_Role.Text;
                Cmd.Parameters.Add("@snm", SqlDbType.VarChar).Value = tb_Staff_Name.Text;
                Cmd.Parameters.Add("@mno", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("@amno", SqlDbType.Decimal).Value = tb_alt_Mobile_No.Text;
                Cmd.Parameters.Add("@jd", SqlDbType.Date).Value = dtp_Joning_Dtate.Value.Date;
                Cmd.Parameters.Add("@adno", SqlDbType.Decimal).Value = tb_Adhar_Card_No.Text;
                Cmd.Parameters.Add("@cadd", SqlDbType.NVarChar).Value = tb_current_Address.Text;
                Cmd.Parameters.Add("@not", SqlDbType.NVarChar).Value = tb_Note.Text;
                Cmd.Parameters.Add("@Stus", SqlDbType.Bit).Value = 1;
                Cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = Shared_Class.Username;

                Cmd.ExecuteNonQuery();

                Clear_Controls();

                MessageBox.Show(" Staff Details Saved Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Fill All The Filds", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            Shared_Class.Con_Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            Shared_Class.Con_Open();

            SqlCommand cmd = new SqlCommand("Select * From Staff_Details Where Staff_ID = '" + tb_U_Staff_Id.Text + "' ", Shared_Class.Con);

            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                cmb_U_Staff_Role.Text = obj.GetString(obj.GetOrdinal("Staff_Role")); 
                cmb_U_Staff_Role.Items.Add("Admin");
                tb_U_Staff_Name.Text = obj.GetString(obj.GetOrdinal("Staff_Name"));
               tb_U_Mob_No.Text = (obj["Mobile_No"].ToString());
                tb_U_Alt_Mob_No.Text = (obj["Alt_Mobile_No"].ToString());
                dtp_U_Joinining_Date.Text = (obj["Joining_Date"].ToString());  
               tb_U_Adhar_Card_No.Text = (obj["Adhar_card_No"].ToString());  
                tb_U_Current_Address.Text = obj.GetString(obj.GetOrdinal("Current_Address"));
                tb_U_Note.Text = obj.GetString(obj.GetOrdinal("Note"));
            }
            else
            {
                MessageBox.Show("Invalide Id ");
            }

            Shared_Class.Con_Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (tb_U_Staff_Name.Text != "" && tb_U_Mob_No.Text != "" && tb_U_Alt_Mob_No.Text != "" && tb_U_Adhar_Card_No.Text != "" && tb_U_Current_Address.Text != "" )
            {
                Shared_Class.Con_Open();

                SqlCommand cmd = new SqlCommand("Update Staff_Details set Staff_Role = @srol, Staff_Name = @snm , Mobile_No = @mno , Alt_Mobile_No = @amno , Joining_Date = @jd , Adhar_card_No = @acno , Current_Address = @cadd , Note = @not ", Shared_Class.Con);

                cmd.Parameters.Add("@srol", SqlDbType.VarChar).Value = cmb_U_Staff_Role.Text;
                cmd.Parameters.Add("@snm", SqlDbType.VarChar).Value = tb_U_Staff_Name.Text;
                cmd.Parameters.Add("@mno", SqlDbType.VarChar).Value = tb_U_Mob_No.Text;
                cmd.Parameters.Add("@amno", SqlDbType.VarChar).Value = tb_U_Alt_Mob_No.Text;
                cmd.Parameters.Add("@jd", SqlDbType.VarChar).Value =dtp_U_Joinining_Date.Text;
                cmd.Parameters.Add("@acno", SqlDbType.VarChar).Value = tb_U_Adhar_Card_No.Text;
                cmd.Parameters.Add("@cadd", SqlDbType.VarChar).Value = tb_U_Current_Address.Text;
                cmd.Parameters.Add("@not", SqlDbType.VarChar).Value = tb_U_Note.Text;
                

                cmd.ExecuteNonQuery();

                MessageBox.Show("Update Successfully ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Shared_Class.Con_Close();
            }
            else
            {
                MessageBox.Show("Fill All The Filds", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_U_Search_Click(object sender, EventArgs e)
        {
            Shared_Class.Con_Open();

            SqlCommand cmd = new SqlCommand("Select * From Staff_Details Where Staff_ID = '" + tb_D_Staff_id.Text + "' ", Shared_Class.Con);

            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_D_Staff_Role.Text = obj.GetString(obj.GetOrdinal("Staff_Role"));
                tb_D_Staff_Name.Text = obj.GetString(obj.GetOrdinal("Staff_Name"));

            }
            else
            {
                MessageBox.Show("Invalide Id ");
            }

            Shared_Class.Con_Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (tb_D_Staff_id.Text != "" && tb_D_Staff_Name.Text != "" && tb_D_Staff_Role.Text != "")
            {
                Shared_Class.Con_Open();

                SqlCommand cmd = new SqlCommand("Update Staff_Details set Status = '0' where Staff_ID = '"+tb_D_Staff_id.Text+"' ", Shared_Class.Con);

                cmd.ExecuteScalar();

                MessageBox.Show("Delete Successfully ", "Detete", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Shared_Class.Con_Close();
            }
            else
            {
                MessageBox.Show("Fill All The Filds", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_D_Refresh_Click(object sender, EventArgs e)
        {
            tb_D_Staff_id.Text = "";
            tb_D_Staff_Name.Text = "";
            tb_D_Staff_Role.Text = "";
        }

    }
}
