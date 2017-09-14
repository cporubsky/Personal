namespace RenamePictures
{
    partial class uxMainForm
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
            this.uxSource = new System.Windows.Forms.TextBox();
            this.uxDestination = new System.Windows.Forms.TextBox();
            this.uxSelectSource = new System.Windows.Forms.Button();
            this.uxSelectDestination = new System.Windows.Forms.Button();
            this.uxStart = new System.Windows.Forms.Button();
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxSourceFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.uxDestinationFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxSource
            // 
            this.uxSource.Location = new System.Drawing.Point(6, 19);
            this.uxSource.Name = "uxSource";
            this.uxSource.Size = new System.Drawing.Size(268, 20);
            this.uxSource.TabIndex = 2;
            // 
            // uxDestination
            // 
            this.uxDestination.Location = new System.Drawing.Point(6, 19);
            this.uxDestination.Name = "uxDestination";
            this.uxDestination.Size = new System.Drawing.Size(268, 20);
            this.uxDestination.TabIndex = 3;
            // 
            // uxSelectSource
            // 
            this.uxSelectSource.Location = new System.Drawing.Point(280, 19);
            this.uxSelectSource.Name = "uxSelectSource";
            this.uxSelectSource.Size = new System.Drawing.Size(75, 20);
            this.uxSelectSource.TabIndex = 4;
            this.uxSelectSource.Text = "Select";
            this.uxSelectSource.UseVisualStyleBackColor = true;
            this.uxSelectSource.Click += new System.EventHandler(this.uxSelectSource_Click);
            // 
            // uxSelectDestination
            // 
            this.uxSelectDestination.Location = new System.Drawing.Point(280, 19);
            this.uxSelectDestination.Name = "uxSelectDestination";
            this.uxSelectDestination.Size = new System.Drawing.Size(75, 20);
            this.uxSelectDestination.TabIndex = 5;
            this.uxSelectDestination.Text = "Select";
            this.uxSelectDestination.UseVisualStyleBackColor = true;
            this.uxSelectDestination.Click += new System.EventHandler(this.uxSelectDestination_Click);
            // 
            // uxStart
            // 
            this.uxStart.Location = new System.Drawing.Point(12, 135);
            this.uxStart.Name = "uxStart";
            this.uxStart.Size = new System.Drawing.Size(75, 23);
            this.uxStart.TabIndex = 6;
            this.uxStart.Text = "Start";
            this.uxStart.UseVisualStyleBackColor = true;
            this.uxStart.Click += new System.EventHandler(this.uxStart_Click);
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(93, 135);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 7;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uxSource);
            this.groupBox1.Controls.Add(this.uxSelectSource);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 54);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uxDestination);
            this.groupBox2.Controls.Add(this.uxSelectDestination);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 57);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination";
            // 
            // uxMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 169);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxStart);
            this.Name = "uxMainForm";
            this.Text = "Picture Rename";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox uxSource;
        private System.Windows.Forms.TextBox uxDestination;
        private System.Windows.Forms.Button uxSelectSource;
        private System.Windows.Forms.Button uxSelectDestination;
        private System.Windows.Forms.Button uxStart;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.FolderBrowserDialog uxSourceFolderDialog;
        private System.Windows.Forms.FolderBrowserDialog uxDestinationFolderDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

