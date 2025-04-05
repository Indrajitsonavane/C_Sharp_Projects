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
using System.IO;

namespace Food_Shop_Billing_System.Forms.Expence_Details
{
    public partial class frm_View_Expance_Details : Form
    {
        public frm_View_Expance_Details()
        {
            InitializeComponent();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Shared_Class.Bind_Grid(dgv_Expence_View, "Select Expence_ID, Expence_Details , Amount , Paid_by ,  Date  From  Expence_Details");
            Pb_Bill_Img.Image = null;
        }

        private void frm_View_Expance_Details_Load(object sender, EventArgs e)
        {
            this.dgv_Expence_View.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11);

            Shared_Class.Bind_Grid(dgv_Expence_View, "Select Expence_ID, Expence_Details , Amount , Paid_by ,  Date  From  Expence_Details");
        }

        private void dgv_Merchant_View_SelectionChanged(object sender, EventArgs e)
        {
            Shared_Class.Con_Open();

            Int32 selectedRowCount = dgv_Expence_View.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1)
            {
                string value = dgv_Expence_View.SelectedCells[0].RowIndex.ToString();

                int index = Convert.ToInt32(value);

                int id = Convert.ToInt32(dgv_Expence_View.Rows[index].Cells[0].Value);

                SqlCommand cmd = new SqlCommand("select Bill_Image from Expence_Details where Expence_ID = '" + id + "'  ", Shared_Class.Con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Bill_Image"]);
                    Pb_Bill_Img.Image = new Bitmap(ms);
                   
                }
                else
                {
                    MessageBox.Show("invalide");
                }
            }

            

            Shared_Class.Con_Close();
        }
    }
}
