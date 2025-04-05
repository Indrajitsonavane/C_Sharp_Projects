
namespace Food_Shop_Billing_System.Forms.Product_Details
{
    partial class frm_Add_Product_Details
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
            this.lbl_Header = new System.Windows.Forms.Label();
            this.cmb_Merchant_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Merchant_Name = new System.Windows.Forms.Label();
            this.lbl_Purchase_Price = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Sales_Price = new System.Windows.Forms.Label();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.tb_Purchase_Price = new System.Windows.Forms.TextBox();
            this.tb_Sales_Prise = new System.Windows.Forms.TextBox();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.gb_Add_Product = new System.Windows.Forms.GroupBox();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.cmb_Units = new System.Windows.Forms.ComboBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.tb_Note = new System.Windows.Forms.TextBox();
            this.pnl_header.SuspendLayout();
            this.gb_Add_Product.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(462, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(540, 76);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = " ADD PRODUCT";
            // 
            // cmb_Merchant_Name
            // 
            this.cmb_Merchant_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Merchant_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Merchant_Name.FormattingEnabled = true;
            this.cmb_Merchant_Name.Location = new System.Drawing.Point(321, 202);
            this.cmb_Merchant_Name.Name = "cmb_Merchant_Name";
            this.cmb_Merchant_Name.Size = new System.Drawing.Size(297, 37);
            this.cmb_Merchant_Name.TabIndex = 3;
            // 
            // cmb_Category
            // 
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(321, 126);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(297, 37);
            this.cmb_Category.TabIndex = 2;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(783, 423);
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
            this.btn_Refresh.Location = new System.Drawing.Point(454, 423);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(149, 54);
            this.btn_Refresh.TabIndex = 9;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.Location = new System.Drawing.Point(81, 45);
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
            this.lbl_Product_Name.Location = new System.Drawing.Point(81, 297);
            this.lbl_Product_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(175, 29);
            this.lbl_Product_Name.TabIndex = 5;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Merchant_Name
            // 
            this.lbl_Merchant_Name.AutoSize = true;
            this.lbl_Merchant_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Merchant_Name.Location = new System.Drawing.Point(81, 210);
            this.lbl_Merchant_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Merchant_Name.Name = "lbl_Merchant_Name";
            this.lbl_Merchant_Name.Size = new System.Drawing.Size(193, 29);
            this.lbl_Merchant_Name.TabIndex = 6;
            this.lbl_Merchant_Name.Text = "Merchant Name";
            // 
            // lbl_Purchase_Price
            // 
            this.lbl_Purchase_Price.AutoSize = true;
            this.lbl_Purchase_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Price.Location = new System.Drawing.Point(816, 40);
            this.lbl_Purchase_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Purchase_Price.Name = "lbl_Purchase_Price";
            this.lbl_Purchase_Price.Size = new System.Drawing.Size(185, 29);
            this.lbl_Purchase_Price.TabIndex = 6;
            this.lbl_Purchase_Price.Text = "Purchase Price";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(81, 129);
            this.lbl_Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(115, 29);
            this.lbl_Category.TabIndex = 6;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_Sales_Price
            // 
            this.lbl_Sales_Price.AutoSize = true;
            this.lbl_Sales_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sales_Price.Location = new System.Drawing.Point(816, 127);
            this.lbl_Sales_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Sales_Price.Name = "lbl_Sales_Price";
            this.lbl_Sales_Price.Size = new System.Drawing.Size(142, 29);
            this.lbl_Sales_Price.TabIndex = 6;
            this.lbl_Sales_Price.Text = "Sales Price";
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Enabled = false;
            this.tb_Product_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(321, 45);
            this.tb_Product_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Product_ID.MaxLength = 5;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(297, 36);
            this.tb_Product_ID.TabIndex = 1;
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(321, 297);
            this.tb_Product_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Product_Name.MaxLength = 80;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(297, 36);
            this.tb_Product_Name.TabIndex = 4;
            this.tb_Product_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Product_Name_KeyPress);
            // 
            // tb_Purchase_Price
            // 
            this.tb_Purchase_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Price.Location = new System.Drawing.Point(1056, 41);
            this.tb_Purchase_Price.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Purchase_Price.MaxLength = 10;
            this.tb_Purchase_Price.Name = "tb_Purchase_Price";
            this.tb_Purchase_Price.Size = new System.Drawing.Size(297, 36);
            this.tb_Purchase_Price.TabIndex = 5;
            this.tb_Purchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Purchase_Price_KeyPress);
            // 
            // tb_Sales_Prise
            // 
            this.tb_Sales_Prise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sales_Prise.Location = new System.Drawing.Point(1056, 128);
            this.tb_Sales_Prise.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Sales_Prise.MaxLength = 10;
            this.tb_Sales_Prise.Name = "tb_Sales_Prise";
            this.tb_Sales_Prise.Size = new System.Drawing.Size(297, 36);
            this.tb_Sales_Prise.TabIndex = 7;
            this.tb_Sales_Prise.TextChanged += new System.EventHandler(this.tb_Sales_Prise_TextChanged);
            this.tb_Sales_Prise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Sales_Prise_KeyPress);
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.pnl_header.Controls.Add(this.lbl_Header);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1637, 100);
            this.pnl_header.TabIndex = 10;
            // 
            // gb_Add_Product
            // 
            this.gb_Add_Product.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_Add_Product.Controls.Add(this.lbl_Unit);
            this.gb_Add_Product.Controls.Add(this.cmb_Units);
            this.gb_Add_Product.Controls.Add(this.cmb_Merchant_Name);
            this.gb_Add_Product.Controls.Add(this.cmb_Category);
            this.gb_Add_Product.Controls.Add(this.btn_Submit);
            this.gb_Add_Product.Controls.Add(this.btn_Refresh);
            this.gb_Add_Product.Controls.Add(this.lbl_Product_ID);
            this.gb_Add_Product.Controls.Add(this.lbl_Product_Name);
            this.gb_Add_Product.Controls.Add(this.lbl_Merchant_Name);
            this.gb_Add_Product.Controls.Add(this.lbl_Note);
            this.gb_Add_Product.Controls.Add(this.lbl_Purchase_Price);
            this.gb_Add_Product.Controls.Add(this.lbl_Category);
            this.gb_Add_Product.Controls.Add(this.lbl_Sales_Price);
            this.gb_Add_Product.Controls.Add(this.tb_Product_ID);
            this.gb_Add_Product.Controls.Add(this.tb_Product_Name);
            this.gb_Add_Product.Controls.Add(this.tb_Note);
            this.gb_Add_Product.Controls.Add(this.tb_Purchase_Price);
            this.gb_Add_Product.Controls.Add(this.tb_Sales_Prise);
            this.gb_Add_Product.Location = new System.Drawing.Point(49, 141);
            this.gb_Add_Product.Name = "gb_Add_Product";
            this.gb_Add_Product.Size = new System.Drawing.Size(1525, 529);
            this.gb_Add_Product.TabIndex = 1;
            this.gb_Add_Product.TabStop = false;
            this.gb_Add_Product.Text = "Add Product";
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
            // cmb_Units
            // 
            this.cmb_Units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Units.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Units.FormattingEnabled = true;
            this.cmb_Units.Items.AddRange(new object[] {
            "Kg",
            "ML",
            "Pic"});
            this.cmb_Units.Location = new System.Drawing.Point(1377, 41);
            this.cmb_Units.Name = "cmb_Units";
            this.cmb_Units.Size = new System.Drawing.Size(78, 34);
            this.cmb_Units.TabIndex = 6;
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.Location = new System.Drawing.Point(816, 229);
            this.lbl_Note.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(66, 29);
            this.lbl_Note.TabIndex = 6;
            this.lbl_Note.Text = "Note";
            // 
            // tb_Note
            // 
            this.tb_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Note.Location = new System.Drawing.Point(1056, 228);
            this.tb_Note.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Note.MaxLength = 150;
            this.tb_Note.Multiline = true;
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(297, 117);
            this.tb_Note.TabIndex = 8;
            // 
            // frm_Add_Product_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1637, 710);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.gb_Add_Product);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Add_Product_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_Product_Details_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.gb_Add_Product.ResumeLayout(false);
            this.gb_Add_Product.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.ComboBox cmb_Merchant_Name;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Merchant_Name;
        private System.Windows.Forms.Label lbl_Purchase_Price;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Sales_Price;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.TextBox tb_Purchase_Price;
        private System.Windows.Forms.TextBox tb_Sales_Prise;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.GroupBox gb_Add_Product;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.TextBox tb_Note;
        private System.Windows.Forms.ComboBox cmb_Units;
        private System.Windows.Forms.Label lbl_Unit;
    }
}