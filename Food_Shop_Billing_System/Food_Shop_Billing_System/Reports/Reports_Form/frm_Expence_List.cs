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
    public partial class frm_Expence_List : Form
    {
        public frm_Expence_List()
        {
            InitializeComponent();
        }

        private void frm_Expence_List_Load(object sender, EventArgs e)
        {
            Shared_Class.Con_Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SP_Expence_List", Shared_Class.Con);
          


            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Shared_Class.Con_Close();

            Food_Shop_Billing_System.Reports.RPT_File.Expence_List cr_Expence = new Food_Shop_Billing_System.Reports.RPT_File.Expence_List();
            cr_Expence.Database.Tables["SP_Expence_List"].SetDataSource(dtbl);

            crystalReportViewer1.ReportSource = null;

            crystalReportViewer1.ReportSource = cr_Expence;
        }
    }
}
