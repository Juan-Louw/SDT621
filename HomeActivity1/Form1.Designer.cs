namespace HomeActivity1
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
            label2 = new Label();
            txtNumber = new TextBox();
            btnPlay = new Button();
            lblResults = new Label();
            lblAttempts = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Lottery";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 46);
            label2.Name = "label2";
            label2.Size = new Size(171, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter your lucky number (1-20)";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(303, 43);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 2;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(114, 87);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(289, 23);
            btnPlay.TabIndex = 3;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(114, 122);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(38, 15);
            lblResults.TabIndex = 4;
            lblResults.Text = "label3";
            // 
            // lblAttempts
            // 
            lblAttempts.AutoSize = true;
            lblAttempts.Location = new Point(409, 95);
            lblAttempts.Name = "lblAttempts";
            lblAttempts.Size = new Size(38, 15);
            lblAttempts.TabIndex = 5;
            lblAttempts.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 305);
            Controls.Add(lblAttempts);
            Controls.Add(lblResults);
            Controls.Add(btnPlay);
            Controls.Add(txtNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNumber;
        private Button btnPlay;
        private Label lblResults;
        private Label lblAttempts;
    }
}
