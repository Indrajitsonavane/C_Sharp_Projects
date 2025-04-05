
namespace Food_Shop_Billing_System.Forms.Payment_Details
{
    partial class frm_Payment_Details
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
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_Add_Payments = new System.Windows.Forms.GroupBox();
            this.cmb_Merchant_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Merchant_Name = new System.Windows.Forms.Label();
            this.tb_Remening_Bill = new System.Windows.Forms.TextBox();
            this.lbl_Remening_Bill = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.cmb_Payment_Mode = new System.Windows.Forms.ComboBox();
            this.lbl_Payment_Date = new System.Windows.Forms.Label();
            this.tb_T_Remening_Bill = new System.Windows.Forms.TextBox();
            this.lbl_T_Remening_Bill = new System.Windows.Forms.Label();
            this.tb_Payment_Id = new System.Windows.Forms.TextBox();
            this.dtp_Payment_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Payment_Mode = new System.Windows.Forms.Label();
            this.tb_paid_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Paid_Amount = new System.Windows.Forms.Label();
            this.lbl_payment_Id = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            this.gb_Add_Payments.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.pnl_header.Controls.Add(this.lbl_Header);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1762, 100);
            this.pnl_header.TabIndex = 14;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(526, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(580, 76);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = " ADD PAYMENTS";
            // 
            // gb_Add_Payments
            // 
            this.gb_Add_Payments.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_Add_Payments.Controls.Add(this.cmb_Merchant_Name);
            this.gb_Add_Payments.Controls.Add(this.lbl_Date);
            this.gb_Add_Payments.Controls.Add(this.dtp_Date);
            this.gb_Add_Payments.Controls.Add(this.lbl_Merchant_Name);
            this.gb_Add_Payments.Controls.Add(this.tb_Remening_Bill);
            this.gb_Add_Payments.Controls.Add(this.lbl_Remening_Bill);
            this.gb_Add_Payments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Add_Payments.Location = new System.Drawing.Point(27, 124);
            this.gb_Add_Payments.Name = "gb_Add_Payments";
            this.gb_Add_Payments.Size = new System.Drawing.Size(1696, 92);
            this.gb_Add_Payments.TabIndex = 13;
            this.gb_Add_Payments.TabStop = false;
            this.gb_Add_Payments.Text = "Add Payments";
            // 
            // cmb_Merchant_Name
            // 
            this.cmb_Merchant_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Merchant_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Merchant_Name.FormattingEnabled = true;
            this.cmb_Merchant_Name.Location = new System.Drawing.Point(242, 31);
            this.cmb_Merchant_Name.Name = "cmb_Merchant_Name";
            this.cmb_Merchant_Name.Size = new System.Drawing.Size(262, 34);
            this.cmb_Merchant_Name.TabIndex = 1;
            this.cmb_Merchant_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Merchant_Name_SelectedIndexChanged);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(1199, 31);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(58, 26);
            this.lbl_Date.TabIndex = 19;
            this.lbl_Date.Text = "Date";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Enabled = false;
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(1302, 28);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(256, 30);
            this.dtp_Date.TabIndex = 18;
            // 
            // lbl_Merchant_Name
            // 
            this.lbl_Merchant_Name.AutoSize = true;
            this.lbl_Merchant_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Merchant_Name.Location = new System.Drawing.Point(30, 33);
            this.lbl_Merchant_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Merchant_Name.Name = "lbl_Merchant_Name";
            this.lbl_Merchant_Name.Size = new System.Drawing.Size(193, 29);
            this.lbl_Merchant_Name.TabIndex = 6;
            this.lbl_Merchant_Name.Text = "Merchant Name";
            // 
            // tb_Remening_Bill
            // 
            this.tb_Remening_Bill.Enabled = false;
            this.tb_Remening_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Remening_Bill.Location = new System.Drawing.Point(826, 29);
            this.tb_Remening_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Remening_Bill.MaxLength = 40;
            this.tb_Remening_Bill.Name = "tb_Remening_Bill";
            this.tb_Remening_Bill.Size = new System.Drawing.Size(282, 36);
            this.tb_Remening_Bill.TabIndex = 2;
            // 
            // lbl_Remening_Bill
            // 
            this.lbl_Remening_Bill.AutoSize = true;
            this.lbl_Remening_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Remening_Bill.Location = new System.Drawing.Point(607, 33);
            this.lbl_Remening_Bill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Remening_Bill.Name = "lbl_Remening_Bill";
            this.lbl_Remening_Bill.Size = new System.Drawing.Size(171, 29);
            this.lbl_Remening_Bill.TabIndex = 6;
            this.lbl_Remening_Bill.Text = "Remening Bill";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.btn_Refresh);
            this.groupBox1.Controls.Add(this.cmb_Payment_Mode);
            this.groupBox1.Controls.Add(this.lbl_Payment_Date);
            this.groupBox1.Controls.Add(this.tb_T_Remening_Bill);
            this.groupBox1.Controls.Add(this.lbl_T_Remening_Bill);
            this.groupBox1.Controls.Add(this.tb_Payment_Id);
            this.groupBox1.Controls.Add(this.dtp_Payment_Date);
            this.groupBox1.Controls.Add(this.lbl_Payment_Mode);
            this.groupBox1.Controls.Add(this.tb_paid_Amount);
            this.groupBox1.Controls.Add(this.lbl_Paid_Amount);
            this.groupBox1.Controls.Add(this.lbl_payment_Id);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(87, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1591, 497);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Payments";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(835, 394);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(141, 55);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(536, 393);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(143, 59);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // cmb_Payment_Mode
            // 
            this.cmb_Payment_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Payment_Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Payment_Mode.FormattingEnabled = true;
            this.cmb_Payment_Mode.Items.AddRange(new object[] {
            "UPI",
            "NEFT",
            "Net Banking"});
            this.cmb_Payment_Mode.Location = new System.Drawing.Point(1116, 160);
            this.cmb_Payment_Mode.Name = "cmb_Payment_Mode";
            this.cmb_Payment_Mode.Size = new System.Drawing.Size(264, 34);
            this.cmb_Payment_Mode.TabIndex = 4;
            // 
            // lbl_Payment_Date
            // 
            this.lbl_Payment_Date.AutoSize = true;
            this.lbl_Payment_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment_Date.Location = new System.Drawing.Point(880, 73);
            this.lbl_Payment_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Payment_Date.Name = "lbl_Payment_Date";
            this.lbl_Payment_Date.Size = new System.Drawing.Size(174, 29);
            this.lbl_Payment_Date.TabIndex = 19;
            this.lbl_Payment_Date.Text = "Payment Date";
            // 
            // tb_T_Remening_Bill
            // 
            this.tb_T_Remening_Bill.Enabled = false;
            this.tb_T_Remening_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_T_Remening_Bill.Location = new System.Drawing.Point(420, 272);
            this.tb_T_Remening_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.tb_T_Remening_Bill.MaxLength = 40;
            this.tb_T_Remening_Bill.Name = "tb_T_Remening_Bill";
            this.tb_T_Remening_Bill.Size = new System.Drawing.Size(255, 36);
            this.tb_T_Remening_Bill.TabIndex = 2;
            // 
            // lbl_T_Remening_Bill
            // 
            this.lbl_T_Remening_Bill.AutoSize = true;
            this.lbl_T_Remening_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_T_Remening_Bill.Location = new System.Drawing.Point(190, 273);
            this.lbl_T_Remening_Bill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_T_Remening_Bill.Name = "lbl_T_Remening_Bill";
            this.lbl_T_Remening_Bill.Size = new System.Drawing.Size(171, 29);
            this.lbl_T_Remening_Bill.TabIndex = 6;
            this.lbl_T_Remening_Bill.Text = "Remening Bill";
            // 
            // tb_Payment_Id
            // 
            this.tb_Payment_Id.Enabled = false;
            this.tb_Payment_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Payment_Id.Location = new System.Drawing.Point(422, 80);
            this.tb_Payment_Id.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Payment_Id.MaxLength = 5;
            this.tb_Payment_Id.Name = "tb_Payment_Id";
            this.tb_Payment_Id.Size = new System.Drawing.Size(249, 36);
            this.tb_Payment_Id.TabIndex = 1;
            // 
            // dtp_Payment_Date
            // 
            this.dtp_Payment_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Payment_Date.Location = new System.Drawing.Point(1116, 73);
            this.dtp_Payment_Date.Name = "dtp_Payment_Date";
            this.dtp_Payment_Date.Size = new System.Drawing.Size(262, 30);
            this.dtp_Payment_Date.TabIndex = 3;
            // 
            // lbl_Payment_Mode
            // 
            this.lbl_Payment_Mode.AutoSize = true;
            this.lbl_Payment_Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment_Mode.Location = new System.Drawing.Point(880, 161);
            this.lbl_Payment_Mode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Payment_Mode.Name = "lbl_Payment_Mode";
            this.lbl_Payment_Mode.Size = new System.Drawing.Size(184, 29);
            this.lbl_Payment_Mode.TabIndex = 6;
            this.lbl_Payment_Mode.Text = "Payment Mode";
            // 
            // tb_paid_Amount
            // 
            this.tb_paid_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_paid_Amount.Location = new System.Drawing.Point(422, 177);
            this.tb_paid_Amount.Margin = new System.Windows.Forms.Padding(4);
            this.tb_paid_Amount.MaxLength = 40;
            this.tb_paid_Amount.Name = "tb_paid_Amount";
            this.tb_paid_Amount.Size = new System.Drawing.Size(255, 36);
            this.tb_paid_Amount.TabIndex = 2;
            this.tb_paid_Amount.TextChanged += new System.EventHandler(this.tb_paid_Amount_TextChanged);
            this.tb_paid_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_paid_Amount_KeyPress);
            // 
            // lbl_Paid_Amount
            // 
            this.lbl_Paid_Amount.AutoSize = true;
            this.lbl_Paid_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Paid_Amount.Location = new System.Drawing.Point(192, 177);
            this.lbl_Paid_Amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Paid_Amount.Name = "lbl_Paid_Amount";
            this.lbl_Paid_Amount.Size = new System.Drawing.Size(159, 29);
            this.lbl_Paid_Amount.TabIndex = 6;
            this.lbl_Paid_Amount.Text = "Paid Amount";
            // 
            // lbl_payment_Id
            // 
            this.lbl_payment_Id.AutoSize = true;
            this.lbl_payment_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_payment_Id.Location = new System.Drawing.Point(196, 82);
            this.lbl_payment_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_payment_Id.Name = "lbl_payment_Id";
            this.lbl_payment_Id.Size = new System.Drawing.Size(138, 29);
            this.lbl_payment_Id.TabIndex = 6;
            this.lbl_payment_Id.Text = "payment Id";
            // 
            // frm_Payment_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1762, 789);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.gb_Add_Payments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Payment_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment_Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Payment_Details_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.gb_Add_Payments.ResumeLayout(false);
            this.gb_Add_Payments.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gb_Add_Payments;
        private System.Windows.Forms.Label lbl_Merchant_Name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Payment_Id;
        private System.Windows.Forms.Label lbl_payment_Id;
        private System.Windows.Forms.Label lbl_Payment_Date;
        private System.Windows.Forms.DateTimePicker dtp_Payment_Date;
        private System.Windows.Forms.TextBox tb_paid_Amount;
        private System.Windows.Forms.Label lbl_Paid_Amount;
        private System.Windows.Forms.TextBox tb_Remening_Bill;
        private System.Windows.Forms.Label lbl_Remening_Bill;
        private System.Windows.Forms.Label lbl_Payment_Mode;
        private System.Windows.Forms.ComboBox cmb_Payment_Mode;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ComboBox cmb_Merchant_Name;
        private System.Windows.Forms.TextBox tb_T_Remening_Bill;
        private System.Windows.Forms.Label lbl_T_Remening_Bill;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dtp_Date;
    }
}