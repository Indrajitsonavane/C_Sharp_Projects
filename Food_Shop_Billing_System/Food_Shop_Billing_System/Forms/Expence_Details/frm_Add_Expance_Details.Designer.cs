
namespace Food_Shop_Billing_System.Forms.Expence_Details
{
    partial class frm_Add_Expance_Details
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
            this.Pb_Bill_Img = new System.Windows.Forms.PictureBox();
            this.Bill_Image = new System.Windows.Forms.Label();
            this.lbl_Paid_by = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.lbl_Expnce_Details = new System.Windows.Forms.Label();
            this.lbl_Expence_ID = new System.Windows.Forms.Label();
            this.tb_Amount = new System.Windows.Forms.TextBox();
            this.tb_Expance_Details = new System.Windows.Forms.TextBox();
            this.tb_Expance_ID = new System.Windows.Forms.TextBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Details = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_Add_Expence = new System.Windows.Forms.GroupBox();
            this.cmb_Staff_Name = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Bill_Img)).BeginInit();
            this.lbl_Details.SuspendLayout();
            this.gb_Add_Expence.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pb_Bill_Img
            // 
            this.Pb_Bill_Img.BackColor = System.Drawing.SystemColors.Control;
            this.Pb_Bill_Img.Location = new System.Drawing.Point(1069, 98);
            this.Pb_Bill_Img.Name = "Pb_Bill_Img";
            this.Pb_Bill_Img.Size = new System.Drawing.Size(351, 273);
            this.Pb_Bill_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Bill_Img.TabIndex = 18;
            this.Pb_Bill_Img.TabStop = false;
            this.Pb_Bill_Img.Click += new System.EventHandler(this.Pb_Bill_Img_Click);
            // 
            // Bill_Image
            // 
            this.Bill_Image.AutoSize = true;
            this.Bill_Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_Image.Location = new System.Drawing.Point(892, 118);
            this.Bill_Image.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bill_Image.Name = "Bill_Image";
            this.Bill_Image.Size = new System.Drawing.Size(120, 29);
            this.Bill_Image.TabIndex = 17;
            this.Bill_Image.Text = "Bill Image";
            // 
            // lbl_Paid_by
            // 
            this.lbl_Paid_by.AutoSize = true;
            this.lbl_Paid_by.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Paid_by.Location = new System.Drawing.Point(909, 386);
            this.lbl_Paid_by.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Paid_by.Name = "lbl_Paid_by";
            this.lbl_Paid_by.Size = new System.Drawing.Size(93, 29);
            this.lbl_Paid_by.TabIndex = 17;
            this.lbl_Paid_by.Text = "Paid by";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount.Location = new System.Drawing.Point(230, 340);
            this.lbl_Amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(94, 29);
            this.lbl_Amount.TabIndex = 17;
            this.lbl_Amount.Text = "Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1658, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 26);
            this.label8.TabIndex = 17;
            this.label8.Text = "Expence ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1631, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Expence ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1704, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Expence ID";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(892, 35);
            this.Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(63, 29);
            this.Date.TabIndex = 17;
            this.Date.Text = "Date";
            // 
            // lbl_Expnce_Details
            // 
            this.lbl_Expnce_Details.AutoSize = true;
            this.lbl_Expnce_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expnce_Details.Location = new System.Drawing.Point(230, 132);
            this.lbl_Expnce_Details.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Expnce_Details.Name = "lbl_Expnce_Details";
            this.lbl_Expnce_Details.Size = new System.Drawing.Size(187, 29);
            this.lbl_Expnce_Details.TabIndex = 17;
            this.lbl_Expnce_Details.Text = "Expence Details";
            // 
            // lbl_Expence_ID
            // 
            this.lbl_Expence_ID.AutoSize = true;
            this.lbl_Expence_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expence_ID.Location = new System.Drawing.Point(230, 45);
            this.lbl_Expence_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Expence_ID.Name = "lbl_Expence_ID";
            this.lbl_Expence_ID.Size = new System.Drawing.Size(136, 29);
            this.lbl_Expence_ID.TabIndex = 17;
            this.lbl_Expence_ID.Text = "Expence ID";
            // 
            // tb_Amount
            // 
            this.tb_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Amount.Location = new System.Drawing.Point(426, 337);
            this.tb_Amount.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Amount.MaxLength = 10;
            this.tb_Amount.Name = "tb_Amount";
            this.tb_Amount.Size = new System.Drawing.Size(307, 34);
            this.tb_Amount.TabIndex = 2;
            // 
            // tb_Expance_Details
            // 
            this.tb_Expance_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Expance_Details.Location = new System.Drawing.Point(426, 132);
            this.tb_Expance_Details.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Expance_Details.MaxLength = 120;
            this.tb_Expance_Details.Multiline = true;
            this.tb_Expance_Details.Name = "tb_Expance_Details";
            this.tb_Expance_Details.Size = new System.Drawing.Size(307, 145);
            this.tb_Expance_Details.TabIndex = 1;
            // 
            // tb_Expance_ID
            // 
            this.tb_Expance_ID.Enabled = false;
            this.tb_Expance_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Expance_ID.Location = new System.Drawing.Point(426, 45);
            this.tb_Expance_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Expance_ID.MaxLength = 5;
            this.tb_Expance_ID.Name = "tb_Expance_ID";
            this.tb_Expance_ID.Size = new System.Drawing.Size(307, 34);
            this.tb_Expance_ID.TabIndex = 2;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(1069, 35);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(270, 34);
            this.dtp_Date.TabIndex = 5;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(442, 435);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(149, 54);
            this.btn_Submit.TabIndex = 7;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Details
            // 
            this.lbl_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.lbl_Details.Controls.Add(this.lbl_Header);
            this.lbl_Details.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Details.Location = new System.Drawing.Point(0, 0);
            this.lbl_Details.Name = "lbl_Details";
            this.lbl_Details.Size = new System.Drawing.Size(1637, 100);
            this.lbl_Details.TabIndex = 14;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(478, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(721, 76);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "ADD SHOP EXPENCE";
            // 
            // gb_Add_Expence
            // 
            this.gb_Add_Expence.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_Add_Expence.Controls.Add(this.cmb_Staff_Name);
            this.gb_Add_Expence.Controls.Add(this.Pb_Bill_Img);
            this.gb_Add_Expence.Controls.Add(this.Bill_Image);
            this.gb_Add_Expence.Controls.Add(this.lbl_Paid_by);
            this.gb_Add_Expence.Controls.Add(this.lbl_Amount);
            this.gb_Add_Expence.Controls.Add(this.label8);
            this.gb_Add_Expence.Controls.Add(this.label6);
            this.gb_Add_Expence.Controls.Add(this.label4);
            this.gb_Add_Expence.Controls.Add(this.Date);
            this.gb_Add_Expence.Controls.Add(this.lbl_Expnce_Details);
            this.gb_Add_Expence.Controls.Add(this.lbl_Expence_ID);
            this.gb_Add_Expence.Controls.Add(this.tb_Amount);
            this.gb_Add_Expence.Controls.Add(this.tb_Expance_Details);
            this.gb_Add_Expence.Controls.Add(this.tb_Expance_ID);
            this.gb_Add_Expence.Controls.Add(this.dtp_Date);
            this.gb_Add_Expence.Controls.Add(this.btn_Submit);
            this.gb_Add_Expence.Controls.Add(this.btn_Refresh);
            this.gb_Add_Expence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Add_Expence.Location = new System.Drawing.Point(49, 133);
            this.gb_Add_Expence.Name = "gb_Add_Expence";
            this.gb_Add_Expence.Size = new System.Drawing.Size(1497, 526);
            this.gb_Add_Expence.TabIndex = 1;
            this.gb_Add_Expence.TabStop = false;
            this.gb_Add_Expence.Text = "Add Expence";
            // 
            // cmb_Staff_Name
            // 
            this.cmb_Staff_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Staff_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Staff_Name.FormattingEnabled = true;
            this.cmb_Staff_Name.Location = new System.Drawing.Point(1070, 386);
            this.cmb_Staff_Name.Name = "cmb_Staff_Name";
            this.cmb_Staff_Name.Size = new System.Drawing.Size(276, 37);
            this.cmb_Staff_Name.TabIndex = 5;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(113, 435);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(149, 54);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Add_Expance_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1637, 710);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Details);
            this.Controls.Add(this.gb_Add_Expence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Add_Expance_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Expance Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_Expance_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Bill_Img)).EndInit();
            this.lbl_Details.ResumeLayout(false);
            this.lbl_Details.PerformLayout();
            this.gb_Add_Expence.ResumeLayout(false);
            this.gb_Add_Expence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb_Bill_Img;
        private System.Windows.Forms.Label Bill_Image;
        private System.Windows.Forms.Label lbl_Paid_by;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label lbl_Expnce_Details;
        private System.Windows.Forms.Label lbl_Expence_ID;
        private System.Windows.Forms.TextBox tb_Amount;
        private System.Windows.Forms.TextBox tb_Expance_Details;
        private System.Windows.Forms.TextBox tb_Expance_ID;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Panel lbl_Details;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gb_Add_Expence;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ComboBox cmb_Staff_Name;
    }
}