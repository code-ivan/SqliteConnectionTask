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
            this.DbPath = new System.Windows.Forms.TextBox();
            this.Browse_Button = new System.Windows.Forms.Button();
            this.Query_TextBox = new System.Windows.Forms.TextBox();
            this.CreateCef_Button = new System.Windows.Forms.Button();
            this.Cef_textBox = new System.Windows.Forms.TextBox();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Close_Button = new System.Windows.Forms.Button();
            this.queryError = new System.Windows.Forms.Label();
            this.mappingGroupBox = new System.Windows.Forms.GroupBox();
            this.mappingError = new System.Windows.Forms.Label();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateQuery = new System.Windows.Forms.Button();
            this.extension_comboBox = new System.Windows.Forms.ComboBox();
            this.exstension_textBox = new System.Windows.Forms.TextBox();
            this.severity_comboBox = new System.Windows.Forms.ComboBox();
            this.name_comboBox = new System.Windows.Forms.ComboBox();
            this.eventClassId_comboBox = new System.Windows.Forms.ComboBox();
            this.deviceVersion_textBox = new System.Windows.Forms.TextBox();
            this.product_textBox = new System.Windows.Forms.TextBox();
            this.vendor_textBox = new System.Windows.Forms.TextBox();
            this.version_textBox = new System.Windows.Forms.TextBox();
            this.tables_comboBox = new System.Windows.Forms.ComboBox();
            this.id_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.onlyBox = new System.Windows.Forms.CheckBox();
            this.mappingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "db";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "DB files|*.db";
            this.openFileDialog1.Title = "Browse Text Files";
            // 
            // DbPath
            // 
            this.DbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DbPath.Location = new System.Drawing.Point(12, 43);
            this.DbPath.Name = "DbPath";
            this.DbPath.Size = new System.Drawing.Size(774, 26);
            this.DbPath.TabIndex = 0;
            // 
            // Browse_Button
            // 
            this.Browse_Button.Location = new System.Drawing.Point(792, 43);
            this.Browse_Button.Name = "Browse_Button";
            this.Browse_Button.Size = new System.Drawing.Size(83, 26);
            this.Browse_Button.TabIndex = 1;
            this.Browse_Button.Text = "Browse";
            this.Browse_Button.UseVisualStyleBackColor = true;
            this.Browse_Button.Click += new System.EventHandler(this.Browse_Button_Click);
            // 
            // Query_TextBox
            // 
            this.Query_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Query_TextBox.Location = new System.Drawing.Point(510, 243);
            this.Query_TextBox.Multiline = true;
            this.Query_TextBox.Name = "Query_TextBox";
            this.Query_TextBox.Size = new System.Drawing.Size(461, 253);
            this.Query_TextBox.TabIndex = 2;
            this.Query_TextBox.TextChanged += new System.EventHandler(this.Query_TextBox_TextChanged);
            // 
            // CreateCef_Button
            // 
            this.CreateCef_Button.Location = new System.Drawing.Point(888, 520);
            this.CreateCef_Button.Name = "CreateCef_Button";
            this.CreateCef_Button.Size = new System.Drawing.Size(83, 26);
            this.CreateCef_Button.TabIndex = 3;
            this.CreateCef_Button.Text = "Test";
            this.CreateCef_Button.UseVisualStyleBackColor = true;
            this.CreateCef_Button.Click += new System.EventHandler(this.CreateCef_Button_Click);
            // 
            // Cef_textBox
            // 
            this.Cef_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cef_textBox.Location = new System.Drawing.Point(51, 619);
            this.Cef_textBox.Name = "Cef_textBox";
            this.Cef_textBox.Size = new System.Drawing.Size(873, 26);
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
            this.label1.Location = new System.Drawing.Point(505, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(46, 591);
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
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "SQLite Data Base:";
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
            // queryError
            // 
            this.queryError.AutoSize = true;
            this.queryError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queryError.ForeColor = System.Drawing.Color.Red;
            this.queryError.Location = new System.Drawing.Point(596, 211);
            this.queryError.Name = "queryError";
            this.queryError.Size = new System.Drawing.Size(0, 18);
            this.queryError.TabIndex = 10;
            // 
            // mappingGroupBox
            // 
            this.mappingGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.mappingGroupBox.Controls.Add(this.mappingError);
            this.mappingGroupBox.Controls.Add(this.comboBox14);
            this.mappingGroupBox.Controls.Add(this.comboBox13);
            this.mappingGroupBox.Controls.Add(this.comboBox12);
            this.mappingGroupBox.Controls.Add(this.comboBox11);
            this.mappingGroupBox.Controls.Add(this.comboBox10);
            this.mappingGroupBox.Controls.Add(this.comboBox9);
            this.mappingGroupBox.Controls.Add(this.comboBox8);
            this.mappingGroupBox.Controls.Add(this.comboBox7);
            this.mappingGroupBox.Controls.Add(this.label13);
            this.mappingGroupBox.Controls.Add(this.label12);
            this.mappingGroupBox.Controls.Add(this.label11);
            this.mappingGroupBox.Controls.Add(this.label10);
            this.mappingGroupBox.Controls.Add(this.label9);
            this.mappingGroupBox.Controls.Add(this.label8);
            this.mappingGroupBox.Controls.Add(this.label7);
            this.mappingGroupBox.Controls.Add(this.label6);
            this.mappingGroupBox.Controls.Add(this.label4);
            this.mappingGroupBox.Controls.Add(this.CreateQuery);
            this.mappingGroupBox.Controls.Add(this.extension_comboBox);
            this.mappingGroupBox.Controls.Add(this.exstension_textBox);
            this.mappingGroupBox.Controls.Add(this.severity_comboBox);
            this.mappingGroupBox.Controls.Add(this.name_comboBox);
            this.mappingGroupBox.Controls.Add(this.eventClassId_comboBox);
            this.mappingGroupBox.Controls.Add(this.deviceVersion_textBox);
            this.mappingGroupBox.Controls.Add(this.product_textBox);
            this.mappingGroupBox.Controls.Add(this.vendor_textBox);
            this.mappingGroupBox.Controls.Add(this.version_textBox);
            this.mappingGroupBox.Enabled = false;
            this.mappingGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mappingGroupBox.Location = new System.Drawing.Point(17, 196);
            this.mappingGroupBox.Name = "mappingGroupBox";
            this.mappingGroupBox.Size = new System.Drawing.Size(448, 362);
            this.mappingGroupBox.TabIndex = 11;
            this.mappingGroupBox.TabStop = false;
            // 
            // mappingError
            // 
            this.mappingError.AutoSize = true;
            this.mappingError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mappingError.ForeColor = System.Drawing.Color.Red;
            this.mappingError.Location = new System.Drawing.Point(115, 23);
            this.mappingError.Name = "mappingError";
            this.mappingError.Size = new System.Drawing.Size(0, 18);
            this.mappingError.TabIndex = 32;
            // 
            // comboBox14
            // 
            this.comboBox14.Enabled = false;
            this.comboBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Location = new System.Drawing.Point(265, 274);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(158, 24);
            this.comboBox14.TabIndex = 36;
            this.comboBox14.Text = "Extension";
            // 
            // comboBox13
            // 
            this.comboBox13.Enabled = false;
            this.comboBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Location = new System.Drawing.Point(265, 246);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(158, 24);
            this.comboBox13.TabIndex = 35;
            this.comboBox13.Text = "Severity";
            // 
            // comboBox12
            // 
            this.comboBox12.Enabled = false;
            this.comboBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Location = new System.Drawing.Point(265, 217);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(158, 24);
            this.comboBox12.TabIndex = 34;
            this.comboBox12.Text = "Name";
            // 
            // comboBox11
            // 
            this.comboBox11.Enabled = false;
            this.comboBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(265, 187);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(158, 24);
            this.comboBox11.TabIndex = 33;
            this.comboBox11.Text = "Device Event Class ID";
            // 
            // comboBox10
            // 
            this.comboBox10.Enabled = false;
            this.comboBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(265, 159);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(158, 24);
            this.comboBox10.TabIndex = 32;
            this.comboBox10.Text = "Deivce Version";
            // 
            // comboBox9
            // 
            this.comboBox9.Enabled = false;
            this.comboBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(265, 131);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(158, 24);
            this.comboBox9.TabIndex = 31;
            this.comboBox9.Text = "Device Product";
            // 
            // comboBox8
            // 
            this.comboBox8.Enabled = false;
            this.comboBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(265, 103);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(158, 24);
            this.comboBox8.TabIndex = 30;
            this.comboBox8.Text = "DeviceVendor";
            // 
            // comboBox7
            // 
            this.comboBox7.Enabled = false;
            this.comboBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(265, 73);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(158, 24);
            this.comboBox7.TabIndex = 29;
            this.comboBox7.Tag = "";
            this.comboBox7.Text = "Version";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(238, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 24);
            this.label13.TabIndex = 28;
            this.label13.Text = ">";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(238, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 24);
            this.label12.TabIndex = 27;
            this.label12.Text = ">";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(238, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = ">";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(238, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 24);
            this.label10.TabIndex = 25;
            this.label10.Text = ">";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(238, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = ">";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(238, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = ">";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(238, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = ">";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(238, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = ">";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mapping";
            // 
            // CreateQuery
            // 
            this.CreateQuery.Enabled = false;
            this.CreateQuery.Location = new System.Drawing.Point(340, 324);
            this.CreateQuery.Name = "CreateQuery";
            this.CreateQuery.Size = new System.Drawing.Size(83, 26);
            this.CreateQuery.TabIndex = 12;
            this.CreateQuery.Text = "Add";
            this.CreateQuery.UseVisualStyleBackColor = true;
            this.CreateQuery.Click += new System.EventHandler(this.CreateQuery_Click);
            // 
            // extension_comboBox
            // 
            this.extension_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.extension_comboBox.FormattingEnabled = true;
            this.extension_comboBox.Location = new System.Drawing.Point(121, 276);
            this.extension_comboBox.Name = "extension_comboBox";
            this.extension_comboBox.Size = new System.Drawing.Size(111, 24);
            this.extension_comboBox.TabIndex = 19;
            this.extension_comboBox.Text = " (Extension)";
            // 
            // exstension_textBox
            // 
            this.exstension_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exstension_textBox.Location = new System.Drawing.Point(6, 276);
            this.exstension_textBox.Name = "exstension_textBox";
            this.exstension_textBox.Size = new System.Drawing.Size(109, 22);
            this.exstension_textBox.TabIndex = 13;
            this.exstension_textBox.Text = "testKey";
            // 
            // severity_comboBox
            // 
            this.severity_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.severity_comboBox.FormattingEnabled = true;
            this.severity_comboBox.Location = new System.Drawing.Point(6, 246);
            this.severity_comboBox.Name = "severity_comboBox";
            this.severity_comboBox.Size = new System.Drawing.Size(226, 24);
            this.severity_comboBox.TabIndex = 18;
            this.severity_comboBox.Text = "Выбор поля (Severity)";
            // 
            // name_comboBox
            // 
            this.name_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_comboBox.FormattingEnabled = true;
            this.name_comboBox.Location = new System.Drawing.Point(6, 217);
            this.name_comboBox.Name = "name_comboBox";
            this.name_comboBox.Size = new System.Drawing.Size(226, 24);
            this.name_comboBox.TabIndex = 17;
            this.name_comboBox.Text = "Выбор поля (Name)";
            // 
            // eventClassId_comboBox
            // 
            this.eventClassId_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventClassId_comboBox.FormattingEnabled = true;
            this.eventClassId_comboBox.Location = new System.Drawing.Point(6, 187);
            this.eventClassId_comboBox.Name = "eventClassId_comboBox";
            this.eventClassId_comboBox.Size = new System.Drawing.Size(226, 24);
            this.eventClassId_comboBox.TabIndex = 16;
            this.eventClassId_comboBox.Text = "Выбор поля (Device Event Class ID)";
            // 
            // deviceVersion_textBox
            // 
            this.deviceVersion_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deviceVersion_textBox.Location = new System.Drawing.Point(6, 159);
            this.deviceVersion_textBox.Name = "deviceVersion_textBox";
            this.deviceVersion_textBox.Size = new System.Drawing.Size(226, 22);
            this.deviceVersion_textBox.TabIndex = 15;
            this.deviceVersion_textBox.Text = "1.0.0";
            // 
            // product_textBox
            // 
            this.product_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_textBox.Location = new System.Drawing.Point(6, 131);
            this.product_textBox.Name = "product_textBox";
            this.product_textBox.Size = new System.Drawing.Size(226, 22);
            this.product_textBox.TabIndex = 14;
            this.product_textBox.Text = "Product";
            // 
            // vendor_textBox
            // 
            this.vendor_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vendor_textBox.Location = new System.Drawing.Point(6, 103);
            this.vendor_textBox.Name = "vendor_textBox";
            this.vendor_textBox.Size = new System.Drawing.Size(226, 22);
            this.vendor_textBox.TabIndex = 13;
            this.vendor_textBox.Text = "Vendor";
            // 
            // version_textBox
            // 
            this.version_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.version_textBox.Location = new System.Drawing.Point(6, 75);
            this.version_textBox.Name = "version_textBox";
            this.version_textBox.Size = new System.Drawing.Size(226, 22);
            this.version_textBox.TabIndex = 12;
            this.version_textBox.Text = "0";
            // 
            // tables_comboBox
            // 
            this.tables_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tables_comboBox.FormattingEnabled = true;
            this.tables_comboBox.Location = new System.Drawing.Point(17, 148);
            this.tables_comboBox.Name = "tables_comboBox";
            this.tables_comboBox.Size = new System.Drawing.Size(226, 24);
            this.tables_comboBox.TabIndex = 18;
            this.tables_comboBox.SelectedIndexChanged += new System.EventHandler(this.tables_comboBox_SelectedIndexChanged);
            // 
            // id_comboBox
            // 
            this.id_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_comboBox.FormattingEnabled = true;
            this.id_comboBox.Location = new System.Drawing.Point(282, 148);
            this.id_comboBox.Name = "id_comboBox";
            this.id_comboBox.Size = new System.Drawing.Size(123, 24);
            this.id_comboBox.TabIndex = 19;
            this.id_comboBox.Text = "Выбор поля (ID)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(407, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = ">";
            // 
            // comboBox15
            // 
            this.comboBox15.Enabled = false;
            this.comboBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Location = new System.Drawing.Point(425, 148);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(40, 24);
            this.comboBox15.TabIndex = 30;
            this.comboBox15.Text = "ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(13, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 20);
            this.label14.TabIndex = 31;
            this.label14.Text = "Chose table:";
            // 
            // onlyBox
            // 
            this.onlyBox.AutoSize = true;
            this.onlyBox.Location = new System.Drawing.Point(487, 152);
            this.onlyBox.Name = "onlyBox";
            this.onlyBox.Size = new System.Drawing.Size(71, 17);
            this.onlyBox.TabIndex = 32;
            this.onlyBox.Text = "SQL Only";
            this.onlyBox.UseVisualStyleBackColor = true;
            this.onlyBox.CheckedChanged += new System.EventHandler(this.onlyBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 705);
            this.Controls.Add(this.onlyBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBox15);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.id_comboBox);
            this.Controls.Add(this.tables_comboBox);
            this.Controls.Add(this.mappingGroupBox);
            this.Controls.Add(this.queryError);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connect_Button);
            this.Controls.Add(this.Cef_textBox);
            this.Controls.Add(this.CreateCef_Button);
            this.Controls.Add(this.Query_TextBox);
            this.Controls.Add(this.Browse_Button);
            this.Controls.Add(this.DbPath);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mappingGroupBox.ResumeLayout(false);
            this.mappingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox DbPath;
        private System.Windows.Forms.Button Browse_Button;
        private System.Windows.Forms.TextBox Query_TextBox;
        private System.Windows.Forms.Button CreateCef_Button;
        private System.Windows.Forms.TextBox Cef_textBox;
        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Label queryError;
        private System.Windows.Forms.GroupBox mappingGroupBox;
        private System.Windows.Forms.ComboBox comboBox14;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateQuery;
        private System.Windows.Forms.ComboBox extension_comboBox;
        private System.Windows.Forms.TextBox exstension_textBox;
        private System.Windows.Forms.ComboBox severity_comboBox;
        private System.Windows.Forms.ComboBox name_comboBox;
        private System.Windows.Forms.ComboBox eventClassId_comboBox;
        private System.Windows.Forms.TextBox deviceVersion_textBox;
        private System.Windows.Forms.TextBox product_textBox;
        private System.Windows.Forms.TextBox vendor_textBox;
        private System.Windows.Forms.TextBox version_textBox;
        private System.Windows.Forms.ComboBox tables_comboBox;
        private System.Windows.Forms.ComboBox id_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label mappingError;
        private System.Windows.Forms.CheckBox onlyBox;
    }
}