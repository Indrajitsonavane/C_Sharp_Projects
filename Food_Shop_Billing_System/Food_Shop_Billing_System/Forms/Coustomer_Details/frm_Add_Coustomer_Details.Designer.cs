
namespace Food_Shop_Billing_System.Forms.Coustomer_Details
{
    partial class frm_Add_Coustomer_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Costomer_Name = new System.Windows.Forms.TextBox();
            this.gb_Add_Product = new System.Windows.Forms.GroupBox();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Unit1 = new System.Windows.Forms.Label();
            this.lbl_Product_Total = new System.Windows.Forms.Label();
            this.tb_Product_Total = new System.Windows.Forms.TextBox();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cmb_Category_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.tb_Sals_Price = new System.Windows.Forms.TextBox();
            this.lbl_Sales_Price = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Coustomer_ID = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_Bill = new System.Windows.Forms.Label();
            this.gb_Order_List = new System.Windows.Forms.GroupBox();
            this.dgv_Order_List = new System.Windows.Forms.DataGridView();
            this.Sr_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sales_Prise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Bill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tb_Final_Bill = new System.Windows.Forms.TextBox();
            this.tb_Discount = new System.Windows.Forms.TextBox();
            this.tb_Total_Bill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Percentage = new System.Windows.Forms.Label();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.gb_Add_Product.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_Order_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order_List)).BeginInit();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(596, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Customer Name";
            // 
            // tb_Costomer_Name
            // 
            this.tb_Costomer_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Costomer_Name.Location = new System.Drawing.Point(801, 17);
            this.tb_Costomer_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Costomer_Name.MaxLength = 80;
            this.tb_Costomer_Name.Name = "tb_Costomer_Name";
            this.tb_Costomer_Name.Size = new System.Drawing.Size(276, 32);
            this.tb_Costomer_Name.TabIndex = 1;
            this.tb_Costomer_Name.TextChanged += new System.EventHandler(this.tb_Costomer_Name_TextChanged);
            // 
            // gb_Add_Product
            // 
            this.gb_Add_Product.BackColor = System.Drawing.Color.White;
            this.gb_Add_Product.Controls.Add(this.lbl_Unit);
            this.gb_Add_Product.Controls.Add(this.lbl_Quantity);
            this.gb_Add_Product.Controls.Add(this.tb_Quantity);
            this.gb_Add_Product.Controls.Add(this.lbl_Unit1);
            this.gb_Add_Product.Controls.Add(this.lbl_Product_Total);
            this.gb_Add_Product.Controls.Add(this.tb_Product_Total);
            this.gb_Add_Product.Controls.Add(this.cmb_Product_Name);
            this.gb_Add_Product.Controls.Add(this.lbl_Product_Name);
            this.gb_Add_Product.Controls.Add(this.btn_Add);
            this.gb_Add_Product.Controls.Add(this.cmb_Category_Name);
            this.gb_Add_Product.Controls.Add(this.lbl_Category_Name);
            this.gb_Add_Product.Controls.Add(this.tb_Sals_Price);
            this.gb_Add_Product.Controls.Add(this.lbl_Sales_Price);
            this.gb_Add_Product.Location = new System.Drawing.Point(22, 169);
            this.gb_Add_Product.Name = "gb_Add_Product";
            this.gb_Add_Product.Size = new System.Drawing.Size(1707, 132);
            this.gb_Add_Product.TabIndex = 4;
            this.gb_Add_Product.TabStop = false;
            this.gb_Add_Product.Text = "Add Product";
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit.Location = new System.Drawing.Point(487, 75);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(57, 26);
            this.lbl_Unit.TabIndex = 32;
            this.lbl_Unit.Text = "(Pic)";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(23, 74);
            this.lbl_Quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(93, 26);
            this.lbl_Quantity.TabIndex = 31;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(205, 72);
            this.tb_Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Quantity.MaxLength = 100;
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(276, 32);
            this.tb_Quantity.TabIndex = 30;
            this.tb_Quantity.TextChanged += new System.EventHandler(this.tb_Quantity_TextChanged);
            // 
            // lbl_Unit1
            // 
            this.lbl_Unit1.AutoSize = true;
            this.lbl_Unit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit1.Location = new System.Drawing.Point(1086, 78);
            this.lbl_Unit1.Name = "lbl_Unit1";
            this.lbl_Unit1.Size = new System.Drawing.Size(57, 26);
            this.lbl_Unit1.TabIndex = 29;
            this.lbl_Unit1.Text = "(Pic)";
            // 
            // lbl_Product_Total
            // 
            this.lbl_Product_Total.AutoSize = true;
            this.lbl_Product_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Total.Location = new System.Drawing.Point(1136, 25);
            this.lbl_Product_Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Product_Total.Name = "lbl_Product_Total";
            this.lbl_Product_Total.Size = new System.Drawing.Size(140, 26);
            this.lbl_Product_Total.TabIndex = 24;
            this.lbl_Product_Total.Text = "Product Total";
            // 
            // tb_Product_Total
            // 
            this.tb_Product_Total.Enabled = false;
            this.tb_Product_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Total.Location = new System.Drawing.Point(1323, 21);
            this.tb_Product_Total.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Product_Total.MaxLength = 100;
            this.tb_Product_Total.Name = "tb_Product_Total";
            this.tb_Product_Total.Size = new System.Drawing.Size(255, 32);
            this.tb_Product_Total.TabIndex = 5;
            this.tb_Product_Total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Product_Total_KeyPress);
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(801, 22);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(276, 34);
            this.cmb_Product_Name.TabIndex = 4;
            this.cmb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_Name_SelectedIndexChanged);
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(613, 25);
            this.lbl_Product_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(152, 26);
            this.lbl_Product_Name.TabIndex = 17;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(1198, 69);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(153, 49);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // cmb_Category_Name
            // 
            this.cmb_Category_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category_Name.FormattingEnabled = true;
            this.cmb_Category_Name.Location = new System.Drawing.Point(204, 21);
            this.cmb_Category_Name.Name = "cmb_Category_Name";
            this.cmb_Category_Name.Size = new System.Drawing.Size(278, 34);
            this.cmb_Category_Name.TabIndex = 3;
            this.cmb_Category_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_name_SelectedIndexChanged);
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Name.Location = new System.Drawing.Point(17, 30);
            this.lbl_Category_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(165, 26);
            this.lbl_Category_Name.TabIndex = 6;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // tb_Sals_Price
            // 
            this.tb_Sals_Price.Enabled = false;
            this.tb_Sals_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sals_Price.Location = new System.Drawing.Point(801, 77);
            this.tb_Sals_Price.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Sals_Price.MaxLength = 5;
            this.tb_Sals_Price.Name = "tb_Sals_Price";
            this.tb_Sals_Price.Size = new System.Drawing.Size(276, 32);
            this.tb_Sals_Price.TabIndex = 6;
            this.tb_Sals_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Seals_Price_KeyPress);
            // 
            // lbl_Sales_Price
            // 
            this.lbl_Sales_Price.AutoSize = true;
            this.lbl_Sales_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sales_Price.Location = new System.Drawing.Point(596, 80);
            this.lbl_Sales_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Sales_Price.Name = "lbl_Sales_Price";
            this.lbl_Sales_Price.Size = new System.Drawing.Size(123, 26);
            this.lbl_Sales_Price.TabIndex = 6;
            this.lbl_Sales_Price.Text = "Sales Price";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(1323, 16);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(255, 30);
            this.dtp_Date.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1181, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Customer ID";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.dtp_Date);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_Coustomer_ID);
            this.groupBox1.Controls.Add(this.tb_Costomer_Name);
            this.groupBox1.Location = new System.Drawing.Point(22, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1707, 65);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Product";
            // 
            // tb_Coustomer_ID
            // 
            this.tb_Coustomer_ID.Enabled = false;
            this.tb_Coustomer_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Coustomer_ID.Location = new System.Drawing.Point(206, 19);
            this.tb_Coustomer_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Coustomer_ID.MaxLength = 5;
            this.tb_Coustomer_ID.Name = "tb_Coustomer_ID";
            this.tb_Coustomer_ID.Size = new System.Drawing.Size(276, 32);
            this.tb_Coustomer_ID.TabIndex = 1;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(247, 379);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(149, 54);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(25, 379);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(149, 54);
            this.btn_Refresh.TabIndex = 9;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // lbl_Bill
            // 
            this.lbl_Bill.AutoSize = true;
            this.lbl_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bill.Location = new System.Drawing.Point(1293, 387);
            this.lbl_Bill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Bill.Name = "lbl_Bill";
            this.lbl_Bill.Size = new System.Drawing.Size(95, 26);
            this.lbl_Bill.TabIndex = 17;
            this.lbl_Bill.Text = "Final Bill";
            // 
            // gb_Order_List
            // 
            this.gb_Order_List.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_Order_List.Controls.Add(this.dgv_Order_List);
            this.gb_Order_List.Controls.Add(this.tb_Final_Bill);
            this.gb_Order_List.Controls.Add(this.tb_Discount);
            this.gb_Order_List.Controls.Add(this.tb_Total_Bill);
            this.gb_Order_List.Controls.Add(this.label1);
            this.gb_Order_List.Controls.Add(this.lbl_Percentage);
            this.gb_Order_List.Controls.Add(this.lbl_Discount);
            this.gb_Order_List.Controls.Add(this.btn_Save);
            this.gb_Order_List.Controls.Add(this.btn_Refresh);
            this.gb_Order_List.Controls.Add(this.lbl_Bill);
            this.gb_Order_List.ForeColor = System.Drawing.Color.Black;
            this.gb_Order_List.Location = new System.Drawing.Point(22, 311);
            this.gb_Order_List.Name = "gb_Order_List";
            this.gb_Order_List.Size = new System.Drawing.Size(1707, 456);
            this.gb_Order_List.TabIndex = 26;
            this.gb_Order_List.TabStop = false;
            this.gb_Order_List.Text = "Order List";
            // 
            // dgv_Order_List
            // 
            this.dgv_Order_List.AllowUserToAddRows = false;
            this.dgv_Order_List.AllowUserToDeleteRows = false;
            this.dgv_Order_List.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Order_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Order_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Order_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sr_No,
            this.Product_Name,
            this.Sales_Prise,
            this.Quantity,
            this.Total_Bill,
            this.Delete});
            this.dgv_Order_List.Location = new System.Drawing.Point(39, 21);
            this.dgv_Order_List.Name = "dgv_Order_List";
            this.dgv_Order_List.ReadOnly = true;
            this.dgv_Order_List.RowHeadersWidth = 51;
            this.dgv_Order_List.RowTemplate.Height = 24;
            this.dgv_Order_List.Size = new System.Drawing.Size(1624, 326);
            this.dgv_Order_List.TabIndex = 22;
            this.dgv_Order_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Order_List_CellContentClick);
            // 
            // Sr_No
            // 
            this.Sr_No.HeaderText = "Sr.No";
            this.Sr_No.MinimumWidth = 6;
            this.Sr_No.Name = "Sr_No";
            this.Sr_No.ReadOnly = true;
            this.Sr_No.Width = 125;
            // 
            // Product_Name
            // 
            this.Product_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_Name.HeaderText = "Product Name";
            this.Product_Name.MinimumWidth = 6;
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            // 
            // Sales_Prise
            // 
            this.Sales_Prise.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sales_Prise.HeaderText = "Sale Price";
            this.Sales_Prise.MinimumWidth = 6;
            this.Sales_Prise.Name = "Sales_Prise";
            this.Sales_Prise.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 105;
            // 
            // Total_Bill
            // 
            this.Total_Bill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total_Bill.HeaderText = "Total Bill";
            this.Total_Bill.MinimumWidth = 6;
            this.Total_Bill.Name = "Total_Bill";
            this.Total_Bill.ReadOnly = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.Width = 125;
            // 
            // tb_Final_Bill
            // 
            this.tb_Final_Bill.Enabled = false;
            this.tb_Final_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Final_Bill.Location = new System.Drawing.Point(1396, 379);
            this.tb_Final_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Final_Bill.MaxLength = 10;
            this.tb_Final_Bill.Name = "tb_Final_Bill";
            this.tb_Final_Bill.Size = new System.Drawing.Size(179, 43);
            this.tb_Final_Bill.TabIndex = 21;
            // 
            // tb_Discount
            // 
            this.tb_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Discount.Location = new System.Drawing.Point(1055, 380);
            this.tb_Discount.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Discount.MaxLength = 10;
            this.tb_Discount.Name = "tb_Discount";
            this.tb_Discount.Size = new System.Drawing.Size(179, 43);
            this.tb_Discount.TabIndex = 7;
            this.tb_Discount.TextChanged += new System.EventHandler(this.tb_Discount_TextChanged);
            // 
            // tb_Total_Bill
            // 
            this.tb_Total_Bill.Enabled = false;
            this.tb_Total_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Bill.Location = new System.Drawing.Point(743, 381);
            this.tb_Total_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Total_Bill.MaxLength = 10;
            this.tb_Total_Bill.Name = "tb_Total_Bill";
            this.tb_Total_Bill.Size = new System.Drawing.Size(179, 43);
            this.tb_Total_Bill.TabIndex = 21;
            this.tb_Total_Bill.TextChanged += new System.EventHandler(this.tb_Total_Bill_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(641, 388);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Total Bill";
            // 
            // lbl_Percentage
            // 
            this.lbl_Percentage.AutoSize = true;
            this.lbl_Percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Percentage.Location = new System.Drawing.Point(1249, 389);
            this.lbl_Percentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Percentage.Name = "lbl_Percentage";
            this.lbl_Percentage.Size = new System.Drawing.Size(35, 29);
            this.lbl_Percentage.TabIndex = 19;
            this.lbl_Percentage.Text = "%";
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.Location = new System.Drawing.Point(947, 389);
            this.lbl_Discount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(97, 26);
            this.lbl_Discount.TabIndex = 19;
            this.lbl_Discount.Text = "Discount";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(613, 13);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(429, 58);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "ADD CUSTOMER";
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.pnl_header.Controls.Add(this.lbl_Header);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1762, 80);
            this.pnl_header.TabIndex = 25;
            // 
            // frm_Add_Coustomer_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1762, 789);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Add_Product);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_Order_List);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Add_Coustomer_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Coustomer Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_Coustomer_Details_Load);
            this.gb_Add_Product.ResumeLayout(false);
            this.gb_Add_Product.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_Order_List.ResumeLayout(false);
            this.gb_Order_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order_List)).EndInit();
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Costomer_Name;
        private System.Windows.Forms.GroupBox gb_Add_Product;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.ComboBox cmb_Category_Name;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.Label lbl_Sales_Price;
        private System.Windows.Forms.TextBox tb_Sals_Price;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Coustomer_ID;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Bill;
        private System.Windows.Forms.GroupBox gb_Order_List;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.Label lbl_Percentage;
        private System.Windows.Forms.Label lbl_Product_Total;
        private System.Windows.Forms.TextBox tb_Product_Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Final_Bill;
        private System.Windows.Forms.TextBox tb_Discount;
        private System.Windows.Forms.TextBox tb_Total_Bill;
        private System.Windows.Forms.DataGridView dgv_Order_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sr_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales_Prise;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Bill;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label lbl_Unit1;
        private System.Windows.Forms.Label lbl_Unit;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox tb_Quantity;
    }
}