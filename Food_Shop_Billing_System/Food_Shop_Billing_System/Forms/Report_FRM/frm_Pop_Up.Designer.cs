
namespace Food_Shop_Billing_System.Forms.Report_FRM
{
    partial class frm_Pop_Up
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
            this.gb_Date = new System.Windows.Forms.GroupBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.dtp_To_dt = new System.Windows.Forms.DateTimePicker();
            this.lbl_To_Date = new System.Windows.Forms.Label();
            this.lbl_From_Date = new System.Windows.Forms.Label();
            this.dtp_From_dt = new System.Windows.Forms.DateTimePicker();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_Date.SuspendLayout();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Date
            // 
            this.gb_Date.BackColor = System.Drawing.Color.White;
            this.gb_Date.Controls.Add(this.btn_Calculate);
            this.gb_Date.Controls.Add(this.dtp_To_dt);
            this.gb_Date.Controls.Add(this.lbl_To_Date);
            this.gb_Date.Controls.Add(this.lbl_From_Date);
            this.gb_Date.Controls.Add(this.dtp_From_dt);
            this.gb_Date.Location = new System.Drawing.Point(39, 95);
            this.gb_Date.Name = "gb_Date";
            this.gb_Date.Size = new System.Drawing.Size(546, 470);
            this.gb_Date.TabIndex = 43;
            this.gb_Date.TabStop = false;
            this.gb_Date.Text = "Report Date";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btn_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.ForeColor = System.Drawing.Color.White;
            this.btn_Calculate.Location = new System.Drawing.Point(125, 287);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(270, 48);
            this.btn_Calculate.TabIndex = 41;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // dtp_To_dt
            // 
            this.dtp_To_dt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_To_dt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_To_dt.Location = new System.Drawing.Point(216, 183);
            this.dtp_To_dt.Name = "dtp_To_dt";
            this.dtp_To_dt.Size = new System.Drawing.Size(265, 32);
            this.dtp_To_dt.TabIndex = 39;
            // 
            // lbl_To_Date
            // 
            this.lbl_To_Date.AutoSize = true;
            this.lbl_To_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_To_Date.Location = new System.Drawing.Point(94, 188);
            this.lbl_To_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_To_Date.Name = "lbl_To_Date";
            this.lbl_To_Date.Size = new System.Drawing.Size(88, 26);
            this.lbl_To_Date.TabIndex = 40;
            this.lbl_To_Date.Text = "To Date";
            // 
            // lbl_From_Date
            // 
            this.lbl_From_Date.AutoSize = true;
            this.lbl_From_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_From_Date.Location = new System.Drawing.Point(77, 92);
            this.lbl_From_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_From_Date.Name = "lbl_From_Date";
            this.lbl_From_Date.Size = new System.Drawing.Size(115, 26);
            this.lbl_From_Date.TabIndex = 37;
            this.lbl_From_Date.Text = "From Date";
            // 
            // dtp_From_dt
            // 
            this.dtp_From_dt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_From_dt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_From_dt.Location = new System.Drawing.Point(216, 88);
            this.dtp_From_dt.Name = "dtp_From_dt";
            this.dtp_From_dt.Size = new System.Drawing.Size(265, 32);
            this.dtp_From_dt.TabIndex = 36;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.pnl_header.Controls.Add(this.lbl_Header);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(630, 75);
            this.pnl_header.TabIndex = 42;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(32, 22);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(540, 39);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "CUSTOMER MONTHLY REPORT";
            // 
            // frm_Pop_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 633);
            this.Controls.Add(this.gb_Date);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Pop_Up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Pop_Up";
            this.Load += new System.EventHandler(this.frm_Pop_Up_Load);
            this.gb_Date.ResumeLayout(false);
            this.gb_Date.PerformLayout();
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Date;
        private System.Windows.Forms.Button btn_Calculate;
        public  System.Windows.Forms.DateTimePicker dtp_To_dt;
        private System.Windows.Forms.Label lbl_To_Date;
        private System.Windows.Forms.Label lbl_From_Date;
        private System.Windows.Forms.DateTimePicker dtp_From_dt;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_Header;
    }
}