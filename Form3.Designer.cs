namespace Project01
{
    partial class Form3
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
            this.bt_chuyen_doi = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_cong_thuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nguyenLieuInput = new System.Windows.Forms.FlowLayoutPanel();
            this.nguyenLieuConvert = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_so_ng = new System.Windows.Forms.TextBox();
            this.tb_so_ng_ct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Kihieu = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // bt_chuyen_doi
            // 
            this.bt_chuyen_doi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_chuyen_doi.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.bt_chuyen_doi.Location = new System.Drawing.Point(287, 140);
            this.bt_chuyen_doi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_chuyen_doi.Name = "bt_chuyen_doi";
            this.bt_chuyen_doi.Size = new System.Drawing.Size(133, 27);
            this.bt_chuyen_doi.TabIndex = 3;
            this.bt_chuyen_doi.Text = "Chuyển đổi";
            this.bt_chuyen_doi.UseVisualStyleBackColor = true;
            this.bt_chuyen_doi.Click += new System.EventHandler(this.bt_chuyen_doi_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(596, 5);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_cong_thuc
            // 
            this.tb_cong_thuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_cong_thuc.Location = new System.Drawing.Point(144, 40);
            this.tb_cong_thuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_cong_thuc.Name = "tb_cong_thuc";
            this.tb_cong_thuc.Size = new System.Drawing.Size(483, 22);
            this.tb_cong_thuc.TabIndex = 5;
            this.tb_cong_thuc.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập nguyên liệu:";
            // 
            // nguyenLieuInput
            // 
            this.nguyenLieuInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nguyenLieuInput.Location = new System.Drawing.Point(16, 173);
            this.nguyenLieuInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nguyenLieuInput.Name = "nguyenLieuInput";
            this.nguyenLieuInput.Size = new System.Drawing.Size(200, 267);
            this.nguyenLieuInput.TabIndex = 7;
            // 
            // nguyenLieuConvert
            // 
            this.nguyenLieuConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nguyenLieuConvert.Location = new System.Drawing.Point(520, 173);
            this.nguyenLieuConvert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nguyenLieuConvert.Name = "nguyenLieuConvert";
            this.nguyenLieuConvert.Size = new System.Drawing.Size(107, 267);
            this.nguyenLieuConvert.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số lượng người thực tế:";
            // 
            // tb_so_ng
            // 
            this.tb_so_ng.Location = new System.Drawing.Point(275, 112);
            this.tb_so_ng.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_so_ng.Name = "tb_so_ng";
            this.tb_so_ng.Size = new System.Drawing.Size(132, 22);
            this.tb_so_ng.TabIndex = 11;
            // 
            // tb_so_ng_ct
            // 
            this.tb_so_ng_ct.Location = new System.Drawing.Point(275, 77);
            this.tb_so_ng_ct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_so_ng_ct.Name = "tb_so_ng_ct";
            this.tb_so_ng_ct.Size = new System.Drawing.Size(132, 22);
            this.tb_so_ng_ct.TabIndex = 13;
            this.tb_so_ng_ct.TextChanged += new System.EventHandler(this.tb_so_ng_ct_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số người trong một khẩu phần:";
            // 
            // Kihieu
            // 
            this.Kihieu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Kihieu.Location = new System.Drawing.Point(300, 173);
            this.Kihieu.Margin = new System.Windows.Forms.Padding(4);
            this.Kihieu.Name = "Kihieu";
            this.Kihieu.Size = new System.Drawing.Size(107, 267);
            this.Kihieu.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(683, 453);
            this.Controls.Add(this.tb_so_ng_ct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_so_ng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Kihieu);
            this.Controls.Add(this.nguyenLieuConvert);
            this.Controls.Add(this.nguyenLieuInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_cong_thuc);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bt_chuyen_doi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "la";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_chuyen_doi;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb_cong_thuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel nguyenLieuInput;
        private System.Windows.Forms.FlowLayoutPanel nguyenLieuConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_so_ng;
        private System.Windows.Forms.TextBox tb_so_ng_ct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel Kihieu;
    }
}