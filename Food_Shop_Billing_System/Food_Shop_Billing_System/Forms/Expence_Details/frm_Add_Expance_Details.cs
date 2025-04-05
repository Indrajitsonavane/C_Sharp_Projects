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

namespace Food_Shop_Billing_System.Forms.Expence_Details
{
    public partial class frm_Add_Expance_Details : Form
    {
        public frm_Add_Expance_Details()
        {
            InitializeComponent();
        }

        private void frm_Add_Expance_Details_Load(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("Staff_Name", cmb_Staff_Name, "Select Staff_Name From Staff_Details");

            tb_Expance_ID.Text = Convert.ToString(Shared_Class.Auto_Incr("Expence_Details", "Expence_ID", 1));
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Shared_Class.Con_Open();

            if (tb_Expance_ID.Text != "" && cmb_Staff_Name.Text != "" && tb_Expance_Details.Text != "" && tb_Amount.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Insert Into Expence_Details values (@eid ,@edet , @amt ,@bilimg ,@pd ,@dat ,@User) ", Shared_Class.Con);

                Cmd.Parameters.Add("@eid", SqlDbType.Int).Value = tb_Expance_ID.Text;
                Cmd.Parameters.Add("@edet", SqlDbType.NVarChar).Value = tb_Expance_Details.Text;
                Cmd.Parameters.Add("@amt", SqlDbType.Int).Value = tb_Amount.Text;

                ImageConverter Ic = new ImageConverter();

                byte[] imgarray = (byte[])Ic.ConvertTo(Pb_Bill_Img.Image, typeof(byte[]));

                Cmd.Parameters.Add("@bilimg", SqlDbType.Image).Value = imgarray;
                Cmd.Parameters.Add("@pd", SqlDbType.NVarChar).Value = cmb_Staff_Name.Text;
                Cmd.Parameters.Add("@dat", SqlDbType.Date).Value = dtp_Date.Value;
                Cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = Shared_Class.Username;

                Cmd.ExecuteNonQuery();

                MessageBox.Show(" Saved Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btn_Refresh.PerformClick();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Expance_Details.Text = "";
            tb_Amount.Text = "";
            Pb_Bill_Img.Image = null;
            cmb_Staff_Name.SelectedIndex = -1;

        }

        private void Pb_Bill_Img_Click(object sender, EventArgs e)
        {
            OpenFileDialog odf = new OpenFileDialog();

            odf.Filter = "Image Files(*.jpg;*jpeg; *.Png)|*.jpg;*jpeg; *.Png";

            if (odf.ShowDialog() == DialogResult.OK)
            {
                Pb_Bill_Img.Image = new Bitmap(odf.FileName);
            }
        }
    }
}
