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
using System.Diagnostics;
using Microsoft.Win32;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Net.Mail;

namespace ÖVinder
{
    public partial class ÖVinder : Form {
        Share share = new Share();
        private ITransport transport;
        int rowCountVerbindungen = 0;
        int columnCountVerbindungen = 0;
        int rowCountAbfahrtsplan = 0;
        int columnCountAbfahrtsplan = 0;
        GMarkerGoogle marker;
        //create marker overlay for gmap
        GMapOverlay markersOverlay = new GMapOverlay("markers");
        public ÖVinder() {
            InitializeComponent();
        }

        private void ÖVinder_Load(object sender, EventArgs e) {
            //initialize GMap stuff
            map.MapProvider = GMap.NET.MapProviders.GoogleHybridMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            map.Position = new PointLatLng(46.7976544, 8.2275602);
            map.ShowCenter = false;
            //insert heading rows into tables
            insertHeaderAbfahrtsplan();
            insertHeaderVerbindungen();

            //set autocomplete mode and source
            setAutoCompleteOnTextBox(textBoxMapStation);
            setAutoCompleteOnTextBox(textBoxFrom);
            setAutoCompleteOnTextBox(textBoxTo);
            setAutoCompleteOnTextBox(textBoxFromAbfahrtsplan);

            //set autoscroll to true
            tableLayoutPanelAbfahrsplan.AutoScroll = true;
            tableLayoutPanelVerbindungen.AutoScroll = true;
        }

        public void setAutoCompleteOnTextBox(TextBox textBox) {
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }


        private void buttonSearchAbfahrtsplan_Click(object sender, EventArgs e) {
            //call method for action
            searchAbfahrten();
        }

        private void searchAbfahrten() {
            transport = new Transport();
            Station station = transport.GetStations(textBoxFromAbfahrtsplan.Text).StationList.First();
            var stationBoard = transport.GetStationBoard(station.Name, station.Id);

            //clear table, delete all content from tableLayoutPanelAbfahrsplan
            tableLayoutPanelAbfahrsplan.Controls.Clear();
            insertHeaderAbfahrtsplan();
            rowCountAbfahrtsplan+= 1;

            foreach (StationBoard sb in stationBoard.Entries) {
                columnCountAbfahrtsplan = 0;
                tableLayoutPanelAbfahrsplan.Controls.Add(new Label() { Text = sb.To.ToString() }, columnCountAbfahrtsplan, rowCountAbfahrtsplan);
                tableLayoutPanelAbfahrsplan.Controls.Add(new Label() { Text =  sb.Stop.Departure.ToString("HH:mm")}, 
                    columnCountAbfahrtsplan++, rowCountAbfahrtsplan);
                rowCountAbfahrtsplan++;
            }
        }

        public void showOnMap(Station station) {
            markersOverlay.Markers.Remove(marker);
            map.Position = new PointLatLng(station.Coordinate.XCoordinate, station.Coordinate.YCoordinate);
            marker = new GMarkerGoogle(new PointLatLng(station.Coordinate.XCoordinate, station.Coordinate.YCoordinate),
            GMarkerGoogleType.orange);
            markersOverlay.Markers.Add(marker);
            map.Overlays.Add(markersOverlay);
        }

        private void buttonSearch_Click(object sender, EventArgs e) {
            searchVerbindungenEvent();
        }

        private void searchVerbindungenEvent() {
            transport = new Transport();
            //save connections
            var connections = transport.GetConnections(textBoxFrom.Text, textBoxTo.Text, dateTimePickerDateVerbindungen.Value, dateTimePickerTimeVerbindungen.Value);
            //clear tableLayoutPanelVerbindungen
            tableLayoutPanelVerbindungen.Controls.Clear();
            insertHeaderVerbindungen();
            //increment rowCounter after inserting header
            rowCountVerbindungen++;
            DateTime departureTime;
            DateTime arrivalTime;
            foreach (Connection targetConnection in connections.ConnectionList) {
                columnCountVerbindungen = 0;
                departureTime = Convert.ToDateTime(targetConnection.From.Departure.ToString());
                arrivalTime = Convert.ToDateTime(targetConnection.To.Arrival.ToString());
                string duration = targetConnection.Duration.ToString().Substring(targetConnection.Duration.ToString().Length - 7);

                //add all cols with Text to tableLayout
                tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = departureTime.ToString("HH:mm") },
                columnCountVerbindungen, rowCountVerbindungen);
                tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = arrivalTime.ToString("HH:mm") },
                columnCountVerbindungen++, rowCountVerbindungen);
                tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = duration }, columnCountVerbindungen++, rowCountVerbindungen);
                tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = targetConnection.From.Platform }, columnCountVerbindungen++, rowCountVerbindungen);
                rowCountVerbindungen++;
            }
        }

        private void insertHeaderVerbindungen() {
            //set title Font
            Font titleFont = new Font(Font.Name, 12, FontStyle.Bold);
            columnCountVerbindungen = 0;
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = "Abfahrt:", Font = titleFont, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter},
                0, rowCountVerbindungen);
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = "Ankunft:", Font = titleFont, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter },
                1, rowCountVerbindungen);
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = "Dauer:" , Font = titleFont, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter },
                2, rowCountVerbindungen);
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = "Gleis:", Font = titleFont, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter },
                3, rowCountVerbindungen);
        }
        private void insertHeaderAbfahrtsplan() {
            Font titleFont = new Font(Font.Name, 12, FontStyle.Bold);
            columnCountAbfahrtsplan = 0;
            tableLayoutPanelAbfahrsplan.Controls.Add(new Label() { Text = "Ziel:", Font = titleFont, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter },
                columnCountAbfahrtsplan, 0);
            tableLayoutPanelAbfahrsplan.Controls.Add(new Label() { Text = "Abfahrt:", Font = titleFont, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter },
                columnCountAbfahrtsplan, 0);
        }

        private void textBoxFrom_TextChanged(object sender, EventArgs e) {
            showAutocompleteOptions(textBoxFrom);
        }

        private void showAutocompleteOptions(TextBox textBoxForAutocomplete) {
            if (textBoxForAutocomplete.Text != null) {
                if (textBoxForAutocomplete.Text.Length >= 3) {
                    transport = new Transport();
                    AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                    var stations = transport.GetStations(textBoxForAutocomplete.Text);
                    if (stations != null) {
                        collection.AddRange(stations.StationList.Select(x => x.Name).ToArray());
                    }

                    textBoxForAutocomplete.AutoCompleteCustomSource = collection;
                }
            }
        }

        private void textBoxTo_TextChanged(object sender, EventArgs e) {
            showAutocompleteOptions(textBoxTo);
        }

        private void textBoxVonAbfahrtsplan_TextChanged(object sender, EventArgs e) {
            showAutocompleteOptions(textBoxFromAbfahrtsplan);
        }

        private void buttonShowOnMap_Click(object sender, EventArgs e) {
            Station station = transport.GetStations(textBoxMapStation.Text).StationList.First();
            showOnMap(station);
            map.Zoom = 16;

        }
        private void textBoxMapStation_TextChanged(object sender, EventArgs e) {
            showAutocompleteOptions(textBoxMapStation);
        }

        private void sendMail(string server) {
            string from = "";
            string to = "";
            MailMessage message = new MailMessage(from, to);
            message.Subject = "";
            message.Body = "";
            SmtpClient client = new SmtpClient(server);
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("username", "password");
            try {
                client.Send(message);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }


        private void label5_Click(object sender, EventArgs e) {
            share.Show();

        }
    }
}
