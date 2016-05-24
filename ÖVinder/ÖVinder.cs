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
    public partial class ÖVinder : Form
    {
        private ITransport transport;
        public ÖVinder()
        {
            InitializeComponent();
        }

        private void labelVerbindungenTable_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanelVerbindungen.Visible)
            {
                labelVerbindungenTable.Text = "Verbindungen <";
                tableLayoutPanelVerbindungen.Visible = false;
            } else
            {
                labelVerbindungenTable.Text = "Verbindungen v";
                tableLayoutPanelVerbindungen.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            transport = new Transport();
            var connections = transport.GetConnections(textBoxFrom.Text, textBoxTo.Text);
            int rowCount = 0;
            foreach(Connection targetConnection in connections.ConnectionList)
            {
                Console.WriteLine(targetConnection.From.Station.Name.ToString());
                Console.WriteLine(targetConnection.To.Station.Name.ToString());
                tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = targetConnection.From.Departure.ToString() }, 0, rowCount);
                rowCount++;
            }
            
            
        }
    }
}
