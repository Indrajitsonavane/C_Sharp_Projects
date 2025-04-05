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

namespace Food_Shop_Billing_System.Forms.Payment_Details
{
    public partial class frm_Payment_Details : Form
    {
        public frm_Payment_Details()
        {
            InitializeComponent();
        }

        void clear_Controls()
        {
            tb_paid_Amount.Text = "";
            cmb_Payment_Mode.SelectedIndex = -1;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Shared_Class.Con_Open();

            if (tb_paid_Amount.Text != ""  && cmb_Payment_Mode.Text != "" )
            {
                SqlCommand Cmd = new SqlCommand("Insert Into Payment_Details values (@pid ,@Mnm ,@dat,@rbill, @pdbill ,@totbill , @paymetd , @User) ", Shared_Class.Con);

                Cmd.Parameters.Add("@pid", SqlDbType.Int).Value = tb_Payment_Id.Text ;
                Cmd.Parameters.Add("@Mnm", SqlDbType.VarChar).Value = cmb_Merchant_Name.Text;
                Cmd.Parameters.Add("@dat", SqlDbType.Date).Value = dtp_Payment_Date.Value;
                Cmd.Parameters.Add("@rbill", SqlDbType.Money).Value = tb_T_Remening_Bill.Text;
                Cmd.Parameters.Add("@pdbill", SqlDbType.Money).Value = tb_paid_Amount.Text;
                Cmd.Parameters.Add("@totbill", SqlDbType.Money).Value = tb_Remening_Bill.Text;
                Cmd.Parameters.Add("@paymetd", SqlDbType.VarChar).Value = cmb_Payment_Mode.Text;
                Cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = Shared_Class.Username;

                Cmd.ExecuteNonQuery();

                // update remening amount to merchant Details

                SqlCommand cmd3 = new SqlCommand("Update Merchant_Details set Remening_Amount = @ra Where Merchant_Name = '" + cmb_Merchant_Name.Text + "' ", Shared_Class.Con);

                cmd3.Parameters.Add("@ra", SqlDbType.Money).Value = tb_T_Remening_Bill.Text;
               
                cmd3.ExecuteNonQuery();


                MessageBox.Show("Payment Details Saved Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Fill All The Filds", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            Shared_Class.Con_Close();

            clear_Controls();

        }
        private void frm_Payment_Details_Load(object sender, EventArgs e)
        {
            clear_Controls();

            tb_Payment_Id.Text = Convert.ToString(Shared_Class.Auto_Incr("Payment_Details", "Payment_ID", 1));

            Shared_Class.Bind_ComboBox("Merchant_Name", cmb_Merchant_Name, "Select Merchant_Name From Merchant_Details ");

        }

        private void cmb_Merchant_Name_SelectedIndexChanged(object sender, EventArgs e)
        {

            Shared_Class.Con_Open();

            SqlCommand cmd = new SqlCommand("Select Remening_Amount From Merchant_Details Where Merchant_Name = '" + cmb_Merchant_Name.Text + "' ", Shared_Class.Con);

            SqlDataReader Dr = cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_T_Remening_Bill.Text = tb_Remening_Bill.Text = Dr["Remening_Amount"].ToString();
               // dtp_Date.Text = Dr.GetString(Dr.GetOrdinal("Rem_Amt_Date"));

            }

            cmd.Dispose();
            Dr.Close();

            Shared_Class.Con_Close();
        }

        private void tb_paid_Amount_TextChanged(object sender, EventArgs e)
        {

            if (tb_paid_Amount.Text == ""  )
            {
                tb_paid_Amount.Text = "0";
            }
            else
            {
                tb_T_Remening_Bill.Text = Convert.ToString(double.Parse(tb_Remening_Bill.Text) - double.Parse(tb_paid_Amount.Text));
            }
        }

        private void tb_paid_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                if (e.KeyChar == (char)Keys.Back )
                {
                    tb_paid_Amount.Text = "0.0";
                    tb_T_Remening_Bill.Text = "0.0";
                }

                e.Handled = true;
            }
        }
    }
}
