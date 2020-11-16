namespace Project01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSlideMenu = new System.Windows.Forms.Panel();
            this.panelSubmenu = new System.Windows.Forms.Panel();
            this.btnIngridientsofFood = new System.Windows.Forms.Button();
            this.btnIngridientsExchange = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSlideMenu.SuspendLayout();
            this.panelSubmenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSlideMenu
            // 
            this.panelSlideMenu.AutoScroll = true;
            this.panelSlideMenu.BackColor = System.Drawing.Color.Maroon;
            this.panelSlideMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSlideMenu.Controls.Add(this.panelSubmenu);
            this.panelSlideMenu.Controls.Add(this.btnMenu);
            this.panelSlideMenu.Controls.Add(this.panelLogo);
            this.panelSlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSlideMenu.Name = "panelSlideMenu";
            this.panelSlideMenu.Size = new System.Drawing.Size(250, 553);
            this.panelSlideMenu.TabIndex = 0;
            // 
            // panelSubmenu
            // 
            this.panelSubmenu.BackColor = System.Drawing.Color.IndianRed;
            this.panelSubmenu.Controls.Add(this.btnIngridientsofFood);
            this.panelSubmenu.Controls.Add(this.btnIngridientsExchange);
            this.panelSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelSubmenu.Location = new System.Drawing.Point(0, 130);
            this.panelSubmenu.Name = "panelSubmenu";
            this.panelSubmenu.Size = new System.Drawing.Size(246, 80);
            this.panelSubmenu.TabIndex = 2;
            // 
            // btnIngridientsofFood
            // 
            this.btnIngridientsofFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIngridientsofFood.FlatAppearance.BorderSize = 0;
            this.btnIngridientsofFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngridientsofFood.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIngridientsofFood.ForeColor = System.Drawing.Color.Black;
            this.btnIngridientsofFood.Image = ((System.Drawing.Image)(resources.GetObject("btnIngridientsofFood.Image")));
            this.btnIngridientsofFood.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngridientsofFood.Location = new System.Drawing.Point(0, 40);
            this.btnIngridientsofFood.Name = "btnIngridientsofFood";
            this.btnIngridientsofFood.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIngridientsofFood.Size = new System.Drawing.Size(246, 37);
            this.btnIngridientsofFood.TabIndex = 0;
            this.btnIngridientsofFood.Text = "Needs for a meal";
            this.btnIngridientsofFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngridientsofFood.UseVisualStyleBackColor = true;
            this.btnIngridientsofFood.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnIngridientsExchange
            // 
            this.btnIngridientsExchange.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIngridientsExchange.FlatAppearance.BorderSize = 0;
            this.btnIngridientsExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngridientsExchange.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIngridientsExchange.ForeColor = System.Drawing.Color.Black;
            this.btnIngridientsExchange.Image = ((System.Drawing.Image)(resources.GetObject("btnIngridientsExchange.Image")));
            this.btnIngridientsExchange.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngridientsExchange.Location = new System.Drawing.Point(0, 0);
            this.btnIngridientsExchange.Name = "btnIngridientsExchange";
            this.btnIngridientsExchange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIngridientsExchange.Size = new System.Drawing.Size(246, 40);
            this.btnIngridientsExchange.TabIndex = 0;
            this.btnIngridientsExchange.Text = "Ingridients Exchange";
            this.btnIngridientsExchange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngridientsExchange.UseVisualStyleBackColor = true;
            this.btnIngridientsExchange.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 74);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMenu.Size = new System.Drawing.Size(246, 56);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Maroon;
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(246, 74);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Firebrick;
            this.panelChildForm.Controls.Add(this.panel1);
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(682, 553);
            this.panelChildForm.TabIndex = 2;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(213, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(174, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 67);
            this.label1.TabIndex = 15;
            this.label1.Text = "INGRIDIENTS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 88);
            this.panel1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSlideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.panelSlideMenu.ResumeLayout(false);
            this.panelSubmenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSlideMenu;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelSubmenu;
        private System.Windows.Forms.Button btnIngridientsofFood;
        private System.Windows.Forms.Button btnIngridientsExchange;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

