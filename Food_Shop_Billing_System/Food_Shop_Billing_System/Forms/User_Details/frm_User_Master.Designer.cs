
namespace Food_Shop_Billing_System.Forms.User_Details
{
    partial class frm_User_Master
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
            this.cmb_D_User_Role = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_D_Delete = new System.Windows.Forms.Button();
            this.gb_Delete_User = new System.Windows.Forms.GroupBox();
            this.cmb_D_User_Name = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tc_Delete_User = new System.Windows.Forms.TabPage();
            this.cmb_U_User_Role = new System.Windows.Forms.ComboBox();
            this.tb_U_Password = new System.Windows.Forms.TextBox();
            this.lbl_U_Password = new System.Windows.Forms.Label();
            this.lbl_U_Username = new System.Windows.Forms.Label();
            this.lbl_u_User_Role = new System.Windows.Forms.Label();
            this.btn_U_Update = new System.Windows.Forms.Button();
            this.gb_Update_User = new System.Windows.Forms.GroupBox();
            this.cmb_U_User_Name = new System.Windows.Forms.ComboBox();
            this.tc_Update_User = new System.Windows.Forms.TabPage();
            this.cmb_User_Role = new System.Windows.Forms.ComboBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_User_Role = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.gb_Add_User = new System.Windows.Forms.GroupBox();
            this.tc_Add_user = new System.Windows.Forms.TabPage();
            this.tc_User = new System.Windows.Forms.TabControl();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.gb_Delete_User.SuspendLayout();
            this.tc_Delete_User.SuspendLayout();
            this.gb_Update_User.SuspendLayout();
            this.tc_Update_User.SuspendLayout();
            this.gb_Add_User.SuspendLayout();
            this.tc_Add_user.SuspendLayout();
            this.tc_User.SuspendLayout();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_D_User_Role
            // 
            this.cmb_D_User_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_D_User_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_D_User_Role.FormattingEnabled = true;
            this.cmb_D_User_Role.Items.AddRange(new object[] {
            "Admin",
            "Casher",
            "Maneger"});
            this.cmb_D_User_Role.Location = new System.Drawing.Point(692, 133);
            this.cmb_D_User_Role.Name = "cmb_D_User_Role";
            this.cmb_D_User_Role.Size = new System.Drawing.Size(301, 37);
            this.cmb_D_User_Role.TabIndex = 3;
            this.cmb_D_User_Role.SelectedIndexChanged += new System.EventHandler(this.cmb_D_User_Role_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // btn_D_Delete
            // 
            this.btn_D_Delete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_D_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_D_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_D_Delete.Location = new System.Drawing.Point(563, 351);
            this.btn_D_Delete.Name = "btn_D_Delete";
            this.btn_D_Delete.Size = new System.Drawing.Size(167, 51);
            this.btn_D_Delete.TabIndex = 4;
            this.btn_D_Delete.Text = "Delete";
            this.btn_D_Delete.UseVisualStyleBackColor = false;
            this.btn_D_Delete.Click += new System.EventHandler(this.btn_D_Delete_Click);
            // 
            // gb_Delete_User
            // 
            this.gb_Delete_User.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gb_Delete_User.Controls.Add(this.cmb_D_User_Name);
            this.gb_Delete_User.Controls.Add(this.cmb_D_User_Role);
            this.gb_Delete_User.Controls.Add(this.label2);
            this.gb_Delete_User.Controls.Add(this.label3);
            this.gb_Delete_User.Controls.Add(this.btn_D_Delete);
            this.gb_Delete_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Delete_User.Location = new System.Drawing.Point(228, 58);
            this.gb_Delete_User.Name = "gb_Delete_User";
            this.gb_Delete_User.Size = new System.Drawing.Size(1300, 524);
            this.gb_Delete_User.TabIndex = 2;
            this.gb_Delete_User.TabStop = false;
            this.gb_Delete_User.Text = "Delete User";
            // 
            // cmb_D_User_Name
            // 
            this.cmb_D_User_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_D_User_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_D_User_Name.FormattingEnabled = true;
            this.cmb_D_User_Name.Location = new System.Drawing.Point(692, 214);
            this.cmb_D_User_Name.Name = "cmb_D_User_Name";
            this.cmb_D_User_Name.Size = new System.Drawing.Size(301, 37);
            this.cmb_D_User_Name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "User Role";
            // 
            // tc_Delete_User
            // 
            this.tc_Delete_User.Controls.Add(this.gb_Delete_User);
            this.tc_Delete_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_Delete_User.Location = new System.Drawing.Point(4, 31);
            this.tc_Delete_User.Name = "tc_Delete_User";
            this.tc_Delete_User.Size = new System.Drawing.Size(1746, 648);
            this.tc_Delete_User.TabIndex = 2;
            this.tc_Delete_User.Text = "Delete User";
            this.tc_Delete_User.UseVisualStyleBackColor = true;
            // 
            // cmb_U_User_Role
            // 
            this.cmb_U_User_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_U_User_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_U_User_Role.FormattingEnabled = true;
            this.cmb_U_User_Role.Items.AddRange(new object[] {
            "Admin",
            "Casher",
            "Maneger"});
            this.cmb_U_User_Role.Location = new System.Drawing.Point(696, 92);
            this.cmb_U_User_Role.Name = "cmb_U_User_Role";
            this.cmb_U_User_Role.Size = new System.Drawing.Size(301, 37);
            this.cmb_U_User_Role.TabIndex = 3;
            this.cmb_U_User_Role.SelectedIndexChanged += new System.EventHandler(this.cmb_U_User_Role_SelectedIndexChanged);
            // 
            // tb_U_Password
            // 
            this.tb_U_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_U_Password.Location = new System.Drawing.Point(696, 270);
            this.tb_U_Password.MaxLength = 40;
            this.tb_U_Password.Name = "tb_U_Password";
            this.tb_U_Password.Size = new System.Drawing.Size(301, 36);
            this.tb_U_Password.TabIndex = 5;
            // 
            // lbl_U_Password
            // 
            this.lbl_U_Password.AutoSize = true;
            this.lbl_U_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_U_Password.Location = new System.Drawing.Point(406, 271);
            this.lbl_U_Password.Name = "lbl_U_Password";
            this.lbl_U_Password.Size = new System.Drawing.Size(134, 31);
            this.lbl_U_Password.TabIndex = 1;
            this.lbl_U_Password.Text = "Password";
            // 
            // lbl_U_Username
            // 
            this.lbl_U_Username.AutoSize = true;
            this.lbl_U_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_U_Username.Location = new System.Drawing.Point(406, 176);
            this.lbl_U_Username.Name = "lbl_U_Username";
            this.lbl_U_Username.Size = new System.Drawing.Size(139, 31);
            this.lbl_U_Username.TabIndex = 1;
            this.lbl_U_Username.Text = "Username";
            // 
            // lbl_u_User_Role
            // 
            this.lbl_u_User_Role.AutoSize = true;
            this.lbl_u_User_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_u_User_Role.Location = new System.Drawing.Point(405, 98);
            this.lbl_u_User_Role.Name = "lbl_u_User_Role";
            this.lbl_u_User_Role.Size = new System.Drawing.Size(135, 31);
            this.lbl_u_User_Role.TabIndex = 1;
            this.lbl_u_User_Role.Text = "User Role";
            // 
            // btn_U_Update
            // 
            this.btn_U_Update.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_U_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_U_Update.ForeColor = System.Drawing.Color.White;
            this.btn_U_Update.Location = new System.Drawing.Point(584, 360);
            this.btn_U_Update.Name = "btn_U_Update";
            this.btn_U_Update.Size = new System.Drawing.Size(167, 51);
            this.btn_U_Update.TabIndex = 6;
            this.btn_U_Update.Text = "Update";
            this.btn_U_Update.UseVisualStyleBackColor = false;
            this.btn_U_Update.Click += new System.EventHandler(this.btn_U_Update_Click);
            // 
            // gb_Update_User
            // 
            this.gb_Update_User.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gb_Update_User.Controls.Add(this.cmb_U_User_Name);
            this.gb_Update_User.Controls.Add(this.cmb_U_User_Role);
            this.gb_Update_User.Controls.Add(this.tb_U_Password);
            this.gb_Update_User.Controls.Add(this.lbl_U_Password);
            this.gb_Update_User.Controls.Add(this.lbl_U_Username);
            this.gb_Update_User.Controls.Add(this.lbl_u_User_Role);
            this.gb_Update_User.Controls.Add(this.btn_U_Update);
            this.gb_Update_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Update_User.Location = new System.Drawing.Point(228, 54);
            this.gb_Update_User.Name = "gb_Update_User";
            this.gb_Update_User.Size = new System.Drawing.Size(1352, 518);
            this.gb_Update_User.TabIndex = 2;
            this.gb_Update_User.TabStop = false;
            this.gb_Update_User.Text = "Update User";
            // 
            // cmb_U_User_Name
            // 
            this.cmb_U_User_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_U_User_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_U_User_Name.FormattingEnabled = true;
            this.cmb_U_User_Name.Location = new System.Drawing.Point(696, 176);
            this.cmb_U_User_Name.Name = "cmb_U_User_Name";
            this.cmb_U_User_Name.Size = new System.Drawing.Size(301, 37);
            this.cmb_U_User_Name.TabIndex = 7;
            // 
            // tc_Update_User
            // 
            this.tc_Update_User.Controls.Add(this.gb_Update_User);
            this.tc_Update_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_Update_User.Location = new System.Drawing.Point(4, 31);
            this.tc_Update_User.Name = "tc_Update_User";
            this.tc_Update_User.Padding = new System.Windows.Forms.Padding(3);
            this.tc_Update_User.Size = new System.Drawing.Size(1746, 648);
            this.tc_Update_User.TabIndex = 1;
            this.tc_Update_User.Text = "Update User";
            this.tc_Update_User.UseVisualStyleBackColor = true;
            // 
            // cmb_User_Role
            // 
            this.cmb_User_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_User_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_User_Role.FormattingEnabled = true;
            this.cmb_User_Role.Items.AddRange(new object[] {
            "Admin",
            "Casher",
            "Maneger"});
            this.cmb_User_Role.Location = new System.Drawing.Point(732, 107);
            this.cmb_User_Role.Name = "cmb_User_Role";
            this.cmb_User_Role.Size = new System.Drawing.Size(301, 37);
            this.cmb_User_Role.TabIndex = 3;
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(732, 293);
            this.tb_Password.MaxLength = 40;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(301, 36);
            this.tb_Password.TabIndex = 5;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(442, 294);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(134, 31);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Password";
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(732, 193);
            this.tb_Username.MaxLength = 120;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(301, 36);
            this.tb_Username.TabIndex = 4;
            this.tb_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Username_KeyPress);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(442, 194);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(139, 31);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_User_Role
            // 
            this.lbl_User_Role.AutoSize = true;
            this.lbl_User_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Role.Location = new System.Drawing.Point(442, 102);
            this.lbl_User_Role.Name = "lbl_User_Role";
            this.lbl_User_Role.Size = new System.Drawing.Size(135, 31);
            this.lbl_User_Role.TabIndex = 1;
            this.lbl_User_Role.Text = "User Role";
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(602, 381);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(167, 51);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // gb_Add_User
            // 
            this.gb_Add_User.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_Add_User.Controls.Add(this.cmb_User_Role);
            this.gb_Add_User.Controls.Add(this.tb_Password);
            this.gb_Add_User.Controls.Add(this.lbl_Password);
            this.gb_Add_User.Controls.Add(this.tb_Username);
            this.gb_Add_User.Controls.Add(this.lbl_Username);
            this.gb_Add_User.Controls.Add(this.lbl_User_Role);
            this.gb_Add_User.Controls.Add(this.btn_Submit);
            this.gb_Add_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Add_User.Location = new System.Drawing.Point(171, 37);
            this.gb_Add_User.Name = "gb_Add_User";
            this.gb_Add_User.Size = new System.Drawing.Size(1410, 546);
            this.gb_Add_User.TabIndex = 2;
            this.gb_Add_User.TabStop = false;
            this.gb_Add_User.Text = "Add User";
            // 
            // tc_Add_user
            // 
            this.tc_Add_user.BackColor = System.Drawing.SystemColors.Control;
            this.tc_Add_user.Controls.Add(this.gb_Add_User);
            this.tc_Add_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_Add_user.Location = new System.Drawing.Point(4, 31);
            this.tc_Add_user.Name = "tc_Add_user";
            this.tc_Add_user.Padding = new System.Windows.Forms.Padding(3);
            this.tc_Add_user.Size = new System.Drawing.Size(1746, 648);
            this.tc_Add_user.TabIndex = 0;
            this.tc_Add_user.Text = "Add User";
            // 
            // tc_User
            // 
            this.tc_User.Controls.Add(this.tc_Add_user);
            this.tc_User.Controls.Add(this.tc_Update_User);
            this.tc_User.Controls.Add(this.tc_Delete_User);
            this.tc_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_User.Location = new System.Drawing.Point(0, 105);
            this.tc_User.Name = "tc_User";
            this.tc_User.SelectedIndex = 0;
            this.tc_User.Size = new System.Drawing.Size(1754, 683);
            this.tc_User.TabIndex = 3;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(690, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(378, 76);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "ADD USER";
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.pnl_header.Controls.Add(this.lbl_Header);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1762, 100);
            this.pnl_header.TabIndex = 4;
            // 
            // frm_User_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1762, 789);
            this.ControlBox = false;
            this.Controls.Add(this.tc_User);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_User_Master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_User_Master_Load);
            this.gb_Delete_User.ResumeLayout(false);
            this.gb_Delete_User.PerformLayout();
            this.tc_Delete_User.ResumeLayout(false);
            this.gb_Update_User.ResumeLayout(false);
            this.gb_Update_User.PerformLayout();
            this.tc_Update_User.ResumeLayout(false);
            this.gb_Add_User.ResumeLayout(false);
            this.gb_Add_User.PerformLayout();
            this.tc_Add_user.ResumeLayout(false);
            this.tc_User.ResumeLayout(false);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_D_User_Role;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_D_Delete;
        private System.Windows.Forms.GroupBox gb_Delete_User;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tc_Delete_User;
        private System.Windows.Forms.ComboBox cmb_U_User_Role;
        private System.Windows.Forms.TextBox tb_U_Password;
        private System.Windows.Forms.Label lbl_U_Password;
        private System.Windows.Forms.Label lbl_U_Username;
        private System.Windows.Forms.Label lbl_u_User_Role;
        private System.Windows.Forms.Button btn_U_Update;
        private System.Windows.Forms.GroupBox gb_Update_User;
        private System.Windows.Forms.TabPage tc_Update_User;
        private System.Windows.Forms.ComboBox cmb_User_Role;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_User_Role;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.GroupBox gb_Add_User;
        private System.Windows.Forms.TabPage tc_Add_user;
        private System.Windows.Forms.TabControl tc_User;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.ComboBox cmb_U_User_Name;
        private System.Windows.Forms.ComboBox cmb_D_User_Name;
    }
}