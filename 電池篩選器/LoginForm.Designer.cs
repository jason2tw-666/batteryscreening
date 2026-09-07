namespace 電池篩選器
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(231, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 89);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 1;
            label1.Text = "帳號(account number):";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 163);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 3;
            label2.Text = "密碼(password):";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(231, 160);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(293, 23);
            textBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(615, 508);
            button1.Name = "button1";
            button1.Size = new Size(105, 23);
            button1.TabIndex = 4;
            button1.Text = "登入(log in)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(28, 508);
            button2.Name = "button2";
            button2.Size = new Size(197, 23);
            button2.TabIndex = 5;
            button2.Text = "新建帳號(Create a new account)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 21);
            button3.Name = "button3";
            button3.Size = new Size(332, 23);
            button3.TabIndex = 6;
            button3.Text = "確認設備連線狀況(Check device connection status)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(28, 201);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(760, 281);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private RichTextBox richTextBox1;
    }
}