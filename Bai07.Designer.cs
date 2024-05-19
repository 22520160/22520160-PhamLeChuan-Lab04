namespace Lab04
{
    partial class Bai07
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.Control;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(18, 148);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(620, 585);
            flowLayoutPanel1.TabIndex = 19;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.PeachPuff;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            comboBox2.Location = new Point(596, 744);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(43, 28);
            comboBox2.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.PeachPuff;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            comboBox1.Location = new Point(436, 746);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(43, 28);
            comboBox1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(516, 747);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 14;
            label3.Text = "Page Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(379, 747);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 13;
            label2.Text = "Page";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 20F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(18, 32);
            label1.Name = "label1";
            label1.Size = new Size(305, 39);
            label1.TabIndex = 10;
            label1.Text = "HÔM NAY ĂN GÌ ?";
            // 
            // button1
            // 
            button1.Location = new Point(348, 54);
            button1.Name = "button1";
            button1.Size = new Size(118, 54);
            button1.TabIndex = 0;
            button1.Text = "Ăn gì giờ?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(516, 54);
            button2.Name = "button2";
            button2.Size = new Size(122, 54);
            button2.TabIndex = 1;
            button2.Text = "Thêm món ăn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(18, 113);
            button3.Name = "button3";
            button3.Size = new Size(58, 29);
            button3.TabIndex = 2;
            button3.Text = "All";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(82, 113);
            button4.Name = "button4";
            button4.Size = new Size(138, 29);
            button4.TabIndex = 3;
            button4.Text = "Tôi đóng góp";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Bai07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 790);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai07";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}