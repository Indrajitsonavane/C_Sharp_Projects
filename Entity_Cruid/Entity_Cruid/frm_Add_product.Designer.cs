
namespace Entity_Cruid
{
    partial class frm_Add_product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_Add_Product = new System.Windows.Forms.GroupBox();
            this.lbl_Barcode = new System.Windows.Forms.Label();
            this.tb_Barcode = new System.Windows.Forms.TextBox();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Purchase_Price = new System.Windows.Forms.Label();
            this.lbl_Sales_Price = new System.Windows.Forms.Label();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.tb_Purchase_Price = new System.Windows.Forms.TextBox();
            this.tb_Sales_Prise = new System.Windows.Forms.TextBox();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_Add_Product.SuspendLayout();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Add_Product
            // 
            this.gb_Add_Product.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_Add_Product.Controls.Add(this.lbl_Barcode);
            this.gb_Add_Product.Controls.Add(this.tb_Barcode);
            this.gb_Add_Product.Controls.Add(this.lbl_Unit);
            this.gb_Add_Product.Controls.Add(this.btn_Submit);
            this.gb_Add_Product.Controls.Add(this.btn_Refresh);
            this.gb_Add_Product.Controls.Add(this.lbl_Product_ID);
            this.gb_Add_Product.Controls.Add(this.lbl_Product_Name);
            this.gb_Add_Product.Controls.Add(this.lbl_Purchase_Price);
            this.gb_Add_Product.Controls.Add(this.lbl_Sales_Price);
            this.gb_Add_Product.Controls.Add(this.tb_Product_ID);
            this.gb_Add_Product.Controls.Add(this.tb_Product_Name);
            this.gb_Add_Product.Controls.Add(this.tb_Purchase_Price);
            this.gb_Add_Product.Controls.Add(this.tb_Sales_Prise);
            this.gb_Add_Product.Location = new System.Drawing.Point(22, 129);
            this.gb_Add_Product.Name = "gb_Add_Product";
            this.gb_Add_Product.Size = new System.Drawing.Size(1427, 442);
            this.gb_Add_Product.TabIndex = 11;
            this.gb_Add_Product.TabStop = false;
            this.gb_Add_Product.Text = "Add Product";
            // 
            // lbl_Barcode
            // 
            this.lbl_Barcode.AutoSize = true;
            this.lbl_Barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Barcode.Location = new System.Drawing.Point(194, 100);
            this.lbl_Barcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Barcode.Name = "lbl_Barcode";
            this.lbl_Barcode.Size = new System.Drawing.Size(107, 29);
            this.lbl_Barcode.TabIndex = 18;
            this.lbl_Barcode.Text = "Barcode";
            // 
            // tb_Barcode
            // 
            this.tb_Barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Barcode.Location = new System.Drawing.Point(377, 97);
            this.tb_Barcode.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Barcode.MaxLength = 30;
            this.tb_Barcode.Name = "tb_Barcode";
            this.tb_Barcode.Size = new System.Drawing.Size(297, 36);
            this.tb_Barcode.TabIndex = 17;
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit.Location = new System.Drawing.Point(1384, 138);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(0, 26);
            this.lbl_Unit.TabIndex = 12;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(665, 334);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(143, 54);
            this.btn_Submit.TabIndex = 8;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(411, 334);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(149, 54);
            this.btn_Refresh.TabIndex = 9;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.Location = new System.Drawing.Point(194, 38);
            this.lbl_Product_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(131, 29);
            this.lbl_Product_ID.TabIndex = 5;
            this.lbl_Product_ID.Text = "Product ID";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(194, 179);
            this.lbl_Product_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(175, 29);
            this.lbl_Product_Name.TabIndex = 5;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Purchase_Price
            // 
            this.lbl_Purchase_Price.AutoSize = true;
            this.lbl_Purchase_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Price.Location = new System.Drawing.Point(792, 28);
            this.lbl_Purchase_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Purchase_Price.Name = "lbl_Purchase_Price";
            this.lbl_Purchase_Price.Size = new System.Drawing.Size(185, 29);
            this.lbl_Purchase_Price.TabIndex = 6;
            this.lbl_Purchase_Price.Text = "Purchase Price";
            // 
            // lbl_Sales_Price
            // 
            this.lbl_Sales_Price.AutoSize = true;
            this.lbl_Sales_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sales_Price.Location = new System.Drawing.Point(792, 115);
            this.lbl_Sales_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Sales_Price.Name = "lbl_Sales_Price";
            this.lbl_Sales_Price.Size = new System.Drawing.Size(142, 29);
            this.lbl_Sales_Price.TabIndex = 6;
            this.lbl_Sales_Price.Text = "Sales Price";
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(377, 35);
            this.tb_Product_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Product_ID.MaxLength = 5;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(297, 36);
            this.tb_Product_ID.TabIndex = 1;
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(377, 176);
            this.tb_Product_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Product_Name.MaxLength = 80;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(297, 36);
            this.tb_Product_Name.TabIndex = 4;
            // 
            // tb_Purchase_Price
            // 
            this.tb_Purchase_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Price.Location = new System.Drawing.Point(992, 27);
            this.tb_Purchase_Price.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Purchase_Price.MaxLength = 10;
            this.tb_Purchase_Price.Name = "tb_Purchase_Price";
            this.tb_Purchase_Price.Size = new System.Drawing.Size(297, 36);
            this.tb_Purchase_Price.TabIndex = 5;
            // 
            // tb_Sales_Prise
            // 
            this.tb_Sales_Prise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sales_Prise.Location = new System.Drawing.Point(992, 114);
            this.tb_Sales_Prise.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Sales_Prise.MaxLength = 10;
            this.tb_Sales_Prise.Name = "tb_Sales_Prise";
            this.tb_Sales_Prise.Size = new System.Drawing.Size(297, 36);
            this.tb_Sales_Prise.TabIndex = 7;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.pnl_header.Controls.Add(this.lbl_Header);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1469, 100);
            this.pnl_header.TabIndex = 12;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(446, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(540, 76);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = " ADD PRODUCT";
            // 
            // frm_Add_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 613);
            this.Controls.Add(this.gb_Add_Product);
            this.Controls.Add(this.pnl_header);
            this.Name = "frm_Add_product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gb_Add_Product.ResumeLayout(false);
            this.gb_Add_Product.PerformLayout();
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_Add_Product;
        private System.Windows.Forms.Label lbl_Unit;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Purchase_Price;
        private System.Windows.Forms.Label lbl_Sales_Price;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.TextBox tb_Purchase_Price;
        private System.Windows.Forms.TextBox tb_Sales_Prise;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Barcode;
        private System.Windows.Forms.TextBox tb_Barcode;
    }
}

