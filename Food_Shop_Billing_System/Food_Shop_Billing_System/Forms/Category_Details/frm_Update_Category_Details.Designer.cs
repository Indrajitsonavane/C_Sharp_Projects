
namespace Food_Shop_Billing_System.Forms.Category_Details
{
    partial class frm_Update_Category_Details
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_Category_ID = new System.Windows.Forms.Label();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.gb_Add_Product = new System.Windows.Forms.GroupBox();
            this.tb_Merchant_Name = new System.Windows.Forms.TextBox();
            this.lbl_Merchant_Name = new System.Windows.Forms.Label();
            this.tb_Category_ID = new System.Windows.Forms.TextBox();
            this.tb_Category_Name = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            this.gb_Add_Product.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(458, 24);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(699, 76);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "UPDATE CATEGORY";
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(633, 374);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(159, 54);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(336, 374);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(165, 54);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_Category_ID
            // 
            this.lbl_Category_ID.AutoSize = true;
            this.lbl_Category_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_ID.Location = new System.Drawing.Point(307, 95);
            this.lbl_Category_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category_ID.Name = "lbl_Category_ID";
            this.lbl_Category_ID.Size = new System.Drawing.Size(146, 29);
            this.lbl_Category_ID.TabIndex = 6;
            this.lbl_Category_ID.Text = "Category ID";
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.pnl_header.Controls.Add(this.lbl_Header);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1637, 122);
            this.pnl_header.TabIndex = 14;
            // 
            // gb_Add_Product
            // 
            this.gb_Add_Product.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_Add_Product.Controls.Add(this.tb_Merchant_Name);
            this.gb_Add_Product.Controls.Add(this.lbl_Merchant_Name);
            this.gb_Add_Product.Controls.Add(this.tb_Category_ID);
            this.gb_Add_Product.Controls.Add(this.tb_Category_Name);
            this.gb_Add_Product.Controls.Add(this.btn_Search);
            this.gb_Add_Product.Controls.Add(this.btn_Submit);
            this.gb_Add_Product.Controls.Add(this.lbl_Category_Name);
            this.gb_Add_Product.Controls.Add(this.btn_Refresh);
            this.gb_Add_Product.Controls.Add(this.lbl_Category_ID);
            this.gb_Add_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Add_Product.Location = new System.Drawing.Point(198, 162);
            this.gb_Add_Product.Name = "gb_Add_Product";
            this.gb_Add_Product.Size = new System.Drawing.Size(1180, 485);
            this.gb_Add_Product.TabIndex = 1;
            this.gb_Add_Product.TabStop = false;
            this.gb_Add_Product.Text = "Add Category";
            // 
            // tb_Merchant_Name
            // 
            this.tb_Merchant_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Merchant_Name.Location = new System.Drawing.Point(553, 167);
            this.tb_Merchant_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Merchant_Name.MaxLength = 40;
            this.tb_Merchant_Name.Name = "tb_Merchant_Name";
            this.tb_Merchant_Name.Size = new System.Drawing.Size(313, 36);
            this.tb_Merchant_Name.TabIndex = 3;
            // 
            // lbl_Merchant_Name
            // 
            this.lbl_Merchant_Name.AutoSize = true;
            this.lbl_Merchant_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Merchant_Name.Location = new System.Drawing.Point(307, 167);
            this.lbl_Merchant_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Merchant_Name.Name = "lbl_Merchant_Name";
            this.lbl_Merchant_Name.Size = new System.Drawing.Size(193, 29);
            this.lbl_Merchant_Name.TabIndex = 8;
            this.lbl_Merchant_Name.Text = "Merchant Name";
            // 
            // tb_Category_ID
            // 
            this.tb_Category_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category_ID.Location = new System.Drawing.Point(553, 88);
            this.tb_Category_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Category_ID.MaxLength = 5;
            this.tb_Category_ID.Name = "tb_Category_ID";
            this.tb_Category_ID.Size = new System.Drawing.Size(313, 36);
            this.tb_Category_ID.TabIndex = 1;
            // 
            // tb_Category_Name
            // 
            this.tb_Category_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category_Name.Location = new System.Drawing.Point(553, 245);
            this.tb_Category_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Category_Name.MaxLength = 40;
            this.tb_Category_Name.Name = "tb_Category_Name";
            this.tb_Category_Name.Size = new System.Drawing.Size(313, 36);
            this.tb_Category_Name.TabIndex = 4;
            this.tb_Category_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Category_Name_KeyPress);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(936, 88);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(138, 48);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Name.Location = new System.Drawing.Point(307, 245);
            this.lbl_Category_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(190, 29);
            this.lbl_Category_Name.TabIndex = 6;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // frm_Update_Category_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1637, 710);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.gb_Add_Product);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Update_Category_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Category Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Update_Category_Details_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.gb_Add_Product.ResumeLayout(false);
            this.gb_Add_Product.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_Category_ID;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.GroupBox gb_Add_Product;
        private System.Windows.Forms.TextBox tb_Category_ID;
        private System.Windows.Forms.TextBox tb_Category_Name;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Merchant_Name;
        private System.Windows.Forms.TextBox tb_Merchant_Name;
    }
}