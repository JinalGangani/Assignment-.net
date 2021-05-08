namespace q4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButtonLCM = new System.Windows.Forms.RadioButton();
            this.radioButtonHCF = new System.Windows.Forms.RadioButton();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 22);
            this.textBox2.TabIndex = 1;
            // 
            // radioButtonLCM
            // 
            this.radioButtonLCM.AutoSize = true;
            this.radioButtonLCM.Location = new System.Drawing.Point(320, 55);
            this.radioButtonLCM.Name = "radioButtonLCM";
            this.radioButtonLCM.Size = new System.Drawing.Size(57, 21);
            this.radioButtonLCM.TabIndex = 2;
            this.radioButtonLCM.TabStop = true;
            this.radioButtonLCM.Text = "LCM";
            this.radioButtonLCM.UseVisualStyleBackColor = true;
            this.radioButtonLCM.CheckedChanged += new System.EventHandler(this.radioButtonLCM_CheckedChanged);
            // 
            // radioButtonHCF
            // 
            this.radioButtonHCF.AutoSize = true;
            this.radioButtonHCF.Location = new System.Drawing.Point(320, 115);
            this.radioButtonHCF.Name = "radioButtonHCF";
            this.radioButtonHCF.Size = new System.Drawing.Size(56, 21);
            this.radioButtonHCF.TabIndex = 3;
            this.radioButtonHCF.TabStop = true;
            this.radioButtonHCF.Text = "HCF";
            this.radioButtonHCF.UseVisualStyleBackColor = true;
            this.radioButtonHCF.CheckedChanged += new System.EventHandler(this.radioButtonHCF_CheckedChanged);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(158, 189);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(133, 17);
            this.labelMessage.TabIndex = 4;
            this.labelMessage.Text = "Result Display Here";
            this.labelMessage.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 395);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.radioButtonHCF);
            this.Controls.Add(this.radioButtonLCM);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButtonLCM;
        private System.Windows.Forms.RadioButton radioButtonHCF;
        private System.Windows.Forms.Label labelMessage;
    }
}

