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

namespace Food_Shop_Billing_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void cmb_User_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
           Shared_Class.Bind_ComboBox("User_Name", cmb_User_Name, "Select User_Name from Login where User_Role = '" + cmb_User_Role.Text + "'");

        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {

            Shared_Class.Con_Open();

            SqlCommand Cmd = new SqlCommand("Select Count(*) from Login where User_Role = '" + cmb_User_Role.Text + "' And User_Name ='" + cmb_User_Name.Text + "' And Password = '" + tb_Password.Text + "'", Shared_Class.Con);

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("WELCOME ", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (cmb_User_Role.SelectedIndex == 0)
                {
                    Shared_Class.User_Role = 1;
                }
                else if (cmb_User_Role.SelectedIndex == 1)
                {
                    Shared_Class.User_Role = 2;
                }
                else if (cmb_User_Role.SelectedIndex == 2)
                {
                    Shared_Class.User_Role = 3;
                }

                Shared_Class.Username = cmb_User_Name.Text;
                frm_Main_MDI obj = new frm_Main_MDI();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect User Credentials!!!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           

            cmb_User_Name.SelectedIndex = -1;
            tb_Password.Text = "";
            cmb_User_Role.SelectedIndex = 0;
            cmb_User_Role.Focus();

            Shared_Class.Con_Close();

        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            cmb_User_Role.Focus();
        }
    }
}
