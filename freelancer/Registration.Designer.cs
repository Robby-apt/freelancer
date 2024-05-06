namespace freelancer
{
    partial class Registration
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
            toLogin = new Button();
            regBtn = new Button();
            regUserType = new ListBox();
            regConfirmPassword = new TextBox();
            regPassword = new TextBox();
            regUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // toLogin
            // 
            toLogin.Location = new Point(84, 336);
            toLogin.Name = "toLogin";
            toLogin.Size = new Size(216, 40);
            toLogin.TabIndex = 19;
            toLogin.Text = "Already have an account? Login instead";
            toLogin.UseVisualStyleBackColor = true;
            toLogin.Click += toLogin_Click;
            // 
            // regBtn
            // 
            regBtn.Location = new Point(200, 279);
            regBtn.Name = "regBtn";
            regBtn.Size = new Size(100, 23);
            regBtn.TabIndex = 18;
            regBtn.Text = "Register";
            regBtn.UseVisualStyleBackColor = true;
            regBtn.Click += regBtn_Click;
            // 
            // regUserType
            // 
            regUserType.AllowDrop = true;
            regUserType.FormattingEnabled = true;
            regUserType.ItemHeight = 15;
            regUserType.Items.AddRange(new object[] { "Freelancer", "Client" });
            regUserType.Location = new Point(200, 224);
            regUserType.Name = "regUserType";
            regUserType.Size = new Size(100, 34);
            regUserType.TabIndex = 17;
            // 
            // regConfirmPassword
            // 
            regConfirmPassword.Location = new Point(200, 165);
            regConfirmPassword.Name = "regConfirmPassword";
            regConfirmPassword.Size = new Size(100, 23);
            regConfirmPassword.TabIndex = 16;
            // 
            // regPassword
            // 
            regPassword.Location = new Point(200, 106);
            regPassword.Name = "regPassword";
            regPassword.Size = new Size(100, 23);
            regPassword.TabIndex = 15;
            // 
            // regUsername
            // 
            regUsername.Location = new Point(200, 52);
            regUsername.Name = "regUsername";
            regUsername.Size = new Size(100, 23);
            regUsername.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 228);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 13;
            label4.Text = "User type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 168);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 12;
            label3.Text = "Confirm password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 109);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 11;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 55);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 10;
            label1.Text = "Username:";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toLogin);
            Controls.Add(regBtn);
            Controls.Add(regUserType);
            Controls.Add(regConfirmPassword);
            Controls.Add(regPassword);
            Controls.Add(regUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button toLogin;
        private Button regBtn;
        private ListBox regUserType;
        private TextBox regConfirmPassword;
        private TextBox regPassword;
        private TextBox regUsername;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}