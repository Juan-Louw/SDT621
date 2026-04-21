namespace ClassActivity3
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
            label3 = new Label();
            btnCreate = new Button();
            btnRead = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            listView1 = new ListView();
            txtProductId = new TextBox();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 39);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Product ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 72);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 1;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 104);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Lime;
            btnCreate.Location = new Point(469, 158);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(109, 23);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.FromArgb(255, 128, 0);
            btnRead.Location = new Point(469, 187);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(109, 23);
            btnRead.TabIndex = 4;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Location = new Point(469, 216);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(109, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(469, 249);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(36, 158);
            listView1.Name = "listView1";
            listView1.Size = new Size(427, 173);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(155, 31);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(197, 23);
            txtProductId.TabIndex = 8;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(155, 64);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(197, 23);
            txtProductName.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(155, 101);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(197, 23);
            txtPrice.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPrice);
            Controls.Add(txtProductName);
            Controls.Add(txtProductId);
            Controls.Add(listView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnRead);
            Controls.Add(btnCreate);
            Controls.Add(label3);
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
        private Label label3;
        private Button btnCreate;
        private Button btnRead;
        private Button btnUpdate;
        private Button btnDelete;
        private ListView listView1;
        private TextBox txtProductId;
        private TextBox txtProductName;
        private TextBox txtPrice;
    }
}
