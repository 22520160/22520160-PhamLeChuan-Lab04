﻿namespace Lab04
{
    partial class Sign_up
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
            groupBox2 = new GroupBox();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            txtphone = new TextBox();
            txtlast = new TextBox();
            txtfirst = new TextBox();
            txtemail = new TextBox();
            label10 = new Label();
            label6 = new Label();
            label12 = new Label();
            label7 = new Label();
            label11 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            txtmatkhau = new TextBox();
            txtname = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Location = new Point(434, 615);
            button2.Name = "button2";
            button2.Size = new Size(86, 34);
            button2.TabIndex = 20;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(323, 615);
            button1.Name = "button1";
            button1.Size = new Size(87, 34);
            button1.TabIndex = 19;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(txtphone);
            groupBox2.Controls.Add(txtlast);
            groupBox2.Controls.Add(txtfirst);
            groupBox2.Controls.Add(txtemail);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(22, 253);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(498, 335);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "User information";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.White;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Male", "Female" });
            comboBox2.Location = new Point(89, 299);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(404, 28);
            comboBox2.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.PeachPuff;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(89, 211);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(404, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "None", "Việt Nam" });
            comboBox1.Location = new Point(89, 256);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(404, 28);
            comboBox1.TabIndex = 15;
            // 
            // txtphone
            // 
            txtphone.BackColor = Color.White;
            txtphone.Location = new Point(89, 168);
            txtphone.Multiline = true;
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(404, 29);
            txtphone.TabIndex = 14;
            // 
            // txtlast
            // 
            txtlast.BackColor = Color.White;
            txtlast.Location = new Point(89, 120);
            txtlast.Multiline = true;
            txtlast.Name = "txtlast";
            txtlast.Size = new Size(404, 29);
            txtlast.TabIndex = 13;
            // 
            // txtfirst
            // 
            txtfirst.BackColor = Color.White;
            txtfirst.Location = new Point(89, 78);
            txtfirst.Multiline = true;
            txtfirst.Name = "txtfirst";
            txtfirst.Size = new Size(404, 29);
            txtfirst.TabIndex = 12;
            // 
            // txtemail
            // 
            txtemail.BackColor = Color.White;
            txtemail.Location = new Point(89, 34);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(404, 29);
            txtemail.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 217);
            label10.Name = "label10";
            label10.Size = new Size(64, 20);
            label10.TabIndex = 9;
            label10.Text = "Birthday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 37);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 302);
            label12.Name = "label12";
            label12.Size = new Size(57, 20);
            label12.TabIndex = 11;
            label12.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 81);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 6;
            label7.Text = "Firstname";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 259);
            label11.Name = "label11";
            label11.Size = new Size(74, 20);
            label11.TabIndex = 10;
            label11.Text = "Language";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 123);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 7;
            label8.Text = "Lastname";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 171);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 8;
            label9.Text = "Phone";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtmatkhau);
            groupBox1.Controls.Add(txtname);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(22, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(498, 141);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sign up";
            // 
            // txtmatkhau
            // 
            txtmatkhau.BackColor = Color.White;
            txtmatkhau.Location = new Point(89, 90);
            txtmatkhau.Multiline = true;
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.PasswordChar = '*';
            txtmatkhau.Size = new Size(404, 29);
            txtmatkhau.TabIndex = 5;
            // 
            // txtname
            // 
            txtname.BackColor = Color.White;
            txtname.Location = new Point(89, 31);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(404, 29);
            txtname.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 34);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 93);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 16F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(145, 20);
            label1.Name = "label1";
            label1.Size = new Size(236, 31);
            label1.TabIndex = 16;
            label1.Text = "HÔM NAY ĂN GÌ?";
            // 
            // Sign_up
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 673);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Sign_up";
            Text = "Sign_up";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtlast;
        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}