using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity_Cruid.DB;

namespace Entity_Cruid
{
    public partial class frm_Update_Product : Form
    {
        TempEntities DB = new TempEntities();
        Product_Details obj = new Product_Details();

  

        public frm_Update_Product()
        {
            InitializeComponent();

           
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
           int ID = Convert.ToInt32(tb_Product_ID.Text);

            obj = DB.Product_Details.Where(x => x.Product_Id ==  ID ).FirstOrDefault();

            tb_Product_ID.Text = Convert.ToString(obj.Product_Id);
            tb_Barcode.Text = obj.barcode;
            tb_Product_Name.Text = obj.Product_Name;
            tb_Parchase_Price.Text = Convert.ToString(obj.Purchase_Prise);
            tb_Seals_Prise.Text = Convert.ToString(obj.Sales_Price);


        }

        private void frm_Update_Product_Load(object sender, EventArgs e)
        {

          
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            obj.Product_Id = Convert.ToInt32(tb_Product_ID.Text);
            obj.Product_Name = tb_Product_Name.Text;
            obj.barcode = tb_Barcode.Text;
            obj.Purchase_Prise = Convert.ToInt32(tb_Parchase_Price.Text);
            obj.Sales_Price = Convert.ToInt32(tb_Seals_Prise.Text);

            DB.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();

            int Flag = DB.SaveChanges();

            if (Flag <= 0)
            {
                MessageBox.Show("Success !!!!");
            }
            else
            {
                MessageBox.Show("Fail !!!!");
            }
        }
    }
}
