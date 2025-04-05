
namespace Food_Shop_Billing_System.Reports.Reports_Form
{
    partial class frm_Customer_Monthly_Sales
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
            this.CRV_Customer_Monthly_Report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRV_Customer_Monthly_Report
            // 
            this.CRV_Customer_Monthly_Report.ActiveViewIndex = -1;
            this.CRV_Customer_Monthly_Report.AutoScroll = true;
            this.CRV_Customer_Monthly_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV_Customer_Monthly_Report.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV_Customer_Monthly_Report.DisplayStatusBar = false;
            this.CRV_Customer_Monthly_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV_Customer_Monthly_Report.Enabled = false;
            this.CRV_Customer_Monthly_Report.Location = new System.Drawing.Point(0, 0);
            this.CRV_Customer_Monthly_Report.Name = "CRV_Customer_Monthly_Report";
            this.CRV_Customer_Monthly_Report.Size = new System.Drawing.Size(1305, 909);
            this.CRV_Customer_Monthly_Report.TabIndex = 0;
            this.CRV_Customer_Monthly_Report.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_Customer_Monthly_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 909);
            this.Controls.Add(this.CRV_Customer_Monthly_Report);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frm_Customer_Monthly_Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Monthly Sales";
            this.Load += new System.EventHandler(this.frm_Customer_Monthly_Sales_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV_Customer_Monthly_Report;
    }
}