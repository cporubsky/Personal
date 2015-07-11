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
            // uxMainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 92);
            this.Controls.Add(this.uxButton1);
            this.Name = "uxMainMenuForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxButton1;

    }
}

