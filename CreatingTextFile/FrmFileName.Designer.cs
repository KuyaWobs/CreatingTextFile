namespace CreatingTextFile
{
    partial class FrmFileName
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
            txtFileName = new TextBox();
            label1 = new Label();
            btnOkay = new Button();
            SuspendLayout();
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(69, 53);
            txtFileName.Multiline = true;
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(252, 32);
            txtFileName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 35);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter File Name";
            // 
            // btnOkay
            // 
            btnOkay.Location = new Point(142, 105);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(90, 31);
            btnOkay.TabIndex = 2;
            btnOkay.Text = "Okay";
            btnOkay.UseVisualStyleBackColor = true;
            btnOkay.Click += btnOkay_Click;
            // 
            // FrmFileName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 208);
            Controls.Add(btnOkay);
            Controls.Add(label1);
            Controls.Add(txtFileName);
            Name = "FrmFileName";
            Text = "FrmFileName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFileName;
        private Label label1;
        private Button btnOkay;
    }
}