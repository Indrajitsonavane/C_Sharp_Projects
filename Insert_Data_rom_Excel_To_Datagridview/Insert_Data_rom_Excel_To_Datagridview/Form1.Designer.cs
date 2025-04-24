
namespace Insert_Data_rom_Excel_To_Datagridview
{
    partial class Form1
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
            this.btn_Select_Exel_File = new System.Windows.Forms.Button();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Select_Exel_File
            // 
            this.btn_Select_Exel_File.Location = new System.Drawing.Point(57, 49);
            this.btn_Select_Exel_File.Name = "btn_Select_Exel_File";
            this.btn_Select_Exel_File.Size = new System.Drawing.Size(164, 37);
            this.btn_Select_Exel_File.TabIndex = 0;
            this.btn_Select_Exel_File.Text = "Select Exel File";
            this.btn_Select_Exel_File.UseVisualStyleBackColor = true;
            this.btn_Select_Exel_File.Click += new System.EventHandler(this.btn_Select_Exel_File_Click);
            // 
            // dgv_Data
            // 
            this.dgv_Data.AllowUserToAddRows = false;
            this.dgv_Data.AllowUserToDeleteRows = false;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Location = new System.Drawing.Point(12, 130);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.ReadOnly = true;
            this.dgv_Data.RowHeadersWidth = 51;
            this.dgv_Data.RowTemplate.Height = 24;
            this.dgv_Data.Size = new System.Drawing.Size(1269, 502);
            this.dgv_Data.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 661);
            this.Controls.Add(this.dgv_Data);
            this.Controls.Add(this.btn_Select_Exel_File);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Select_Exel_File;
        private System.Windows.Forms.DataGridView dgv_Data;
    }
}

