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
            txtpassword = new TextBox();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Location = new Point(107, 73);
            UserName.Name = "UserName";
            UserName.Size = new Size(84, 15);

            UserName.TabIndex = 0;
            UserName.Text = "tên đăng nhập";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(203, 75);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(125, 27);
            txtUserName.TabIndex = 1;
            // 
            // matkhau
            // 
            matkhau.AutoSize = true;
            matkhau.Location = new Point(107, 168);
            matkhau.Name = "matkhau";
            matkhau.Size = new Size(57, 15);
            matkhau.TabIndex = 2;
            matkhau.Text = "mật khẩu";

            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(203, 168);
            txtpassword.Margin = new Padding(3, 4, 3, 4);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(114, 27);
            txtpassword.TabIndex = 3;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(212, 245);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(94, 29);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(btnlogin);
            Controls.Add(txtpassword);
            Controls.Add(matkhau);
            Controls.Add(txtUserName);
            Controls.Add(UserName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserName;
        private TextBox txtUserName;
        private Label matkhau;
        private TextBox txtpassword;
        private Button btnlogin;
    }
}
