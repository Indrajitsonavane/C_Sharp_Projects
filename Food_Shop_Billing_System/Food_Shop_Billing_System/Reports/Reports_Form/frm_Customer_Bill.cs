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

namespace Food_Shop_Billing_System.Reports.Reports_Form
{
    public partial class frm_Customer_Bill : Form
    {
       
        public frm_Customer_Bill()
        {
            InitializeComponent();
        }

        private void frm_Customer_Bill_Load(object sender, EventArgs e)
        {
            Shared_Class.Con_Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SP_Customer_Bill", Shared_Class.Con);
            sqlDa.SelectCommand.Parameters.AddWithValue("@Cid", Shared_Class.Index);
           

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Shared_Class.Con_Close();

            Food_Shop_Billing_System.Reports.RPT_File.CRV_Customer cr_Customer_Bill = new Food_Shop_Billing_System.Reports.RPT_File.CRV_Customer();
            cr_Customer_Bill.Database.Tables["SP_Customer_Bill"].SetDataSource(dtbl);

            CRV_Customer_Bill.ReportSource = null;

            CRV_Customer_Bill.ReportSource = cr_Customer_Bill;
        }
    }
}
