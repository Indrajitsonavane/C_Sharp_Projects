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

namespace Food_Shop_Billing_System.Forms.Coustomer_Details
{
    public partial class frm_Add_Coustomer_Details : Form
    {
        public frm_Add_Coustomer_Details()
        {
            InitializeComponent();
        }

        int cnt = 1;
        double Tot_Price;
        int Cstock = 0;

        private void frm_Add_Coustomer_Details_Load(object sender, EventArgs e)
        {
            lbl_Unit.Visible = false;
            lbl_Unit1.Visible = false;

            tb_Coustomer_ID.Text = Convert.ToString(Shared_Class.Auto_Incr("Customer_Details", "Coustomer_ID", 1));
        }

        private void tb_Costomer_Name_TextChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("Category_Name", cmb_Category_Name, "Select Category_Name From Category_Details");
        }

        private void cmb_Category_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Bind_ComboBox("Product_Name", cmb_Product_Name, "Select Product_Name From Product_Details Where Category = '" + cmb_Category_Name.Text + "' And Status = 1 ");
        }

        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Con_Open();


            SqlCommand cmd = new SqlCommand("Select Sales_Price  From  Product_Details where Category = '" + cmb_Category_Name.Text + "' And Product_Name = '" + cmb_Product_Name.Text + "' ", Shared_Class.Con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
               tb_Sals_Price.Text = (dr["Sales_Price"].ToString());
            }

            Shared_Class.Con_Close();

            tb_Quantity.Enabled = true;
        }


        private void tb_Product_Total_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }

        private void tb_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }

        private void tb_Seals_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cmb_Category_Name.Text != "" && cmb_Product_Name.Text != "" && tb_Product_Total.Text != "" && tb_Sals_Price.Text != "" && tb_Quantity.Text != "" && tb_Product_Total.Text != "")
            {
                int flag = -1, Qty = Convert.ToInt32(tb_Quantity.Text);

                for (int i = 0; i <= dgv_Order_List.Rows.Count - 1; i++)
                {
                    if (Convert.ToString(dgv_Order_List.Rows[i].Cells[1].Value) == cmb_Product_Name.Text)
                    {
                        Qty += Convert.ToInt32(dgv_Order_List.Rows[i].Cells[3].Value);
                        Tot_Price = Convert.ToDouble(Qty) * Convert.ToDouble(tb_Sals_Price.Text);

                        dgv_Order_List.Rows[i].Cells[3].Value = Qty;
                        dgv_Order_List.Rows[i].Cells[4].Value = Tot_Price;

                        flag = 1;

                    }

                }

                if (flag == -1)
                {

                    dgv_Order_List.Rows.Add(cnt, cmb_Product_Name.Text, tb_Sals_Price.Text, tb_Quantity.Text, tb_Product_Total.Text);
                    cnt++;
                }


                tb_Total_Bill.Text = "0";

                for (int i = 0; i < dgv_Order_List.Rows.Count; i++)
                {
                    tb_Total_Bill.Text = Convert.ToString(double.Parse(tb_Total_Bill.Text) + double.Parse(dgv_Order_List.Rows[i].Cells[4].Value.ToString()));

                    Shared_Class.Con_Open();

                    SqlCommand cmd3 = new SqlCommand("Select Current_Stock From Product_Details Where Product_Name = '" + dgv_Order_List.Rows[i].Cells[1].Value + "' ", Shared_Class.Con);

                    SqlDataReader Dr = cmd3.ExecuteReader();

                    if (Dr.Read())
                    {
                        Cstock = Convert.ToInt32(Dr["Current_Stock"].ToString());
                    }

                    if (Cstock < Convert.ToInt32(tb_Quantity.Text))
                    {
                        dgv_Order_List.Rows.RemoveAt(i);
                        MessageBox.Show( "Avilable Stock = "+ Convert.ToString(Cstock), "NO Stock Avalible", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    }

                    cmd3.Dispose();

                    Shared_Class.Con_Close();
                }

                tb_Product_Total.Text = "";
                tb_Sals_Price.Text = "";
                tb_Quantity.Text = "";
                cmb_Category_Name.SelectedIndex = -1;
                cmb_Product_Name.SelectedIndex = -1;

            }
        }

        private void tb_Total_Bill_TextChanged(object sender, EventArgs e)
        {
            if (tb_Discount.Text == "")
            {
                tb_Discount.Text = "0";
            }
        }

        private void tb_Discount_TextChanged(object sender, EventArgs e)
        {
            if (tb_Discount.Text == "")
            {
                tb_Discount.Text = "0.0";
            }
            else
            {
                double Disc_Amount = (Convert.ToDouble(tb_Total_Bill.Text) * Convert.ToDouble(tb_Discount.Text)) / 100;

                tb_Final_Bill.Text = Convert.ToString(Convert.ToDouble(tb_Total_Bill.Text) - Disc_Amount ); 
            }
           
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Discount.Text == "0")
            {
                tb_Final_Bill.Text = tb_Total_Bill.Text;
            }

            Shared_Class.Con_Open();

            if (tb_Final_Bill.Text != "" && tb_Coustomer_ID.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Insert Into Customer_Details values (@cid  ,@cnm ,@det , @dis , @totbill ,@User ) ", Shared_Class.Con);

                Cmd.Parameters.Add("@cid", SqlDbType.Int).Value = tb_Coustomer_ID.Text;
                Cmd.Parameters.Add("@cnm", SqlDbType.VarChar).Value = tb_Costomer_Name.Text;
                Cmd.Parameters.Add("@det", SqlDbType.Date).Value = dtp_Date.Value;
                Cmd.Parameters.Add("@dis", SqlDbType.Money).Value = tb_Discount.Text;
                Cmd.Parameters.Add("@totbill", SqlDbType.Money).Value = tb_Final_Bill.Text;
                Cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = Shared_Class.Username;

                Cmd.ExecuteNonQuery();
                Cmd.Dispose();

                for (int i = 0; i <= dgv_Order_List.Rows.Count - 1; i++)
                {

                    SqlCommand Cmd1 = new SqlCommand("Insert Into Purchase_Details values (@cid ,@pnm ,@sp , @qty ,@fbill )", Shared_Class.Con);

                    Cmd1.Parameters.Add("@cid", SqlDbType.Int).Value = tb_Coustomer_ID.Text;
                    Cmd1.Parameters.Add("@pnm", SqlDbType.VarChar).Value = dgv_Order_List.Rows[i].Cells[1].Value;
                    Cmd1.Parameters.Add("@sp", SqlDbType.VarChar).Value = dgv_Order_List.Rows[i].Cells[2].Value;
                    Cmd1.Parameters.Add("@qty", SqlDbType.VarChar).Value = dgv_Order_List.Rows[i].Cells[3].Value;
                    Cmd1.Parameters.Add("@fbill", SqlDbType.Money).Value = dgv_Order_List.Rows[i].Cells[4].Value;
               
                    Cmd1.ExecuteNonQuery();
                    Cmd1.Dispose();


                    SqlCommand cmd2 = new SqlCommand("Update Product_Details set Current_Stock = @cs where Product_Name = '" + dgv_Order_List.Rows[i].Cells[1].Value + "' ", Shared_Class.Con);

                    cmd2.Parameters.Add("@cs", SqlDbType.Int).Value = Cstock - Convert.ToInt32(dgv_Order_List.Rows[i].Cells[3].Value);

                    cmd2.ExecuteNonQuery();

                }


                MessageBox.Show("Add Successfully ", "Add Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Shared_Class.Con_Close();

                Shared_Class.Index = Convert.ToInt32(tb_Coustomer_ID.Text);

                Reports.Reports_Form.frm_Customer_Bill obj = new Reports.Reports_Form.frm_Customer_Bill();
                obj.Show();

                dgv_Order_List.Rows.Clear();

            }
            else
            {
                MessageBox.Show("Fill All The Filds", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }

        private void dgv_Order_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Order_List.Rows.Count > -1)
            {
                tb_Total_Bill.Text = Convert.ToString(double.Parse(tb_Total_Bill.Text) - Convert.ToDouble(dgv_Order_List.Rows[e.RowIndex].Cells[4].Value));

                dgv_Order_List.Rows.RemoveAt(e.RowIndex);
            }

        }

        private void tb_Quantity_TextChanged(object sender, EventArgs e)
        {
            if (tb_Sals_Price.Text != "" && tb_Quantity.Text != "")
            {
                double Amount = Convert.ToDouble(tb_Quantity.Text) * Convert.ToDouble(tb_Sals_Price.Text);

                tb_Product_Total.Text = Convert.ToString(Amount);
            }


            lbl_Unit.Visible = true;
            lbl_Unit1.Visible = true;

            Shared_Class.Con_Open();

            SqlCommand cmd1 = new SqlCommand("Select Unit From Product_Details Where Product_Name = '" + cmb_Product_Name.Text + "' ", Shared_Class.Con);

            SqlDataReader Dr = cmd1.ExecuteReader();

            if (Dr.Read())
            {
                lbl_Unit1.Text = lbl_Unit.Text = Dr["Unit"].ToString();
            }

            Dr.Close();
        }
        // table = coustomer_details &  Purchase details

    }
}
