﻿using System;
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
    public partial class frm_View_Products : Form
    {
        TempEntities DB = new TempEntities();
        Product_Details obj = new Product_Details();

        public frm_View_Products()
        {
            InitializeComponent();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dgv_Product_View.DataSource = DB.Product_Details.ToList<Product_Details>();
        }

        private void frm_View_Products_Load(object sender, EventArgs e)
        {
            dgv_Product_View.DataSource = DB.Product_Details.ToList<Product_Details>();
        }
    }
}
