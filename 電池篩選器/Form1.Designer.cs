namespace 電池篩選器
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            textBox2 = new TextBox();
            button2 = new Button();
            textBox3 = new TextBox();
            button3 = new Button();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            label10 = new Label();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            button4 = new Button();
            label11 = new Label();
            comboBox7 = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "4100KV", "5600KV", "8500KV" });
            comboBox1.Location = new Point(83, 92);
            comboBox1.Margin = new Padding(5, 5, 5, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(219, 31);
            comboBox1.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(55, 156);
            checkBox1.Margin = new Padding(5, 5, 5, 5);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(622, 27);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "是否需要排序電池新鮮度(Is it necessary to sort batteries by freshness?)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(55, 259);
            button1.Margin = new Padding(5, 5, 5, 5);
            button1.Name = "button1";
            button1.Size = new Size(339, 35);
            button1.TabIndex = 3;
            button1.Text = "EXCLE 匯入(Excel Import)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(55, 319);
            textBox2.Margin = new Padding(5, 5, 5, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(952, 30);
            textBox2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(55, 501);
            button2.Margin = new Padding(5, 5, 5, 5);
            button2.Name = "button2";
            button2.Size = new Size(371, 35);
            button2.TabIndex = 5;
            button2.Text = "開始執行匹配(Start matching process)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(55, 435);
            textBox3.Margin = new Padding(5, 5, 5, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(952, 30);
            textBox3.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(55, 377);
            button3.Margin = new Padding(5, 5, 5, 5);
            button3.Name = "button3";
            button3.Size = new Size(339, 35);
            button3.TabIndex = 7;
            button3.Text = "EXCLE 匯出(Export to Excel)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "4100KV", "5600KV", "8500KV" });
            comboBox2.Location = new Point(409, 92);
            comboBox2.Margin = new Padding(5, 5, 5, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(219, 31);
            comboBox2.TabIndex = 8;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "4100KV", "5600KV", "8500KV" });
            comboBox3.Location = new Point(762, 92);
            comboBox3.Margin = new Padding(5, 5, 5, 5);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(219, 31);
            comboBox3.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(55, 195);
            dateTimePicker1.Margin = new Padding(5, 5, 5, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(312, 30);
            dateTimePicker1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 572);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 23);
            label1.TabIndex = 12;
            label1.Text = "計算出的電池匹配率(MAX)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 14);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(559, 23);
            label2.TabIndex = 13;
            label2.Text = "請選擇你的電池優先順序(Please select your battery priority order.)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 661);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(221, 23);
            label3.TabIndex = 14;
            label3.Text = "計算出的電池匹配率(MIN)";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(580, 572);
            textBox4.Margin = new Padding(5, 5, 5, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(156, 30);
            textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(773, 572);
            textBox5.Margin = new Padding(5, 5, 5, 5);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(156, 30);
            textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(377, 661);
            textBox6.Margin = new Padding(5, 5, 5, 5);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(160, 30);
            textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(580, 661);
            textBox7.Margin = new Padding(5, 5, 5, 5);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(156, 30);
            textBox7.TabIndex = 19;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(773, 661);
            textBox8.Margin = new Padding(5, 5, 5, 5);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(156, 30);
            textBox8.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(377, 572);
            textBox1.Margin = new Padding(5, 5, 5, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 30);
            textBox1.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 51);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 23);
            label4.TabIndex = 22;
            label4.Text = "優先";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(503, 51);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 23);
            label5.TabIndex = 23;
            label5.Text = "其次";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(849, 51);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 23);
            label6.TabIndex = 24;
            label6.Text = "最後";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(407, 544);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(73, 23);
            label7.TabIndex = 25;
            label7.Text = "4100KV";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(614, 544);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(73, 23);
            label8.TabIndex = 26;
            label8.Text = "5600KV";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(806, 544);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(73, 23);
            label9.TabIndex = 27;
            label9.Text = "8500KV";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(300, 814);
            textBox9.Margin = new Padding(5, 5, 5, 5);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(123, 30);
            textBox9.TabIndex = 28;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(471, 814);
            textBox10.Margin = new Padding(5, 5, 5, 5);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(123, 30);
            textBox10.TabIndex = 29;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(649, 819);
            textBox11.Margin = new Padding(5, 5, 5, 5);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(123, 30);
            textBox11.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(83, 814);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(100, 23);
            label10.TabIndex = 31;
            label10.Text = "匹配寬容值";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(377, 747);
            comboBox4.Margin = new Padding(5, 5, 5, 5);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(160, 31);
            comboBox4.TabIndex = 33;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(577, 747);
            comboBox5.Margin = new Padding(5, 5, 5, 5);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(160, 31);
            comboBox5.TabIndex = 34;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(770, 747);
            comboBox6.Margin = new Padding(5, 5, 5, 5);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(160, 31);
            comboBox6.TabIndex = 35;
            // 
            // button4
            // 
            button4.Location = new Point(317, 981);
            button4.Margin = new Padding(5, 5, 5, 5);
            button4.Name = "button4";
            button4.Size = new Size(468, 35);
            button4.TabIndex = 36;
            button4.Text = "匹配後產出EXCEL(Output after matching Excel)";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 909);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(100, 23);
            label11.TabIndex = 38;
            label11.Text = "單組別最高";
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            comboBox7.Location = new Point(256, 914);
            comboBox7.Margin = new Padding(5, 5, 5, 5);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(59, 31);
            comboBox7.TabIndex = 39;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(327, 914);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(64, 23);
            label12.TabIndex = 40;
            label12.Text = "組電池";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 595);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(348, 23);
            label13.TabIndex = 41;
            label13.Text = "Calculated battery matching rate (MAX)";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(19, 684);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new Size(345, 23);
            label14.TabIndex = 42;
            label14.Text = "Calculated battery matching rate (MIN)";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(83, 837);
            label15.Margin = new Padding(5, 0, 5, 0);
            label15.Name = "label15";
            label15.Size = new Size(176, 23);
            label15.TabIndex = 43;
            label15.Text = "Matching tolerance";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(24, 747);
            label16.Margin = new Padding(5, 0, 5, 0);
            label16.Name = "label16";
            label16.Size = new Size(118, 23);
            label16.TabIndex = 44;
            label16.Text = "單顆檢視分數";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(24, 770);
            label17.Margin = new Padding(5, 0, 5, 0);
            label17.Name = "label17";
            label17.Size = new Size(252, 23);
            label17.TabIndex = 45;
            label17.Text = "Single-item inspection score";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(19, 932);
            label18.Margin = new Padding(5, 0, 5, 0);
            label18.Name = "label18";
            label18.Size = new Size(223, 23);
            label18.TabIndex = 46;
            label18.Text = "Highest in a single group";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(327, 937);
            label19.Margin = new Padding(5, 0, 5, 0);
            label19.Name = "label19";
            label19.Size = new Size(116, 23);
            label19.TabIndex = 47;
            label19.Text = "battery pack";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 1035);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(comboBox7);
            Controls.Add(label11);
            Controls.Add(button4);
            Controls.Add(comboBox6);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(label10);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "電池分選器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private Button button1;
        private TextBox textBox2;
        private Button button2;
        private TextBox textBox3;
        private Button button3;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private Label label10;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private Button button4;
        private Label label11;
        private ComboBox comboBox7;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
    }
}
