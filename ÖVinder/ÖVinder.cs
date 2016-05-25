using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace ÖVinder
{
    public partial class ÖVinder : Form {
        private ITransport transport;
        public ÖVinder() {
            InitializeComponent();
        }

        private void labelVerbindungenTable_Click(object sender, EventArgs e) {
            if (tableLayoutPanelVerbindungen.Visible) {
                labelVerbindungenTable.Text = "Verbindungen <";
                tableLayoutPanelVerbindungen.Visible = false;
            } else {
                labelVerbindungenTable.Text = "Verbindungen v";
                tableLayoutPanelVerbindungen.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void buttonSearch_Click(object sender, EventArgs e) {
            tableLayoutPanelVerbindungen.Controls.Clear();
            transport = new Transport();
            var connections = transport.GetConnections(textBoxFrom.Text, textBoxTo.Text);
            int rowCount = 0;
            int columnCount = 0;
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = "Abfahrt:" }, columnCount, rowCount);
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = "Dauer:" }, columnCount++, rowCount);
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = "Gleis / Platform:" }, columnCount++, rowCount);
            rowCount++;
            DateTime departureTime;
            foreach (Connection targetConnection in connections.ConnectionList) {
                columnCount = 0;
                Console.WriteLine(targetConnection.Duration.ToString());
                departureTime = Convert.ToDateTime(targetConnection.From.Departure.ToString());
                string duration = targetConnection.Duration.ToString().Substring(targetConnection.Duration.ToString().Length - 7);
                tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = departureTime.Hour.ToString() + ":" + departureTime.Minute.ToString() }, columnCount, rowCount);
                tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = duration }, columnCount++, rowCount);
                tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = targetConnection.From.Platform }, columnCount++, rowCount);
                rowCount += 1;
            }            
        }
    }
}
