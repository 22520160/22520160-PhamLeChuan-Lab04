namespace Lab04
{
    partial class Bai03
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            buttonReload = new Button();
            textBox1 = new TextBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 18);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(617, 60);
            button2.Name = "button2";
            button2.Size = new Size(137, 29);
            button2.TabIndex = 1;
            button2.Text = "Down resources";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(469, 60);
            button3.Name = "button3";
            button3.Size = new Size(126, 29);
            button3.TabIndex = 2;
            button3.Text = "Down files";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // buttonReload
            // 
            buttonReload.Location = new Point(617, 17);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(137, 29);
            buttonReload.TabIndex = 3;
            buttonReload.Text = "Reload";
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += buttonReload_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(483, 27);
            textBox1.TabIndex = 4;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 110);
            webView21.Name = "webView21";
            webView21.Size = new Size(742, 328);
            webView21.TabIndex = 5;
            webView21.ZoomFactor = 1D;
            // 
            // webView2
            // 
            webView2.AllowExternalDrop = true;
            webView2.CreationProperties = null;
            webView2.DefaultBackgroundColor = Color.White;
            webView2.Location = new Point(-2, 441);
            webView2.Name = "webView2";
            webView2.Size = new Size(10, 10);
            webView2.TabIndex = 6;
            webView2.ZoomFactor = 1D;
            // 
            // Bai03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 450);
            Controls.Add(webView2);
            Controls.Add(webView21);
            Controls.Add(textBox1);
            Controls.Add(buttonReload);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Bai03";
            Text = "Bai03";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button buttonReload;
        private TextBox textBox1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
    }
}