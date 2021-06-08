//created on 2021-05-07
//by Nikhil Prasad
//for Embedded Systems Design
//MiniProject Assignment

using System;
using System.Device.Location;
using System.IO.Ports;
using System.Windows.Forms;

namespace gpsEmulator
{
    public partial class Form1 : Form
    {
        //global variables
        string dataIN;//receiver buffer
        public string oldData = ""; //variable for previous data
        public static double totalDistance; //adds all distances
        public static double totalTime; //adds time

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            ComPortComboBox.Items.AddRange(ports);

            OpenButton.Enabled = true;     //enable OPEN serial port button
            CloseButton.Enabled = false;   //disable CLOSE serial port button

            AddtoDataCheckBox.Checked = true;   //enable appending new data
            AlwaysUpdateCheckBox.Checked = false;  //disable clearing old data
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = ComPortComboBox.Text;
                serialPort.BaudRate = Convert.ToInt32(BaudRateComboBox.Text);
                serialPort.DataBits = Convert.ToInt32(DataBitsComboBox.Text);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), StopBitsComboBox.Text);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), ParityBitsComboBox.Text);

                serialPort.Open();
                progressBar1.Value = 100;
                OpenButton.Enabled = false;
                CloseButton.Enabled = true;
                OnOffLabel.Text = "ON";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "COM Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)      
            {
                serialPort.Close();    //close serial port
                progressBar1.Value = 0; //clear progress bar
                OpenButton.Enabled = true; //enable OPEN button
                CloseButton.Enabled = false; 
                OnOffLabel.Text = "OFF";  //Port status OFF
            }
        }
        private void DataBitsLabel_Click(object sender, EventArgs e)
        {

        }
        private void ParityBitsLabel_Click(object sender, EventArgs e)
        {

        }
        private void ComPortLabel_Click(object sender, EventArgs e)
        {

        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serialPort.ReadExisting();        //read receiver buffer
            this.Invoke(new EventHandler(ShowData));    //call a data display function
        }
        private void ShowData(object sender, EventArgs e)   //user-defined data display function
        {
            int dataINLength = dataIN.Length;   //get the length of received data
            NumericalDataLength.Text = string.Format("{0:00}", dataINLength); //display the data length

            if (AlwaysUpdateCheckBox.Checked)
            {
                ReceivedDataTextbox.Text = dataIN;   //always show the newly-received data
            }
            else if (AddtoDataCheckBox.Checked)
            {
                ReceivedDataTextbox.Text += dataIN;  //keep old data, and append new data
            }
            SingleLineTextBox.Text = dataIN;

            geoCalculation();
        }

        private void ClearDataButton_Click(object sender, EventArgs e)
        {
            if (ReceivedDataTextbox.Text != "")   //if the received data textbox is not empty
                ReceivedDataTextbox.Text = "";   //Assigning textbox with empty string - deleting all previous data
            if (SingleLineTextBox.Text != "")
                SingleLineTextBox.Text = "";
        }

        private void AlwaysUpdateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AlwaysUpdateCheckBox.Checked)
            {
                AlwaysUpdateCheckBox.Checked = true;   //enable showing new data only
                AddtoDataCheckBox.Checked = false;
            }
            else AddtoDataCheckBox.Checked = true;

        }

        private void AddtoDataCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AddtoDataCheckBox.Checked)
            {
                AlwaysUpdateCheckBox.Checked = false;
                AddtoDataCheckBox.Checked = true;   //enable appending new data to old data
            }
            else AlwaysUpdateCheckBox.Checked = true;
        }
        /// <summary>
        /// This method is responsible for the calculations 
        /// that will be displayed on the 2nd tab of the GUI
        /// </summary>
        private void geoCalculation()
        {
            double lat1, lat2, lng1, lng2, distance, lat1Temp, lat2Temp, lng1Temp, lng2Temp, speed, distanceTemp;
            string strLat1, strLat2, strLng1, strLng2, strTime1, strTime2;
            string latDeg, latMins;
            double timeDifference;
            //previousData = dataIN;

            string[] gpsSplitCurrent = dataIN.Split(',');
            string[] gpsSplitPrevious = oldData.Split(',');
            if (oldData.Length > 0)
            {
                strTime1 = gpsSplitPrevious[1];
                Time1TB.Text = strTime1;
                strTime2 = gpsSplitCurrent[1];
                Time2TB.Text = strTime2;

                //Index 3 is the compass direction e.g N/s/E/W, Index 2 is the Actual Lng/Lat Value
                strLat1 = gpsSplitPrevious[3] + gpsSplitPrevious[2];
                Lat1TB.Text = strLat1;
                strLat2 = gpsSplitCurrent[3] + gpsSplitCurrent[2];
                Lat2TB.Text = strLat2;
                LatitudeTB.Text = strLat2;

                //gpsSplitPrevious[5] is E or W,     gpsSplitPrevious[4] is longitude
                strLng1 = gpsSplitPrevious[5] + gpsSplitPrevious[4];
                Lng1TB.Text = strLng1;
                strLng2 = gpsSplitCurrent[5] + gpsSplitCurrent[4];
                Lng2TB.Text = strLng2;
                LongitudeTB.Text = strLng2;

                //gpsSplitCurrent = dataIN.Split(',');
                //strLat2 = gpsSplitCurrent[3] + gpsSplitCurrent[2];

                /* Extracting the Degree value and Mins value from the
                 * Latitude and Longitudes to convert them into degrees in the next step
                 */
                latDeg = gpsSplitCurrent[2].Substring(0, 2);
                latMins = gpsSplitCurrent[2].Substring(2, 11);
                string lngDeg = gpsSplitCurrent[4].Substring(0, 3);
                string lngMins = gpsSplitCurrent[4].Substring(3, 11);

                string lat2Deg = gpsSplitPrevious[2].Substring(0, 2);
                string lat2Mins = gpsSplitPrevious[2].Substring(2, 11);
                string lng2Deg = gpsSplitPrevious[4].Substring(0, 3);
                string lng2Mins = gpsSplitPrevious[4].Substring(3, 11);

                //Converting to Degrees via method
                lat2Temp = ConvertToDegrees(latDeg, latMins);               
                lng2Temp = ConvertToDegrees(lngDeg, lngMins);               
                lat1Temp = ConvertToDegrees(lat2Deg, lat2Mins);               
                lng1Temp = ConvertToDegrees(lng2Deg, lng2Mins);

                //Making values negative if it contains S or W
                if (strLat1.Contains("S"))
                    lat1 = -1 * lat1Temp;
                else
                    lat1 = lat1Temp;
                if (strLng1.Contains("W"))
                    lng1 = -1 * lng1Temp;
                else
                    lng1 = lng1Temp;
                if (strLat2.Contains("S"))
                    lat2 = -1 * lat2Temp;
                else
                    lat2 = lat2Temp;
                if (strLng2.Contains("W"))
                    lng2 = -1 * lng2Temp;
                else
                    lng2 = lng2Temp;

                GeoCoordinate p1 = new GeoCoordinate(lat1, lng1);
                GeoCoordinate p2 = new GeoCoordinate(lat2, lng2);
                
                //Calculating distance and adding all the distances to get totalDistance
                distance = p1.GetDistanceTo(p2);
                distanceTemp = Math.Round(distance, 2);
                totalDistance += distance;
                double tempTotalDistance = Math.Round(totalDistance, 2) / 1000; //converting m to km
                DistanceTB.Text = Convert.ToString(distanceTemp);
                TotalDistanceTB.Text = Convert.ToString(tempTotalDistance);

                //Time display and calculations
                double time1 = Convert.ToDouble(strTime1);
                double time2 = Convert.ToDouble(strTime2);
                timeDifference = time2 - time1;
                totalTime += (timeDifference / 60);
                double tempTotalTime = Math.Round(totalTime, 4);
                speed = (distance / timeDifference) * 3.6; //converting m/s to km/hour
                double tempSpeed = Math.Round(speed, 2);
                TotalTimeTB.Text = Convert.ToString(tempTotalTime);
                SpeedTB.Text = Convert.ToString(speed);

                double bearing = DegreeBearing(lat1, lng1, lat2, lng2);
                BearingOutput(bearing);

                //SpeedChart.Series.Add(Convert.ToString(speed));
            }
            oldData = dataIN;
        }
        private static double DegreeBearing(double lat1, double lng1, double lat2, double lng2)
        {
            var dLon = ToRad(lng2 - lng1);
            var dPhi = Math.Log(
                Math.Tan(ToRad(lat2) / 2 + Math.PI / 4) / Math.Tan(ToRad(lat1) / 2 + Math.PI / 4));
            if (Math.Abs(dLon) > Math.PI)
                dLon = dLon > 0 ? -(2 * Math.PI - dLon) : (2 * Math.PI + dLon);
            return ToBearing(Math.Atan2(dLon, dPhi));
        }

        private static double ToRad(double degrees)
        {
            return degrees * (Math.PI / 180);
        }

        private static double ToDegrees(double radians)
        {
            return radians * 180 / Math.PI;
        }

        private static double ToBearing(double radians)
        {
            // convert radians to degrees (as bearing: 0...360)
            return (ToDegrees(radians) + 360) % 360;
        }

        private void BearingOutput(double bearing)
        {
            if (bearing == 0 || bearing == 360)
                CompassTB.Text = "N";
            else if (bearing > 0 && bearing < 90)
                CompassTB.Text = "NE";
            else if (bearing == 90)
                CompassTB.Text = "E";
            else if (bearing > 90 && bearing < 180)
                CompassTB.Text = "SE";
            else if (bearing == 180)
                CompassTB.Text = "S";
            else if (bearing > 180 && bearing < 270)
                CompassTB.Text = "SW";
            else if (bearing == 270)
                CompassTB.Text = "W";
            else if (bearing > 270 && bearing < 360)
                CompassTB.Text = "NW";
        }

        private double ConvertToDegrees(string degrees, string mins)
        {
            return (Convert.ToDouble(degrees) + Convert.ToDouble(mins) / 60);
        }

        private void TimeToHours(string strTime1, string strTime2) //not used in final version this but has been implemented
        {
            //need to convert time to seconds or mins first(Correct format of time needed)
            double hour1, min1, sec1, milSec1, totalTime1;
            double hour2, min2, sec2, milSec2, totalTime2;

            if (oldData.Length > 0)
            {
                hour1 = Convert.ToDouble(strTime1.Substring(0, 2));
                min1 = Convert.ToDouble(strTime1.Substring(2, 2)) / 60; //converting min to hours
                sec1 = Convert.ToDouble(strTime1.Substring(4, 5)) / 3600; //converting seconds to hours
                if (strTime1.Length > 6)
                    milSec1 = Convert.ToDouble(strTime1.Substring(7, strTime1.Length - 7)) / 3600;
                else
                    milSec1 = 0;
                totalTime1 = hour1 + min1 + sec1 + milSec1;                       //time1 is in hours now

                hour2 = Convert.ToDouble(strTime2.Substring(0, 2)); //converting hour to seconds
                min2 = Convert.ToDouble(strTime2.Substring(2, 2)) / 60; //converting min to seconds
                sec2 = Convert.ToDouble(strTime2.Substring(4, 5)) / 3600;
                if (strTime2.Length > 6)
                    milSec2 = Convert.ToDouble(strTime2.Substring(7, strTime2.Length - 7)) / 3600000;
                else
                    milSec2 = 0;
                totalTime2 = hour2 + min2 + sec2 + milSec2;                       //time2 is in seconds now
            }
        }
    }
}
