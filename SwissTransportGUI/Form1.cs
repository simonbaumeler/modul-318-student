using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportGUI
{
    public partial class Form1 : Form
    {
        private TimeSpan Time;

        private DateTime Date;

        private List<Station> Stations;

        private List<Connection> Connections;

        private List<StationBoardRoot> StadionBoards;

        private Transport transpotinstance;

        public Form1()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            Time = DateTime.Now.TimeOfDay;
            Date = DateTime.Today;
            this.MTxtbxTime.Text = Time.ToString();
            this.MTxtbxDate.Text = Date.ToString();
            transpotinstance = new Transport();
        }

        private void BtSearchConnection_Click(object sender, EventArgs e)
        {
            try
            {
                this.lstVwConnections.Items.Clear();

                if (cmbBxStart.Text == string.Empty || cmbBxGoal.Text == string.Empty)
                {
                    MessageBox.Show("Bitte füllen Sie mindestens Abfahrts-/ und Zeilort aus!", "SwissTransport Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    FillConnectionListView();
                    WriteInfos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Es ist ein unerwarteter Fehler aufgetreten {Environment.NewLine} Message: {ex.Message}", "SwissTransport Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WriteInfos()
        {
            this.lblInfo.Location = new Point(6, 85);
            this.lblInfo2.Location = new Point(6, 115);
            this.lblInfo.Text = $"Ergebnisse für Ihre Suche von {this.cmbBxStart.Text} nach {this.cmbBxGoal.Text}";
            this.lblInfo2.Text = $"am {this.MTxtbxDate.Text} um {this.MTxtbxTime.Text} Uhr";
        }

        private void FillConnectionListView()
        {
            Connections = transpotinstance.GetConnections(cmbBxStart.Text, cmbBxGoal.Text).ConnectionList;

            foreach (var connection in Connections)
            {
                var listViewItem = new ListViewItem(GetFormattedDateString(connection.From.Departure));
                listViewItem.SubItems.Add(GetFormattedDateString(connection.To.Arrival));
                listViewItem.SubItems.Add(GetFormattedDurationString(connection.Duration));
                listViewItem.SubItems.Add(connection.From.Platform);
                listViewItem.SubItems.Add(connection.To.Platform);
                this.lstVwConnections.Items.Add(listViewItem);
            }
        }

        private string GetFormattedDateString (string date)
        {
            var formattedDate = Convert.ToDateTime(date);
            return formattedDate.ToString("HH:mm");
        }

        private string GetFormattedDurationString (string time)
        {        
            return time.Replace("00d", string.Empty);
        }

        private void BtnDayBack_Click(object sender, EventArgs e)
        {
            Date = Date.AddDays(-1);
            this.MTxtbxDate.Text = Date.ToString();
        }

        private void BtnDayOn_Click(object sender, EventArgs e)
        {
            Date = Date.AddDays(1);
            this.MTxtbxDate.Text = Date.ToString();
        }

        private void BtnMinuteOn_Click(object sender, EventArgs e)
        {
            Time = Time.Add(new TimeSpan(00, 01, 00));
            this.MTxtbxTime.Text = Time.ToString();
        }

        private void BtnMinuteBack_Click(object sender, EventArgs e)
        {
            Time = Time.Add(new TimeSpan(00, -1, 00));
            this.MTxtbxTime.Text = Time.ToString();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Date = this.dateTimePicker1.Value;
            this.MTxtbxDate.Text = Date.ToShortDateString();
        }

        private void comboBox_DropDown(object sender, EventArgs e)
        {
            try
            {
                LoadStations(sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Es ist ein unerwarteter Fehler aufgetreten {Environment.NewLine} Message: {ex.Message}", "SwissTransport Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStations(object sender)
        {
            try
            {
                var combobox = (ComboBox)sender;

                if (Stations != null)
                {
                    foreach (var Station in Stations)
                    {
                        combobox.Items.Remove(Station.Name);
                    }
                }

                Stations = transpotinstance.GetStations(combobox.Text).StationList;

                foreach (var Station in Stations)
                {
                    combobox.Items.Add(Station.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Es ist ein unerwarteter Fehler aufgetreten {Environment.NewLine} Message: {ex.Message}", "SwissTransport Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btShowTimeTable_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Es ist ein unerwarteter Fehler aufgetreten {Environment.NewLine} Message: {ex.Message}", "SwissTransport Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillStationListView()
        {
            
        }
    }
}
