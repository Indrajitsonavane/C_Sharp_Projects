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

namespace Food_Shop_Billing_System.Forms.Merchant_Details
{
    public partial class frm_Add_Merchant_Details : Form
    {
        public frm_Add_Merchant_Details()
        {
            InitializeComponent();
        }

        private void frm_Add_Merchant_Details_Load(object sender, EventArgs e)
        {
            tb_Marchant_ID.Focus();
            Clear_Controls();
        }

        private void tb_Marchant_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }

        private void tb_Merchant_Name_KeyPress(object sender, KeyPressEventArgs e)
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
        void Clear_Controls()
        {
            tb_Marchant_ID.Clear();
            tb_Merchant_Name.Clear();
            tb_Owner_Mobile_No.Clear();
            tb_Bink_Info.Clear();
            tb_Merchant_Address.Clear();

            tb_Marchant_ID.Text = Convert.ToString(Shared_Class.Auto_Incr("Merchant_Details", "Merchant_id", 1));
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Shared_Class.Con_Open();

            if (tb_Marchant_ID.Text != "" && tb_Merchant_Name.Text != "" && tb_Owner_Mobile_No.Text != "" && tb_Bink_Info.Text != "" && tb_Merchant_Address.Text != "")

            {
                SqlCommand Cmd = new SqlCommand("Insert Into Merchant_Details values(@Mid ,@Mnm ,@Mno, @Bd ,@Madd ,@ramt ,@rdat , @dat ,@User ) ", Shared_Class.Con);

                Cmd.Parameters.Add("@Mid", SqlDbType.Int).Value = tb_Marchant_ID.Text;
                Cmd.Parameters.Add("@Mnm", SqlDbType.VarChar).Value = tb_Merchant_Name.Text;
                Cmd.Parameters.Add("@Mno", SqlDbType.Decimal).Value = tb_Owner_Mobile_No.Text;
                Cmd.Parameters.Add("@Bd", SqlDbType.NVarChar).Value = tb_Bink_Info.Text;
                Cmd.Parameters.Add("@Madd", SqlDbType.NVarChar).Value = tb_Merchant_Address.Text;
                Cmd.Parameters.Add("@ramt", SqlDbType.Money).Value = "0";
                Cmd.Parameters.Add("@rdat", SqlDbType.Date).Value = dtp_Merchant_Date.Value;
                Cmd.Parameters.Add("@dat", SqlDbType.Date).Value = dtp_Merchant_Date.Value;
                Cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = Shared_Class.Username;


                Cmd.ExecuteNonQuery();

                MessageBox.Show(" Mearchant Details Saved Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Fill All The Filds", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            Shared_Class.Con_Close();

            Clear_Controls();
        }

    }
}
