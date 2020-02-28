namespace SqliteCEF
{
    partial class MainForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DbRoot = new System.Windows.Forms.TextBox();
            this.Browse_Button = new System.Windows.Forms.Button();
            this.Query_TextBox = new System.Windows.Forms.TextBox();
            this.CreateCef_Button = new System.Windows.Forms.Button();
            this.Cef_textBox = new System.Windows.Forms.TextBox();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Close_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "db";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "DB files|*.db";
            this.openFileDialog1.Title = "Browse Text Files";
            // 
            // DbRoot
            // 
            this.DbRoot.Enabled = false;
            this.DbRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DbRoot.Location = new System.Drawing.Point(12, 43);
            this.DbRoot.Name = "DbRoot";
            this.DbRoot.Size = new System.Drawing.Size(690, 26);
            this.DbRoot.TabIndex = 0;
            // 
            // Browse_Button
            // 
            this.Browse_Button.Location = new System.Drawing.Point(708, 43);
            this.Browse_Button.Name = "Browse_Button";
            this.Browse_Button.Size = new System.Drawing.Size(83, 26);
            this.Browse_Button.TabIndex = 1;
            this.Browse_Button.Text = "Browse";
            this.Browse_Button.UseVisualStyleBackColor = true;
            this.Browse_Button.Click += new System.EventHandler(this.Browse_Button_Click);
            // 
            // Query_TextBox
            // 
            this.Query_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Query_TextBox.Location = new System.Drawing.Point(58, 167);
            this.Query_TextBox.Multiline = true;
            this.Query_TextBox.Name = "Query_TextBox";
            this.Query_TextBox.Size = new System.Drawing.Size(690, 195);
            this.Query_TextBox.TabIndex = 2;
            // 
            // CreateCef_Button
            // 
            this.CreateCef_Button.Location = new System.Drawing.Point(665, 368);
            this.CreateCef_Button.Name = "CreateCef_Button";
            this.CreateCef_Button.Size = new System.Drawing.Size(83, 26);
            this.CreateCef_Button.TabIndex = 3;
            this.CreateCef_Button.Text = "Test";
            this.CreateCef_Button.UseVisualStyleBackColor = true;
            this.CreateCef_Button.Click += new System.EventHandler(this.CreateCef_Button_Click);
            // 
            // Cef_textBox
            // 
            this.Cef_textBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cef_textBox.Location = new System.Drawing.Point(58, 437);
            this.Cef_textBox.Name = "Cef_textBox";
            this.Cef_textBox.Size = new System.Drawing.Size(690, 26);
            this.Cef_textBox.TabIndex = 4;
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(12, 75);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(94, 26);
            this.Connect_Button.TabIndex = 5;
            this.Connect_Button.Text = "Connect";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "CEF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Chose local db:";
            // 
            // Close_Button
            // 
            this.Close_Button.Location = new System.Drawing.Point(112, 75);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(94, 26);
            this.Close_Button.TabIndex = 9;
            this.Close_Button.Text = "Disconnect";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 501);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connect_Button);
            this.Controls.Add(this.Cef_textBox);
            this.Controls.Add(this.CreateCef_Button);
            this.Controls.Add(this.Query_TextBox);
            this.Controls.Add(this.Browse_Button);
            this.Controls.Add(this.DbRoot);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox DbRoot;
        private System.Windows.Forms.Button Browse_Button;
        private System.Windows.Forms.TextBox Query_TextBox;
        private System.Windows.Forms.Button CreateCef_Button;
        private System.Windows.Forms.TextBox Cef_textBox;
        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Close_Button;
    }
}