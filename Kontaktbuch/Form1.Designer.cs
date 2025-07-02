namespace Kontaktbuch
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
            label1 = new Label();
            listBox1 = new ListBox();
            saveBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            deleteBtn = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 61);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "name";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(259, 61);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(173, 109);
            listBox1.TabIndex = 7;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(96, 194);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(100, 23);
            saveBtn.TabIndex = 9;
            saveBtn.Text = "save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 90);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 10;
            label2.Text = "last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 119);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 11;
            label3.Text = "phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 148);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 12;
            label4.Text = "e-mail";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(96, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(96, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(96, 145);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 13;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Segoe UI", 9F);
            deleteBtn.Location = new Point(290, 194);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(100, 23);
            deleteBtn.TabIndex = 9;
            deleteBtn.Text = "delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(200, 9);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 14;
            label5.Text = "contacts";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(483, 251);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(deleteBtn);
            Controls.Add(saveBtn);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button saveBtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button deleteBtn;
        private Label label5;
    }
}
