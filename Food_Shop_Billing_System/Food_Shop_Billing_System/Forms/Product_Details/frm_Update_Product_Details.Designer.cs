
namespace Food_Shop_Billing_System.Forms.Product_Details
{
    partial class frm_Update_Product_Details
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
            this.pnl_header = new System.Windows.Forms.Panel();
            this.gb_Add_Product = new System.Windows.Forms.GroupBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.tb_Note = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Merchant_Name = new System.Windows.Forms.TextBox();
            this.tb_Category = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Marchant_Name = new System.Windows.Forms.Label();
            this.lbl_Parchase_Price = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Seals_Prise = new System.Windows.Forms.Label();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.tb_Parchase_Price = new System.Windows.Forms.TextBox();
            this.tb_Seals_Prise = new System.Windows.Forms.TextBox();
            this.pnl_header.SuspendLayout();
            this.gb_Add_Product.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(386, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(653, 76);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "UPDATE PRODUCT";
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.pnl_header.Controls.Add(this.lbl_Header);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1637, 100);
            this.pnl_header.TabIndex = 12;
            // 
            // gb_Add_Product
            // 
            this.gb_Add_Product.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_Add_Product.Controls.Add(this.lbl_Note);
            this.gb_Add_Product.Controls.Add(this.tb_Note);
            this.gb_Add_Product.Controls.Add(this.btn_Search);
            this.gb_Add_Product.Controls.Add(this.tb_Merchant_Name);
            this.gb_Add_Product.Controls.Add(this.tb_Category);
            this.gb_Add_Product.Controls.Add(this.btn_Update);
            this.gb_Add_Product.Controls.Add(this.btn_Refresh);
            this.gb_Add_Product.Controls.Add(this.lbl_Product_ID);
            this.gb_Add_Product.Controls.Add(this.lbl_Product_Name);
            this.gb_Add_Product.Controls.Add(this.lbl_Marchant_Name);
            this.gb_Add_Product.Controls.Add(this.lbl_Parchase_Price);
            this.gb_Add_Product.Controls.Add(this.lbl_Category);
            this.gb_Add_Product.Controls.Add(this.lbl_Seals_Prise);
            this.gb_Add_Product.Controls.Add(this.tb_Product_ID);
            this.gb_Add_Product.Controls.Add(this.tb_Product_Name);
            this.gb_Add_Product.Controls.Add(this.tb_Parchase_Price);
            this.gb_Add_Product.Controls.Add(this.tb_Seals_Prise);
            this.gb_Add_Product.Location = new System.Drawing.Point(47, 129);
            this.gb_Add_Product.Name = "gb_Add_Product";
            this.gb_Add_Product.Size = new System.Drawing.Size(1530, 511);
            this.gb_Add_Product.TabIndex = 1;
            this.gb_Add_Product.TabStop = false;
            this.gb_Add_Product.Text = "Add Product";
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.Location = new System.Drawing.Point(870, 241);
            this.lbl_Note.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(66, 29);
            this.lbl_Note.TabIndex = 20;
            this.lbl_Note.Text = "Note";
            // 
            // tb_Note
            // 
            this.tb_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Note.Location = new System.Drawing.Point(1110, 241);
            this.tb_Note.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Note.MaxLength = 150;
            this.tb_Note.Multiline = true;
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(297, 117);
            this.tb_Note.TabIndex = 19;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(699, 38);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(121, 47);
            this.btn_Search.TabIndex = 18;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Merchant_Name
            // 
            this.tb_Merchant_Name.Enabled = false;
            this.tb_Merchant_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Merchant_Name.Location = new System.Drawing.Point(373, 300);
            this.tb_Merchant_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Merchant_Name.MaxLength = 40;
            this.tb_Merchant_Name.Name = "tb_Merchant_Name";
            this.tb_Merchant_Name.Size = new System.Drawing.Size(297, 36);
            this.tb_Merchant_Name.TabIndex = 17;
            // 
            // tb_Category
            // 
            this.tb_Category.Enabled = false;
            this.tb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category.Location = new System.Drawing.Point(373, 128);
            this.tb_Category.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Category.MaxLength = 40;
            this.tb_Category.Name = "tb_Category";
            this.tb_Category.Size = new System.Drawing.Size(297, 36);
            this.tb_Category.TabIndex = 16;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(869, 392);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(143, 54);
            this.btn_Update.TabIndex = 15;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(540, 392);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(149, 54);
            this.btn_Refresh.TabIndex = 14;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.Location = new System.Drawing.Point(133, 44);
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
            this.lbl_Product_Name.Location = new System.Drawing.Point(133, 215);
            this.lbl_Product_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(175, 29);
            this.lbl_Product_Name.TabIndex = 5;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Marchant_Name
            // 
            this.lbl_Marchant_Name.AutoSize = true;
            this.lbl_Marchant_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marchant_Name.Location = new System.Drawing.Point(133, 307);
            this.lbl_Marchant_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Marchant_Name.Name = "lbl_Marchant_Name";
            this.lbl_Marchant_Name.Size = new System.Drawing.Size(193, 29);
            this.lbl_Marchant_Name.TabIndex = 6;
            this.lbl_Marchant_Name.Text = "Marchant Name";
            // 
            // lbl_Parchase_Price
            // 
            this.lbl_Parchase_Price.AutoSize = true;
            this.lbl_Parchase_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Parchase_Price.Location = new System.Drawing.Point(870, 148);
            this.lbl_Parchase_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Parchase_Price.Name = "lbl_Parchase_Price";
            this.lbl_Parchase_Price.Size = new System.Drawing.Size(185, 29);
            this.lbl_Parchase_Price.TabIndex = 6;
            this.lbl_Parchase_Price.Text = "Parchase Price";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(133, 128);
            this.lbl_Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(115, 29);
            this.lbl_Category.TabIndex = 6;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_Seals_Prise
            // 
            this.lbl_Seals_Prise.AutoSize = true;
            this.lbl_Seals_Prise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Seals_Prise.Location = new System.Drawing.Point(870, 49);
            this.lbl_Seals_Prise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Seals_Prise.Name = "lbl_Seals_Prise";
            this.lbl_Seals_Prise.Size = new System.Drawing.Size(142, 29);
            this.lbl_Seals_Prise.TabIndex = 6;
            this.lbl_Seals_Prise.Text = "Seals Prise";
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(373, 44);
            this.tb_Product_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Product_ID.MaxLength = 40;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(297, 36);
            this.tb_Product_ID.TabIndex = 1;
            this.tb_Product_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Product_ID_KeyPress);
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(373, 215);
            this.tb_Product_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Product_Name.MaxLength = 40;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(297, 36);
            this.tb_Product_Name.TabIndex = 3;
            this.tb_Product_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Product_Name_KeyPress);
            // 
            // tb_Parchase_Price
            // 
            this.tb_Parchase_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Parchase_Price.Location = new System.Drawing.Point(1110, 149);
            this.tb_Parchase_Price.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Parchase_Price.MaxLength = 40;
            this.tb_Parchase_Price.Name = "tb_Parchase_Price";
            this.tb_Parchase_Price.Size = new System.Drawing.Size(297, 36);
            this.tb_Parchase_Price.TabIndex = 6;
            this.tb_Parchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Parchase_Price_KeyPress);
            // 
            // tb_Seals_Prise
            // 
            this.tb_Seals_Prise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Seals_Prise.Location = new System.Drawing.Point(1110, 50);
            this.tb_Seals_Prise.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Seals_Prise.MaxLength = 40;
            this.tb_Seals_Prise.Name = "tb_Seals_Prise";
            this.tb_Seals_Prise.Size = new System.Drawing.Size(297, 36);
            this.tb_Seals_Prise.TabIndex = 5;
            this.tb_Seals_Prise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Seals_Prise_KeyPress);
            // 
            // frm_Update_Product_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1637, 710);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.gb_Add_Product);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Update_Product_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Product Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Update_Product_Details_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.gb_Add_Product.ResumeLayout(false);
            this.gb_Add_Product.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.GroupBox gb_Add_Product;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Marchant_Name;
        private System.Windows.Forms.Label lbl_Parchase_Price;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Seals_Prise;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.TextBox tb_Parchase_Price;
        private System.Windows.Forms.TextBox tb_Seals_Prise;
        private System.Windows.Forms.TextBox tb_Merchant_Name;
        private System.Windows.Forms.TextBox tb_Category;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.TextBox tb_Note;
    }
}