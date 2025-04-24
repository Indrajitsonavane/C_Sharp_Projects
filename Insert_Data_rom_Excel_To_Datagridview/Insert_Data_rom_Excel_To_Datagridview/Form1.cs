using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insert_Data_rom_Excel_To_Datagridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    
        private void btn_Select_Exel_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Excel Sheet(*.Xlsx)|*.Xlsx|All Files(*.*)|*.*";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                string filepath = opd.FileName;

                string con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0};Extended Properties = 'Excel 8.0;HDR={1}'";

                con = string.Format(con , filepath , "yes");

                OleDbConnection exelcon = new OleDbConnection(con);
                exelcon.Open();

                DataTable dtexcel = exelcon.GetOleDbSchemaTable(OleDbSchemaGuid.Tables ,null);

                string exelsheet = dtexcel.Rows[0]["TABLE_NAME"].ToString();

                OleDbCommand cmd = new OleDbCommand("Select * from["+ exelsheet +"]",exelcon);

                OleDbDataAdapter oda = new OleDbDataAdapter(cmd);

                DataTable dt = new DataTable();

                oda.Fill(dt);

                dgv_Data.DataSource = dt;








            }
        }
    }
}
