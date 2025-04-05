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
    public partial class frm_Product_List : Form
    {
        public frm_Product_List()
        {
            InitializeComponent();
        }

        private void frm_Product_List_Load(object sender, EventArgs e)
        {
            Shared_Class.Con_Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SP_Product_List", Shared_Class.Con);
            
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Shared_Class.Con_Close();

            Food_Shop_Billing_System.Reports.RPT_File.CRV_Product_List cr_Product_List = new Food_Shop_Billing_System.Reports.RPT_File.CRV_Product_List();
            cr_Product_List.Database.Tables["SP_Product_List"].SetDataSource(dtbl);

            CRV_Product_List.ReportSource = null;

            CRV_Product_List.ReportSource = cr_Product_List;
        }
    }
}
