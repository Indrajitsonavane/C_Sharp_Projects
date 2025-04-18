
namespace Paint
{
    partial class frm_Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_Rect = new System.Windows.Forms.Button();
            this.btn_Ellipse = new System.Windows.Forms.Button();
            this.btn_Eraser = new System.Windows.Forms.Button();
            this.btn_Pencil = new System.Windows.Forms.Button();
            this.Btn_Color = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1376, 136);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btn_Clear);
            this.panel2.Controls.Add(this.btn_line);
            this.panel2.Controls.Add(this.btn_Rect);
            this.panel2.Controls.Add(this.btn_Ellipse);
            this.panel2.Controls.Add(this.btn_Eraser);
            this.panel2.Controls.Add(this.btn_Pencil);
            this.panel2.Controls.Add(this.Btn_Color);
            this.panel2.Controls.Add(this.pic_color);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1376, 136);
            this.panel2.TabIndex = 1;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clear.Location = new System.Drawing.Point(1272, 74);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(76, 31);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_line
            // 
            this.btn_line.BackgroundImage = global::Paint.Properties.Resources.line;
            this.btn_line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.ForeColor = System.Drawing.Color.White;
            this.btn_line.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_line.Location = new System.Drawing.Point(1194, 56);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(72, 74);
            this.btn_line.TabIndex = 7;
            this.btn_line.Text = "Line";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = true;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_Rect
            // 
            this.btn_Rect.BackgroundImage = global::Paint.Properties.Resources.rectangle;
            this.btn_Rect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rect.ForeColor = System.Drawing.Color.White;
            this.btn_Rect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Rect.Location = new System.Drawing.Point(1123, 56);
            this.btn_Rect.Name = "btn_Rect";
            this.btn_Rect.Size = new System.Drawing.Size(65, 74);
            this.btn_Rect.TabIndex = 6;
            this.btn_Rect.Text = "Rect";
            this.btn_Rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Rect.UseVisualStyleBackColor = true;
            this.btn_Rect.Click += new System.EventHandler(this.btn_Rect_Click);
            // 
            // btn_Ellipse
            // 
            this.btn_Ellipse.BackgroundImage = global::Paint.Properties.Resources.circle;
            this.btn_Ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ellipse.ForeColor = System.Drawing.Color.White;
            this.btn_Ellipse.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Ellipse.Location = new System.Drawing.Point(1042, 55);
            this.btn_Ellipse.Name = "btn_Ellipse";
            this.btn_Ellipse.Size = new System.Drawing.Size(75, 78);
            this.btn_Ellipse.TabIndex = 5;
            this.btn_Ellipse.Text = "Ellipse";
            this.btn_Ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Ellipse.UseVisualStyleBackColor = true;
            this.btn_Ellipse.Click += new System.EventHandler(this.btn_Ellipse_Click);
            // 
            // btn_Eraser
            // 
            this.btn_Eraser.BackgroundImage = global::Paint.Properties.Resources.eraser;
            this.btn_Eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eraser.ForeColor = System.Drawing.Color.White;
            this.btn_Eraser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eraser.Location = new System.Drawing.Point(968, 55);
            this.btn_Eraser.Name = "btn_Eraser";
            this.btn_Eraser.Size = new System.Drawing.Size(68, 75);
            this.btn_Eraser.TabIndex = 4;
            this.btn_Eraser.Text = "Eraser";
            this.btn_Eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Eraser.UseVisualStyleBackColor = true;
            this.btn_Eraser.Click += new System.EventHandler(this.btn_Eraser_Click);
            // 
            // btn_Pencil
            // 
            this.btn_Pencil.BackgroundImage = global::Paint.Properties.Resources.pencil;
            this.btn_Pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pencil.ForeColor = System.Drawing.Color.White;
            this.btn_Pencil.Location = new System.Drawing.Point(901, 55);
            this.btn_Pencil.Name = "btn_Pencil";
            this.btn_Pencil.Size = new System.Drawing.Size(61, 78);
            this.btn_Pencil.TabIndex = 3;
            this.btn_Pencil.Text = "pencil";
            this.btn_Pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Pencil.UseVisualStyleBackColor = true;
            this.btn_Pencil.Click += new System.EventHandler(this.btn_Pencil_Click);
            // 
            // Btn_Color
            // 
            this.Btn_Color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Color.BackgroundImage")));
            this.Btn_Color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Color.ForeColor = System.Drawing.Color.White;
            this.Btn_Color.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Color.Location = new System.Drawing.Point(811, 55);
            this.Btn_Color.Name = "Btn_Color";
            this.Btn_Color.Size = new System.Drawing.Size(62, 55);
            this.Btn_Color.TabIndex = 1;
            this.Btn_Color.Text = "Color";
            this.Btn_Color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Color.UseVisualStyleBackColor = true;
            this.Btn_Color.Click += new System.EventHandler(this.Btn_Color_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Location = new System.Drawing.Point(680, 68);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(42, 42);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(0, 697);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1376, 32);
            this.panel3.TabIndex = 2;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 136);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1376, 561);
            this.pic.TabIndex = 3;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // frm_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 729);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Button Btn_Color;
        private System.Windows.Forms.Button btn_Pencil;
        private System.Windows.Forms.Button btn_Eraser;
        private System.Windows.Forms.Button btn_Ellipse;
        private System.Windows.Forms.Button btn_Rect;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_Clear;
    }
}

