using Entity_Cruid.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Cruid
{
    public partial class frm_Add_product : Form
    {
        TempEntities DB = new TempEntities();
        Product_Details obj = new Product_Details();



        public frm_Add_product()
        {
            InitializeComponent();

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            obj.Product_Id = Convert.ToInt32(tb_Product_ID.Text);
            obj.Product_Name = tb_Product_Name.Text;
            obj.barcode = tb_Barcode.Text;
            obj.Purchase_Prise = Convert.ToInt32(tb_Purchase_Price.Text);
            obj.Sales_Price = Convert.ToInt32(tb_Sales_Prise.Text);

            DB.Product_Details.Add(obj);
            int Flag = DB.SaveChanges();

            if (Flag > 0)
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
