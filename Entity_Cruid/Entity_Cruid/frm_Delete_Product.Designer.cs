
namespace Entity_Cruid
{
    partial class frm_Delete_Product
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_Add_Product = new System.Windows.Forms.GroupBox();
            this.dgv_Product_View = new System.Windows.Forms.DataGridView();
            this.pnl_header.SuspendLayout();
            this.gb_Add_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_View)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(285, 482);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(143, 54);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(26, 482);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(149, 54);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.pnl_header.Controls.Add(this.lbl_Header);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1523, 94);
            this.pnl_header.TabIndex = 14;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(425, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(660, 76);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = " DELETE PRODUCT";
            // 
            // gb_Add_Product
            // 
            this.gb_Add_Product.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_Add_Product.Controls.Add(this.dgv_Product_View);
            this.gb_Add_Product.Controls.Add(this.btn_Delete);
            this.gb_Add_Product.Controls.Add(this.btn_Refresh);
            this.gb_Add_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Add_Product.Location = new System.Drawing.Point(51, 133);
            this.gb_Add_Product.Name = "gb_Add_Product";
            this.gb_Add_Product.Size = new System.Drawing.Size(1412, 556);
            this.gb_Add_Product.TabIndex = 13;
            this.gb_Add_Product.TabStop = false;
            this.gb_Add_Product.Text = "Add Product";
            // 
            // dgv_Product_View
            // 
            this.dgv_Product_View.AllowUserToAddRows = false;
            this.dgv_Product_View.AllowUserToDeleteRows = false;
            this.dgv_Product_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Product_View.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Product_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product_View.Location = new System.Drawing.Point(15, 41);
            this.dgv_Product_View.Name = "dgv_Product_View";
            this.dgv_Product_View.ReadOnly = true;
            this.dgv_Product_View.RowHeadersWidth = 51;
            this.dgv_Product_View.RowTemplate.Height = 24;
            this.dgv_Product_View.Size = new System.Drawing.Size(1361, 409);
            this.dgv_Product_View.TabIndex = 34;
            this.dgv_Product_View.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Product_View_MouseClick);
            // 
            // frm_Delete_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 701);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.gb_Add_Product);
            this.Name = "frm_Delete_Product";
            this.Text = "frm_Delete_Product";
            this.Load += new System.EventHandler(this.frm_Delete_Product_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.gb_Add_Product.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gb_Add_Product;
        private System.Windows.Forms.DataGridView dgv_Product_View;
    }
}