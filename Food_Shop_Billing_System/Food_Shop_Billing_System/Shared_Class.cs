using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Shop_Billing_System
{
    class Shared_Class
    {

        public static string Username = "";
        public static int User_Role = 0;
        public static SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-E11PKD9;Initial Catalog=Food_Shop_Billing_System_DB;Integrated Security=True");

        public static int Index = 0;

        public static DateTime Fdt;
        public static DateTime Tdt;
        public static void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }

        }

        public static void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();

            }

        }
        public static void KeyPress_Only_Numric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        public static void KeyPress_Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }


        public static int Auto_Incr(string Table_Name, string ColName, int Spt)
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) From " + Table_Name + "";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                Cmd.Dispose();

                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(" + ColName + ") From " + Table_Name + "";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt += 1;
            }
            else
            {
                Cnt = Spt;
            }

            Con_Close();

            return Cnt;
        }

        public static void Bind_ComboBox(string Column_Name, ComboBox CMB, string Quary)
        {
            Con_Open();

            CMB.Items.Clear();

            SqlCommand Cmd = new SqlCommand(Quary, Con);

            SqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {

                CMB.Items.Add(Dr.GetString(Dr.GetOrdinal(Column_Name)));

            }


            Dr.Dispose();
            Con_Close();

        }



        public static void Bind_Grid(DataGridView Dgv , string Quary )
        {
            Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter(Quary , Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            Dgv.DataSource = dt;

            Con_Close();

        }



    }
}
