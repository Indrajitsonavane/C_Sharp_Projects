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
    public partial class frm_Customer_Monthly_Sales : Form
    {

        public frm_Customer_Monthly_Sales()
        {
            InitializeComponent();
        }

        private void frm_Customer_Monthly_Sales_Load(object sender, EventArgs e)
        {
            Shared_Class.Con_Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SP_Customer_Monthly", Shared_Class.Con);
            sqlDa.SelectCommand.Parameters.AddWithValue("@Sdt", Shared_Class.Fdt);
            sqlDa.SelectCommand.Parameters.AddWithValue("@Edt", Shared_Class.Tdt);



            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Shared_Class.Con_Close();

            Food_Shop_Billing_System.Reports.RPT_File.CRV_Customer_Monthly_Report cr_Customer_Monthly = new Food_Shop_Billing_System.Reports.RPT_File.CRV_Customer_Monthly_Report();
            cr_Customer_Monthly.Database.Tables["SP_Customer_Monthly"].SetDataSource(dtbl);

            CRV_Customer_Monthly_Report.ReportSource = null;

            CRV_Customer_Monthly_Report.ReportSource = cr_Customer_Monthly;
        }

    }
}
