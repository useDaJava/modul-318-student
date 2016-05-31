namespace ÖVinder {
    partial class Share {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelContent = new System.Windows.Forms.Label();
            this.buttonSendMail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(12, 25);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(438, 20);
            this.textBoxTo.TabIndex = 0;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(15, 64);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(435, 20);
            this.textBoxSubject.TabIndex = 1;
            // 
            // textBoxBody
            // 
            this.textBoxBody.Location = new System.Drawing.Point(12, 112);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(438, 150);
            this.textBoxBody.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Empfänger:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Betreff:";
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Location = new System.Drawing.Point(12, 96);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(36, 13);
            this.labelContent.TabIndex = 5;
            this.labelContent.Text = "Inhalt:";
            // 
            // buttonSendMail
            // 
            this.buttonSendMail.Location = new System.Drawing.Point(12, 268);
            this.buttonSendMail.Name = "buttonSendMail";
            this.buttonSendMail.Size = new System.Drawing.Size(438, 23);
            this.buttonSendMail.TabIndex = 10;
            this.buttonSendMail.Text = "Senden";
            this.buttonSendMail.UseVisualStyleBackColor = true;
            this.buttonSendMail.Click += new System.EventHandler(this.buttonSendMail_Click);
            // 
            // Share
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 294);
            this.Controls.Add(this.buttonSendMail);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxTo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 321);
            this.MinimumSize = new System.Drawing.Size(470, 321);
            this.Name = "Share";
            this.Text = "Share";
            this.Load += new System.EventHandler(this.Share_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.Button buttonSendMail;
    }
}