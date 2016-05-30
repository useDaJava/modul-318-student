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

        private void ÖVinder_Load(object sender, EventArgs e) {
            //set Webbrowser Emulation because of outdated version
            WebBrowserVersionEmulation();
            //insert heading rows into tables
            insertHeaderAbfahrtsplan();
            insertHeaderVerbindungen();
            //set autocomplete mode and source
            textBoxMapStation.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxMapStation.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxFrom.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxFrom.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxTo.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxTo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxFromAbfahrtsplan.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxFromAbfahrtsplan.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //set autoscroll to true
            tableLayoutPanelAbfahrsplan.AutoScroll = true;
            tableLayoutPanelVerbindungen.AutoScroll = true;
        }


        private void buttonSearchAbfahrtsplan_Click(object sender, EventArgs e) {
            //call method for action
            searchAbfahrten();
        }

        private void searchAbfahrten() {
            transport = new Transport();
            Station station = transport.GetStations(textBoxFromAbfahrtsplan.Text).StationList[0];
            transport.GetStations(textBoxFromAbfahrtsplan.Text).StationList.FirstOrDefault(x => x.Name == textBoxFromAbfahrtsplan.Text);
            var stationBoard = transport.GetStationBoard(station.Name, station.Id);

            //clear table, delete all content from tableLayoutPanelAbfahrsplan
            tableLayoutPanelAbfahrsplan.Controls.Clear();
            insertHeaderAbfahrtsplan();
            rowCountAbfahrtsplan+= 1;

            foreach (StationBoard sb in stationBoard.Entries) {
                columnCountAbfahrtsplan = 0;
                tableLayoutPanelAbfahrsplan.Controls.Add(new Label() { Text = sb.To.ToString() }, columnCountAbfahrtsplan, rowCountAbfahrtsplan);
                tableLayoutPanelAbfahrsplan.Controls.Add(new Label() { Text =  sb.Stop.Departure.Hour.ToString() + ":" + addLeadingZero(sb.Stop.Departure.Minute)}, 
                    columnCountAbfahrtsplan++, rowCountAbfahrtsplan);
                rowCountAbfahrtsplan += 1;
            }
            //call showMap method
            showMap(station);
        }

        public void showMap(Station station) {

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
                tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = departureTime.Hour.ToString() + ":" + addLeadingZero(departureTime.Minute) },
                columnCountVerbindungen, rowCountVerbindungen);
                tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = arrivalTime.Hour.ToString() + ":" + addLeadingZero(arrivalTime.Minute) },
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
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = "Abfahrt:", Font = titleFont, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter}, 0, rowCountVerbindungen);
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = "Ankunft:", Font = titleFont, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter }, 1, rowCountVerbindungen);
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = "Dauer:" , Font = titleFont, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter }, 2, rowCountVerbindungen);
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = "Gleis:", Font = titleFont, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter }, 3, rowCountVerbindungen);
        }
        private void insertHeaderAbfahrtsplan() {
            Font titleFont = new Font(Font.Name, 12, FontStyle.Bold);
            columnCountAbfahrtsplan = 0;
            tableLayoutPanelAbfahrsplan.Controls.Add(new Label() { Text = "Ziel:", Font = titleFont, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter },
                columnCountAbfahrtsplan, 0);
            tableLayoutPanelAbfahrsplan.Controls.Add(new Label() { Text = "Abfahrt:", Font = titleFont, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter },
                columnCountAbfahrtsplan, 0);
        }

        private string addLeadingZero(int numberToAddZero) {
            if (numberToAddZero < 10) {
                return "0" + numberToAddZero;
            } else {
                return numberToAddZero.ToString();
            }
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
            Station station = transport.GetStations(textBoxMapStation.Text).StationList[0];
            Console.WriteLine("https://www.google.ch/maps/@" + station.Coordinate.XCoordinate + "," + station.Coordinate.YCoordinate + ",20z");
            webBrowser.Navigate("https://www.google.ch/maps/@" + station.Coordinate.XCoordinate + "," + station.Coordinate.YCoordinate + ",19z");
        }

        private void textBoxMapStation_TextChanged(object sender, EventArgs e) {
            showAutocompleteOptions(textBoxMapStation);
        }

        private static void WebBrowserVersionEmulation() {
            //little hack on the back
            const string BROWSER_EMULATION_KEY =
            @"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION";
            //
            // app.exe and app.vshost.exe
            String appname = Process.GetCurrentProcess().ProcessName + ".exe";
            
            const int browserEmulationMode = 9999;

            RegistryKey browserEmulationKey =
                Registry.CurrentUser.OpenSubKey(BROWSER_EMULATION_KEY, RegistryKeyPermissionCheck.ReadWriteSubTree) ??
                Registry.CurrentUser.CreateSubKey(BROWSER_EMULATION_KEY);

            if (browserEmulationKey != null) {
                browserEmulationKey.SetValue(appname, browserEmulationMode, RegistryValueKind.DWord);
                browserEmulationKey.Close();
            }
        }
    }
}
