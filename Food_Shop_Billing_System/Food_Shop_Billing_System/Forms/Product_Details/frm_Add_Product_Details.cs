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

namespace Food_Shop_Billing_System.Forms.Product_Details
{
    public partial class frm_Add_Product_Details : Form
    {
        public frm_Add_Product_Details()
        {
            InitializeComponent();
        }

        private void frm_Add_Product_Details_Load(object sender, EventArgs e)
        {
            tb_Product_ID.Focus();
            Clear_Controls();
        }
        void Clear_Controls()
        {
            tb_Product_ID.Clear();
            tb_Product_Name.Clear();
            cmb_Category.Items.Clear();
            tb_Purchase_Price.Clear();
            tb_Sales_Prise.Clear();
            cmb_Merchant_Name.Items.Clear();
            tb_Note.Clear();

            tb_Product_ID.Text = Convert.ToString(Shared_Class.Auto_Incr("Product_Details", "Product_Id", 1));

            Shared_Class.Bind_ComboBox("Category_Name", cmb_Category, "Select Category_Name From Category_Details"); 

        }

        private void tb_Product_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Text(sender, e);
        }

        private void tb_Purchase_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }

        private void tb_Sales_Prise_KeyPress(object sender, KeyPressEventArgs e)
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

            if (tb_Product_ID.Text != "" && tb_Product_Name.Text != "" && tb_Purchase_Price.Text != "" && tb_Sales_Prise.Text != "" && tb_Purchase_Price.Text != "" && cmb_Units.Text != "" )

            {
                SqlCommand Cmd = new SqlCommand("Insert Into Product_Details values (@pid ,@pcat ,@pnm ,@pp, @sp ,@mnm ,@not ,@cs, @Status ,@User ,@Unt ) ", Shared_Class.Con);

                Cmd.Parameters.Add("@pid", SqlDbType.Int).Value = tb_Product_ID.Text;
                Cmd.Parameters.Add("@pcat", SqlDbType.VarChar).Value = cmb_Category.Text;
                Cmd.Parameters.Add("@pnm", SqlDbType.VarChar).Value = tb_Product_Name.Text;
                Cmd.Parameters.Add("@pp", SqlDbType.Int).Value = tb_Purchase_Price.Text;
                Cmd.Parameters.Add("@sp", SqlDbType.Int).Value = tb_Sales_Prise.Text;
                Cmd.Parameters.Add("@mnm", SqlDbType.VarChar).Value = cmb_Merchant_Name.Text;
                Cmd.Parameters.Add("@not", SqlDbType.NVarChar).Value = tb_Note.Text;
                Cmd.Parameters.Add("@cs", SqlDbType.Int).Value = 0;
                Cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = 1;
                Cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = Shared_Class.Username;
                Cmd.Parameters.Add("@Unt", SqlDbType.VarChar).Value = cmb_Units.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show(" Saved Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Fill All The Filds", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            Clear_Controls();

            Shared_Class.Con_Close();

        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("Merchant_Name", cmb_Merchant_Name, "Select Merchant_Name From  Category_Details Where Category_Name = '"+ cmb_Category.Text +"'");
        }

        private void tb_Sales_Prise_TextChanged(object sender, EventArgs e)
        {
            lbl_Unit.Text = cmb_Units.Text;
        }
    }
}
