
namespace Food_Shop_Billing_System.Forms.Expence_Details
{
    partial class frm_View_Expance_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dgv_Expence_View = new System.Windows.Forms.DataGridView();
            this.Pb_Bill_Img = new System.Windows.Forms.PictureBox();
            this.Bill_Image = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expence_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Bill_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(656, 20);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(402, 58);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "VIEW EXPENCE";
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.pnl_header.Controls.Add(this.lbl_Header);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1762, 96);
            this.pnl_header.TabIndex = 17;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(1559, 113);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(146, 54);
            this.btn_Refresh.TabIndex = 19;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // dgv_Expence_View
            // 
            this.dgv_Expence_View.AllowUserToAddRows = false;
            this.dgv_Expence_View.AllowUserToDeleteRows = false;
            this.dgv_Expence_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Expence_View.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_Expence_View.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Expence_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Expence_View.Location = new System.Drawing.Point(35, 131);
            this.dgv_Expence_View.Name = "dgv_Expence_View";
            this.dgv_Expence_View.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Expence_View.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Expence_View.RowHeadersWidth = 51;
            this.dgv_Expence_View.RowTemplate.Height = 24;
            this.dgv_Expence_View.Size = new System.Drawing.Size(1301, 614);
            this.dgv_Expence_View.TabIndex = 23;
            this.dgv_Expence_View.SelectionChanged += new System.EventHandler(this.dgv_Merchant_View_SelectionChanged);
            // 
            // Pb_Bill_Img
            // 
            this.Pb_Bill_Img.BackColor = System.Drawing.Color.White;
            this.Pb_Bill_Img.Location = new System.Drawing.Point(1383, 260);
            this.Pb_Bill_Img.Name = "Pb_Bill_Img";
            this.Pb_Bill_Img.Size = new System.Drawing.Size(367, 366);
            this.Pb_Bill_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Bill_Img.TabIndex = 25;
            this.Pb_Bill_Img.TabStop = false;
            // 
            // Bill_Image
            // 
            this.Bill_Image.AutoSize = true;
            this.Bill_Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_Image.Location = new System.Drawing.Point(1504, 214);
            this.Bill_Image.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bill_Image.Name = "Bill_Image";
            this.Bill_Image.Size = new System.Drawing.Size(120, 29);
            this.Bill_Image.TabIndex = 24;
            this.Bill_Image.Text = "Bill Image";
            // 
            // frm_View_Expance_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1762, 789);
            this.ControlBox = false;
            this.Controls.Add(this.Pb_Bill_Img);
            this.Controls.Add(this.Bill_Image);
            this.Controls.Add(this.dgv_Expence_View);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_View_Expance_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Expance Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_View_Expance_Details_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expence_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Bill_Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridView dgv_Expence_View;
        private System.Windows.Forms.PictureBox Pb_Bill_Img;
        private System.Windows.Forms.Label Bill_Image;
    }
}