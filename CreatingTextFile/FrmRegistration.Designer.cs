namespace CreatingTextFile
{
    partial class FrmRegistration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            cbProgram = new ComboBox();
            cbGender = new ComboBox();
            txtFirstName = new TextBox();
            txtMI = new TextBox();
            txtContactNo = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 65);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Student No.";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 108);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 158);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 197);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Birthday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(295, 65);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 5;
            label6.Text = "Program";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(284, 108);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 6;
            label7.Text = "First Name";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(303, 153);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 7;
            label8.Text = "Gender";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(313, 197);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 8;
            label9.Text = "Contact No.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(499, 108);
            label10.Name = "label10";
            label10.Size = new Size(27, 15);
            label10.TabIndex = 9;
            label10.Text = "M.I.";
            label10.Click += label10_Click;
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(107, 62);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(171, 23);
            txtStudentNo.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(107, 105);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(171, 23);
            txtLastName.TabIndex = 11;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(107, 155);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(107, 191);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Location = new Point(354, 62);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(237, 23);
            cbProgram.TabIndex = 14;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(354, 150);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(237, 23);
            cbGender.TabIndex = 15;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(354, 105);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(139, 23);
            txtFirstName.TabIndex = 16;
            // 
            // txtMI
            // 
            txtMI.Location = new Point(532, 105);
            txtMI.Name = "txtMI";
            txtMI.Size = new Size(59, 23);
            txtMI.TabIndex = 17;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(387, 191);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(168, 23);
            txtContactNo.TabIndex = 18;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(255, 249);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(93, 29);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 290);
            Controls.Add(btnRegister);
            Controls.Add(txtContactNo);
            Controls.Add(txtMI);
            Controls.Add(txtFirstName);
            Controls.Add(cbGender);
            Controls.Add(cbProgram);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegistration";
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtAge;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbProgram;
        private ComboBox cbGender;
        private TextBox txtFirstName;
        private TextBox txtMI;
        private TextBox txtContactNo;
        private Button btnRegister;
    }
}