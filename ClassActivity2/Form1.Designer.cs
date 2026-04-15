namespace ClassActivity2
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
            txtDistance = new TextBox();
            txtWeight = new TextBox();
            txtEfficiency = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblResult = new Label();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(326, 16);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(147, 23);
            txtDistance.TabIndex = 0;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(326, 54);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(147, 23);
            txtWeight.TabIndex = 1;
            // 
            // txtEfficiency
            // 
            txtEfficiency.Location = new Point(326, 92);
            txtEfficiency.Name = "txtEfficiency";
            txtEfficiency.Size = new Size(147, 23);
            txtEfficiency.TabIndex = 2;
            txtEfficiency.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 24);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 3;
            label1.Text = "Distance (km)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 62);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 4;
            label2.Text = "Cargo Weight (kg)";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 100);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 5;
            label3.Text = "Fuel Efficiency (L/100km)";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(185, 168);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 6;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Lime;
            btnCalculate.Location = new Point(180, 129);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(293, 23);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(lblResult);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEfficiency);
            Controls.Add(txtWeight);
            Controls.Add(txtDistance);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDistance;
        private TextBox txtWeight;
        private TextBox txtEfficiency;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblResult;
        private Button btnCalculate;
    }
}
