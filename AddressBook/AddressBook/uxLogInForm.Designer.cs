namespace AddressBook
{
    partial class uxLogInForm
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
            this.uxUserName = new System.Windows.Forms.TextBox();
            this.uxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxLogIn = new System.Windows.Forms.Button();
            this.uxResetPw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxUserName
            // 
            this.uxUserName.Location = new System.Drawing.Point(75, 6);
            this.uxUserName.Name = "uxUserName";
            this.uxUserName.Size = new System.Drawing.Size(150, 20);
            this.uxUserName.TabIndex = 0;
            // 
            // uxPassword
            // 
            this.uxPassword.Location = new System.Drawing.Point(74, 35);
            this.uxPassword.Name = "uxPassword";
            this.uxPassword.Size = new System.Drawing.Size(151, 20);
            this.uxPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // uxLogIn
            // 
            this.uxLogIn.Location = new System.Drawing.Point(74, 61);
            this.uxLogIn.Name = "uxLogIn";
            this.uxLogIn.Size = new System.Drawing.Size(75, 23);
            this.uxLogIn.TabIndex = 4;
            this.uxLogIn.Text = "Log In";
            this.uxLogIn.UseVisualStyleBackColor = true;
            this.uxLogIn.Click += new System.EventHandler(this.uxLogIn_Click);
            // 
            // uxResetPw
            // 
            this.uxResetPw.Location = new System.Drawing.Point(150, 61);
            this.uxResetPw.Name = "uxResetPw";
            this.uxResetPw.Size = new System.Drawing.Size(75, 23);
            this.uxResetPw.TabIndex = 5;
            this.uxResetPw.Text = "Reset PW";
            this.uxResetPw.UseVisualStyleBackColor = true;
            // 
            // uxLogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 105);
            this.Controls.Add(this.uxResetPw);
            this.Controls.Add(this.uxLogIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxPassword);
            this.Controls.Add(this.uxUserName);
            this.Name = "uxLogInForm";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxUserName;
        private System.Windows.Forms.TextBox uxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uxLogIn;
        private System.Windows.Forms.Button uxResetPw;
    }
}