namespace GUIPractice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            listBox1 = new ListBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(59, 240);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(168, 30);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(59, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(345, 27);
            textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(430, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 355);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 72);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 112);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 4;
            label2.Text = "Louw";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 159);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 5;
            label3.Text = "Age";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Location = new Point(236, 241);
            button2.Name = "button2";
            button2.Size = new Size(168, 30);
            button2.TabIndex = 6;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(59, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(345, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(59, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(345, 27);
            textBox3.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(59, 194);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(345, 28);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 202);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 11;
            label4.Text = "Gender";
            label4.Click += label4_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(59, 296);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(345, 124);
            listBox1.TabIndex = 12;
            // 
            // button3
            // 
            button3.Location = new Point(840, 24);
            button3.Name = "button3";
            button3.Size = new Size(98, 35);
            button3.TabIndex = 13;
            button3.Text = "Next Page >";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(950, 460);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Cursor = Cursors.Cross;
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Label label4;
        private ListBox listBox1;
        private Button button3;
    }
}
