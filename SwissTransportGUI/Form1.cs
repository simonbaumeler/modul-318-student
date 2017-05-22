using SwissTransport;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        private TimeSpan time;

        /// <summary>
        ///  The Date of the Connectionsearch
        /// </summary>
        private DateTime date;

        /// <summary>
        /// The List of Stations  
        /// </summary>
        private List<Station> stations;

        /// <summary>
        /// The List of Connections
        /// </summary>
        private List<Connection> connections;

        /// <summary>
        /// The List of StationBoards
        /// </summary>
        private List<StationBoard> stadionBoards;

        /// <summary>
        /// The Instance of the Transport Class
        /// </summary>
        private Transport transpotinstance;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class // Standart Constructor of the Form1
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
            time = DateTime.Now.TimeOfDay;
            date = DateTime.Today;
            MTxtbxTime.Text = time.ToString();
            MTxtbxDate.Text = date.ToString();
            transpotinstance = new Transport();
        }

        /// <summary>
        /// Checks if Destionation- or Startstring is empty and returns a messageBox with a Warning if true
        /// Checks if the Time and Date are not the actual and makes a Request with userdefined Date and Time if true and calls FillConectionListView() and WriteInfos()
        /// if the other two clauses were false, it creates a request with actuall Date and Time and calls FillConectionListView() and WriteInfos()
        /// </summary>
        /// <param name="sender">senderobject</param>
        /// <param name="e">eventargs</param>
        private void BtSearchConnection_Click(object sender, EventArgs e)
        {
            try
            {            
                if (cmbBxStart.Text == string.Empty || cmbBxGoal.Text == string.Empty)
                {
                    MessageBox.Show("Bitte füllen Sie mindestens Abfahrts-/ und Zeilort aus!", "SwissTransport Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btShowStation.Enabled = false;
                }
                else if (MTxtbxDate.Text != DateTime.Today.ToString() || MTxtbxTime.Text != DateTime.Now.TimeOfDay.ToString())
                {                  
                    connections = transpotinstance.GetConnections(cmbBxStart.Text, cmbBxGoal.Text, MTxtbxDate.Text, MTxtbxTime.Text).ConnectionList;
                    FillConnectionListView();
                    WriteInfos();
                }
                else
                {
                    connections = transpotinstance.GetConnections(cmbBxStart.Text, cmbBxGoal.Text).ConnectionList;
                    FillConnectionListView();
                    WriteInfos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bei der letzten Aktion ist ein Fehler aufgetreten {Environment.NewLine} Message: {ex.Message} {Environment.NewLine} bitte überprüfen Sie Ihre Angaben und probieren Sie es erneut.", "SwissTransport Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            btShowStation.Enabled = true;           
        }

        /// <summary>
        /// clears the lstVwConnections Listview and refills it with all given Connections
        /// </summary>
        private void FillConnectionListView()
        {         
            lstVwConnections.Items.Clear();

            foreach (var connection in connections)
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
        /// <param name="date">unformatted date</param>
        /// <returns>formatted Date as String (HH:mm)</returns>
        private string GetFormattedDateString(string date)
        {
            var formattedDate = Convert.ToDateTime(date);
            return formattedDate.ToString("HH:mm");
        }

        /// <summary>
        /// Returns string with the formatted String
        /// </summary>
        /// <param name="time">unformated date</param>
        /// <returns>for GUI formatted Time as String (HH:mm:ss)</returns>
        private string GetFormattedDurationString(string time)
        {        
            return time.Replace("00d", string.Empty);
        }

        /// <summary>
        /// Decrements 1 Day from the Date 
        /// </summary>
        /// <param name="sender">senderobject</param>
        /// <param name="e">eventargs</param>
        private void BtnDayBack_Click(object sender, EventArgs e)
        {
            date = date.AddDays(-1);
            MTxtbxDate.Text = date.ToString();
        }

        /// <summary>
        /// Icrements the Date by 1 Day
        /// </summary>
        /// <param name="sender">senderobject</param>
        /// <param name="e">eventargs</param>
        private void BtnDayOn_Click(object sender, EventArgs e)
        {
            date = date.AddDays(1);
            MTxtbxDate.Text = date.ToString();
        }

        /// <summary>
        /// Icrements the Time by 1 Minute
        /// </summary>
        /// <param name="sender">senderobject</param>
        /// <param name="e">eventargs</param>
        private void BtnMinuteOn_Click(object sender, EventArgs e)
        {
            time = time.Add(new TimeSpan(00, 01, 00));
            MTxtbxTime.Text = time.ToString();
        }

        /// <summary>
        /// Decrements the Time by 1 Minute
        /// </summary>
        /// <param name="sender">senderobject</param>
        /// <param name="e">eventargs</param>
        private void BtnMinuteBack_Click(object sender, EventArgs e)
        {
            time = time.Add(new TimeSpan(00, -1, 00));
            MTxtbxTime.Text = time.ToString();
        }

        /// <summary>
        /// Sets the Date to the picked Value of the DateTimePicker
        /// </summary>
        /// <param name="sender">senderobject</param>
        /// <param name="e">eventargs</param>
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = dtTmPckr.Value;
            MTxtbxDate.Text = date.ToShortDateString();
        }

        /// <summary>
        /// Occurs when ever the Dropdownlist drops down and Calls the LoadStation(sender) Method
        /// </summary>
        /// <param name="sender">senderobject</param>
        /// <param name="e">eventargs</param>
        private void ComboBox_DropDown(object sender, EventArgs e)
        {
            try
            {
                LoadStations(sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bei der letzten Aktion ist ein Fehler aufgetreten {Environment.NewLine} Message: {ex.Message}{Environment.NewLine} bitte überprüfen Sie Ihre Angaben und probieren Sie es erneut.", "SwissTransport Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// casts the input param sender to a comboBox and fills it with the Stations coming from the Transport Class
        /// </summary>
        /// <param name="sender">senderobject</param>
        private void LoadStations(object sender)
        {
            try
            {
                var combobox = (ComboBox)sender;

                if (stations != null)
                {
                    combobox.Items.Clear();
                }

                stations = transpotinstance.GetStations(combobox.Text).StationList;

                foreach (var station in stations)
                {
                    combobox.Items.Add(station.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bei der letzten Aktion ist ein Fehler aufgetreten {Environment.NewLine} Message: {ex.Message}{Environment.NewLine} bitte überprüfen Sie Ihre Angaben und probieren Sie es erneut.", "SwissTransport Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Checks if the cmxBxTimeTable.Text is null or emtpy and calls the FillStationListView(string station) Method if not
        /// </summary>
        /// <param name="sender">senderobject</param>
        /// <param name="e">eventargs</param>
        private void BtShowTimeTable_Click(object sender, EventArgs e)
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
                MessageBox.Show($"Bei der letzten Aktion ist ein Fehler aufgetreten {Environment.NewLine} Message: {ex.Message}{Environment.NewLine} bitte überprüfen Sie Ihre Angaben und probieren Sie es erneut.", "SwissTransport Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gets the Station object with the given Text, clears the ListView of the TimeTable and Refills it
        /// </summary>
        /// <param name="station">name of the station</param>
        private void FillStationListView(string station)
        {
            try
            {
                var searchedStation = stations.First(x => x.Name == station);
                stadionBoards = transpotinstance.GetStationBoard(searchedStation.Name, searchedStation.Id).Entries;

                lstVwTimetable.Items.Clear();

                foreach (var stationboard in stadionBoards)
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
                MessageBox.Show($"Bei der letzten Aktion ist ein Fehler aufgetreten {Environment.NewLine} Message: {ex.Message}{Environment.NewLine} bitte überprüfen Sie Ihre Angaben und probieren Sie es erneut.", "SwissTransport Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Shows or hides the WebBrowser Controll and builds up the correct URI to get a view of the chosen Location
        /// </summary>
        /// <param name="sender">senderobject</param>
        /// <param name="e">eventargs</param>
        private void BtShowStation_Click(object sender, EventArgs e)
        {
            try
            {
                var cmbBxName = new ComboBox();

                if (rBArrive.Checked)
                {
                    cmbBxName = cmbBxStart;
                }
                else
                {
                    cmbBxName = cmbBxGoal;
                }

                var button = (Button)sender;

                if (button.Text == "Karte verbergen")
                {
                    wbBrwsr.Visible = false;
                    button.Text = "Station auf Karte anzeigen";
                    return;
                }

                if (cmbBxStart.Text == string.Empty)
                {
                    MessageBox.Show("Bitte füllen Sie mindestens Abfahrts-/ und Zeilort aus!", "SwissTransport Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btShowStation.Enabled = false;
                }

                var station = transpotinstance.GetStations(cmbBxName.Text).StationList.First();

                var uri = "https://wego.here.com/?map=" + station.Coordinate.XCoordinate.ToString() + "," + station.Coordinate.YCoordinate.ToString() + ",17,satellite";

                wbBrwsr.Url = new Uri(uri);
                wbBrwsr.Visible = true;
                btShowStation.Text = "Karte verbergen";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bei der letzten Aktion ist ein Fehler aufgetreten {Environment.NewLine} Message: {ex.Message}{Environment.NewLine} bitte überprüfen Sie Ihre Angaben und probieren Sie es erneut.", "SwissTransport Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
