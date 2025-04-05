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

namespace Food_Shop_Billing_System.Forms.Stock_Details
{
    public partial class frm_Add_Recived_Order : Form
    {
        public frm_Add_Recived_Order()
        {
            InitializeComponent();
        }

        int cnt = 1;
        double Tot_Price;
        int Cstock = 0;
        double Rem_Amt = 0;
        private void tb_Purchase_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }

        private void tb_Sales_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }

        private void tb_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }

        private void tb_Product_Total_Bill_KeyPress(object sender, KeyPressEventArgs e)
        {
            Shared_Class.KeyPress_Only_Numric(sender, e);
        }

        private void frm_Add_Recived_Order_Load(object sender, EventArgs e)
        {
            lbl_Unit.Visible = false;
            lbl_Unit1.Visible = false;

            tb_order_Id.Text = Convert.ToString(Shared_Class.Auto_Incr("Order_Details", "Order_ID", 1));

            Shared_Class.Bind_ComboBox("Merchant_Name", cmb_Merchant_Name, "Select Merchant_Name From Merchant_Details ");
        }

        private void cmb_Category_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
           Shared_Class.Bind_ComboBox("Product_Name", cmb_Product_Name, "Select Product_Name From Product_Details Where Category = '" + cmb_Category_Name.Text + "' And Status = 1 ");

            cmb_Product_Name.Enabled = true;
        }
        private void cmb_Merchant_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            gb_Add_Product.Enabled = true;

            Shared_Class.Bind_ComboBox("Category_Name", cmb_Category_Name, "Select Category_Name From Category_Details Where  Merchant_Name = '"+ cmb_Merchant_Name.Text +"' ");
        }

        private void tb_Quantity_TextChanged(object sender, EventArgs e)
        {
            if (tb_Purchase_Price.Text != "" && tb_Sales_Price.Text != "" && tb_Quantity.Text != "")
            {
                double Amount = Convert.ToDouble(tb_Quantity.Text) * Convert.ToDouble(tb_Purchase_Price.Text);

                tb_Product_Total_Bill.Text = Convert.ToString(Amount);
            }

            lbl_Unit.Visible = true;
            lbl_Unit1.Visible = true;

            Shared_Class.Con_Open();

            SqlCommand cmd1 = new SqlCommand("Select Unit From Product_Details Where Product_Name = '"+ cmb_Product_Name.Text +"' ", Shared_Class.Con);

            SqlDataReader Dr = cmd1.ExecuteReader();

            if (Dr.Read())
            {
               lbl_Unit1.Text = lbl_Unit.Text = Dr["Unit"].ToString();
            }
        
            cmd1.Dispose();
            Dr.Close();

            Shared_Class.Con_Close();

            tb_Product_Total_Bill.Enabled = true;
        }

        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Class.Con_Open();


            SqlCommand cmd = new SqlCommand("Select  Purchase_Prise,Sales_Price  From  Product_Details where Category = '" + cmb_Category_Name.Text + "' And Product_Name = '" + cmb_Product_Name.Text + "' ", Shared_Class.Con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                tb_Purchase_Price.Text = (dr["Purchase_Prise"].ToString());
                tb_Sales_Price.Text = (dr["Sales_Price"].ToString());
            }

            Shared_Class.Con_Close();

            tb_Quantity.Enabled = true;
        }

        private void dgv_Order_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Order_List.Rows.Count > -1)
            {
                tb_Total.Text = Convert.ToString(double.Parse(tb_Total.Text) - Convert.ToDouble(dgv_Order_List.Rows[e.RowIndex].Cells[7].Value));

                dgv_Order_List.Rows.RemoveAt(e.RowIndex);

            }
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cmb_Category_Name.Text != "" && cmb_Product_Name.Text != "" && tb_Purchase_Price.Text != "" && tb_Sales_Price.Text != "" && tb_Quantity.Text != "" && tb_Product_Total_Bill.Text != "")
            {
                int flag = -1, Qty = Convert.ToInt32(tb_Quantity.Text);

                for (int i = 0; i <= dgv_Order_List.Rows.Count - 1; i++)
                {
                    if (Convert.ToString(dgv_Order_List.Rows[i].Cells[3].Value) == cmb_Product_Name.Text)
                    {
                        Qty += Convert.ToInt32(dgv_Order_List.Rows[i].Cells[6].Value);
                        Tot_Price = Convert.ToDouble(Qty) * Convert.ToDouble(tb_Purchase_Price.Text);

                            dgv_Order_List.Rows[i].Cells[5].Value = Qty;
                            dgv_Order_List.Rows[i].Cells[6].Value = Tot_Price;
                       
                        flag = 1;

                    }

                }

                if (flag == -1)
                {

                    dgv_Order_List.Rows.Add(cnt,cmb_Merchant_Name.Text, cmb_Category_Name.Text, cmb_Product_Name.Text, tb_Purchase_Price.Text, tb_Sales_Price.Text, tb_Quantity.Text, tb_Product_Total_Bill.Text);
                    cnt++;
                }


                tb_Total.Text = "0";

                for (int i = 0; i < dgv_Order_List.Rows.Count; i++)
                {
                    tb_Total.Text = Convert.ToString(double.Parse(tb_Total.Text) + double.Parse(dgv_Order_List.Rows[i].Cells[7].Value.ToString() ));

                    Shared_Class.Con_Open();

                    SqlCommand cmd3 = new SqlCommand("Select Current_Stock From Product_Details Where Product_Name = '" + dgv_Order_List.Rows[i].Cells[3].Value + "' ", Shared_Class.Con);

                    SqlDataReader Dr = cmd3.ExecuteReader();
             
                    if (Dr.Read())
                    {
                        Cstock = Convert.ToInt32(Dr["Current_Stock"].ToString()); 
                    }
                  

                    cmd3.Dispose();
                    Dr.Close();

                    SqlCommand cmd4 = new SqlCommand("Select Remening_Amount From Merchant_Details Where Merchant_Name = '" + dgv_Order_List.Rows[i].Cells[1].Value + "' ", Shared_Class.Con);

                    SqlDataReader Dr1 = cmd4.ExecuteReader();

                    if (Dr1.Read())
                    {
                        Rem_Amt = Convert.ToDouble(Dr1["Remening_Amount"].ToString());
                    }

                    cmd4.Dispose();

                    Shared_Class.Con_Close();
                }

               // cmb_Merchant_Name.Items.Clear();
                cmb_Category_Name.SelectedIndex = -1;
                cmb_Product_Name.SelectedIndex = -1;
                cmb_Product_Name.SelectedIndex = -1;
                tb_Purchase_Price.Clear();
                tb_Sales_Price.Clear();
                tb_Quantity.Text = "";
                tb_Product_Total_Bill.Text = "";

            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Shared_Class.Con_Open();

            if  ( tb_Total.Text != "" && tb_order_Id.Text != "" )
            {
                SqlCommand Cmd = new SqlCommand("Insert Into Order_Details values (@oid  ,@dat ,@ptbill , @User) ", Shared_Class.Con);

                Cmd.Parameters.Add("@oid", SqlDbType.Int).Value = tb_order_Id.Text;
                Cmd.Parameters.Add("@dat", SqlDbType.Date).Value =  dtp_Order_Date.Text;
                Cmd.Parameters.Add("@ptbill", SqlDbType.Money).Value = tb_Total.Text;
                Cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = Shared_Class.Username;

                Cmd.ExecuteNonQuery();
                Cmd.Dispose();

                for (int i = 0; i <= dgv_Order_List.Rows.Count - 1; i++)
                {
                  
                    SqlCommand Cmd1 = new SqlCommand("Insert Into Recived_Order_Details values (@oid ,@cat ,@Mnm ,@pnm ,@pp ,@sp,@qty) ", Shared_Class.Con);

                    Cmd1.Parameters.Add("@oid", SqlDbType.Int).Value = tb_order_Id.Text;
                    Cmd1.Parameters.Add("@cat", SqlDbType.VarChar).Value = dgv_Order_List.Rows[i].Cells[2].Value;
                    Cmd1.Parameters.Add("@Mnm", SqlDbType.VarChar).Value = cmb_Merchant_Name.Text;
                    Cmd1.Parameters.Add("@pnm", SqlDbType.VarChar).Value = dgv_Order_List.Rows[i].Cells[3].Value;
                    Cmd1.Parameters.Add("@pp", SqlDbType.Money).Value = dgv_Order_List.Rows[i].Cells[4].Value;
                    Cmd1.Parameters.Add("@sp", SqlDbType.Money).Value = dgv_Order_List.Rows[i].Cells[5].Value;
                    Cmd1.Parameters.Add("@qty", SqlDbType.Int).Value = dgv_Order_List.Rows[i].Cells[6].Value;

                    Cmd1.ExecuteNonQuery();
                    Cmd1.Dispose();


                    SqlCommand cmd2 = new SqlCommand("Update Product_Details set Current_Stock = @cs where Product_Name = '"+ dgv_Order_List.Rows[i].Cells[3].Value +"' ", Shared_Class.Con);

                    cmd2.Parameters.Add("@cs", SqlDbType.Int).Value = Convert.ToInt32(dgv_Order_List.Rows[i].Cells[6].Value) + Cstock;

                    cmd2.ExecuteNonQuery();

                    // 

                    SqlCommand cmd3 = new SqlCommand("Update Merchant_Details set Remening_Amount = @ra where Merchant_Name = '" + dgv_Order_List.Rows[i].Cells[1].Value + "' ", Shared_Class.Con);

                    cmd3.Parameters.Add("@ra", SqlDbType.Money).Value = Convert.ToInt32(dgv_Order_List.Rows[i].Cells[7].Value) + Rem_Amt;
                    cmd3.Parameters.Add("@dat", SqlDbType.Date).Value = dtp_Order_Date.Value;

                    cmd3.ExecuteNonQuery();

                     SqlCommand cmd4 = new SqlCommand("Update Payment_Details set Remening_Amount = @ra where Merchant_Name = '" + dgv_Order_List.Rows[i].Cells[1].Value + "' ", Shared_Class.Con);

                    cmd4.Parameters.Add("@ra", SqlDbType.Money).Value = Convert.ToInt32(dgv_Order_List.Rows[i].Cells[7].Value) + Rem_Amt;
                  

                    cmd3.ExecuteNonQuery();

                }

                MessageBox.Show("Add Successfully ", "Add Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgv_Order_List.Rows.Clear();

            }
            else
            {
                MessageBox.Show("Fill All The Filds", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
                Shared_Class.Con_Close();
        }

    }
}

