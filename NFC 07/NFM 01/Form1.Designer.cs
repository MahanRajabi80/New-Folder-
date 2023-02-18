namespace NFM_01
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_path_00 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_start_of_folders_names = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_end_of_folders_names = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.numericUpDown_sequ_num_up_to = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_sequ_num_start_from = new System.Windows.Forms.NumericUpDown();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Label_sequ_num_up_to = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_Create_New_Folders = new System.Windows.Forms.Button();
            this.checkBox_I_am_sure = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton_Type_of_nums_01 = new System.Windows.Forms.RadioButton();
            this.radioButton_Type_of_nums_02 = new System.Windows.Forms.RadioButton();
            this.radioButton_Type_of_nums_03 = new System.Windows.Forms.RadioButton();
            this.radioButton_Type_of_nums_04 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Go_to_Startup_Path = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sequ_num_up_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sequ_num_start_from)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please specify a location to create new folders there : ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(540, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse ...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "path_00 = ";
            // 
            // textBox_path_00
            // 
            this.textBox_path_00.Location = new System.Drawing.Point(105, 59);
            this.textBox_path_00.Name = "textBox_path_00";
            this.textBox_path_00.Size = new System.Drawing.Size(713, 20);
            this.textBox_path_00.TabIndex = 3;
            this.textBox_path_00.Text = "D:\\a\\b\\test 08";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(155)))), ((int)(((byte)(220)))));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(53)))), ((int)(((byte)(40)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(424, 134);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(394, 173);
            this.listBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "start of folders names :";
            // 
            // textBox_start_of_folders_names
            // 
            this.textBox_start_of_folders_names.Location = new System.Drawing.Point(15, 118);
            this.textBox_start_of_folders_names.MaxLength = 25;
            this.textBox_start_of_folders_names.Name = "textBox_start_of_folders_names";
            this.textBox_start_of_folders_names.Size = new System.Drawing.Size(207, 20);
            this.textBox_start_of_folders_names.TabIndex = 6;
            this.textBox_start_of_folders_names.Text = "New ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "end of folders names :";
            // 
            // textBox_end_of_folders_names
            // 
            this.textBox_end_of_folders_names.Location = new System.Drawing.Point(15, 173);
            this.textBox_end_of_folders_names.MaxLength = 25;
            this.textBox_end_of_folders_names.Name = "textBox_end_of_folders_names";
            this.textBox_end_of_folders_names.Size = new System.Drawing.Size(207, 20);
            this.textBox_end_of_folders_names.TabIndex = 6;
            this.textBox_end_of_folders_names.Text = " Folders";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(174)))), ((int)(((byte)(215)))));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 654);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Center of folders names : ";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(88, 215);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 10;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(88, 46);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            // 
            // numericUpDown_sequ_num_up_to
            // 
            this.numericUpDown_sequ_num_up_to.Location = new System.Drawing.Point(90, 65);
            this.numericUpDown_sequ_num_up_to.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown_sequ_num_up_to.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_sequ_num_up_to.Name = "numericUpDown_sequ_num_up_to";
            this.numericUpDown_sequ_num_up_to.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_sequ_num_up_to.TabIndex = 9;
            this.numericUpDown_sequ_num_up_to.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDown_sequ_num_start_from
            // 
            this.numericUpDown_sequ_num_start_from.Location = new System.Drawing.Point(90, 39);
            this.numericUpDown_sequ_num_start_from.Maximum = new decimal(new int[] {
            119,
            0,
            0,
            0});
            this.numericUpDown_sequ_num_start_from.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_sequ_num_start_from.Name = "numericUpDown_sequ_num_start_from";
            this.numericUpDown_sequ_num_start_from.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_sequ_num_start_from.TabIndex = 9;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "DateTime : ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "start from : ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(129, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sequential Numbers : ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "up to : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "start from : ";
            // 
            // Label_sequ_num_up_to
            // 
            this.Label_sequ_num_up_to.AutoSize = true;
            this.Label_sequ_num_up_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_sequ_num_up_to.Location = new System.Drawing.Point(44, 63);
            this.Label_sequ_num_up_to.Name = "Label_sequ_num_up_to";
            this.Label_sequ_num_up_to.Size = new System.Drawing.Size(43, 15);
            this.Label_sequ_num_up_to.TabIndex = 5;
            this.Label_sequ_num_up_to.Text = "up to : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(420, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(346, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "The list of the folders that were created : ";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Navy;
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // button_Create_New_Folders
            // 
            this.button_Create_New_Folders.BackColor = System.Drawing.Color.Violet;
            this.button_Create_New_Folders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Create_New_Folders.ForeColor = System.Drawing.Color.Teal;
            this.button_Create_New_Folders.Location = new System.Drawing.Point(586, 363);
            this.button_Create_New_Folders.Name = "button_Create_New_Folders";
            this.button_Create_New_Folders.Size = new System.Drawing.Size(206, 67);
            this.button_Create_New_Folders.TabIndex = 1;
            this.button_Create_New_Folders.Text = "Create New Folders";
            this.button_Create_New_Folders.UseVisualStyleBackColor = false;
            this.button_Create_New_Folders.Click += new System.EventHandler(this.button_Create_New_Folders_Click);
            // 
            // checkBox_I_am_sure
            // 
            this.checkBox_I_am_sure.AutoSize = true;
            this.checkBox_I_am_sure.Location = new System.Drawing.Point(591, 340);
            this.checkBox_I_am_sure.Name = "checkBox_I_am_sure";
            this.checkBox_I_am_sure.Size = new System.Drawing.Size(201, 17);
            this.checkBox_I_am_sure.TabIndex = 9;
            this.checkBox_I_am_sure.Text = "I am sure that I want to create folders";
            this.checkBox_I_am_sure.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.monthCalendar2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(10, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 402);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.Label_sequ_num_up_to);
            this.groupBox3.Controls.Add(this.numericUpDown_sequ_num_up_to);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.numericUpDown_sequ_num_start_from);
            this.groupBox3.Location = new System.Drawing.Point(10, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 212);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Type of nums : ";
            // 
            // radioButton_Type_of_nums_01
            // 
            this.radioButton_Type_of_nums_01.AutoSize = true;
            this.radioButton_Type_of_nums_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Type_of_nums_01.Location = new System.Drawing.Point(3, 8);
            this.radioButton_Type_of_nums_01.Name = "radioButton_Type_of_nums_01";
            this.radioButton_Type_of_nums_01.Size = new System.Drawing.Size(128, 21);
            this.radioButton_Type_of_nums_01.TabIndex = 11;
            this.radioButton_Type_of_nums_01.Text = "(1,10,100,1000)";
            this.radioButton_Type_of_nums_01.UseVisualStyleBackColor = true;
            // 
            // radioButton_Type_of_nums_02
            // 
            this.radioButton_Type_of_nums_02.AutoSize = true;
            this.radioButton_Type_of_nums_02.Checked = true;
            this.radioButton_Type_of_nums_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Type_of_nums_02.Location = new System.Drawing.Point(3, 31);
            this.radioButton_Type_of_nums_02.Name = "radioButton_Type_of_nums_02";
            this.radioButton_Type_of_nums_02.Size = new System.Drawing.Size(136, 21);
            this.radioButton_Type_of_nums_02.TabIndex = 11;
            this.radioButton_Type_of_nums_02.TabStop = true;
            this.radioButton_Type_of_nums_02.Text = "(01,10,100,1000)";
            this.radioButton_Type_of_nums_02.UseVisualStyleBackColor = true;
            // 
            // radioButton_Type_of_nums_03
            // 
            this.radioButton_Type_of_nums_03.AutoSize = true;
            this.radioButton_Type_of_nums_03.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Type_of_nums_03.Location = new System.Drawing.Point(3, 57);
            this.radioButton_Type_of_nums_03.Name = "radioButton_Type_of_nums_03";
            this.radioButton_Type_of_nums_03.Size = new System.Drawing.Size(164, 21);
            this.radioButton_Type_of_nums_03.TabIndex = 11;
            this.radioButton_Type_of_nums_03.Text = "(001, 010, 100, 1000)";
            this.radioButton_Type_of_nums_03.UseVisualStyleBackColor = true;
            // 
            // radioButton_Type_of_nums_04
            // 
            this.radioButton_Type_of_nums_04.AutoSize = true;
            this.radioButton_Type_of_nums_04.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Type_of_nums_04.Location = new System.Drawing.Point(131, 12);
            this.radioButton_Type_of_nums_04.Name = "radioButton_Type_of_nums_04";
            this.radioButton_Type_of_nums_04.Size = new System.Drawing.Size(145, 17);
            this.radioButton_Type_of_nums_04.TabIndex = 12;
            this.radioButton_Type_of_nums_04.Text = "(0001, 0010, 0100, 1000)";
            this.radioButton_Type_of_nums_04.UseVisualStyleBackColor = true;
            this.radioButton_Type_of_nums_04.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.radioButton_Type_of_nums_01);
            this.panel1.Controls.Add(this.radioButton_Type_of_nums_04);
            this.panel1.Controls.Add(this.radioButton_Type_of_nums_02);
            this.panel1.Controls.Add(this.radioButton_Type_of_nums_03);
            this.panel1.Location = new System.Drawing.Point(108, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 100);
            this.panel1.TabIndex = 13;
            // 
            // button_Go_to_Startup_Path
            // 
            this.button_Go_to_Startup_Path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Go_to_Startup_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Go_to_Startup_Path.Location = new System.Drawing.Point(586, 437);
            this.button_Go_to_Startup_Path.Name = "button_Go_to_Startup_Path";
            this.button_Go_to_Startup_Path.Size = new System.Drawing.Size(206, 67);
            this.button_Go_to_Startup_Path.TabIndex = 10;
            this.button_Go_to_Startup_Path.Text = "Go to Startup Path";
            this.button_Go_to_Startup_Path.UseVisualStyleBackColor = false;
            this.button_Go_to_Startup_Path.Click += new System.EventHandler(this.button_Go_to_Startup_Path_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(233)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(830, 865);
            this.Controls.Add(this.button_Go_to_Startup_Path);
            this.Controls.Add(this.checkBox_I_am_sure);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_end_of_folders_names);
            this.Controls.Add(this.textBox_start_of_folders_names);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox_path_00);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Create_New_Folders);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1 - LrSh New Folder Creator - Be careful !!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sequ_num_up_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sequ_num_start_from)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_path_00;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_start_of_folders_names;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_end_of_folders_names;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Label_sequ_num_up_to;
        private System.Windows.Forms.NumericUpDown numericUpDown_sequ_num_up_to;
        private System.Windows.Forms.NumericUpDown numericUpDown_sequ_num_start_from;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button_Create_New_Folders;
        private System.Windows.Forms.CheckBox checkBox_I_am_sure;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton_Type_of_nums_03;
        private System.Windows.Forms.RadioButton radioButton_Type_of_nums_02;
        private System.Windows.Forms.RadioButton radioButton_Type_of_nums_01;
        private System.Windows.Forms.RadioButton radioButton_Type_of_nums_04;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Go_to_Startup_Path;
    }
}

