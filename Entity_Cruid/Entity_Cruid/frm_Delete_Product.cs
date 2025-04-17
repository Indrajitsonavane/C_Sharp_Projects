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
    public partial class frm_Delete_Product : Form
    {
        TempEntities DB = new TempEntities();
        Product_Details obj = new Product_Details();

        int ID = 0;

        public frm_Delete_Product()
        {
            InitializeComponent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            

            obj = DB.Product_Details.Where(x => x.Product_Id == ID).FirstOrDefault();

            DB.Entry(obj).State = System.Data.Entity.EntityState.Deleted;

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

        private void dgv_Product_View_MouseClick(object sender, MouseEventArgs e)
        {
            ID = Convert.ToInt32(dgv_Product_View.CurrentRow.Cells[0].Value);
        }

        private void frm_Delete_Product_Load(object sender, EventArgs e)
        {
            dgv_Product_View.DataSource = DB.Product_Details.ToList<Product_Details>();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dgv_Product_View.DataSource = DB.Product_Details.ToList<Product_Details>();
        }
    }
}
