namespace AddressBook
{
    partial class uxMainMenuForm
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
            this.uxButton1 = new System.Windows.Forms.Button();
            this.uxButton2 = new System.Windows.Forms.Button();
            this.uxAddUser = new System.Windows.Forms.Button();
            this.uxButton4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxButton1
            // 
            this.uxButton1.Location = new System.Drawing.Point(12, 12);
            this.uxButton1.Name = "uxButton1";
            this.uxButton1.Size = new System.Drawing.Size(75, 23);
            this.uxButton1.TabIndex = 0;
            this.uxButton1.Text = "New Entry";
            this.uxButton1.UseVisualStyleBackColor = true;
            // 
            // uxButton2
            // 
            this.uxButton2.Location = new System.Drawing.Point(107, 11);
            this.uxButton2.Name = "uxButton2";
            this.uxButton2.Size = new System.Drawing.Size(75, 23);
            this.uxButton2.TabIndex = 1;
            this.uxButton2.Text = "Search";
            this.uxButton2.UseVisualStyleBackColor = true;
            // 
            // uxAddUser
            // 
            this.uxAddUser.Enabled = false;
            this.uxAddUser.Location = new System.Drawing.Point(12, 41);
            this.uxAddUser.Name = "uxAddUser";
            this.uxAddUser.Size = new System.Drawing.Size(75, 23);
            this.uxAddUser.TabIndex = 2;
            this.uxAddUser.Text = "Add User";
            this.uxAddUser.UseVisualStyleBackColor = true;
            this.uxAddUser.Click += new System.EventHandler(this.uxAddUser_Click);
            // 
            // uxButton4
            // 
            this.uxButton4.Enabled = false;
            this.uxButton4.Location = new System.Drawing.Point(107, 41);
            this.uxButton4.Name = "uxButton4";
            this.uxButton4.Size = new System.Drawing.Size(75, 23);
            this.uxButton4.TabIndex = 3;
            this.uxButton4.Text = "Remove";
            this.uxButton4.UseVisualStyleBackColor = true;
            // 
            // uxMainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 76);
            this.Controls.Add(this.uxButton4);
            this.Controls.Add(this.uxAddUser);
            this.Controls.Add(this.uxButton2);
            this.Controls.Add(this.uxButton1);
            this.Name = "uxMainMenuForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxButton1;
        private System.Windows.Forms.Button uxButton2;
        private System.Windows.Forms.Button uxAddUser;
        private System.Windows.Forms.Button uxButton4;
    }
}

