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
        int rowCountVerbindungen = 0;
        int columnCountVerbindungen = 0;
        int rowCountAbfahrtsplan = 0;
        int columnCountAbfahrtsplan = 0;
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

        private void buttonSearchAbfahrtsplan_Click(object sender, EventArgs e) {
            transport = new Transport();
            var stationBoard = transport.GetStationBoard("Sursee", "8502007");
            Console.WriteLine(stationBoard.Entries.Count());

            foreach (StationBoard sb in stationBoard.Entries) {
                columnCountAbfahrtsplan = 0;

                var connections = transport.GetConnections(textBoxFrom.Text, textBoxTo.Text);

                foreach (Connection targetConnection in connections.ConnectionList) {
                    string duration = targetConnection.Duration.ToString().Substring(targetConnection.Duration.ToString().Length - 7);

                }

                tableLayoutPanelAbfahrsplan.Controls.Add(new Label() { Text = sb.To.ToString()}, columnCountVerbindungen, rowCountVerbindungen);
                //tableLayoutPanelAbfahrsplan.Controls.Add(new Label() { Text = transport. }, columnCountVerbindungen++, rowCountVerbindungen);
                rowCountAbfahrtsplan++;
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e) {
            transport = new Transport();
            var connections = transport.GetConnections(textBoxFrom.Text, textBoxTo.Text);
            tableLayoutPanelVerbindungen.Controls.Clear();
            insertHeaderVerbindungen();
            rowCountVerbindungen++;
            DateTime departureTime;
            DateTime arrivalTime;
            foreach (Connection targetConnection in connections.ConnectionList) {
                columnCountVerbindungen = 0;
                Console.WriteLine(targetConnection.Duration.ToString());
                departureTime = Convert.ToDateTime(targetConnection.From.Departure.ToString());
                arrivalTime = Convert.ToDateTime(targetConnection.To.Arrival.ToString());
                string duration = targetConnection.Duration.ToString().Substring(targetConnection.Duration.ToString().Length - 7);
                tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = departureTime.Hour.ToString() + ":" + addLeadingZero(departureTime.Minute)},
                columnCountVerbindungen, rowCountVerbindungen);
                tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = arrivalTime.Hour.ToString() + ":" + addLeadingZero(arrivalTime.Minute) },
                columnCountVerbindungen++, rowCountVerbindungen);
                tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = duration }, columnCountVerbindungen++, rowCountVerbindungen);
                tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = targetConnection.From.Platform }, columnCountVerbindungen++, rowCountVerbindungen);
                rowCountVerbindungen++;
                
            }
        }
        private void insertHeaderVerbindungen() {
            Font titleFont = new Font(Font.Name, 12, FontStyle.Bold | FontStyle.Underline);
            columnCountVerbindungen = 0;
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = "Abfahrt:", Font = titleFont}, columnCountVerbindungen, rowCountVerbindungen);
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = "Ankunft:", Font = titleFont }, columnCountVerbindungen++, rowCountVerbindungen);
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = "Dauer:" , Font = titleFont}, columnCountVerbindungen++, rowCountVerbindungen);
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = "Gleis:", Font = titleFont }, columnCountVerbindungen++, rowCountVerbindungen);
        }
        private void insertHeaderAbfahrtsplan() {
            Font titleFont = new Font(Font.Name, 12, FontStyle.Bold | FontStyle.Underline);
            columnCountAbfahrtsplan = 0;
            tableLayoutPanelAbfahrsplan.Controls.Add(new Label() { Text = "Ziel:", Font = titleFont }, columnCountAbfahrtsplan, rowCountAbfahrtsplan);
            tableLayoutPanelAbfahrsplan.Controls.Add(new Label() { Text = "Abfahrt:", Font = titleFont }, columnCountAbfahrtsplan++, rowCountAbfahrtsplan);
            tableLayoutPanelAbfahrsplan.Controls.Add(new Label() { Text = "Gleis:", Font = titleFont }, columnCountAbfahrtsplan++, rowCountAbfahrtsplan);
        }

        private void ÖVinder_Load(object sender, EventArgs e) {
            insertHeaderAbfahrtsplan();
            insertHeaderVerbindungen();
        }
        private string addLeadingZero(int numberToAddZero) {
            if (numberToAddZero < 10) {
                return "0" + numberToAddZero;
            } else {
                return numberToAddZero.ToString();
            }
        }
    }
}
