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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_Add_product obj = new frm_Add_product();
            obj.Show();
       
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            frm_Update_Product obj = new frm_Update_Product();
            obj.Show();
      
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            frm_View_Products obj = new frm_View_Products();
            obj.Show();
         
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            frm_Delete_Product obj = new frm_Delete_Product();
            obj.Show();
   
        }
    }
}
