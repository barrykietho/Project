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
            this.btnIngridientsOfFood = new System.Windows.Forms.Button();
            this.btnIngridientsExchange = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSlideMenu.SuspendLayout();
            this.panelSubmenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSlideMenu
            // 
            this.panelSlideMenu.AutoScroll = true;
            this.panelSlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
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
            this.panelSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.panelSubmenu.Controls.Add(this.btnIngridientsOfFood);
            this.panelSubmenu.Controls.Add(this.btnIngridientsExchange);
            this.panelSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelSubmenu.Location = new System.Drawing.Point(0, 145);
            this.panelSubmenu.Name = "panelSubmenu";
            this.panelSubmenu.Size = new System.Drawing.Size(250, 80);
            this.panelSubmenu.TabIndex = 2;
            // 
            // btnIngridientsOfFood
            // 
            this.btnIngridientsOfFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIngridientsOfFood.FlatAppearance.BorderSize = 0;
            this.btnIngridientsOfFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngridientsOfFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngridientsOfFood.ForeColor = System.Drawing.Color.White;
            this.btnIngridientsOfFood.Location = new System.Drawing.Point(0, 40);
            this.btnIngridientsOfFood.Name = "btnIngridientsOfFood";
            this.btnIngridientsOfFood.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnIngridientsOfFood.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIngridientsOfFood.Size = new System.Drawing.Size(250, 37);
            this.btnIngridientsOfFood.TabIndex = 0;
            this.btnIngridientsOfFood.Text = "Ingridients Of Food";
            this.btnIngridientsOfFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngridientsOfFood.UseVisualStyleBackColor = true;
            this.btnIngridientsOfFood.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnIngridientsExchange
            // 
            this.btnIngridientsExchange.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIngridientsExchange.FlatAppearance.BorderSize = 0;
            this.btnIngridientsExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngridientsExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngridientsExchange.ForeColor = System.Drawing.Color.White;
            this.btnIngridientsExchange.Location = new System.Drawing.Point(0, 0);
            this.btnIngridientsExchange.Name = "btnIngridientsExchange";
            this.btnIngridientsExchange.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnIngridientsExchange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIngridientsExchange.Size = new System.Drawing.Size(250, 40);
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
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnMenu.Location = new System.Drawing.Point(0, 100);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMenu.Size = new System.Drawing.Size(250, 45);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.Black;
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlayer.Location = new System.Drawing.Point(250, 477);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(682, 76);
            this.panelPlayer.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(682, 477);
            this.panelChildForm.TabIndex = 2;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 313);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelPlayer);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSlideMenu;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelSubmenu;
        private System.Windows.Forms.Button btnIngridientsOfFood;
        private System.Windows.Forms.Button btnIngridientsExchange;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

