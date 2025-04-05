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
    public partial class frm_Monthly_Payments : Form
    {

        public frm_Monthly_Payments()
        {
            InitializeComponent();
        }
        
        private void frm_Monthly_Payments_Load(object sender, EventArgs e)
        {
            Shared_Class.Con_Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SP_Monthly_Payments", Shared_Class.Con);
            sqlDa.SelectCommand.Parameters.AddWithValue("@Sdt", Shared_Class.Fdt);
            sqlDa.SelectCommand.Parameters.AddWithValue("@Edt", Shared_Class.Tdt);


            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Shared_Class.Con_Close();

            Food_Shop_Billing_System.Reports.RPT_File.CRV_Monthly_Payments cr_Monthly_Payments = new Food_Shop_Billing_System.Reports.RPT_File.CRV_Monthly_Payments();
            cr_Monthly_Payments.Database.Tables["SP_Monthly_Payments"].SetDataSource(dtbl);

            CRV_Monthly_Payments.ReportSource = null;

            CRV_Monthly_Payments.ReportSource = cr_Monthly_Payments;
        }
    }
}
