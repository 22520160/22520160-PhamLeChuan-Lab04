namespace Lab04
{
    partial class Themmonan
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
            button2 = new Button();
            button1 = new Button();
            txtmota = new TextBox();
            txthinhanh = new TextBox();
            txtdiachi = new TextBox();
            txtgia = new TextBox();
            txtname = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Location = new Point(378, 458);
            button2.Name = "button2";
            button2.Size = new Size(75, 37);
            button2.TabIndex = 25;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(277, 458);
            button1.Name = "button1";
            button1.Size = new Size(75, 37);
            button1.TabIndex = 24;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtmota
            // 
            txtmota.BackColor = Color.White;
            txtmota.Location = new Point(124, 301);
            txtmota.Multiline = true;
            txtmota.Name = "txtmota";
            txtmota.Size = new Size(329, 120);
            txtmota.TabIndex = 23;
            // 
            // txthinhanh
            // 
            txthinhanh.BackColor = Color.White;
            txthinhanh.Location = new Point(124, 249);
            txthinhanh.Name = "txthinhanh";
            txthinhanh.Size = new Size(329, 27);
            txthinhanh.TabIndex = 22;
            txthinhanh.TextChanged += txthinhanh_TextChanged;
            // 
            // txtdiachi
            // 
            txtdiachi.BackColor = Color.White;
            txtdiachi.Location = new Point(124, 198);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(329, 27);
            txtdiachi.TabIndex = 21;
            // 
            // txtgia
            // 
            txtgia.BackColor = Color.White;
            txtgia.Location = new Point(124, 149);
            txtgia.Name = "txtgia";
            txtgia.Size = new Size(329, 27);
            txtgia.TabIndex = 20;
            // 
            // txtname
            // 
            txtname.BackColor = Color.White;
            txtname.Location = new Point(124, 96);
            txtname.Name = "txtname";
            txtname.Size = new Size(329, 27);
            txtname.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(22, 304);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 18;
            label6.Text = "Mô tả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(22, 252);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 17;
            label5.Text = "Hình ảnh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(22, 201);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 16;
            label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(22, 152);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 15;
            label3.Text = "Giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(22, 99);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 14;
            label2.Text = "Tên món ăn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 16F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(124, 33);
            label1.Name = "label1";
            label1.Size = new Size(206, 31);
            label1.TabIndex = 13;
            label1.Text = "THÊM MÓN ĂN";
            // 
            // Themmonan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 511);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtmota);
            Controls.Add(txthinhanh);
            Controls.Add(txtdiachi);
            Controls.Add(txtgia);
            Controls.Add(txtname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Themmonan";
            Text = "Themmonan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.TextBox txthinhanh;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        

        #endregion
    }
}