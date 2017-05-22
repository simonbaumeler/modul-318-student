using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace SwissTransport
{
    [TestClass]
    public class TransportTest
    {
        private ITransport testee;

        /// <summary>
        /// Checks if the API returns a Valid number of Replies to a correct Request
        /// </summary>
        [TestMethod]
        public void Locations()
        {
            testee = new Transport();
            var stations = testee.GetStations("Sursee,");

            Assert.AreEqual(50, stations.StationList.Count);
        }

        /// <summary>
        /// Checks if the API returns a reply to a valid StationBoardrequest 
        /// </summary>
        [TestMethod]
        public void StationBoard()
        {
            testee = new Transport();
            var stationBoard = testee.GetStationBoard("Sursee", "8502007");

            Assert.IsNotNull(stationBoard);
        }

        /// <summary>
        /// Checks if the API returns a reply to a valid Connectionrequest 
        /// </summary>
        [TestMethod]
        public void Connections()
        {
            testee = new Transport();
            var connections = testee.GetConnections("Sursee", "Luzern");

            Assert.IsNotNull(connections);
        }

        /// <summary>
        /// checks if the API returns a correct reply to a valid ConnectionRequest with specific Date and Time
        /// </summary>
        [TestMethod]
        public void ConnectionsWithDateTime()
        {
            testee = new Transport();

            var connections = testee.GetConnections("Sursee", "Luzern", DateTime.Today.ToString("dd-MM-yyyy"), "12:30");

            var currentTime = Convert.ToDateTime("12:30");

            var times = new List<DateTime>();


            foreach(var connection in connections.ConnectionList)
            {
                times.Add(Convert.ToDateTime(connection.From.Departure));

                var datetime = Convert.ToDateTime(connection.From.Departure);
                connection.From.Departure = datetime.ToString("dd-MM-yyyy");
            }


            Assert.IsNotNull(connections);
            Assert.IsTrue(connections.ConnectionList.TrueForAll(x => x.From.Departure == DateTime.Today.ToString("dd-MM-yyyy")));
            Assert.IsTrue(times.TrueForAll(x => x >= currentTime));
        }
    }
}
