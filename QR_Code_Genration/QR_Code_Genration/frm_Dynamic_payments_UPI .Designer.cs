
namespace QR_Code_Genration
{
    partial class frm_Dynamic_Payments_UPI
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
            this.pb_QRCODE = new System.Windows.Forms.PictureBox();
            this.btn_Genrate_QR = new System.Windows.Forms.Button();
            this.tb_upi_id = new System.Windows.Forms.TextBox();
            this.tb_Amount = new System.Windows.Forms.TextBox();
            this.lbl_upi_id = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_Devlper = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QRCODE)).BeginInit();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_QRCODE
            // 
            this.pb_QRCODE.Location = new System.Drawing.Point(69, 125);
            this.pb_QRCODE.Name = "pb_QRCODE";
            this.pb_QRCODE.Size = new System.Drawing.Size(615, 327);
            this.pb_QRCODE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_QRCODE.TabIndex = 0;
            this.pb_QRCODE.TabStop = false;
            // 
            // btn_Genrate_QR
            // 
            this.btn_Genrate_QR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Genrate_QR.Location = new System.Drawing.Point(567, 542);
            this.btn_Genrate_QR.Name = "btn_Genrate_QR";
            this.btn_Genrate_QR.Size = new System.Drawing.Size(131, 54);
            this.btn_Genrate_QR.TabIndex = 1;
            this.btn_Genrate_QR.Text = "Genrate QR";
            this.btn_Genrate_QR.UseVisualStyleBackColor = true;
            this.btn_Genrate_QR.Click += new System.EventHandler(this.btn_Genrate_QR_Click);
            // 
            // tb_upi_id
            // 
            this.tb_upi_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_upi_id.Location = new System.Drawing.Point(203, 498);
            this.tb_upi_id.Name = "tb_upi_id";
            this.tb_upi_id.Size = new System.Drawing.Size(323, 36);
            this.tb_upi_id.TabIndex = 2;
            this.tb_upi_id.Text = "indrajitsonavane1@oksbi";
            // 
            // tb_Amount
            // 
            this.tb_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Amount.Location = new System.Drawing.Point(203, 626);
            this.tb_Amount.Name = "tb_Amount";
            this.tb_Amount.Size = new System.Drawing.Size(323, 36);
            this.tb_Amount.TabIndex = 2;
            // 
            // lbl_upi_id
            // 
            this.lbl_upi_id.AutoSize = true;
            this.lbl_upi_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_upi_id.Location = new System.Drawing.Point(102, 505);
            this.lbl_upi_id.Name = "lbl_upi_id";
            this.lbl_upi_id.Size = new System.Drawing.Size(68, 25);
            this.lbl_upi_id.TabIndex = 3;
            this.lbl_upi_id.Text = "UPI ID";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount.Location = new System.Drawing.Point(102, 633);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(80, 25);
            this.lbl_Amount.TabIndex = 3;
            this.lbl_Amount.Text = "Amount";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(203, 565);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(323, 36);
            this.tb_name.TabIndex = 2;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(109, 565);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(64, 25);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Name";
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnl_header.Controls.Add(this.lbl_header);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(745, 100);
            this.pnl_header.TabIndex = 4;
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.White;
            this.lbl_header.Location = new System.Drawing.Point(167, 25);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(404, 48);
            this.lbl_header.TabIndex = 3;
            this.lbl_header.Text = " UPI PAYMENT QR";
            // 
            // lbl_Devlper
            // 
            this.lbl_Devlper.AutoSize = true;
            this.lbl_Devlper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Devlper.Location = new System.Drawing.Point(21, 711);
            this.lbl_Devlper.Name = "lbl_Devlper";
            this.lbl_Devlper.Size = new System.Drawing.Size(159, 25);
            this.lbl_Devlper.TabIndex = 3;
            this.lbl_Devlper.Text = "Devloped By = \"\"";
            // 
            // frm_Dynamic_Payments_UPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 745);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.lbl_Devlper);
            this.Controls.Add(this.lbl_upi_id);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_Amount);
            this.Controls.Add(this.tb_upi_id);
            this.Controls.Add(this.btn_Genrate_QR);
            this.Controls.Add(this.pb_QRCODE);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Dynamic_Payments_UPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dynamic Payments UPI QR";
            ((System.ComponentModel.ISupportInitialize)(this.pb_QRCODE)).EndInit();
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_QRCODE;
        private System.Windows.Forms.Button btn_Genrate_QR;
        private System.Windows.Forms.TextBox tb_upi_id;
        private System.Windows.Forms.TextBox tb_Amount;
        private System.Windows.Forms.Label lbl_upi_id;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_Devlper;
    }
}

