namespace Uni5Arrays
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
            btnSaveColor = new Button();
            label1 = new Label();
            txtName = new TextBox();
            txtSex = new TextBox();
            txtSalary = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtColor = new TextBox();
            btnSave = new Button();
            lblColor = new Label();
            lblData = new Label();
            SuspendLayout();
            // 
            // btnSaveColor
            // 
            btnSaveColor.Location = new Point(319, 28);
            btnSaveColor.Name = "btnSaveColor";
            btnSaveColor.Size = new Size(73, 28);
            btnSaveColor.TabIndex = 0;
            btnSaveColor.Text = "Save Color";
            btnSaveColor.UseVisualStyleBackColor = true;
            btnSaveColor.Click += btnSaveColor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 106);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(139, 106);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(146, 26);
            txtName.TabIndex = 3;
            // 
            // txtSex
            // 
            txtSex.Location = new Point(139, 188);
            txtSex.Multiline = true;
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(146, 26);
            txtSex.TabIndex = 4;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(139, 143);
            txtSalary.Multiline = true;
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(146, 26);
            txtSalary.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(65, 148);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 6;
            label2.Text = "Salary";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 193);
            label3.Name = "label3";
            label3.Size = new Size(36, 21);
            label3.TabIndex = 7;
            label3.Text = "Sex";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(65, 33);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 8;
            label4.Text = "Color";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(139, 28);
            txtColor.Multiline = true;
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(146, 26);
            txtColor.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(319, 146);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(73, 28);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(431, 17);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(0, 15);
            lblColor.TabIndex = 11;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(431, 106);
            lblData.Name = "lblData";
            lblData.Size = new Size(0, 15);
            lblData.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblData);
            Controls.Add(lblColor);
            Controls.Add(btnSave);
            Controls.Add(txtColor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSalary);
            Controls.Add(txtSex);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(btnSaveColor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveColor;
        private Label label1;
        private TextBox txtName;
        private TextBox txtSex;
        private TextBox txtSalary;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtColor;
        private Button btnSave;
        private Label lblColor;
        private Label lblData;
    }
}
