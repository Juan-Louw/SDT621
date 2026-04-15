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
            txtDistance.Location = new Point(392, 126);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(147, 23);
            txtDistance.TabIndex = 0;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(392, 164);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(147, 23);
            txtWeight.TabIndex = 1;
            // 
            // txtEfficiency
            // 
            txtEfficiency.Location = new Point(392, 202);
            txtEfficiency.Name = "txtEfficiency";
            txtEfficiency.Size = new Size(147, 23);
            txtEfficiency.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(244, 129);
            label1.Name = "label1";
            label1.Size = new Size(82, 17);
            label1.TabIndex = 3;
            label1.Text = "Distance (km)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(244, 167);
            label2.Name = "label2";
            label2.Size = new Size(106, 17);
            label2.TabIndex = 4;
            label2.Text = "Cargo Weight (kg)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(244, 205);
            label3.Name = "label3";
            label3.Size = new Size(142, 17);
            label3.TabIndex = 5;
            label3.Text = "Fuel Efficiency (L/100km)";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(249, 273);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 6;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Lime;
            btnCalculate.Location = new Point(244, 234);
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
            BackColor = SystemColors.Window;
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
