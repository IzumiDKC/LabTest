namespace LabTest
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
            UserName = new Label();
            txtUserName = new TextBox();
            matkhau = new Label();
            txtmatkhau = new TextBox();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Location = new Point(94, 55);
            UserName.Name = "UserName";
            UserName.Size = new Size(62, 15);
            UserName.TabIndex = 0;
            UserName.Text = "UserName";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(178, 56);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(110, 23);
            txtUserName.TabIndex = 1;
            // 
            // matkhau
            // 
            matkhau.AutoSize = true;
            matkhau.Location = new Point(80, 126);
            matkhau.Name = "matkhau";
            matkhau.Size = new Size(58, 15);
            matkhau.TabIndex = 2;
            matkhau.Text = "Mật Khẩu";
            // 
            // txtmatkhau
            // 
            txtmatkhau.Location = new Point(178, 126);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(100, 23);
            txtmatkhau.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(txtmatkhau);
            Controls.Add(matkhau);
            Controls.Add(txtUserName);
            Controls.Add(UserName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserName;
        private TextBox txtUserName;
        private Label matkhau;
        private TextBox txtmatkhau;
    }
}
