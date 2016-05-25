namespace ÖVinder
{
    partial class ÖVinder
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelVerbindungenTable = new System.Windows.Forms.Label();
            this.tableLayoutPanelVerbindungen = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.labelVon = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.tabPageAbfahrt = new System.Windows.Forms.TabPage();
            this.buttonVerbindungSuchenAbfahrtsplan = new System.Windows.Forms.Button();
            this.tableLayoutPanelAbfahrsplan = new System.Windows.Forms.TableLayoutPanel();
            this.labelAbfahrtsplanVon = new System.Windows.Forms.Label();
            this.textBoxFromAbfahrtsplan = new System.Windows.Forms.TextBox();
            this.labelAbfahrten = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageVerbindungen.SuspendLayout();
            this.tabPageAbfahrt.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(416, 403);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageVerbindungen
            // 
            this.tabPageVerbindungen.Controls.Add(this.buttonSearch);
            this.tabPageVerbindungen.Controls.Add(this.labelVerbindungenTable);
            this.tabPageVerbindungen.Controls.Add(this.tableLayoutPanelVerbindungen);
            this.tabPageVerbindungen.Controls.Add(this.label2);
            this.tabPageVerbindungen.Controls.Add(this.textBoxTo);
            this.tabPageVerbindungen.Controls.Add(this.labelVon);
            this.tabPageVerbindungen.Controls.Add(this.textBoxFrom);
            this.tabPageVerbindungen.Location = new System.Drawing.Point(4, 22);
            this.tabPageVerbindungen.Name = "tabPageVerbindungen";
            this.tabPageVerbindungen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVerbindungen.Size = new System.Drawing.Size(408, 377);
            this.tabPageVerbindungen.TabIndex = 0;
            this.tabPageVerbindungen.Text = "Verbindungen";
            this.tabPageVerbindungen.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(11, 80);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(221, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Verbindung Suchen";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelVerbindungenTable
            // 
            this.labelVerbindungenTable.AutoSize = true;
            this.labelVerbindungenTable.Location = new System.Drawing.Point(1, 151);
            this.labelVerbindungenTable.Name = "labelVerbindungenTable";
            this.labelVerbindungenTable.Size = new System.Drawing.Size(73, 13);
            this.labelVerbindungenTable.TabIndex = 1;
            this.labelVerbindungenTable.Text = "Verbindungen";
            this.labelVerbindungenTable.Click += new System.EventHandler(this.labelVerbindungenTable_Click);
            // 
            // tableLayoutPanelVerbindungen
            // 
            this.tableLayoutPanelVerbindungen.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelVerbindungen.ColumnCount = 4;
            this.tableLayoutPanelVerbindungen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelVerbindungen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelVerbindungen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelVerbindungen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelVerbindungen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelVerbindungen.Location = new System.Drawing.Point(3, 181);
            this.tableLayoutPanelVerbindungen.Name = "tableLayoutPanelVerbindungen";
            this.tableLayoutPanelVerbindungen.RowCount = 2;
            this.tableLayoutPanelVerbindungen.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelVerbindungen.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelVerbindungen.Size = new System.Drawing.Size(402, 193);
            this.tableLayoutPanelVerbindungen.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nach:";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(62, 41);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(170, 20);
            this.textBoxTo.TabIndex = 2;
            this.textBoxTo.TextChanged += new System.EventHandler(this.textBoxTo_TextChanged);
            this.textBoxTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTo_KeyPress);
            // 
            // labelVon
            // 
            this.labelVon.AutoSize = true;
            this.labelVon.Location = new System.Drawing.Point(8, 9);
            this.labelVon.Name = "labelVon";
            this.labelVon.Size = new System.Drawing.Size(29, 13);
            this.labelVon.TabIndex = 1;
            this.labelVon.Text = "Von:";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(62, 6);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(170, 20);
            this.textBoxFrom.TabIndex = 0;
            this.textBoxFrom.TextChanged += new System.EventHandler(this.textBoxFrom_TextChanged);
            // 
            // tabPageAbfahrt
            // 
            this.tabPageAbfahrt.Controls.Add(this.buttonVerbindungSuchenAbfahrtsplan);
            this.tabPageAbfahrt.Controls.Add(this.labelAbfahrten);
            this.tabPageAbfahrt.Controls.Add(this.tableLayoutPanelAbfahrsplan);
            this.tabPageAbfahrt.Controls.Add(this.labelAbfahrtsplanVon);
            this.tabPageAbfahrt.Controls.Add(this.textBoxFromAbfahrtsplan);
            this.tabPageAbfahrt.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbfahrt.Name = "tabPageAbfahrt";
            this.tabPageAbfahrt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbfahrt.Size = new System.Drawing.Size(408, 377);
            this.tabPageAbfahrt.TabIndex = 1;
            this.tabPageAbfahrt.Text = "Abfahrtsplan";
            this.tabPageAbfahrt.UseVisualStyleBackColor = true;
            this.tabPageAbfahrt.Click += new System.EventHandler(this.tabPageAbfahrt_Click);
            // 
            // buttonVerbindungSuchenAbfahrtsplan
            // 
            this.buttonVerbindungSuchenAbfahrtsplan.Location = new System.Drawing.Point(11, 41);
            this.buttonVerbindungSuchenAbfahrtsplan.Name = "buttonVerbindungSuchenAbfahrtsplan";
            this.buttonVerbindungSuchenAbfahrtsplan.Size = new System.Drawing.Size(221, 23);
            this.buttonVerbindungSuchenAbfahrtsplan.TabIndex = 10;
            this.buttonVerbindungSuchenAbfahrtsplan.Text = "Verbindung Suchen";
            this.buttonVerbindungSuchenAbfahrtsplan.UseVisualStyleBackColor = true;
            this.buttonVerbindungSuchenAbfahrtsplan.Click += new System.EventHandler(this.buttonSearchAbfahrtsplan_Click);
            // 
            // tableLayoutPanelAbfahrsplan
            // 
            this.tableLayoutPanelAbfahrsplan.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelAbfahrsplan.ColumnCount = 3;
            this.tableLayoutPanelAbfahrsplan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAbfahrsplan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAbfahrsplan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanelAbfahrsplan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelAbfahrsplan.Location = new System.Drawing.Point(3, 181);
            this.tableLayoutPanelAbfahrsplan.Name = "tableLayoutPanelAbfahrsplan";
            this.tableLayoutPanelAbfahrsplan.RowCount = 2;
            this.tableLayoutPanelAbfahrsplan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAbfahrsplan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAbfahrsplan.Size = new System.Drawing.Size(402, 193);
            this.tableLayoutPanelAbfahrsplan.TabIndex = 20;
            // 
            // labelAbfahrtsplanVon
            // 
            this.labelAbfahrtsplanVon.AutoSize = true;
            this.labelAbfahrtsplanVon.Location = new System.Drawing.Point(8, 9);
            this.labelAbfahrtsplanVon.Name = "labelAbfahrtsplanVon";
            this.labelAbfahrtsplanVon.Size = new System.Drawing.Size(29, 13);
            this.labelAbfahrtsplanVon.TabIndex = 13;
            this.labelAbfahrtsplanVon.Text = "Von:";
            // 
            // textBoxFromAbfahrtsplan
            // 
            this.textBoxFromAbfahrtsplan.Location = new System.Drawing.Point(62, 6);
            this.textBoxFromAbfahrtsplan.Name = "textBoxFromAbfahrtsplan";
            this.textBoxFromAbfahrtsplan.Size = new System.Drawing.Size(170, 20);
            this.textBoxFromAbfahrtsplan.TabIndex = 11;
            this.textBoxFromAbfahrtsplan.TextChanged += new System.EventHandler(this.textBoxVonAbfahrtsplan_TextChanged);
            // 
            // labelAbfahrten
            // 
            this.labelAbfahrten.AutoSize = true;
            this.labelAbfahrten.Location = new System.Drawing.Point(1, 151);
            this.labelAbfahrten.Name = "labelAbfahrten";
            this.labelAbfahrten.Size = new System.Drawing.Size(53, 13);
            this.labelAbfahrten.TabIndex = 12;
            this.labelAbfahrten.Text = "Abfahrten";
            this.labelAbfahrten.Click += new System.EventHandler(this.labelAbfahrten_Click);
            // 
            // ÖVinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 403);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(424, 430);
            this.MinimumSize = new System.Drawing.Size(340, 430);
            this.Name = "ÖVinder";
            this.Text = "ÖVinder";
            this.Load += new System.EventHandler(this.ÖVinder_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageVerbindungen.ResumeLayout(false);
            this.tabPageVerbindungen.PerformLayout();
            this.tabPageAbfahrt.ResumeLayout(false);
            this.tabPageAbfahrt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageVerbindungen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label labelVon;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TabPage tabPageAbfahrt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVerbindungen;
        private System.Windows.Forms.Label labelVerbindungenTable;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonVerbindungSuchenAbfahrtsplan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAbfahrsplan;
        private System.Windows.Forms.Label labelAbfahrtsplanVon;
        private System.Windows.Forms.TextBox textBoxFromAbfahrtsplan;
        private System.Windows.Forms.Label labelAbfahrten;
    }
}

