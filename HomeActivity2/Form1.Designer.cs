namespace HomeActivity2
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
            txtGeuss1 = new TextBox();
            txtGeuss2 = new TextBox();
            txtGeuss3 = new TextBox();
            btnCheckResults = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // txtGeuss1
            // 
            txtGeuss1.BorderStyle = BorderStyle.FixedSingle;
            txtGeuss1.Location = new Point(367, 54);
            txtGeuss1.Name = "txtGeuss1";
            txtGeuss1.Size = new Size(100, 23);
            txtGeuss1.TabIndex = 0;
            // 
            // txtGeuss2
            // 
            txtGeuss2.BorderStyle = BorderStyle.FixedSingle;
            txtGeuss2.Location = new Point(367, 97);
            txtGeuss2.Name = "txtGeuss2";
            txtGeuss2.Size = new Size(100, 23);
            txtGeuss2.TabIndex = 1;
            // 
            // txtGeuss3
            // 
            txtGeuss3.BorderStyle = BorderStyle.FixedSingle;
            txtGeuss3.Location = new Point(367, 148);
            txtGeuss3.Name = "txtGeuss3";
            txtGeuss3.Size = new Size(100, 23);
            txtGeuss3.TabIndex = 2;
            // 
            // btnCheckResults
            // 
            btnCheckResults.Location = new Point(284, 194);
            btnCheckResults.Name = "btnCheckResults";
            btnCheckResults.Size = new Size(183, 23);
            btnCheckResults.TabIndex = 3;
            btnCheckResults.Text = "Check Results";
            btnCheckResults.UseVisualStyleBackColor = true;
            btnCheckResults.Click += btnCheckResults_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 62);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 4;
            label1.Text = "1st Geuss";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 105);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 5;
            label2.Text = "2nd Geuss";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 156);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "3rd Geuss";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(316, 9);
            label4.Name = "label4";
            label4.Size = new Size(117, 30);
            label4.TabIndex = 8;
            label4.Text = "Mini Lotto";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(284, 241);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(183, 94);
            listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCheckResults);
            Controls.Add(txtGeuss3);
            Controls.Add(txtGeuss2);
            Controls.Add(txtGeuss1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGeuss1;
        private TextBox txtGeuss2;
        private TextBox txtGeuss3;
        private Button btnCheckResults;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox listBox1;
    }
}
