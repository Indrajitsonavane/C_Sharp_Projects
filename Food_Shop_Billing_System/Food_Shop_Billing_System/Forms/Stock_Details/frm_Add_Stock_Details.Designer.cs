
namespace Food_Shop_Billing_System.Forms.Stock_Details
{
    partial class frm_Add_Recived_Order
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
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.cmb_Category_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.tb_Purchase_Price = new System.Windows.Forms.TextBox();
            this.lbl_Purchase_Price = new System.Windows.Forms.Label();
            this.tb_Sales_Price = new System.Windows.Forms.TextBox();
            this.lbl_Seals_Price = new System.Windows.Forms.Label();
            this.dgv_Order_List = new System.Windows.Forms.DataGridView();
            this.Sr_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Merchant_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase_Prise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sales_Prise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Bill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_Order_List = new System.Windows.Forms.GroupBox();
            this.lbl_Total_Bill = new System.Windows.Forms.Label();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.gb_Add_Product = new System.Windows.Forms.GroupBox();
            this.lbl_Unit1 = new System.Windows.Forms.Label();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.lbl_Product_Total_Bill = new System.Windows.Forms.Label();
            this.tb_Product_Total_Bill = new System.Windows.Forms.TextBox();
            this.dtp_Order_Date = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tb_order_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Merchant_Name = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order_List)).BeginInit();
            this.gb_Order_List.SuspendLayout();
            this.gb_Add_Product.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.pnl_header.Controls.Add(this.lbl_Header);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1762, 75);
            this.pnl_header.TabIndex = 20;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(639, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(472, 58);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "RECEIVED ORDER";
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Name.Location = new System.Drawing.Point(13, 30);
            this.lbl_Category_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(165, 26);
            this.lbl_Category_Name.TabIndex = 25;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // cmb_Category_Name
            // 
            this.cmb_Category_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category_Name.FormattingEnabled = true;
            this.cmb_Category_Name.Location = new System.Drawing.Point(200, 25);
            this.cmb_Category_Name.Name = "cmb_Category_Name";
            this.cmb_Category_Name.Size = new System.Drawing.Size(263, 34);
            this.cmb_Category_Name.TabIndex = 2;
            this.cmb_Category_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_Name_SelectedIndexChanged);
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(593, 79);
            this.lbl_Quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(93, 26);
            this.lbl_Quantity.TabIndex = 22;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.Enabled = false;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(755, 32);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(261, 34);
            this.cmb_Product_Name.TabIndex = 3;
            this.cmb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_Name_SelectedIndexChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(1597, 34);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(98, 62);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(591, 35);
            this.lbl_Product_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(152, 26);
            this.lbl_Product_Name.TabIndex = 17;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Enabled = false;
            this.tb_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(755, 77);
            this.tb_Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Quantity.MaxLength = 100;
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(261, 32);
            this.tb_Quantity.TabIndex = 4;
            this.tb_Quantity.TextChanged += new System.EventHandler(this.tb_Quantity_TextChanged);
            this.tb_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Quantity_KeyPress);
            // 
            // tb_Purchase_Price
            // 
            this.tb_Purchase_Price.Enabled = false;
            this.tb_Purchase_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Price.Location = new System.Drawing.Point(1311, 30);
            this.tb_Purchase_Price.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Purchase_Price.MaxLength = 10;
            this.tb_Purchase_Price.Name = "tb_Purchase_Price";
            this.tb_Purchase_Price.Size = new System.Drawing.Size(201, 32);
            this.tb_Purchase_Price.TabIndex = 4;
            this.tb_Purchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Purchase_Price_KeyPress);
            // 
            // lbl_Purchase_Price
            // 
            this.lbl_Purchase_Price.AutoSize = true;
            this.lbl_Purchase_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Price.Location = new System.Drawing.Point(1109, 31);
            this.lbl_Purchase_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Purchase_Price.Name = "lbl_Purchase_Price";
            this.lbl_Purchase_Price.Size = new System.Drawing.Size(166, 26);
            this.lbl_Purchase_Price.TabIndex = 6;
            this.lbl_Purchase_Price.Text = "Purchase  Price";
            // 
            // tb_Sales_Price
            // 
            this.tb_Sales_Price.Enabled = false;
            this.tb_Sales_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sales_Price.Location = new System.Drawing.Point(200, 77);
            this.tb_Sales_Price.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Sales_Price.MaxLength = 10;
            this.tb_Sales_Price.Name = "tb_Sales_Price";
            this.tb_Sales_Price.Size = new System.Drawing.Size(265, 32);
            this.tb_Sales_Price.TabIndex = 5;
            this.tb_Sales_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Sales_Price_KeyPress);
            // 
            // lbl_Seals_Price
            // 
            this.lbl_Seals_Price.AutoSize = true;
            this.lbl_Seals_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Seals_Price.Location = new System.Drawing.Point(13, 81);
            this.lbl_Seals_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Seals_Price.Name = "lbl_Seals_Price";
            this.lbl_Seals_Price.Size = new System.Drawing.Size(123, 26);
            this.lbl_Seals_Price.TabIndex = 6;
            this.lbl_Seals_Price.Text = "Sales Price";
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
            this.Merchant_Name,
            this.Category,
            this.Product_Name,
            this.Purchase_Prise,
            this.Sales_Prise,
            this.Quantity,
            this.Total_Bill,
            this.Delete});
            this.dgv_Order_List.Location = new System.Drawing.Point(17, 21);
            this.dgv_Order_List.Name = "dgv_Order_List";
            this.dgv_Order_List.ReadOnly = true;
            this.dgv_Order_List.RowHeadersWidth = 51;
            this.dgv_Order_List.RowTemplate.Height = 24;
            this.dgv_Order_List.Size = new System.Drawing.Size(1681, 331);
            this.dgv_Order_List.TabIndex = 0;
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
            // Merchant_Name
            // 
            this.Merchant_Name.HeaderText = "Merchant Name";
            this.Merchant_Name.MinimumWidth = 6;
            this.Merchant_Name.Name = "Merchant_Name";
            this.Merchant_Name.ReadOnly = true;
            this.Merchant_Name.Width = 125;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Product_Name
            // 
            this.Product_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_Name.HeaderText = "Product Name";
            this.Product_Name.MinimumWidth = 6;
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            // 
            // Purchase_Prise
            // 
            this.Purchase_Prise.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Purchase_Prise.HeaderText = "Purchase Price";
            this.Purchase_Prise.MinimumWidth = 6;
            this.Purchase_Prise.Name = "Purchase_Prise";
            this.Purchase_Prise.ReadOnly = true;
            this.Purchase_Prise.Width = 136;
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
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(219, 377);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(117, 55);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(46, 377);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(129, 55);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // gb_Order_List
            // 
            this.gb_Order_List.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_Order_List.Controls.Add(this.btn_Save);
            this.gb_Order_List.Controls.Add(this.btn_Refresh);
            this.gb_Order_List.Controls.Add(this.lbl_Total_Bill);
            this.gb_Order_List.Controls.Add(this.dgv_Order_List);
            this.gb_Order_List.Controls.Add(this.tb_Total);
            this.gb_Order_List.ForeColor = System.Drawing.Color.Black;
            this.gb_Order_List.Location = new System.Drawing.Point(12, 318);
            this.gb_Order_List.Name = "gb_Order_List";
            this.gb_Order_List.Size = new System.Drawing.Size(1738, 459);
            this.gb_Order_List.TabIndex = 10;
            this.gb_Order_List.TabStop = false;
            this.gb_Order_List.Text = "Order List";
            // 
            // lbl_Total_Bill
            // 
            this.lbl_Total_Bill.AutoSize = true;
            this.lbl_Total_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Bill.Location = new System.Drawing.Point(1285, 387);
            this.lbl_Total_Bill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Total_Bill.Name = "lbl_Total_Bill";
            this.lbl_Total_Bill.Size = new System.Drawing.Size(120, 26);
            this.lbl_Total_Bill.TabIndex = 17;
            this.lbl_Total_Bill.Text = "Order Total";
            // 
            // tb_Total
            // 
            this.tb_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total.Location = new System.Drawing.Point(1431, 378);
            this.tb_Total.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Total.MaxLength = 40;
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(251, 45);
            this.tb_Total.TabIndex = 8;
            // 
            // gb_Add_Product
            // 
            this.gb_Add_Product.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_Add_Product.Controls.Add(this.lbl_Unit1);
            this.gb_Add_Product.Controls.Add(this.lbl_Unit);
            this.gb_Add_Product.Controls.Add(this.btn_Add);
            this.gb_Add_Product.Controls.Add(this.cmb_Product_Name);
            this.gb_Add_Product.Controls.Add(this.lbl_Category_Name);
            this.gb_Add_Product.Controls.Add(this.lbl_Product_Name);
            this.gb_Add_Product.Controls.Add(this.cmb_Category_Name);
            this.gb_Add_Product.Controls.Add(this.lbl_Product_Total_Bill);
            this.gb_Add_Product.Controls.Add(this.lbl_Quantity);
            this.gb_Add_Product.Controls.Add(this.tb_Purchase_Price);
            this.gb_Add_Product.Controls.Add(this.lbl_Purchase_Price);
            this.gb_Add_Product.Controls.Add(this.tb_Sales_Price);
            this.gb_Add_Product.Controls.Add(this.tb_Product_Total_Bill);
            this.gb_Add_Product.Controls.Add(this.tb_Quantity);
            this.gb_Add_Product.Controls.Add(this.lbl_Seals_Price);
            this.gb_Add_Product.Enabled = false;
            this.gb_Add_Product.Location = new System.Drawing.Point(15, 174);
            this.gb_Add_Product.Name = "gb_Add_Product";
            this.gb_Add_Product.Size = new System.Drawing.Size(1735, 138);
            this.gb_Add_Product.TabIndex = 29;
            this.gb_Add_Product.TabStop = false;
            this.gb_Add_Product.Text = "Add Product";
            // 
            // lbl_Unit1
            // 
            this.lbl_Unit1.AutoSize = true;
            this.lbl_Unit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit1.Location = new System.Drawing.Point(1024, 78);
            this.lbl_Unit1.Name = "lbl_Unit1";
            this.lbl_Unit1.Size = new System.Drawing.Size(57, 26);
            this.lbl_Unit1.TabIndex = 27;
            this.lbl_Unit1.Text = "(Pic)";
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit.Location = new System.Drawing.Point(1519, 32);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(57, 26);
            this.lbl_Unit.TabIndex = 26;
            this.lbl_Unit.Text = "(Pic)";
            // 
            // lbl_Product_Total_Bill
            // 
            this.lbl_Product_Total_Bill.AutoSize = true;
            this.lbl_Product_Total_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Total_Bill.Location = new System.Drawing.Point(1104, 79);
            this.lbl_Product_Total_Bill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Product_Total_Bill.Name = "lbl_Product_Total_Bill";
            this.lbl_Product_Total_Bill.Size = new System.Drawing.Size(176, 26);
            this.lbl_Product_Total_Bill.TabIndex = 22;
            this.lbl_Product_Total_Bill.Text = "Product Total Bill";
            // 
            // tb_Product_Total_Bill
            // 
            this.tb_Product_Total_Bill.Enabled = false;
            this.tb_Product_Total_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Total_Bill.Location = new System.Drawing.Point(1312, 75);
            this.tb_Product_Total_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Product_Total_Bill.MaxLength = 100;
            this.tb_Product_Total_Bill.Name = "tb_Product_Total_Bill";
            this.tb_Product_Total_Bill.Size = new System.Drawing.Size(247, 32);
            this.tb_Product_Total_Bill.TabIndex = 8;
            this.tb_Product_Total_Bill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Product_Total_Bill_KeyPress);
            // 
            // dtp_Order_Date
            // 
            this.dtp_Order_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Order_Date.Location = new System.Drawing.Point(1313, 16);
            this.dtp_Order_Date.Name = "dtp_Order_Date";
            this.dtp_Order_Date.Size = new System.Drawing.Size(265, 32);
            this.dtp_Order_Date.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.lbl_Date);
            this.groupBox2.Controls.Add(this.dtp_Order_Date);
            this.groupBox2.Controls.Add(this.tb_order_Id);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmb_Merchant_Name);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1737, 64);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Product";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(1172, 17);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(58, 26);
            this.lbl_Date.TabIndex = 35;
            this.lbl_Date.Text = "Date";
            // 
            // tb_order_Id
            // 
            this.tb_order_Id.Enabled = false;
            this.tb_order_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_order_Id.Location = new System.Drawing.Point(202, 17);
            this.tb_order_Id.Margin = new System.Windows.Forms.Padding(4);
            this.tb_order_Id.MaxLength = 5;
            this.tb_order_Id.Name = "tb_order_Id";
            this.tb_order_Id.Size = new System.Drawing.Size(256, 32);
            this.tb_order_Id.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "Order ID";
            // 
            // cmb_Merchant_Name
            // 
            this.cmb_Merchant_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Merchant_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Merchant_Name.FormattingEnabled = true;
            this.cmb_Merchant_Name.Location = new System.Drawing.Point(757, 14);
            this.cmb_Merchant_Name.Name = "cmb_Merchant_Name";
            this.cmb_Merchant_Name.Size = new System.Drawing.Size(261, 34);
            this.cmb_Merchant_Name.TabIndex = 1;
            this.cmb_Merchant_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Merchant_Name_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(565, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "Merchant Name";
            // 
            // frm_Add_Recived_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1762, 789);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_Add_Product);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.gb_Order_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Recived_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recived Order (Stock_Details)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_Recived_Order_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order_List)).EndInit();
            this.gb_Order_List.ResumeLayout(false);
            this.gb_Order_List.PerformLayout();
            this.gb_Add_Product.ResumeLayout(false);
            this.gb_Add_Product.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Seals_Price;
        private System.Windows.Forms.Label lbl_Purchase_Price;
        private System.Windows.Forms.TextBox tb_Sales_Price;
        private System.Windows.Forms.TextBox tb_Purchase_Price;
        private System.Windows.Forms.DataGridView dgv_Order_List;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.GroupBox gb_Order_List;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.ComboBox cmb_Category_Name;
        private System.Windows.Forms.GroupBox gb_Add_Product;
        private System.Windows.Forms.DateTimePicker dtp_Order_Date;
        private System.Windows.Forms.Label lbl_Product_Total_Bill;
        private System.Windows.Forms.TextBox tb_Product_Total_Bill;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_order_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Merchant_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Total_Bill;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sr_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Merchant_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_Prise;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales_Prise;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Bill;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label lbl_Unit1;
        private System.Windows.Forms.Label lbl_Unit;
    }
}