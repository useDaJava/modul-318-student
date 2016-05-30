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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageVerbindungen = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerTimeVerbindungen = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDateVerbindungen = new System.Windows.Forms.DateTimePicker();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelVerbindungenTable = new System.Windows.Forms.Label();
            this.tableLayoutPanelVerbindungen = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.labelVon = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.tabPageAbfahrt = new System.Windows.Forms.TabPage();
            this.buttonVerbindungSuchenAbfahrtsplan = new System.Windows.Forms.Button();
            this.labelAbfahrten = new System.Windows.Forms.Label();
            this.tableLayoutPanelAbfahrsplan = new System.Windows.Forms.TableLayoutPanel();
            this.labelAbfahrtsplanVon = new System.Windows.Forms.Label();
            this.textBoxFromAbfahrtsplan = new System.Windows.Forms.TextBox();
            this.tabPageMap = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMapStation = new System.Windows.Forms.TextBox();
            this.buttonShowOnMap = new System.Windows.Forms.Button();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.tabControl.SuspendLayout();
            this.tabPageVerbindungen.SuspendLayout();
            this.tabPageAbfahrt.SuspendLayout();
            this.tabPageMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageVerbindungen);
            this.tabControl.Controls.Add(this.tabPageAbfahrt);
            this.tabControl.Controls.Add(this.tabPageMap);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(446, 403);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageVerbindungen
            // 
            this.tabPageVerbindungen.Controls.Add(this.label3);
            this.tabPageVerbindungen.Controls.Add(this.dateTimePickerTimeVerbindungen);
            this.tabPageVerbindungen.Controls.Add(this.label1);
            this.tabPageVerbindungen.Controls.Add(this.dateTimePickerDateVerbindungen);
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
            this.tabPageVerbindungen.Size = new System.Drawing.Size(438, 377);
            this.tabPageVerbindungen.TabIndex = 0;
            this.tabPageVerbindungen.Text = "Verbindungen";
            this.tabPageVerbindungen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Zeit:";
            // 
            // dateTimePickerTimeVerbindungen
            // 
            this.dateTimePickerTimeVerbindungen.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTimeVerbindungen.Location = new System.Drawing.Point(62, 84);
            this.dateTimePickerTimeVerbindungen.Name = "dateTimePickerTimeVerbindungen";
            this.dateTimePickerTimeVerbindungen.ShowUpDown = true;
            this.dateTimePickerTimeVerbindungen.Size = new System.Drawing.Size(171, 20);
            this.dateTimePickerTimeVerbindungen.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Datum";
            // 
            // dateTimePickerDateVerbindungen
            // 
            this.dateTimePickerDateVerbindungen.Location = new System.Drawing.Point(62, 58);
            this.dateTimePickerDateVerbindungen.Name = "dateTimePickerDateVerbindungen";
            this.dateTimePickerDateVerbindungen.Size = new System.Drawing.Size(170, 20);
            this.dateTimePickerDateVerbindungen.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(12, 119);
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
            this.tableLayoutPanelVerbindungen.Size = new System.Drawing.Size(432, 193);
            this.tableLayoutPanelVerbindungen.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nach:";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(62, 32);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(170, 20);
            this.textBoxTo.TabIndex = 2;
            this.textBoxTo.TextChanged += new System.EventHandler(this.textBoxTo_TextChanged);
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
            this.tabPageAbfahrt.Size = new System.Drawing.Size(438, 377);
            this.tabPageAbfahrt.TabIndex = 1;
            this.tabPageAbfahrt.Text = "Abfahrtsplan";
            this.tabPageAbfahrt.UseVisualStyleBackColor = true;
            // 
            // buttonVerbindungSuchenAbfahrtsplan
            // 
            this.buttonVerbindungSuchenAbfahrtsplan.Location = new System.Drawing.Point(11, 32);
            this.buttonVerbindungSuchenAbfahrtsplan.Name = "buttonVerbindungSuchenAbfahrtsplan";
            this.buttonVerbindungSuchenAbfahrtsplan.Size = new System.Drawing.Size(221, 23);
            this.buttonVerbindungSuchenAbfahrtsplan.TabIndex = 10;
            this.buttonVerbindungSuchenAbfahrtsplan.Text = "Verbindung Suchen";
            this.buttonVerbindungSuchenAbfahrtsplan.UseVisualStyleBackColor = true;
            this.buttonVerbindungSuchenAbfahrtsplan.Click += new System.EventHandler(this.buttonSearchAbfahrtsplan_Click);
            // 
            // labelAbfahrten
            // 
            this.labelAbfahrten.AutoSize = true;
            this.labelAbfahrten.Location = new System.Drawing.Point(1, 151);
            this.labelAbfahrten.Name = "labelAbfahrten";
            this.labelAbfahrten.Size = new System.Drawing.Size(53, 13);
            this.labelAbfahrten.TabIndex = 12;
            this.labelAbfahrten.Text = "Abfahrten";
            // 
            // tableLayoutPanelAbfahrsplan
            // 
            this.tableLayoutPanelAbfahrsplan.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelAbfahrsplan.ColumnCount = 2;
            this.tableLayoutPanelAbfahrsplan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAbfahrsplan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAbfahrsplan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelAbfahrsplan.Location = new System.Drawing.Point(3, 181);
            this.tableLayoutPanelAbfahrsplan.Name = "tableLayoutPanelAbfahrsplan";
            this.tableLayoutPanelAbfahrsplan.RowCount = 2;
            this.tableLayoutPanelAbfahrsplan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAbfahrsplan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAbfahrsplan.Size = new System.Drawing.Size(432, 193);
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
            // tabPageMap
            // 
            this.tabPageMap.Controls.Add(this.map);
            this.tabPageMap.Controls.Add(this.buttonShowOnMap);
            this.tabPageMap.Controls.Add(this.textBoxMapStation);
            this.tabPageMap.Controls.Add(this.label4);
            this.tabPageMap.Location = new System.Drawing.Point(4, 22);
            this.tabPageMap.Name = "tabPageMap";
            this.tabPageMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMap.Size = new System.Drawing.Size(438, 377);
            this.tabPageMap.TabIndex = 2;
            this.tabPageMap.Text = "Karte";
            this.tabPageMap.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Station:";
            // 
            // textBoxMapStation
            // 
            this.textBoxMapStation.Location = new System.Drawing.Point(62, 6);
            this.textBoxMapStation.Name = "textBoxMapStation";
            this.textBoxMapStation.Size = new System.Drawing.Size(170, 20);
            this.textBoxMapStation.TabIndex = 1;
            this.textBoxMapStation.TextChanged += new System.EventHandler(this.textBoxMapStation_TextChanged);
            // 
            // buttonShowOnMap
            // 
            this.buttonShowOnMap.Location = new System.Drawing.Point(11, 32);
            this.buttonShowOnMap.Name = "buttonShowOnMap";
            this.buttonShowOnMap.Size = new System.Drawing.Size(221, 23);
            this.buttonShowOnMap.TabIndex = 2;
            this.buttonShowOnMap.Text = "Station auf Karte anzeigen";
            this.buttonShowOnMap.UseVisualStyleBackColor = true;
            this.buttonShowOnMap.Click += new System.EventHandler(this.buttonShowOnMap_Click);
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(3, 61);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 20;
            this.map.MinZoom = 0;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(432, 313);
            this.map.TabIndex = 23;
            this.map.Zoom = 1D;
            // 
            // ÖVinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 403);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(454, 430);
            this.MinimumSize = new System.Drawing.Size(454, 430);
            this.Name = "ÖVinder";
            this.Text = "ÖVinder";
            this.Load += new System.EventHandler(this.ÖVinder_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageVerbindungen.ResumeLayout(false);
            this.tabPageVerbindungen.PerformLayout();
            this.tabPageAbfahrt.ResumeLayout(false);
            this.tabPageAbfahrt.PerformLayout();
            this.tabPageMap.ResumeLayout(false);
            this.tabPageMap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
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
        private System.Windows.Forms.DateTimePicker dateTimePickerDateVerbindungen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerTimeVerbindungen;
        private System.Windows.Forms.TabPage tabPageMap;
        private System.Windows.Forms.TextBox textBoxMapStation;
        private System.Windows.Forms.Label label4;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Button buttonShowOnMap;
    }
}

