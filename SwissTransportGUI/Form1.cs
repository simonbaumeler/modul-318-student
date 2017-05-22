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
    /// <summary>
    /// Code behind the MainForm
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// The Time of the Connectionsearch
        /// </summary>
        private TimeSpan Time;

        /// <summary>
        ///  The Date of the Connectionsearch
        /// </summary>
        private DateTime Date;

        /// <summary>
        /// The List of Stations  
        /// </summary>
        private List<Station> Stations;

        /// <summary>
        /// The List of Connections
        /// </summary>
        private List<Connection> Connections;

        /// <summary>
        /// The List of StationBoards
        /// </summary>
        private List<StationBoard> StadionBoards;

        /// <summary>
        /// The Instance of the Transport Class
        /// </summary>
        private Transport transpotinstance;

        /// <summary>
        /// Standart Constructor of the Form1
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            InitializeData();
        }

        /// <summary>
        /// Initializes Standartvalues 
        /// </summary>
        private void InitializeData()
        {
            Time = DateTime.Now.TimeOfDay;
            Date = DateTime.Today;
            MTxtbxTime.Text = Time.ToString();
            MTxtbxDate.Text = Date.ToString();
            transpotinstance = new Transport();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtSearchConnection_Click(object sender, EventArgs e)
        {
            try
            {            
                if (cmbBxStart.Text == string.Empty || cmbBxGoal.Text == string.Empty)
                {
                    MessageBox.Show("Bitte füllen Sie mindestens Abfahrts-/ und Zeilort aus!", "SwissTransport Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lstVwConnections.Items.Clear();
                    FillConnectionListView();
                    WriteInfos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Es ist ein unerwarteter Fehler aufgetreten {Environment.NewLine} Message: {ex.Message}", "SwissTransport Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        /// <summary>
        /// Sets a Explanationtext on lblInfo and lblInfo 2
        /// </summary>
        private void WriteInfos()
        {
            lblInfo.Location = new Point(3, 113);
            lblInfo2.Location = new Point(3, 140);
            lblInfo.Text = $"Ergebnisse für Ihre Suche von {cmbBxStart.Text} nach {cmbBxGoal.Text}";
            lblInfo2.Text = $"am {MTxtbxDate.Text} um {MTxtbxTime.Text} Uhr";
        }

        /// <summary>
        /// Gets all Connections from the Transport Class and fills the lstVwConnections Listview with all given Connections
        /// </summary>
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
                lstVwConnections.Items.Add(listViewItem);
            }
        }

        /// <summary>
        /// Returns string with the formatted Date
        /// </summary>
        /// <param name="date"></param>
        /// <returns>formatted Date as String (HH:mm)</returns>
        private string GetFormattedDateString (string date)
        {
            var formattedDate = Convert.ToDateTime(date);
            return formattedDate.ToString("HH:mm");
        }

        /// <summary>
        /// Returns string with the formatted String
        /// </summary>
        /// <param name="time"></param>
        /// <returns>for GUI formatted Time as String (HH:mm:ss)</returns>
        private string GetFormattedDurationString (string time)
        {        
            return time.Replace("00d", string.Empty);
        }

        /// <summary>
        /// Decrements 1 Day from the Date 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDayBack_Click(object sender, EventArgs e)
        {
            Date = Date.AddDays(-1);
            MTxtbxDate.Text = Date.ToString();
        }

        /// <summary>
        /// Icrements the Date by 1 Day
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDayOn_Click(object sender, EventArgs e)
        {
            Date = Date.AddDays(1);
            MTxtbxDate.Text = Date.ToString();
        }

        /// <summary>
        /// Icrements the Time by 1 Minute
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMinuteOn_Click(object sender, EventArgs e)
        {
            Time = Time.Add(new TimeSpan(00, 01, 00));
            MTxtbxTime.Text = Time.ToString();
        }

        /// <summary>
        /// Decrements the Time by 1 Minute
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMinuteBack_Click(object sender, EventArgs e)
        {
            Time = Time.Add(new TimeSpan(00, -1, 00));
            MTxtbxTime.Text = Time.ToString();
        }

        /// <summary>
        /// Sets the Date to the picked Value of the DateTimePicker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Date = dtTmPckr.Value;
            MTxtbxDate.Text = Date.ToShortDateString();
        }

        /// <summary>
        /// Occurs when ever the Dropdownlist drops down and Calls the LoadStation(sender) Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// casts the input param sender to a comboBox and fills it with the Stations coming from the Transport Class
        /// </summary>
        /// <param name="sender"></param>
        private void LoadStations(object sender)
        {
            try
            {
                var combobox = (ComboBox)sender;

                if (Stations != null)
                {
                    combobox.Items.Clear();
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

        /// <summary>
        /// Checks if the cmxBxTimeTable.Text is null or emtpy and calls the FillStationListView(string station) Method if not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btShowTimeTable_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBxTimeTable.Text == string.Empty)
                {
                    MessageBox.Show("Bitte wählen Sie einen Abfahrtsort!", "SwissTransport Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    FillStationListView(cmbBxTimeTable.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Es ist ein unerwarteter Fehler aufgetreten {Environment.NewLine} Message: {ex.Message}", "SwissTransport Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gets the Station object with the given Text, clears the ListView of the TimeTable and Refills it
        /// </summary>
        /// <param name="station"></param>
        private void FillStationListView(string station)
        {
            try
            {
                var searchedStation = Stations.First(x => x.Name == station);
                StadionBoards = transpotinstance.GetStationBoard(searchedStation.Name, searchedStation.Id).Entries;

                lstVwTimetable.Items.Clear();

                foreach(var stationboard in StadionBoards)
                {
                    var listViewItem = new ListViewItem(stationboard.Number);
                    listViewItem.SubItems.Add(stationboard.Stop.Departure.ToString("HH:mm"));
                    listViewItem.SubItems.Add(stationboard.To);
                    listViewItem.SubItems.Add(stationboard.Operator);
                    lstVwTimetable.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Es ist ein unerwarteter Fehler aufgetreten {Environment.NewLine} Message: {ex.Message}", "SwissTransport Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
