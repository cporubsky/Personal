namespace System_Info
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.uxOs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxMachineName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uxProcessor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxMemory = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uxIP = new System.Windows.Forms.Label();
            this.uxRadioButton1 = new System.Windows.Forms.RadioButton();
            this.uxRadioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 74);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(25, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "OS:";
            // 
            // uxOs
            // 
            this.uxOs.AutoSize = true;
            this.uxOs.Location = new System.Drawing.Point(44, 74);
            this.uxOs.Name = "uxOs";
            this.uxOs.Size = new System.Drawing.Size(0, 13);
            this.uxOs.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Machine Name:";
            // 
            // uxMachineName
            // 
            this.uxMachineName.AutoSize = true;
            this.uxMachineName.Location = new System.Drawing.Point(101, 18);
            this.uxMachineName.Name = "uxMachineName";
            this.uxMachineName.Size = new System.Drawing.Size(0, 13);
            this.uxMachineName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Processor:";
            // 
            // uxProcessor
            // 
            this.uxProcessor.AutoSize = true;
            this.uxProcessor.Location = new System.Drawing.Point(67, 46);
            this.uxProcessor.Name = "uxProcessor";
            this.uxProcessor.Size = new System.Drawing.Size(0, 13);
            this.uxProcessor.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Memory:";
            // 
            // uxMemory
            // 
            this.uxMemory.AutoSize = true;
            this.uxMemory.Location = new System.Drawing.Point(67, 102);
            this.uxMemory.Name = "uxMemory";
            this.uxMemory.Size = new System.Drawing.Size(0, 13);
            this.uxMemory.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 48);
            this.textBox1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "IP:";
            // 
            // uxIP
            // 
            this.uxIP.AutoSize = true;
            this.uxIP.Location = new System.Drawing.Point(40, 134);
            this.uxIP.Name = "uxIP";
            this.uxIP.Size = new System.Drawing.Size(0, 13);
            this.uxIP.TabIndex = 13;
            // 
            // uxRadioButton1
            // 
            this.uxRadioButton1.AutoSize = true;
            this.uxRadioButton1.Checked = true;
            this.uxRadioButton1.Location = new System.Drawing.Point(6, 20);
            this.uxRadioButton1.Name = "uxRadioButton1";
            this.uxRadioButton1.Size = new System.Drawing.Size(49, 17);
            this.uxRadioButton1.TabIndex = 15;
            this.uxRadioButton1.TabStop = true;
            this.uxRadioButton1.Text = "ADM";
            this.uxRadioButton1.UseVisualStyleBackColor = true;
            // 
            // uxRadioButton2
            // 
            this.uxRadioButton2.AutoSize = true;
            this.uxRadioButton2.Location = new System.Drawing.Point(6, 44);
            this.uxRadioButton2.Name = "uxRadioButton2";
            this.uxRadioButton2.Size = new System.Drawing.Size(45, 17);
            this.uxRadioButton2.TabIndex = 16;
            this.uxRadioButton2.Text = "SFA";
            this.uxRadioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(15, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 75);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hard Drives";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uxRadioButton2);
            this.groupBox2.Controls.Add(this.uxRadioButton1);
            this.groupBox2.Location = new System.Drawing.Point(124, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 75);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dept";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 323);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uxIP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uxMemory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxProcessor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxMachineName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxOs);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "System Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label uxOs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label uxMachineName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label uxProcessor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uxMemory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label uxIP;
        private System.Windows.Forms.RadioButton uxRadioButton1;
        private System.Windows.Forms.RadioButton uxRadioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

