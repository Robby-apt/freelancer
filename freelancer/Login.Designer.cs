
namespace freelancer
{
    partial class Login
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
            loginUsername = new TextBox();
            loginPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            loginBtn = new Button();
            toRegForm = new Button();
            SuspendLayout();
            // 
            // loginUsername
            // 
            loginUsername.Location = new Point(170, 90);
            loginUsername.Name = "loginUsername";
            loginUsername.Size = new Size(100, 23);
            loginUsername.TabIndex = 0;
            // 
            // loginPassword
            // 
            loginPassword.Location = new Point(170, 161);
            loginPassword.Name = "loginPassword";
            loginPassword.Size = new Size(100, 23);
            loginPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 93);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 164);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(170, 222);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(100, 23);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            // 
            // toRegForm
            // 
            toRegForm.Location = new Point(93, 285);
            toRegForm.Name = "toRegForm";
            toRegForm.Size = new Size(177, 23);
            toRegForm.TabIndex = 5;
            toRegForm.Text = "Register as a user instead";
            toRegForm.UseVisualStyleBackColor = true;
            toRegForm.Click += this.toRegForm_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toRegForm);
            Controls.Add(loginBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginPassword);
            Controls.Add(loginUsername);
            Name = "Login";
            Text = "Login Page";
            ResumeLayout(false);
            PerformLayout();
        }

        private void toRegForm_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration(userData);
            registration.Show();
            this.Hide();
        }

        #endregion

        private TextBox loginUsername;
        private TextBox loginPassword;
        private Label label1;
        private Label label2;
        private Button loginBtn;
        private Button toRegForm;
    }
}
