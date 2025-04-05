
namespace Food_Shop_Billing_System.Forms.Staff_Details
{
    partial class frm_Staff_Master
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
            this.tb_Staff_ID = new System.Windows.Forms.TextBox();
            this.tc_User = new System.Windows.Forms.TabControl();
            this.tc_Add_Staff = new System.Windows.Forms.TabPage();
            this.gb_Add_Staff_Details = new System.Windows.Forms.GroupBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dtp_Joning_Dtate = new System.Windows.Forms.DateTimePicker();
            this.cmb_Staff_Role = new System.Windows.Forms.ComboBox();
            this.lbl_Current_Address = new System.Windows.Forms.Label();
            this.lbl_Joining_Date = new System.Windows.Forms.Label();
            this.lbl_Alt_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.lbl_Staff_Role = new System.Windows.Forms.Label();
            this.lbl_Staff_Name = new System.Windows.Forms.Label();
            this.lbl_Adhar_Card_No = new System.Windows.Forms.Label();
            this.lbl_Staff_ID = new System.Windows.Forms.Label();
            this.tb_Note = new System.Windows.Forms.TextBox();
            this.tb_current_Address = new System.Windows.Forms.TextBox();
            this.tb_Adhar_Card_No = new System.Windows.Forms.TextBox();
            this.tb_alt_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Staff_Name = new System.Windows.Forms.TextBox();
            this.tc_Update_Staff = new System.Windows.Forms.TabPage();
            this.gb_Add_Shop_Details = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_U_Refresh = new System.Windows.Forms.Button();
            this.dtp_U_Joinining_Date = new System.Windows.Forms.DateTimePicker();
            this.cmb_U_Staff_Role = new System.Windows.Forms.ComboBox();
            this.lbl_U_Current_Address = new System.Windows.Forms.Label();
            this.Lbl_U_Joinining_Date = new System.Windows.Forms.Label();
            this.lbl_U_Alt_Mob_No = new System.Windows.Forms.Label();
            this.lbl_U_Mob_No = new System.Windows.Forms.Label();
            this.lbl_U_Note = new System.Windows.Forms.Label();
            this.lbl_U_Staff_Role = new System.Windows.Forms.Label();
            this.lbl_U_Staff_Name = new System.Windows.Forms.Label();
            this.lbl_U_Adhar_Card_No = new System.Windows.Forms.Label();
            this.lbl_U_Staff_Id = new System.Windows.Forms.Label();
            this.tb_U_Note = new System.Windows.Forms.TextBox();
            this.tb_U_Current_Address = new System.Windows.Forms.TextBox();
            this.tb_U_Adhar_Card_No = new System.Windows.Forms.TextBox();
            this.tb_U_Alt_Mob_No = new System.Windows.Forms.TextBox();
            this.tb_U_Mob_No = new System.Windows.Forms.TextBox();
            this.tb_U_Staff_Name = new System.Windows.Forms.TextBox();
            this.tb_U_Staff_Id = new System.Windows.Forms.TextBox();
            this.tc_Delete_Staff = new System.Windows.Forms.TabPage();
            this.gb_Delete_Staff = new System.Windows.Forms.GroupBox();
            this.tb_D_Staff_Name = new System.Windows.Forms.TextBox();
            this.tb_D_Staff_Role = new System.Windows.Forms.TextBox();
            this.btn_U_Search = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_D_Refresh = new System.Windows.Forms.Button();
            this.lbl_D_Staff_Role = new System.Windows.Forms.Label();
            this.lbl_D_Staff_Name = new System.Windows.Forms.Label();
            this.lbl_D_Staff_Id = new System.Windows.Forms.Label();
            this.tb_D_Staff_id = new System.Windows.Forms.TextBox();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.tc_User.SuspendLayout();
            this.tc_Add_Staff.SuspendLayout();
            this.gb_Add_Staff_Details.SuspendLayout();
            this.tc_Update_Staff.SuspendLayout();
            this.gb_Add_Shop_Details.SuspendLayout();
            this.tc_Delete_Staff.SuspendLayout();
            this.gb_Delete_Staff.SuspendLayout();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Staff_ID
            // 
            this.tb_Staff_ID.Enabled = false;
            this.tb_Staff_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Staff_ID.Location = new System.Drawing.Point(300, 49);
            this.tb_Staff_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Staff_ID.MaxLength = 5;
            this.tb_Staff_ID.Name = "tb_Staff_ID";
            this.tb_Staff_ID.Size = new System.Drawing.Size(298, 36);
            this.tb_Staff_ID.TabIndex = 1;
            this.tb_Staff_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Staff_ID_KeyPress);
            // 
            // tc_User
            // 
            this.tc_User.Controls.Add(this.tc_Add_Staff);
            this.tc_User.Controls.Add(this.tc_Update_Staff);
            this.tc_User.Controls.Add(this.tc_Delete_Staff);
            this.tc_User.Location = new System.Drawing.Point(0, 103);
            this.tc_User.Name = "tc_User";
            this.tc_User.SelectedIndex = 0;
            this.tc_User.Size = new System.Drawing.Size(1637, 605);
            this.tc_User.TabIndex = 6;
            // 
            // tc_Add_Staff
            // 
            this.tc_Add_Staff.BackColor = System.Drawing.SystemColors.Control;
            this.tc_Add_Staff.Controls.Add(this.gb_Add_Staff_Details);
            this.tc_Add_Staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_Add_Staff.Location = new System.Drawing.Point(4, 25);
            this.tc_Add_Staff.Name = "tc_Add_Staff";
            this.tc_Add_Staff.Padding = new System.Windows.Forms.Padding(3);
            this.tc_Add_Staff.Size = new System.Drawing.Size(1629, 576);
            this.tc_Add_Staff.TabIndex = 0;
            this.tc_Add_Staff.Text = "Add Staff";
            // 
            // gb_Add_Staff_Details
            // 
            this.gb_Add_Staff_Details.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_Add_Staff_Details.Controls.Add(this.btn_Submit);
            this.gb_Add_Staff_Details.Controls.Add(this.btn_Refresh);
            this.gb_Add_Staff_Details.Controls.Add(this.dtp_Joning_Dtate);
            this.gb_Add_Staff_Details.Controls.Add(this.cmb_Staff_Role);
            this.gb_Add_Staff_Details.Controls.Add(this.lbl_Current_Address);
            this.gb_Add_Staff_Details.Controls.Add(this.lbl_Joining_Date);
            this.gb_Add_Staff_Details.Controls.Add(this.lbl_Alt_Mobile_No);
            this.gb_Add_Staff_Details.Controls.Add(this.lbl_Mobile_No);
            this.gb_Add_Staff_Details.Controls.Add(this.lbl_Note);
            this.gb_Add_Staff_Details.Controls.Add(this.lbl_Staff_Role);
            this.gb_Add_Staff_Details.Controls.Add(this.lbl_Staff_Name);
            this.gb_Add_Staff_Details.Controls.Add(this.lbl_Adhar_Card_No);
            this.gb_Add_Staff_Details.Controls.Add(this.lbl_Staff_ID);
            this.gb_Add_Staff_Details.Controls.Add(this.tb_Note);
            this.gb_Add_Staff_Details.Controls.Add(this.tb_current_Address);
            this.gb_Add_Staff_Details.Controls.Add(this.tb_Adhar_Card_No);
            this.gb_Add_Staff_Details.Controls.Add(this.tb_alt_Mobile_No);
            this.gb_Add_Staff_Details.Controls.Add(this.tb_Mobile_No);
            this.gb_Add_Staff_Details.Controls.Add(this.tb_Staff_Name);
            this.gb_Add_Staff_Details.Controls.Add(this.tb_Staff_ID);
            this.gb_Add_Staff_Details.Location = new System.Drawing.Point(104, 17);
            this.gb_Add_Staff_Details.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Add_Staff_Details.Name = "gb_Add_Staff_Details";
            this.gb_Add_Staff_Details.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Add_Staff_Details.Size = new System.Drawing.Size(1448, 537);
            this.gb_Add_Staff_Details.TabIndex = 1;
            this.gb_Add_Staff_Details.TabStop = false;
            this.gb_Add_Staff_Details.Tag = "";
            this.gb_Add_Staff_Details.Text = "Add Shop Details";
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(750, 456);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(143, 54);
            this.btn_Submit.TabIndex = 11;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(421, 456);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(149, 54);
            this.btn_Refresh.TabIndex = 10;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // dtp_Joning_Dtate
            // 
            this.dtp_Joning_Dtate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Joning_Dtate.Location = new System.Drawing.Point(1025, 54);
            this.dtp_Joning_Dtate.Name = "dtp_Joning_Dtate";
            this.dtp_Joning_Dtate.Size = new System.Drawing.Size(278, 36);
            this.dtp_Joning_Dtate.TabIndex = 6;
            // 
            // cmb_Staff_Role
            // 
            this.cmb_Staff_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Staff_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Staff_Role.FormattingEnabled = true;
            this.cmb_Staff_Role.Items.AddRange(new object[] {
            "Admin",
            "Casher",
            "Maneger",
            "Other"});
            this.cmb_Staff_Role.Location = new System.Drawing.Point(300, 128);
            this.cmb_Staff_Role.Name = "cmb_Staff_Role";
            this.cmb_Staff_Role.Size = new System.Drawing.Size(298, 37);
            this.cmb_Staff_Role.TabIndex = 2;
            // 
            // lbl_Current_Address
            // 
            this.lbl_Current_Address.AutoSize = true;
            this.lbl_Current_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Current_Address.Location = new System.Drawing.Point(753, 198);
            this.lbl_Current_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Current_Address.Name = "lbl_Current_Address";
            this.lbl_Current_Address.Size = new System.Drawing.Size(196, 29);
            this.lbl_Current_Address.TabIndex = 2;
            this.lbl_Current_Address.Text = "Current Address";
            // 
            // lbl_Joining_Date
            // 
            this.lbl_Joining_Date.AutoSize = true;
            this.lbl_Joining_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Joining_Date.Location = new System.Drawing.Point(753, 47);
            this.lbl_Joining_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Joining_Date.Name = "lbl_Joining_Date";
            this.lbl_Joining_Date.Size = new System.Drawing.Size(154, 29);
            this.lbl_Joining_Date.TabIndex = 2;
            this.lbl_Joining_Date.Text = "Joining Date";
            // 
            // lbl_Alt_Mobile_No
            // 
            this.lbl_Alt_Mobile_No.AutoSize = true;
            this.lbl_Alt_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alt_Mobile_No.Location = new System.Drawing.Point(64, 381);
            this.lbl_Alt_Mobile_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Alt_Mobile_No.Name = "lbl_Alt_Mobile_No";
            this.lbl_Alt_Mobile_No.Size = new System.Drawing.Size(164, 29);
            this.lbl_Alt_Mobile_No.TabIndex = 2;
            this.lbl_Alt_Mobile_No.Text = "Alt Mobile No";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(65, 297);
            this.lbl_Mobile_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(127, 29);
            this.lbl_Mobile_No.TabIndex = 2;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.Location = new System.Drawing.Point(763, 339);
            this.lbl_Note.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(66, 29);
            this.lbl_Note.TabIndex = 2;
            this.lbl_Note.Text = "Note";
            // 
            // lbl_Staff_Role
            // 
            this.lbl_Staff_Role.AutoSize = true;
            this.lbl_Staff_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_Role.Location = new System.Drawing.Point(65, 127);
            this.lbl_Staff_Role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Staff_Role.Name = "lbl_Staff_Role";
            this.lbl_Staff_Role.Size = new System.Drawing.Size(124, 29);
            this.lbl_Staff_Role.TabIndex = 2;
            this.lbl_Staff_Role.Text = "Staff Role";
            // 
            // lbl_Staff_Name
            // 
            this.lbl_Staff_Name.AutoSize = true;
            this.lbl_Staff_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_Name.Location = new System.Drawing.Point(65, 210);
            this.lbl_Staff_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Staff_Name.Name = "lbl_Staff_Name";
            this.lbl_Staff_Name.Size = new System.Drawing.Size(140, 29);
            this.lbl_Staff_Name.TabIndex = 2;
            this.lbl_Staff_Name.Text = "Staff Name";
            // 
            // lbl_Adhar_Card_No
            // 
            this.lbl_Adhar_Card_No.AutoSize = true;
            this.lbl_Adhar_Card_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Adhar_Card_No.Location = new System.Drawing.Point(747, 121);
            this.lbl_Adhar_Card_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Adhar_Card_No.Name = "lbl_Adhar_Card_No";
            this.lbl_Adhar_Card_No.Size = new System.Drawing.Size(187, 29);
            this.lbl_Adhar_Card_No.TabIndex = 2;
            this.lbl_Adhar_Card_No.Text = " Adhar Card No";
            // 
            // lbl_Staff_ID
            // 
            this.lbl_Staff_ID.AutoSize = true;
            this.lbl_Staff_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_ID.Location = new System.Drawing.Point(64, 49);
            this.lbl_Staff_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Staff_ID.Name = "lbl_Staff_ID";
            this.lbl_Staff_ID.Size = new System.Drawing.Size(96, 29);
            this.lbl_Staff_ID.TabIndex = 2;
            this.lbl_Staff_ID.Text = "Staff ID";
            // 
            // tb_Note
            // 
            this.tb_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Note.Location = new System.Drawing.Point(1025, 339);
            this.tb_Note.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Note.MaxLength = 150;
            this.tb_Note.Multiline = true;
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(290, 83);
            this.tb_Note.TabIndex = 9;
            // 
            // tb_current_Address
            // 
            this.tb_current_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_current_Address.Location = new System.Drawing.Point(1025, 199);
            this.tb_current_Address.Margin = new System.Windows.Forms.Padding(4);
            this.tb_current_Address.MaxLength = 150;
            this.tb_current_Address.Multiline = true;
            this.tb_current_Address.Name = "tb_current_Address";
            this.tb_current_Address.Size = new System.Drawing.Size(290, 115);
            this.tb_current_Address.TabIndex = 8;
            // 
            // tb_Adhar_Card_No
            // 
            this.tb_Adhar_Card_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Adhar_Card_No.Location = new System.Drawing.Point(1025, 120);
            this.tb_Adhar_Card_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Adhar_Card_No.MaxLength = 11;
            this.tb_Adhar_Card_No.Name = "tb_Adhar_Card_No";
            this.tb_Adhar_Card_No.Size = new System.Drawing.Size(278, 36);
            this.tb_Adhar_Card_No.TabIndex = 7;
            this.tb_Adhar_Card_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Adhar_Card_No_KeyPress);
            // 
            // tb_alt_Mobile_No
            // 
            this.tb_alt_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_alt_Mobile_No.Location = new System.Drawing.Point(300, 382);
            this.tb_alt_Mobile_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_alt_Mobile_No.MaxLength = 10;
            this.tb_alt_Mobile_No.Name = "tb_alt_Mobile_No";
            this.tb_alt_Mobile_No.Size = new System.Drawing.Size(298, 36);
            this.tb_alt_Mobile_No.TabIndex = 5;
            this.tb_alt_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_alt_Mobile_No_KeyPress);
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(300, 298);
            this.tb_Mobile_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(298, 36);
            this.tb_Mobile_No.TabIndex = 4;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Mobile_No_KeyPress);
            // 
            // tb_Staff_Name
            // 
            this.tb_Staff_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Staff_Name.Location = new System.Drawing.Point(300, 209);
            this.tb_Staff_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Staff_Name.MaxLength = 120;
            this.tb_Staff_Name.Name = "tb_Staff_Name";
            this.tb_Staff_Name.Size = new System.Drawing.Size(298, 36);
            this.tb_Staff_Name.TabIndex = 3;
            this.tb_Staff_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Staff_Name_KeyPress);
            // 
            // tc_Update_Staff
            // 
            this.tc_Update_Staff.BackColor = System.Drawing.SystemColors.Control;
            this.tc_Update_Staff.Controls.Add(this.gb_Add_Shop_Details);
            this.tc_Update_Staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_Update_Staff.Location = new System.Drawing.Point(4, 25);
            this.tc_Update_Staff.Name = "tc_Update_Staff";
            this.tc_Update_Staff.Padding = new System.Windows.Forms.Padding(3);
            this.tc_Update_Staff.Size = new System.Drawing.Size(1629, 576);
            this.tc_Update_Staff.TabIndex = 1;
            this.tc_Update_Staff.Text = "Update Staff";
            // 
            // gb_Add_Shop_Details
            // 
            this.gb_Add_Shop_Details.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_Add_Shop_Details.Controls.Add(this.btn_Search);
            this.gb_Add_Shop_Details.Controls.Add(this.btn_update);
            this.gb_Add_Shop_Details.Controls.Add(this.btn_U_Refresh);
            this.gb_Add_Shop_Details.Controls.Add(this.dtp_U_Joinining_Date);
            this.gb_Add_Shop_Details.Controls.Add(this.cmb_U_Staff_Role);
            this.gb_Add_Shop_Details.Controls.Add(this.lbl_U_Current_Address);
            this.gb_Add_Shop_Details.Controls.Add(this.Lbl_U_Joinining_Date);
            this.gb_Add_Shop_Details.Controls.Add(this.lbl_U_Alt_Mob_No);
            this.gb_Add_Shop_Details.Controls.Add(this.lbl_U_Mob_No);
            this.gb_Add_Shop_Details.Controls.Add(this.lbl_U_Note);
            this.gb_Add_Shop_Details.Controls.Add(this.lbl_U_Staff_Role);
            this.gb_Add_Shop_Details.Controls.Add(this.lbl_U_Staff_Name);
            this.gb_Add_Shop_Details.Controls.Add(this.lbl_U_Adhar_Card_No);
            this.gb_Add_Shop_Details.Controls.Add(this.lbl_U_Staff_Id);
            this.gb_Add_Shop_Details.Controls.Add(this.tb_U_Note);
            this.gb_Add_Shop_Details.Controls.Add(this.tb_U_Current_Address);
            this.gb_Add_Shop_Details.Controls.Add(this.tb_U_Adhar_Card_No);
            this.gb_Add_Shop_Details.Controls.Add(this.tb_U_Alt_Mob_No);
            this.gb_Add_Shop_Details.Controls.Add(this.tb_U_Mob_No);
            this.gb_Add_Shop_Details.Controls.Add(this.tb_U_Staff_Name);
            this.gb_Add_Shop_Details.Controls.Add(this.tb_U_Staff_Id);
            this.gb_Add_Shop_Details.Location = new System.Drawing.Point(106, 18);
            this.gb_Add_Shop_Details.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Add_Shop_Details.Name = "gb_Add_Shop_Details";
            this.gb_Add_Shop_Details.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Add_Shop_Details.Size = new System.Drawing.Size(1394, 540);
            this.gb_Add_Shop_Details.TabIndex = 5;
            this.gb_Add_Shop_Details.TabStop = false;
            this.gb_Add_Shop_Details.Tag = "";
            this.gb_Add_Shop_Details.Text = "Add Shop Details";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(609, 45);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(102, 40);
            this.btn_Search.TabIndex = 12;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(716, 464);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(143, 54);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Submit";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_U_Refresh
            // 
            this.btn_U_Refresh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_U_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_U_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_U_Refresh.Location = new System.Drawing.Point(387, 464);
            this.btn_U_Refresh.Name = "btn_U_Refresh";
            this.btn_U_Refresh.Size = new System.Drawing.Size(149, 54);
            this.btn_U_Refresh.TabIndex = 10;
            this.btn_U_Refresh.Text = "Refresh";
            this.btn_U_Refresh.UseVisualStyleBackColor = false;
            // 
            // dtp_U_Joinining_Date
            // 
            this.dtp_U_Joinining_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_U_Joinining_Date.Location = new System.Drawing.Point(1007, 59);
            this.dtp_U_Joinining_Date.Name = "dtp_U_Joinining_Date";
            this.dtp_U_Joinining_Date.Size = new System.Drawing.Size(278, 36);
            this.dtp_U_Joinining_Date.TabIndex = 6;
            // 
            // cmb_U_Staff_Role
            // 
            this.cmb_U_Staff_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_U_Staff_Role.FormattingEnabled = true;
            this.cmb_U_Staff_Role.Location = new System.Drawing.Point(300, 128);
            this.cmb_U_Staff_Role.Name = "cmb_U_Staff_Role";
            this.cmb_U_Staff_Role.Size = new System.Drawing.Size(285, 37);
            this.cmb_U_Staff_Role.TabIndex = 2;
            // 
            // lbl_U_Current_Address
            // 
            this.lbl_U_Current_Address.AutoSize = true;
            this.lbl_U_Current_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_U_Current_Address.Location = new System.Drawing.Point(735, 203);
            this.lbl_U_Current_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_U_Current_Address.Name = "lbl_U_Current_Address";
            this.lbl_U_Current_Address.Size = new System.Drawing.Size(196, 29);
            this.lbl_U_Current_Address.TabIndex = 2;
            this.lbl_U_Current_Address.Text = "Current Address";
            // 
            // Lbl_U_Joinining_Date
            // 
            this.Lbl_U_Joinining_Date.AutoSize = true;
            this.Lbl_U_Joinining_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_U_Joinining_Date.Location = new System.Drawing.Point(735, 52);
            this.Lbl_U_Joinining_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_U_Joinining_Date.Name = "Lbl_U_Joinining_Date";
            this.Lbl_U_Joinining_Date.Size = new System.Drawing.Size(154, 29);
            this.Lbl_U_Joinining_Date.TabIndex = 2;
            this.Lbl_U_Joinining_Date.Text = "Joining Date";
            // 
            // lbl_U_Alt_Mob_No
            // 
            this.lbl_U_Alt_Mob_No.AutoSize = true;
            this.lbl_U_Alt_Mob_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_U_Alt_Mob_No.Location = new System.Drawing.Point(64, 381);
            this.lbl_U_Alt_Mob_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_U_Alt_Mob_No.Name = "lbl_U_Alt_Mob_No";
            this.lbl_U_Alt_Mob_No.Size = new System.Drawing.Size(164, 29);
            this.lbl_U_Alt_Mob_No.TabIndex = 2;
            this.lbl_U_Alt_Mob_No.Text = "Alt Mobile No";
            // 
            // lbl_U_Mob_No
            // 
            this.lbl_U_Mob_No.AutoSize = true;
            this.lbl_U_Mob_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_U_Mob_No.Location = new System.Drawing.Point(65, 297);
            this.lbl_U_Mob_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_U_Mob_No.Name = "lbl_U_Mob_No";
            this.lbl_U_Mob_No.Size = new System.Drawing.Size(127, 29);
            this.lbl_U_Mob_No.TabIndex = 2;
            this.lbl_U_Mob_No.Text = "Mobile No";
            // 
            // lbl_U_Note
            // 
            this.lbl_U_Note.AutoSize = true;
            this.lbl_U_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_U_Note.Location = new System.Drawing.Point(856, 344);
            this.lbl_U_Note.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_U_Note.Name = "lbl_U_Note";
            this.lbl_U_Note.Size = new System.Drawing.Size(66, 29);
            this.lbl_U_Note.TabIndex = 2;
            this.lbl_U_Note.Text = "Note";
            // 
            // lbl_U_Staff_Role
            // 
            this.lbl_U_Staff_Role.AutoSize = true;
            this.lbl_U_Staff_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_U_Staff_Role.Location = new System.Drawing.Point(65, 127);
            this.lbl_U_Staff_Role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_U_Staff_Role.Name = "lbl_U_Staff_Role";
            this.lbl_U_Staff_Role.Size = new System.Drawing.Size(124, 29);
            this.lbl_U_Staff_Role.TabIndex = 2;
            this.lbl_U_Staff_Role.Text = "Staff Role";
            // 
            // lbl_U_Staff_Name
            // 
            this.lbl_U_Staff_Name.AutoSize = true;
            this.lbl_U_Staff_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_U_Staff_Name.Location = new System.Drawing.Point(65, 210);
            this.lbl_U_Staff_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_U_Staff_Name.Name = "lbl_U_Staff_Name";
            this.lbl_U_Staff_Name.Size = new System.Drawing.Size(140, 29);
            this.lbl_U_Staff_Name.TabIndex = 2;
            this.lbl_U_Staff_Name.Text = "Staff Name";
            // 
            // lbl_U_Adhar_Card_No
            // 
            this.lbl_U_Adhar_Card_No.AutoSize = true;
            this.lbl_U_Adhar_Card_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_U_Adhar_Card_No.Location = new System.Drawing.Point(735, 126);
            this.lbl_U_Adhar_Card_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_U_Adhar_Card_No.Name = "lbl_U_Adhar_Card_No";
            this.lbl_U_Adhar_Card_No.Size = new System.Drawing.Size(187, 29);
            this.lbl_U_Adhar_Card_No.TabIndex = 2;
            this.lbl_U_Adhar_Card_No.Text = " Adhar Card No";
            // 
            // lbl_U_Staff_Id
            // 
            this.lbl_U_Staff_Id.AutoSize = true;
            this.lbl_U_Staff_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_U_Staff_Id.Location = new System.Drawing.Point(64, 49);
            this.lbl_U_Staff_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_U_Staff_Id.Name = "lbl_U_Staff_Id";
            this.lbl_U_Staff_Id.Size = new System.Drawing.Size(96, 29);
            this.lbl_U_Staff_Id.TabIndex = 2;
            this.lbl_U_Staff_Id.Text = "Staff ID";
            // 
            // tb_U_Note
            // 
            this.tb_U_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_U_Note.Location = new System.Drawing.Point(1007, 344);
            this.tb_U_Note.Margin = new System.Windows.Forms.Padding(4);
            this.tb_U_Note.MaxLength = 150;
            this.tb_U_Note.Multiline = true;
            this.tb_U_Note.Name = "tb_U_Note";
            this.tb_U_Note.Size = new System.Drawing.Size(290, 83);
            this.tb_U_Note.TabIndex = 9;
            // 
            // tb_U_Current_Address
            // 
            this.tb_U_Current_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_U_Current_Address.Location = new System.Drawing.Point(1007, 204);
            this.tb_U_Current_Address.Margin = new System.Windows.Forms.Padding(4);
            this.tb_U_Current_Address.MaxLength = 150;
            this.tb_U_Current_Address.Multiline = true;
            this.tb_U_Current_Address.Name = "tb_U_Current_Address";
            this.tb_U_Current_Address.Size = new System.Drawing.Size(290, 115);
            this.tb_U_Current_Address.TabIndex = 8;
            // 
            // tb_U_Adhar_Card_No
            // 
            this.tb_U_Adhar_Card_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_U_Adhar_Card_No.Location = new System.Drawing.Point(1007, 125);
            this.tb_U_Adhar_Card_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_U_Adhar_Card_No.MaxLength = 11;
            this.tb_U_Adhar_Card_No.Name = "tb_U_Adhar_Card_No";
            this.tb_U_Adhar_Card_No.Size = new System.Drawing.Size(278, 36);
            this.tb_U_Adhar_Card_No.TabIndex = 7;
            // 
            // tb_U_Alt_Mob_No
            // 
            this.tb_U_Alt_Mob_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_U_Alt_Mob_No.Location = new System.Drawing.Point(300, 382);
            this.tb_U_Alt_Mob_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_U_Alt_Mob_No.MaxLength = 10;
            this.tb_U_Alt_Mob_No.Name = "tb_U_Alt_Mob_No";
            this.tb_U_Alt_Mob_No.Size = new System.Drawing.Size(285, 36);
            this.tb_U_Alt_Mob_No.TabIndex = 5;
            // 
            // tb_U_Mob_No
            // 
            this.tb_U_Mob_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_U_Mob_No.Location = new System.Drawing.Point(300, 298);
            this.tb_U_Mob_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_U_Mob_No.MaxLength = 10;
            this.tb_U_Mob_No.Name = "tb_U_Mob_No";
            this.tb_U_Mob_No.Size = new System.Drawing.Size(285, 36);
            this.tb_U_Mob_No.TabIndex = 4;
            // 
            // tb_U_Staff_Name
            // 
            this.tb_U_Staff_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_U_Staff_Name.Location = new System.Drawing.Point(300, 209);
            this.tb_U_Staff_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_U_Staff_Name.MaxLength = 120;
            this.tb_U_Staff_Name.Name = "tb_U_Staff_Name";
            this.tb_U_Staff_Name.Size = new System.Drawing.Size(285, 36);
            this.tb_U_Staff_Name.TabIndex = 3;
            // 
            // tb_U_Staff_Id
            // 
            this.tb_U_Staff_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_U_Staff_Id.Location = new System.Drawing.Point(300, 49);
            this.tb_U_Staff_Id.Margin = new System.Windows.Forms.Padding(4);
            this.tb_U_Staff_Id.MaxLength = 5;
            this.tb_U_Staff_Id.Name = "tb_U_Staff_Id";
            this.tb_U_Staff_Id.Size = new System.Drawing.Size(285, 36);
            this.tb_U_Staff_Id.TabIndex = 1;
            // 
            // tc_Delete_Staff
            // 
            this.tc_Delete_Staff.Controls.Add(this.gb_Delete_Staff);
            this.tc_Delete_Staff.Location = new System.Drawing.Point(4, 25);
            this.tc_Delete_Staff.Name = "tc_Delete_Staff";
            this.tc_Delete_Staff.Size = new System.Drawing.Size(1629, 576);
            this.tc_Delete_Staff.TabIndex = 2;
            this.tc_Delete_Staff.Text = "Delete staff";
            this.tc_Delete_Staff.UseVisualStyleBackColor = true;
            // 
            // gb_Delete_Staff
            // 
            this.gb_Delete_Staff.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gb_Delete_Staff.Controls.Add(this.tb_D_Staff_Name);
            this.gb_Delete_Staff.Controls.Add(this.tb_D_Staff_Role);
            this.gb_Delete_Staff.Controls.Add(this.btn_U_Search);
            this.gb_Delete_Staff.Controls.Add(this.btn_Delete);
            this.gb_Delete_Staff.Controls.Add(this.btn_D_Refresh);
            this.gb_Delete_Staff.Controls.Add(this.lbl_D_Staff_Role);
            this.gb_Delete_Staff.Controls.Add(this.lbl_D_Staff_Name);
            this.gb_Delete_Staff.Controls.Add(this.lbl_D_Staff_Id);
            this.gb_Delete_Staff.Controls.Add(this.tb_D_Staff_id);
            this.gb_Delete_Staff.Location = new System.Drawing.Point(153, 26);
            this.gb_Delete_Staff.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Delete_Staff.Name = "gb_Delete_Staff";
            this.gb_Delete_Staff.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Delete_Staff.Size = new System.Drawing.Size(1362, 516);
            this.gb_Delete_Staff.TabIndex = 6;
            this.gb_Delete_Staff.TabStop = false;
            this.gb_Delete_Staff.Tag = "";
            this.gb_Delete_Staff.Text = "Add Shop Details";
            // 
            // tb_D_Staff_Name
            // 
            this.tb_D_Staff_Name.Enabled = false;
            this.tb_D_Staff_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_D_Staff_Name.Location = new System.Drawing.Point(633, 249);
            this.tb_D_Staff_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_D_Staff_Name.Name = "tb_D_Staff_Name";
            this.tb_D_Staff_Name.Size = new System.Drawing.Size(309, 36);
            this.tb_D_Staff_Name.TabIndex = 21;
            // 
            // tb_D_Staff_Role
            // 
            this.tb_D_Staff_Role.Enabled = false;
            this.tb_D_Staff_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_D_Staff_Role.Location = new System.Drawing.Point(633, 165);
            this.tb_D_Staff_Role.Margin = new System.Windows.Forms.Padding(4);
            this.tb_D_Staff_Role.Name = "tb_D_Staff_Role";
            this.tb_D_Staff_Role.Size = new System.Drawing.Size(309, 36);
            this.tb_D_Staff_Role.TabIndex = 20;
            // 
            // btn_U_Search
            // 
            this.btn_U_Search.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_U_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_U_Search.ForeColor = System.Drawing.Color.White;
            this.btn_U_Search.Location = new System.Drawing.Point(974, 78);
            this.btn_U_Search.Name = "btn_U_Search";
            this.btn_U_Search.Size = new System.Drawing.Size(121, 47);
            this.btn_U_Search.TabIndex = 19;
            this.btn_U_Search.Text = "Search";
            this.btn_U_Search.UseVisualStyleBackColor = false;
            this.btn_U_Search.Click += new System.EventHandler(this.btn_U_Search_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(799, 383);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(143, 54);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_D_Refresh
            // 
            this.btn_D_Refresh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_D_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_D_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_D_Refresh.Location = new System.Drawing.Point(485, 383);
            this.btn_D_Refresh.Name = "btn_D_Refresh";
            this.btn_D_Refresh.Size = new System.Drawing.Size(149, 54);
            this.btn_D_Refresh.TabIndex = 10;
            this.btn_D_Refresh.Text = "Refresh";
            this.btn_D_Refresh.UseVisualStyleBackColor = false;
            this.btn_D_Refresh.Click += new System.EventHandler(this.btn_D_Refresh_Click);
            // 
            // lbl_D_Staff_Role
            // 
            this.lbl_D_Staff_Role.AutoSize = true;
            this.lbl_D_Staff_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_D_Staff_Role.Location = new System.Drawing.Point(398, 168);
            this.lbl_D_Staff_Role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_D_Staff_Role.Name = "lbl_D_Staff_Role";
            this.lbl_D_Staff_Role.Size = new System.Drawing.Size(124, 29);
            this.lbl_D_Staff_Role.TabIndex = 2;
            this.lbl_D_Staff_Role.Text = "Staff Role";
            // 
            // lbl_D_Staff_Name
            // 
            this.lbl_D_Staff_Name.AutoSize = true;
            this.lbl_D_Staff_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_D_Staff_Name.Location = new System.Drawing.Point(398, 256);
            this.lbl_D_Staff_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_D_Staff_Name.Name = "lbl_D_Staff_Name";
            this.lbl_D_Staff_Name.Size = new System.Drawing.Size(140, 29);
            this.lbl_D_Staff_Name.TabIndex = 2;
            this.lbl_D_Staff_Name.Text = "Staff Name";
            // 
            // lbl_D_Staff_Id
            // 
            this.lbl_D_Staff_Id.AutoSize = true;
            this.lbl_D_Staff_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_D_Staff_Id.Location = new System.Drawing.Point(397, 85);
            this.lbl_D_Staff_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_D_Staff_Id.Name = "lbl_D_Staff_Id";
            this.lbl_D_Staff_Id.Size = new System.Drawing.Size(96, 29);
            this.lbl_D_Staff_Id.TabIndex = 2;
            this.lbl_D_Staff_Id.Text = "Staff ID";
            // 
            // tb_D_Staff_id
            // 
            this.tb_D_Staff_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_D_Staff_id.Location = new System.Drawing.Point(633, 85);
            this.tb_D_Staff_id.Margin = new System.Windows.Forms.Padding(4);
            this.tb_D_Staff_id.Name = "tb_D_Staff_id";
            this.tb_D_Staff_id.Size = new System.Drawing.Size(309, 36);
            this.tb_D_Staff_id.TabIndex = 1;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.pnl_header.Controls.Add(this.lbl_Header);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1637, 100);
            this.pnl_header.TabIndex = 7;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(485, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(544, 76);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "STAFF DETAILS";
            // 
            // frm_Staff_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1637, 710);
            this.ControlBox = false;
            this.Controls.Add(this.tc_User);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Staff_Master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Staff_Master_Load);
            this.tc_User.ResumeLayout(false);
            this.tc_Add_Staff.ResumeLayout(false);
            this.gb_Add_Staff_Details.ResumeLayout(false);
            this.gb_Add_Staff_Details.PerformLayout();
            this.tc_Update_Staff.ResumeLayout(false);
            this.gb_Add_Shop_Details.ResumeLayout(false);
            this.gb_Add_Shop_Details.PerformLayout();
            this.tc_Delete_Staff.ResumeLayout(false);
            this.gb_Delete_Staff.ResumeLayout(false);
            this.gb_Delete_Staff.PerformLayout();
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Staff_ID;
        private System.Windows.Forms.TabControl tc_User;
        private System.Windows.Forms.TabPage tc_Add_Staff;
        private System.Windows.Forms.GroupBox gb_Add_Staff_Details;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DateTimePicker dtp_Joning_Dtate;
        private System.Windows.Forms.ComboBox cmb_Staff_Role;
        private System.Windows.Forms.Label lbl_Current_Address;
        private System.Windows.Forms.Label lbl_Joining_Date;
        private System.Windows.Forms.Label lbl_Alt_Mobile_No;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Label lbl_Staff_Role;
        private System.Windows.Forms.Label lbl_Staff_Name;
        private System.Windows.Forms.Label lbl_Adhar_Card_No;
        private System.Windows.Forms.Label lbl_Staff_ID;
        private System.Windows.Forms.TextBox tb_Note;
        private System.Windows.Forms.TextBox tb_current_Address;
        private System.Windows.Forms.TextBox tb_Adhar_Card_No;
        private System.Windows.Forms.TextBox tb_alt_Mobile_No;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Staff_Name;
        private System.Windows.Forms.TabPage tc_Update_Staff;
        private System.Windows.Forms.GroupBox gb_Add_Shop_Details;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_U_Refresh;
        private System.Windows.Forms.DateTimePicker dtp_U_Joinining_Date;
        private System.Windows.Forms.Label lbl_U_Current_Address;
        private System.Windows.Forms.Label Lbl_U_Joinining_Date;
        private System.Windows.Forms.Label lbl_U_Alt_Mob_No;
        private System.Windows.Forms.Label lbl_U_Mob_No;
        private System.Windows.Forms.Label lbl_U_Note;
        private System.Windows.Forms.Label lbl_U_Staff_Role;
        private System.Windows.Forms.Label lbl_U_Staff_Name;
        private System.Windows.Forms.Label lbl_U_Adhar_Card_No;
        private System.Windows.Forms.Label lbl_U_Staff_Id;
        private System.Windows.Forms.TextBox tb_U_Note;
        private System.Windows.Forms.TextBox tb_U_Current_Address;
        private System.Windows.Forms.TextBox tb_U_Adhar_Card_No;
        private System.Windows.Forms.TextBox tb_U_Alt_Mob_No;
        private System.Windows.Forms.TextBox tb_U_Mob_No;
        private System.Windows.Forms.TextBox tb_U_Staff_Name;
        private System.Windows.Forms.TextBox tb_U_Staff_Id;
        private System.Windows.Forms.TabPage tc_Delete_Staff;
        private System.Windows.Forms.GroupBox gb_Delete_Staff;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_D_Refresh;
        private System.Windows.Forms.Label lbl_D_Staff_Role;
        private System.Windows.Forms.Label lbl_D_Staff_Name;
        private System.Windows.Forms.Label lbl_D_Staff_Id;
        private System.Windows.Forms.TextBox tb_D_Staff_id;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cmb_U_Staff_Role;
        private System.Windows.Forms.Button btn_U_Search;
        private System.Windows.Forms.TextBox tb_D_Staff_Name;
        private System.Windows.Forms.TextBox tb_D_Staff_Role;
    }
}