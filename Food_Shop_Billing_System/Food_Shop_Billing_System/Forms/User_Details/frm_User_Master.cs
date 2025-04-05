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

namespace Food_Shop_Billing_System.Forms.User_Details
{
    public partial class frm_User_Master : Form
    {
        public frm_User_Master()
        {
            InitializeComponent();
        }
        int cnt = 0; 
        private void frm_User_Master_Load(object sender, EventArgs e)
        {
            cnt = Shared_Class.Auto_Incr("Login", "User_Id", 1) ;
        }

        private void tb_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Text(sender, e);
        }


        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Shared_Class.Con_Open();

            if (tb_Username.Text != "" && tb_Password.Text != "" && cmb_User_Role.Text != "")

            {
                SqlCommand Cmd = new SqlCommand("Insert Into Login values (@uid ,@Unm , @urol, @pass, @Stus ) ", Shared_Class.Con);

               Cmd.Parameters.Add("@uid", SqlDbType.Int).Value = cnt ;
               Cmd.Parameters.Add("@unm", SqlDbType.VarChar).Value = tb_Username.Text ;
               Cmd.Parameters.Add("@urol", SqlDbType.VarChar).Value = cmb_User_Role.Text;
               Cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = tb_Password.Text ;
               Cmd.Parameters.Add("@Stus", SqlDbType.Bit).Value = 1;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Login Details Saved Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmb_User_Role.SelectedIndex = -1;
                tb_Username.Text = "";
                tb_Password.Text = "";
                


            }
            else
            {
                MessageBox.Show("Fill All The Filds", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            Shared_Class.Con_Close();


        }
  

        private void btn_U_Update_Click(object sender, EventArgs e)
        {

            if ( tb_U_Password.Text != "")
            {
                Shared_Class.Con_Open();

                SqlCommand cmd = new SqlCommand("Update Login set Password = '"+ tb_U_Password.Text + "' Where user_Role = '" + cmb_U_User_Role.Text + "' And User_Name = '" + cmb_U_User_Name.Text +"' ", Shared_Class.Con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Update Successfully ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmb_U_User_Role.SelectedIndex = -1;
                cmb_U_User_Name.SelectedIndex = -1;
                tb_U_Password.Text = "";


                Shared_Class.Con_Close();
            }
            else
            {
                MessageBox.Show("Fill All The Filds", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmb_U_User_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("User_Name", cmb_U_User_Name, "Select User_Name from Login where User_Role = '" + cmb_U_User_Role.Text + "'");
        }

        private void btn_D_Delete_Click(object sender, EventArgs e)
        {

            if (cmb_D_User_Name.Text != "" && cmb_D_User_Role.Text != "")
            {
                Shared_Class.Con_Open();

                SqlCommand cmd = new SqlCommand("Update Login set Status = '0' where User_Name = '" + cmb_D_User_Name.Text + "' ", Shared_Class.Con);

                cmd.ExecuteScalar();

                MessageBox.Show("Delete Successfully ", "Detete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmb_D_User_Name.SelectedIndex = - 1;
                cmb_D_User_Role.SelectedIndex = -1;
                

                Shared_Class.Con_Close();
            }
            else
            {
                MessageBox.Show("Fill All The Filds", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Are You Sure ", cmb_D_User_Name.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmb_D_User_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("Product_Name", cmb_D_User_Name, "Select User_Name From Login where User_Role = '" + cmb_D_User_Role.Text + "' and status = '1'");
        }

    
    }
}

