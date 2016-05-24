namespace ÖVinder
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageVerbindungen = new System.Windows.Forms.TabPage();
            this.tabPageAbfahrt = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelVon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPageVerbindungen.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageVerbindungen);
            this.tabControl1.Controls.Add(this.tabPageAbfahrt);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 402);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageVerbindungen
            // 
            this.tabPageVerbindungen.Controls.Add(this.dateTimePicker1);
            this.tabPageVerbindungen.Controls.Add(this.label3);
            this.tabPageVerbindungen.Controls.Add(this.label2);
            this.tabPageVerbindungen.Controls.Add(this.textBox2);
            this.tabPageVerbindungen.Controls.Add(this.labelVon);
            this.tabPageVerbindungen.Controls.Add(this.textBox1);
            this.tabPageVerbindungen.Location = new System.Drawing.Point(4, 22);
            this.tabPageVerbindungen.Name = "tabPageVerbindungen";
            this.tabPageVerbindungen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVerbindungen.Size = new System.Drawing.Size(624, 376);
            this.tabPageVerbindungen.TabIndex = 0;
            this.tabPageVerbindungen.Text = "Verbindungen";
            this.tabPageVerbindungen.UseVisualStyleBackColor = true;
            // 
            // tabPageAbfahrt
            // 
            this.tabPageAbfahrt.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbfahrt.Name = "tabPageAbfahrt";
            this.tabPageAbfahrt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbfahrt.Size = new System.Drawing.Size(547, 296);
            this.tabPageAbfahrt.TabIndex = 1;
            this.tabPageAbfahrt.Text = "Abfahrtsplan";
            this.tabPageAbfahrt.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 0;
            // 
            // labelVon
            // 
            this.labelVon.AutoSize = true;
            this.labelVon.Location = new System.Drawing.Point(11, 27);
            this.labelVon.Name = "labelVon";
            this.labelVon.Size = new System.Drawing.Size(29, 13);
            this.labelVon.TabIndex = 1;
            this.labelVon.Text = "label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(331, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 402);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ÖVinder";
            this.tabControl1.ResumeLayout(false);
            this.tabPageVerbindungen.ResumeLayout(false);
            this.tabPageVerbindungen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageVerbindungen;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelVon;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPageAbfahrt;
    }
}

