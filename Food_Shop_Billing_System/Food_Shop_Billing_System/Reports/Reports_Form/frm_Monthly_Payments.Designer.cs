
namespace Food_Shop_Billing_System.Reports.Reports_Form
{
    partial class frm_Monthly_Payments
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
            this.CRV_Monthly_Payments = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRV_Monthly_Payments
            // 
            this.CRV_Monthly_Payments.ActiveViewIndex = -1;
            this.CRV_Monthly_Payments.AutoScroll = true;
            this.CRV_Monthly_Payments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV_Monthly_Payments.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV_Monthly_Payments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV_Monthly_Payments.Location = new System.Drawing.Point(0, 0);
            this.CRV_Monthly_Payments.Name = "CRV_Monthly_Payments";
            this.CRV_Monthly_Payments.Size = new System.Drawing.Size(1305, 909);
            this.CRV_Monthly_Payments.TabIndex = 0;
            this.CRV_Monthly_Payments.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_Monthly_Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 909);
            this.Controls.Add(this.CRV_Monthly_Payments);
            this.Name = "frm_Monthly_Payments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Payments";
            this.Load += new System.EventHandler(this.frm_Monthly_Payments_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV_Monthly_Payments;
    }
}