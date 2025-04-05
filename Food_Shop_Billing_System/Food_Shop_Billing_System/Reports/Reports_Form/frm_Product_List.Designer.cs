
namespace Food_Shop_Billing_System.Reports.Reports_Form
{
    partial class frm_Product_List
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
            this.CRV_Product_List = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRV_Product_List
            // 
            this.CRV_Product_List.ActiveViewIndex = -1;
            this.CRV_Product_List.AutoScroll = true;
            this.CRV_Product_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV_Product_List.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV_Product_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV_Product_List.Location = new System.Drawing.Point(0, 0);
            this.CRV_Product_List.Name = "CRV_Product_List";
            this.CRV_Product_List.Size = new System.Drawing.Size(1305, 909);
            this.CRV_Product_List.TabIndex = 0;
            this.CRV_Product_List.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_Product_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 909);
            this.Controls.Add(this.CRV_Product_List);
            this.Name = "frm_Product_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product List";
            this.Load += new System.EventHandler(this.frm_Product_List_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV_Product_List;
    }
}