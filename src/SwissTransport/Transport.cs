using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;

namespace SwissTransport
{
    public class Transport : ITransport
    {
        /// <summary>
        /// Creates a RequestUrl passes it to the CreateWebRequest and reads out the Result
        /// than deserializes the Answer to a Stations object
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public Stations GetStations(string query)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var message = new StreamReader(responseStream).ReadToEnd();
                var stations = JsonConvert.DeserializeObject<Stations>(message);
                return stations;
            }

            return null;
        }

        /// <summary>
        /// Creates a RequestUrl passes it to the CreateWebRequest and reads out the Result
        /// , checks if the give Answer is Correct
        /// than deserializes the Answer to a StationBoardRoot
        /// </summary>
        /// <param name="station"></param>
        /// <returns>a StationBoardRoot Object</returns>
        public StationBoardRoot GetStationBoard(string station)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?Station=" + station);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var jsonObject = JObject.Parse(readToEnd);
                var parse = true;

                try
                {
                    //if the Stationname was valid an InvalidCastException occurs (if the name was invalid the API returns false in the staion attribute)
                    jsonObject["station"].Value<bool>();
                    parse = false;
                }

                catch (InvalidCastException)
                {

                }

                if (!parse)
                {
                    throw new InvalidOperationException("Die Station ist invalid.");
                }

                var stationboard =
                    JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                return stationboard;
            }
            return null;
        }

        /// <summary>
        /// Creates a RequestUrl passes it to the CreateWebRequest and reads out the Result
        /// than deserializes the Answer to a StationBoardRoot object
        /// </summary>
        /// <param name="station"></param>
        /// <param name="id"></param>
        /// <returns>a StationBoardRoot object </returns>
        public StationBoardRoot GetStationBoard(string station, string id)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?Station=" + station + "&id=" + id);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var stationboard =
                    JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                return stationboard;
            }

            return null;
        }

        /// <summary>
        /// Creates a RequestUrl passes it to the CreateWebRequest and reads out the Result
        /// than deserializes the Answer to a Connection object
        /// </summary>
        /// <param name="fromStation"></param>
        /// <param name="toStattion"></param>
        /// <returns>a Connections object with all Connections</returns>
        public Connections GetConnections(string fromStation, string toStattion)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStattion);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var connections =
                    JsonConvert.DeserializeObject<Connections>(readToEnd);
                return connections;
            }

            return null;
        }

        /// <summary>
        /// Creates a RequestUrl with Date and Time, passes it to the CreateWebRequest and reads out the Result
        /// than deserializes the Answer to a Connection object
        /// </summary>
        /// <param name="fromStation"></param>
        /// <param name="toStattion"></param>
        /// <param name="date">YY-MM-DD</param>
        /// <param name="time">HH-mm</param>
        /// <returns>a Connections object with all Connections</returns>
        public Connections GetConnections(string fromStation, string toStattion, string date, string time)
        {
            date = date.Replace('.', '-');
            var datetime = date + "T" + time;
            var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStattion + "&datetime=" + datetime);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var connections =
                    JsonConvert.DeserializeObject<Connections>(readToEnd);
                return connections;
            }

            return null;
        }

        /// <summary>
        /// Creates a Request and returns the answer from the API
        /// </summary>
        /// <param name="url"></param>
        /// <returns>the Webequest</returns>
        private static WebRequest CreateWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;
            
            return request;
        }
    }
}
