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


namespace AutocomleteCombobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

            Auto();

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Temp;Integrated Security=True");

            con.Open();

            SqlCommand Cmd = new SqlCommand("Select Product_Name , barcode From Product_Details", con);

            SqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {

               
                cmb_P_Name.Items.Add(Dr["barcode"].ToString());

            }




        }

        void Auto()
        {

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Temp;Integrated Security=True");

            con.Open();

            SqlCommand Cmd = new SqlCommand("Select Product_Name , barcode From Product_Details", con);

            SqlDataReader Dr = Cmd.ExecuteReader();

            AutoCompleteStringCollection Autocom = new AutoCompleteStringCollection();

            

            while (Dr.Read())
            {

                Autocom.Add(Dr["Product_Name"].ToString());
                Autocom.Add(Dr["barcode"].ToString());

            }



            this.cmb_P_Name.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_P_Name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmb_P_Name.AutoCompleteCustomSource = Autocom;

        }
    }
}
