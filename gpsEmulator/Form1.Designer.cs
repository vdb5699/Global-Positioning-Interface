
namespace gpsEmulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TabControls = new System.Windows.Forms.TabControl();
            this.SerialPortTab = new System.Windows.Forms.TabPage();
            this.StatusGroupBox = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.CloseButton = new System.Windows.Forms.Button();
            this.OnOffStatusGB = new System.Windows.Forms.GroupBox();
            this.OnOffLabel = new System.Windows.Forms.Label();
            this.OpenButton = new System.Windows.Forms.Button();
            this.SerialPortParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.ParityBitsComboBox = new System.Windows.Forms.ComboBox();
            this.StopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.DataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.ComPortComboBox = new System.Windows.Forms.ComboBox();
            this.ParityBitsLabel = new System.Windows.Forms.Label();
            this.StopBitsLabel = new System.Windows.Forms.Label();
            this.DataBitsLabel = new System.Windows.Forms.Label();
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.ComPortLabel = new System.Windows.Forms.Label();
            this.GPSDataTab = new System.Windows.Forms.TabPage();
            this.ReceivedDataGroupBox = new System.Windows.Forms.GroupBox();
            this.PositionDataGB = new System.Windows.Forms.GroupBox();
            this.CalculationGB = new System.Windows.Forms.GroupBox();
            this.TotalTimeTB = new System.Windows.Forms.TextBox();
            this.TotalDistanceTB = new System.Windows.Forms.TextBox();
            this.TotalTimeLabel = new System.Windows.Forms.Label();
            this.TotalDistanceLabel = new System.Windows.Forms.Label();
            this.CompassTB = new System.Windows.Forms.TextBox();
            this.SpeedTB = new System.Windows.Forms.TextBox();
            this.DistanceTB = new System.Windows.Forms.TextBox();
            this.CompassLabel = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.CurrentPostionGB = new System.Windows.Forms.GroupBox();
            this.Time2TB = new System.Windows.Forms.TextBox();
            this.Lng2TB = new System.Windows.Forms.TextBox();
            this.Lat2TB = new System.Windows.Forms.TextBox();
            this.Time2Label = new System.Windows.Forms.Label();
            this.Lng2Label = new System.Windows.Forms.Label();
            this.Lat2Label = new System.Windows.Forms.Label();
            this.PreviousPositionGB = new System.Windows.Forms.GroupBox();
            this.Time1TB = new System.Windows.Forms.TextBox();
            this.Lng1TB = new System.Windows.Forms.TextBox();
            this.Lat1TB = new System.Windows.Forms.TextBox();
            this.Time1Label = new System.Windows.Forms.Label();
            this.Lng1Label = new System.Windows.Forms.Label();
            this.Lat1Label = new System.Windows.Forms.Label();
            this.ReceivingOptionsGB = new System.Windows.Forms.GroupBox();
            this.NumericalDataLength = new System.Windows.Forms.Label();
            this.DataLengthLabel = new System.Windows.Forms.Label();
            this.AddtoDataCheckBox = new System.Windows.Forms.CheckBox();
            this.AlwaysUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.ClearDataButton = new System.Windows.Forms.Button();
            this.SingleLineTextBox = new System.Windows.Forms.TextBox();
            this.ReceivedDataTextbox = new System.Windows.Forms.TextBox();
            this.GPSDataAnalysisTab = new System.Windows.Forms.TabPage();
            this.GPSDataVisualisationGB = new System.Windows.Forms.GroupBox();
            this.MapLocation = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.LongitudeTB = new System.Windows.Forms.TextBox();
            this.LongitudeLabel = new System.Windows.Forms.Label();
            this.LatitudeTB = new System.Windows.Forms.TextBox();
            this.LatitudeLabel = new System.Windows.Forms.Label();
            this.SpeedRecordGB = new System.Windows.Forms.GroupBox();
            this.SpeedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.TabControls.SuspendLayout();
            this.SerialPortTab.SuspendLayout();
            this.StatusGroupBox.SuspendLayout();
            this.OnOffStatusGB.SuspendLayout();
            this.SerialPortParametersGroupBox.SuspendLayout();
            this.GPSDataTab.SuspendLayout();
            this.ReceivedDataGroupBox.SuspendLayout();
            this.PositionDataGB.SuspendLayout();
            this.CalculationGB.SuspendLayout();
            this.CurrentPostionGB.SuspendLayout();
            this.PreviousPositionGB.SuspendLayout();
            this.ReceivingOptionsGB.SuspendLayout();
            this.GPSDataAnalysisTab.SuspendLayout();
            this.GPSDataVisualisationGB.SuspendLayout();
            this.SpeedRecordGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedChart)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControls
            // 
            this.TabControls.Controls.Add(this.SerialPortTab);
            this.TabControls.Controls.Add(this.GPSDataTab);
            this.TabControls.Controls.Add(this.GPSDataAnalysisTab);
            this.TabControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControls.Location = new System.Drawing.Point(13, 13);
            this.TabControls.Name = "TabControls";
            this.TabControls.SelectedIndex = 0;
            this.TabControls.Size = new System.Drawing.Size(628, 748);
            this.TabControls.TabIndex = 0;
            // 
            // SerialPortTab
            // 
            this.SerialPortTab.Controls.Add(this.StatusGroupBox);
            this.SerialPortTab.Controls.Add(this.SerialPortParametersGroupBox);
            this.SerialPortTab.Location = new System.Drawing.Point(4, 31);
            this.SerialPortTab.Name = "SerialPortTab";
            this.SerialPortTab.Padding = new System.Windows.Forms.Padding(3);
            this.SerialPortTab.Size = new System.Drawing.Size(620, 713);
            this.SerialPortTab.TabIndex = 0;
            this.SerialPortTab.Text = "Serial Port";
            this.SerialPortTab.UseVisualStyleBackColor = true;
            // 
            // StatusGroupBox
            // 
            this.StatusGroupBox.Controls.Add(this.progressBar1);
            this.StatusGroupBox.Controls.Add(this.CloseButton);
            this.StatusGroupBox.Controls.Add(this.OnOffStatusGB);
            this.StatusGroupBox.Controls.Add(this.OpenButton);
            this.StatusGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusGroupBox.Location = new System.Drawing.Point(16, 448);
            this.StatusGroupBox.Name = "StatusGroupBox";
            this.StatusGroupBox.Size = new System.Drawing.Size(584, 259);
            this.StatusGroupBox.TabIndex = 1;
            this.StatusGroupBox.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(48, 208);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(483, 28);
            this.progressBar1.TabIndex = 3;
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(48, 125);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(119, 57);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // OnOffStatusGB
            // 
            this.OnOffStatusGB.Controls.Add(this.OnOffLabel);
            this.OnOffStatusGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnOffStatusGB.Location = new System.Drawing.Point(211, 27);
            this.OnOffStatusGB.Name = "OnOffStatusGB";
            this.OnOffStatusGB.Size = new System.Drawing.Size(320, 155);
            this.OnOffStatusGB.TabIndex = 2;
            this.OnOffStatusGB.TabStop = false;
            this.OnOffStatusGB.Text = "Serial Port Status";
            // 
            // OnOffLabel
            // 
            this.OnOffLabel.AutoSize = true;
            this.OnOffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnOffLabel.Location = new System.Drawing.Point(118, 68);
            this.OnOffLabel.Name = "OnOffLabel";
            this.OnOffLabel.Size = new System.Drawing.Size(86, 38);
            this.OnOffLabel.TabIndex = 0;
            this.OnOffLabel.Text = "OFF";
            // 
            // OpenButton
            // 
            this.OpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenButton.Location = new System.Drawing.Point(48, 33);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(119, 57);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SerialPortParametersGroupBox
            // 
            this.SerialPortParametersGroupBox.Controls.Add(this.ParityBitsComboBox);
            this.SerialPortParametersGroupBox.Controls.Add(this.StopBitsComboBox);
            this.SerialPortParametersGroupBox.Controls.Add(this.DataBitsComboBox);
            this.SerialPortParametersGroupBox.Controls.Add(this.BaudRateComboBox);
            this.SerialPortParametersGroupBox.Controls.Add(this.ComPortComboBox);
            this.SerialPortParametersGroupBox.Controls.Add(this.ParityBitsLabel);
            this.SerialPortParametersGroupBox.Controls.Add(this.StopBitsLabel);
            this.SerialPortParametersGroupBox.Controls.Add(this.DataBitsLabel);
            this.SerialPortParametersGroupBox.Controls.Add(this.BaudRateLabel);
            this.SerialPortParametersGroupBox.Controls.Add(this.ComPortLabel);
            this.SerialPortParametersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialPortParametersGroupBox.Location = new System.Drawing.Point(16, 17);
            this.SerialPortParametersGroupBox.Name = "SerialPortParametersGroupBox";
            this.SerialPortParametersGroupBox.Size = new System.Drawing.Size(584, 425);
            this.SerialPortParametersGroupBox.TabIndex = 0;
            this.SerialPortParametersGroupBox.TabStop = false;
            this.SerialPortParametersGroupBox.Text = "Serial Port Parameters";
            // 
            // ParityBitsComboBox
            // 
            this.ParityBitsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParityBitsComboBox.FormattingEnabled = true;
            this.ParityBitsComboBox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.ParityBitsComboBox.Location = new System.Drawing.Point(253, 324);
            this.ParityBitsComboBox.Name = "ParityBitsComboBox";
            this.ParityBitsComboBox.Size = new System.Drawing.Size(241, 37);
            this.ParityBitsComboBox.TabIndex = 9;
            this.ParityBitsComboBox.Text = "None";
            // 
            // StopBitsComboBox
            // 
            this.StopBitsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopBitsComboBox.FormattingEnabled = true;
            this.StopBitsComboBox.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.StopBitsComboBox.Location = new System.Drawing.Point(253, 259);
            this.StopBitsComboBox.Name = "StopBitsComboBox";
            this.StopBitsComboBox.Size = new System.Drawing.Size(241, 37);
            this.StopBitsComboBox.TabIndex = 8;
            this.StopBitsComboBox.Text = "One";
            // 
            // DataBitsComboBox
            // 
            this.DataBitsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataBitsComboBox.FormattingEnabled = true;
            this.DataBitsComboBox.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.DataBitsComboBox.Location = new System.Drawing.Point(253, 198);
            this.DataBitsComboBox.Name = "DataBitsComboBox";
            this.DataBitsComboBox.Size = new System.Drawing.Size(241, 37);
            this.DataBitsComboBox.TabIndex = 7;
            this.DataBitsComboBox.Text = "8";
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.BaudRateComboBox.Location = new System.Drawing.Point(253, 142);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(241, 37);
            this.BaudRateComboBox.TabIndex = 6;
            this.BaudRateComboBox.Text = "9600";
            // 
            // ComPortComboBox
            // 
            this.ComPortComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComPortComboBox.FormattingEnabled = true;
            this.ComPortComboBox.Location = new System.Drawing.Point(253, 81);
            this.ComPortComboBox.Name = "ComPortComboBox";
            this.ComPortComboBox.Size = new System.Drawing.Size(241, 37);
            this.ComPortComboBox.TabIndex = 5;
            // 
            // ParityBitsLabel
            // 
            this.ParityBitsLabel.AutoSize = true;
            this.ParityBitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParityBitsLabel.Location = new System.Drawing.Point(93, 332);
            this.ParityBitsLabel.Name = "ParityBitsLabel";
            this.ParityBitsLabel.Size = new System.Drawing.Size(119, 29);
            this.ParityBitsLabel.TabIndex = 4;
            this.ParityBitsLabel.Text = "Parity Bits";
            this.ParityBitsLabel.Click += new System.EventHandler(this.ParityBitsLabel_Click);
            // 
            // StopBitsLabel
            // 
            this.StopBitsLabel.AutoSize = true;
            this.StopBitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopBitsLabel.Location = new System.Drawing.Point(93, 267);
            this.StopBitsLabel.Name = "StopBitsLabel";
            this.StopBitsLabel.Size = new System.Drawing.Size(109, 29);
            this.StopBitsLabel.TabIndex = 3;
            this.StopBitsLabel.Text = "Stop Bits";
            // 
            // DataBitsLabel
            // 
            this.DataBitsLabel.AutoSize = true;
            this.DataBitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataBitsLabel.Location = new System.Drawing.Point(94, 206);
            this.DataBitsLabel.Name = "DataBitsLabel";
            this.DataBitsLabel.Size = new System.Drawing.Size(108, 29);
            this.DataBitsLabel.TabIndex = 2;
            this.DataBitsLabel.Text = "Data Bits";
            this.DataBitsLabel.Click += new System.EventHandler(this.DataBitsLabel_Click);
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.AutoSize = true;
            this.BaudRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRateLabel.Location = new System.Drawing.Point(92, 150);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(125, 29);
            this.BaudRateLabel.TabIndex = 1;
            this.BaudRateLabel.Text = "Baud Rate";
            // 
            // ComPortLabel
            // 
            this.ComPortLabel.AutoSize = true;
            this.ComPortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComPortLabel.Location = new System.Drawing.Point(93, 89);
            this.ComPortLabel.Name = "ComPortLabel";
            this.ComPortLabel.Size = new System.Drawing.Size(119, 29);
            this.ComPortLabel.TabIndex = 0;
            this.ComPortLabel.Text = "COM Port";
            this.ComPortLabel.Click += new System.EventHandler(this.ComPortLabel_Click);
            // 
            // GPSDataTab
            // 
            this.GPSDataTab.Controls.Add(this.ReceivedDataGroupBox);
            this.GPSDataTab.Location = new System.Drawing.Point(4, 31);
            this.GPSDataTab.Name = "GPSDataTab";
            this.GPSDataTab.Padding = new System.Windows.Forms.Padding(3);
            this.GPSDataTab.Size = new System.Drawing.Size(620, 713);
            this.GPSDataTab.TabIndex = 1;
            this.GPSDataTab.Text = "GPS Data";
            this.GPSDataTab.UseVisualStyleBackColor = true;
            // 
            // ReceivedDataGroupBox
            // 
            this.ReceivedDataGroupBox.Controls.Add(this.PositionDataGB);
            this.ReceivedDataGroupBox.Controls.Add(this.ReceivingOptionsGB);
            this.ReceivedDataGroupBox.Controls.Add(this.SingleLineTextBox);
            this.ReceivedDataGroupBox.Controls.Add(this.ReceivedDataTextbox);
            this.ReceivedDataGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceivedDataGroupBox.Location = new System.Drawing.Point(7, 7);
            this.ReceivedDataGroupBox.Name = "ReceivedDataGroupBox";
            this.ReceivedDataGroupBox.Size = new System.Drawing.Size(597, 700);
            this.ReceivedDataGroupBox.TabIndex = 0;
            this.ReceivedDataGroupBox.TabStop = false;
            this.ReceivedDataGroupBox.Text = "Received Data";
            // 
            // PositionDataGB
            // 
            this.PositionDataGB.Controls.Add(this.CalculationGB);
            this.PositionDataGB.Controls.Add(this.CurrentPostionGB);
            this.PositionDataGB.Controls.Add(this.PreviousPositionGB);
            this.PositionDataGB.Location = new System.Drawing.Point(14, 314);
            this.PositionDataGB.Name = "PositionDataGB";
            this.PositionDataGB.Size = new System.Drawing.Size(577, 380);
            this.PositionDataGB.TabIndex = 3;
            this.PositionDataGB.TabStop = false;
            // 
            // CalculationGB
            // 
            this.CalculationGB.Controls.Add(this.TotalTimeTB);
            this.CalculationGB.Controls.Add(this.TotalDistanceTB);
            this.CalculationGB.Controls.Add(this.TotalTimeLabel);
            this.CalculationGB.Controls.Add(this.TotalDistanceLabel);
            this.CalculationGB.Controls.Add(this.CompassTB);
            this.CalculationGB.Controls.Add(this.SpeedTB);
            this.CalculationGB.Controls.Add(this.DistanceTB);
            this.CalculationGB.Controls.Add(this.CompassLabel);
            this.CalculationGB.Controls.Add(this.SpeedLabel);
            this.CalculationGB.Controls.Add(this.distanceLabel);
            this.CalculationGB.Location = new System.Drawing.Point(6, 211);
            this.CalculationGB.Name = "CalculationGB";
            this.CalculationGB.Size = new System.Drawing.Size(565, 163);
            this.CalculationGB.TabIndex = 2;
            this.CalculationGB.TabStop = false;
            this.CalculationGB.Text = "Calculation";
            // 
            // TotalTimeTB
            // 
            this.TotalTimeTB.Location = new System.Drawing.Point(284, 125);
            this.TotalTimeTB.Name = "TotalTimeTB";
            this.TotalTimeTB.Size = new System.Drawing.Size(191, 28);
            this.TotalTimeTB.TabIndex = 9;
            // 
            // TotalDistanceTB
            // 
            this.TotalDistanceTB.Location = new System.Drawing.Point(77, 125);
            this.TotalDistanceTB.Name = "TotalDistanceTB";
            this.TotalDistanceTB.Size = new System.Drawing.Size(191, 28);
            this.TotalDistanceTB.TabIndex = 8;
            // 
            // TotalTimeLabel
            // 
            this.TotalTimeLabel.AutoSize = true;
            this.TotalTimeLabel.Location = new System.Drawing.Point(308, 98);
            this.TotalTimeLabel.Name = "TotalTimeLabel";
            this.TotalTimeLabel.Size = new System.Drawing.Size(142, 24);
            this.TotalTimeLabel.TabIndex = 7;
            this.TotalTimeLabel.Text = "Total Time(min)";
            // 
            // TotalDistanceLabel
            // 
            this.TotalDistanceLabel.AutoSize = true;
            this.TotalDistanceLabel.Location = new System.Drawing.Point(94, 98);
            this.TotalDistanceLabel.Name = "TotalDistanceLabel";
            this.TotalDistanceLabel.Size = new System.Drawing.Size(165, 24);
            this.TotalDistanceLabel.TabIndex = 6;
            this.TotalDistanceLabel.Text = "Total Distance(km)";
            // 
            // CompassTB
            // 
            this.CompassTB.Location = new System.Drawing.Point(373, 58);
            this.CompassTB.Name = "CompassTB";
            this.CompassTB.Size = new System.Drawing.Size(163, 28);
            this.CompassTB.TabIndex = 5;
            // 
            // SpeedTB
            // 
            this.SpeedTB.Location = new System.Drawing.Point(197, 58);
            this.SpeedTB.Name = "SpeedTB";
            this.SpeedTB.Size = new System.Drawing.Size(163, 28);
            this.SpeedTB.TabIndex = 4;
            // 
            // DistanceTB
            // 
            this.DistanceTB.Location = new System.Drawing.Point(19, 58);
            this.DistanceTB.Name = "DistanceTB";
            this.DistanceTB.Size = new System.Drawing.Size(163, 28);
            this.DistanceTB.TabIndex = 3;
            // 
            // CompassLabel
            // 
            this.CompassLabel.AutoSize = true;
            this.CompassLabel.Location = new System.Drawing.Point(410, 35);
            this.CompassLabel.Name = "CompassLabel";
            this.CompassLabel.Size = new System.Drawing.Size(89, 24);
            this.CompassLabel.TabIndex = 2;
            this.CompassLabel.Text = "Compass";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(219, 35);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(119, 24);
            this.SpeedLabel.TabIndex = 1;
            this.SpeedLabel.Text = "Speed(km/h)";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(43, 35);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(110, 24);
            this.distanceLabel.TabIndex = 0;
            this.distanceLabel.Text = "Distance(m)";
            // 
            // CurrentPostionGB
            // 
            this.CurrentPostionGB.Controls.Add(this.Time2TB);
            this.CurrentPostionGB.Controls.Add(this.Lng2TB);
            this.CurrentPostionGB.Controls.Add(this.Lat2TB);
            this.CurrentPostionGB.Controls.Add(this.Time2Label);
            this.CurrentPostionGB.Controls.Add(this.Lng2Label);
            this.CurrentPostionGB.Controls.Add(this.Lat2Label);
            this.CurrentPostionGB.Location = new System.Drawing.Point(280, 26);
            this.CurrentPostionGB.Name = "CurrentPostionGB";
            this.CurrentPostionGB.Size = new System.Drawing.Size(291, 179);
            this.CurrentPostionGB.TabIndex = 1;
            this.CurrentPostionGB.TabStop = false;
            this.CurrentPostionGB.Text = "Current Position";
            // 
            // Time2TB
            // 
            this.Time2TB.Location = new System.Drawing.Point(84, 130);
            this.Time2TB.Name = "Time2TB";
            this.Time2TB.Size = new System.Drawing.Size(188, 28);
            this.Time2TB.TabIndex = 8;
            // 
            // Lng2TB
            // 
            this.Lng2TB.Location = new System.Drawing.Point(84, 79);
            this.Lng2TB.Name = "Lng2TB";
            this.Lng2TB.Size = new System.Drawing.Size(188, 28);
            this.Lng2TB.TabIndex = 7;
            // 
            // Lat2TB
            // 
            this.Lat2TB.Location = new System.Drawing.Point(84, 26);
            this.Lat2TB.Name = "Lat2TB";
            this.Lat2TB.Size = new System.Drawing.Size(188, 28);
            this.Lat2TB.TabIndex = 6;
            // 
            // Time2Label
            // 
            this.Time2Label.AutoSize = true;
            this.Time2Label.Location = new System.Drawing.Point(21, 133);
            this.Time2Label.Name = "Time2Label";
            this.Time2Label.Size = new System.Drawing.Size(63, 24);
            this.Time2Label.TabIndex = 6;
            this.Time2Label.Text = "Time2";
            // 
            // Lng2Label
            // 
            this.Lng2Label.AutoSize = true;
            this.Lng2Label.Location = new System.Drawing.Point(21, 82);
            this.Lng2Label.Name = "Lng2Label";
            this.Lng2Label.Size = new System.Drawing.Size(52, 24);
            this.Lng2Label.TabIndex = 6;
            this.Lng2Label.Text = "Lng2";
            // 
            // Lat2Label
            // 
            this.Lat2Label.AutoSize = true;
            this.Lat2Label.Location = new System.Drawing.Point(21, 29);
            this.Lat2Label.Name = "Lat2Label";
            this.Lat2Label.Size = new System.Drawing.Size(44, 24);
            this.Lat2Label.TabIndex = 6;
            this.Lat2Label.Text = "Lat2";
            // 
            // PreviousPositionGB
            // 
            this.PreviousPositionGB.Controls.Add(this.Time1TB);
            this.PreviousPositionGB.Controls.Add(this.Lng1TB);
            this.PreviousPositionGB.Controls.Add(this.Lat1TB);
            this.PreviousPositionGB.Controls.Add(this.Time1Label);
            this.PreviousPositionGB.Controls.Add(this.Lng1Label);
            this.PreviousPositionGB.Controls.Add(this.Lat1Label);
            this.PreviousPositionGB.Location = new System.Drawing.Point(6, 26);
            this.PreviousPositionGB.Name = "PreviousPositionGB";
            this.PreviousPositionGB.Size = new System.Drawing.Size(268, 179);
            this.PreviousPositionGB.TabIndex = 0;
            this.PreviousPositionGB.TabStop = false;
            this.PreviousPositionGB.Text = "Previous Position";
            // 
            // Time1TB
            // 
            this.Time1TB.Location = new System.Drawing.Point(76, 130);
            this.Time1TB.Name = "Time1TB";
            this.Time1TB.Size = new System.Drawing.Size(176, 28);
            this.Time1TB.TabIndex = 5;
            // 
            // Lng1TB
            // 
            this.Lng1TB.Location = new System.Drawing.Point(76, 79);
            this.Lng1TB.Name = "Lng1TB";
            this.Lng1TB.Size = new System.Drawing.Size(176, 28);
            this.Lng1TB.TabIndex = 4;
            // 
            // Lat1TB
            // 
            this.Lat1TB.Location = new System.Drawing.Point(76, 26);
            this.Lat1TB.Name = "Lat1TB";
            this.Lat1TB.Size = new System.Drawing.Size(176, 28);
            this.Lat1TB.TabIndex = 3;
            // 
            // Time1Label
            // 
            this.Time1Label.AutoSize = true;
            this.Time1Label.Location = new System.Drawing.Point(15, 133);
            this.Time1Label.Name = "Time1Label";
            this.Time1Label.Size = new System.Drawing.Size(63, 24);
            this.Time1Label.TabIndex = 2;
            this.Time1Label.Text = "Time1";
            // 
            // Lng1Label
            // 
            this.Lng1Label.AutoSize = true;
            this.Lng1Label.Location = new System.Drawing.Point(15, 82);
            this.Lng1Label.Name = "Lng1Label";
            this.Lng1Label.Size = new System.Drawing.Size(52, 24);
            this.Lng1Label.TabIndex = 1;
            this.Lng1Label.Text = "Lng1";
            // 
            // Lat1Label
            // 
            this.Lat1Label.AutoSize = true;
            this.Lat1Label.Location = new System.Drawing.Point(15, 29);
            this.Lat1Label.Name = "Lat1Label";
            this.Lat1Label.Size = new System.Drawing.Size(44, 24);
            this.Lat1Label.TabIndex = 0;
            this.Lat1Label.Text = "Lat1";
            // 
            // ReceivingOptionsGB
            // 
            this.ReceivingOptionsGB.Controls.Add(this.NumericalDataLength);
            this.ReceivingOptionsGB.Controls.Add(this.DataLengthLabel);
            this.ReceivingOptionsGB.Controls.Add(this.AddtoDataCheckBox);
            this.ReceivingOptionsGB.Controls.Add(this.AlwaysUpdateCheckBox);
            this.ReceivingOptionsGB.Controls.Add(this.ClearDataButton);
            this.ReceivingOptionsGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceivingOptionsGB.Location = new System.Drawing.Point(14, 204);
            this.ReceivingOptionsGB.Name = "ReceivingOptionsGB";
            this.ReceivingOptionsGB.Size = new System.Drawing.Size(577, 115);
            this.ReceivingOptionsGB.TabIndex = 2;
            this.ReceivingOptionsGB.TabStop = false;
            this.ReceivingOptionsGB.Text = "Receiving Options";
            // 
            // NumericalDataLength
            // 
            this.NumericalDataLength.AutoSize = true;
            this.NumericalDataLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericalDataLength.Location = new System.Drawing.Point(492, 83);
            this.NumericalDataLength.Name = "NumericalDataLength";
            this.NumericalDataLength.Size = new System.Drawing.Size(30, 24);
            this.NumericalDataLength.TabIndex = 4;
            this.NumericalDataLength.Text = "00";
            // 
            // DataLengthLabel
            // 
            this.DataLengthLabel.AutoSize = true;
            this.DataLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataLengthLabel.Location = new System.Drawing.Point(286, 83);
            this.DataLengthLabel.Name = "DataLengthLabel";
            this.DataLengthLabel.Size = new System.Drawing.Size(200, 24);
            this.DataLengthLabel.TabIndex = 3;
            this.DataLengthLabel.Text = "Received Data Length:";
            // 
            // AddtoDataCheckBox
            // 
            this.AddtoDataCheckBox.AutoSize = true;
            this.AddtoDataCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddtoDataCheckBox.Location = new System.Drawing.Point(309, 52);
            this.AddtoDataCheckBox.Name = "AddtoDataCheckBox";
            this.AddtoDataCheckBox.Size = new System.Drawing.Size(164, 28);
            this.AddtoDataCheckBox.TabIndex = 2;
            this.AddtoDataCheckBox.Text = "Add to Old Data";
            this.AddtoDataCheckBox.UseVisualStyleBackColor = true;
            this.AddtoDataCheckBox.CheckedChanged += new System.EventHandler(this.AddtoDataCheckBox_CheckedChanged);
            // 
            // AlwaysUpdateCheckBox
            // 
            this.AlwaysUpdateCheckBox.AutoSize = true;
            this.AlwaysUpdateCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlwaysUpdateCheckBox.Location = new System.Drawing.Point(309, 20);
            this.AlwaysUpdateCheckBox.Name = "AlwaysUpdateCheckBox";
            this.AlwaysUpdateCheckBox.Size = new System.Drawing.Size(156, 28);
            this.AlwaysUpdateCheckBox.TabIndex = 1;
            this.AlwaysUpdateCheckBox.Text = "Always Update";
            this.AlwaysUpdateCheckBox.UseVisualStyleBackColor = true;
            this.AlwaysUpdateCheckBox.CheckedChanged += new System.EventHandler(this.AlwaysUpdateCheckBox_CheckedChanged);
            // 
            // ClearDataButton
            // 
            this.ClearDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearDataButton.Location = new System.Drawing.Point(77, 37);
            this.ClearDataButton.Name = "ClearDataButton";
            this.ClearDataButton.Size = new System.Drawing.Size(173, 58);
            this.ClearDataButton.TabIndex = 0;
            this.ClearDataButton.Text = "Clear Received Data";
            this.ClearDataButton.UseVisualStyleBackColor = true;
            this.ClearDataButton.Click += new System.EventHandler(this.ClearDataButton_Click);
            // 
            // SingleLineTextBox
            // 
            this.SingleLineTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleLineTextBox.Location = new System.Drawing.Point(14, 170);
            this.SingleLineTextBox.Name = "SingleLineTextBox";
            this.SingleLineTextBox.ReadOnly = true;
            this.SingleLineTextBox.Size = new System.Drawing.Size(577, 22);
            this.SingleLineTextBox.TabIndex = 1;
            // 
            // ReceivedDataTextbox
            // 
            this.ReceivedDataTextbox.Location = new System.Drawing.Point(14, 26);
            this.ReceivedDataTextbox.Multiline = true;
            this.ReceivedDataTextbox.Name = "ReceivedDataTextbox";
            this.ReceivedDataTextbox.ReadOnly = true;
            this.ReceivedDataTextbox.Size = new System.Drawing.Size(577, 130);
            this.ReceivedDataTextbox.TabIndex = 0;
            // 
            // GPSDataAnalysisTab
            // 
            this.GPSDataAnalysisTab.Controls.Add(this.GPSDataVisualisationGB);
            this.GPSDataAnalysisTab.Controls.Add(this.SpeedRecordGB);
            this.GPSDataAnalysisTab.Location = new System.Drawing.Point(4, 31);
            this.GPSDataAnalysisTab.Name = "GPSDataAnalysisTab";
            this.GPSDataAnalysisTab.Size = new System.Drawing.Size(620, 713);
            this.GPSDataAnalysisTab.TabIndex = 2;
            this.GPSDataAnalysisTab.Text = "GPS Data Analysis";
            this.GPSDataAnalysisTab.UseVisualStyleBackColor = true;
            // 
            // GPSDataVisualisationGB
            // 
            this.GPSDataVisualisationGB.Controls.Add(this.MapLocation);
            this.GPSDataVisualisationGB.Controls.Add(this.PauseButton);
            this.GPSDataVisualisationGB.Controls.Add(this.LongitudeTB);
            this.GPSDataVisualisationGB.Controls.Add(this.LongitudeLabel);
            this.GPSDataVisualisationGB.Controls.Add(this.LatitudeTB);
            this.GPSDataVisualisationGB.Controls.Add(this.LatitudeLabel);
            this.GPSDataVisualisationGB.Location = new System.Drawing.Point(28, 398);
            this.GPSDataVisualisationGB.Name = "GPSDataVisualisationGB";
            this.GPSDataVisualisationGB.Size = new System.Drawing.Size(561, 289);
            this.GPSDataVisualisationGB.TabIndex = 1;
            this.GPSDataVisualisationGB.TabStop = false;
            this.GPSDataVisualisationGB.Text = "GPS Data Visualisation";
            // 
            // MapLocation
            // 
            this.MapLocation.Location = new System.Drawing.Point(152, 216);
            this.MapLocation.Name = "MapLocation";
            this.MapLocation.Size = new System.Drawing.Size(227, 35);
            this.MapLocation.TabIndex = 5;
            this.MapLocation.Text = "Map Location";
            this.MapLocation.UseVisualStyleBackColor = true;
            // 
            // PauseButton
            // 
            this.PauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseButton.Location = new System.Drawing.Point(152, 162);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(227, 35);
            this.PauseButton.TabIndex = 4;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            // 
            // LongitudeTB
            // 
            this.LongitudeTB.Location = new System.Drawing.Point(191, 105);
            this.LongitudeTB.Name = "LongitudeTB";
            this.LongitudeTB.Size = new System.Drawing.Size(286, 28);
            this.LongitudeTB.TabIndex = 3;
            // 
            // LongitudeLabel
            // 
            this.LongitudeLabel.AutoSize = true;
            this.LongitudeLabel.Location = new System.Drawing.Point(56, 108);
            this.LongitudeLabel.Name = "LongitudeLabel";
            this.LongitudeLabel.Size = new System.Drawing.Size(99, 24);
            this.LongitudeLabel.TabIndex = 2;
            this.LongitudeLabel.Text = "Longitude:";
            // 
            // LatitudeTB
            // 
            this.LatitudeTB.Location = new System.Drawing.Point(191, 58);
            this.LatitudeTB.Name = "LatitudeTB";
            this.LatitudeTB.Size = new System.Drawing.Size(286, 28);
            this.LatitudeTB.TabIndex = 1;
            // 
            // LatitudeLabel
            // 
            this.LatitudeLabel.AutoSize = true;
            this.LatitudeLabel.Location = new System.Drawing.Point(56, 62);
            this.LatitudeLabel.Name = "LatitudeLabel";
            this.LatitudeLabel.Size = new System.Drawing.Size(80, 24);
            this.LatitudeLabel.TabIndex = 0;
            this.LatitudeLabel.Text = "Latitude:";
            // 
            // SpeedRecordGB
            // 
            this.SpeedRecordGB.Controls.Add(this.SpeedChart);
            this.SpeedRecordGB.Location = new System.Drawing.Point(28, 16);
            this.SpeedRecordGB.Name = "SpeedRecordGB";
            this.SpeedRecordGB.Size = new System.Drawing.Size(561, 376);
            this.SpeedRecordGB.TabIndex = 0;
            this.SpeedRecordGB.TabStop = false;
            this.SpeedRecordGB.Text = "Speed Record";
            // 
            // SpeedChart
            // 
            chartArea1.Name = "ChartArea1";
            this.SpeedChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SpeedChart.Legends.Add(legend1);
            this.SpeedChart.Location = new System.Drawing.Point(38, 40);
            this.SpeedChart.Name = "SpeedChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Speed";
            this.SpeedChart.Series.Add(series1);
            this.SpeedChart.Size = new System.Drawing.Size(492, 300);
            this.SpeedChart.TabIndex = 0;
            this.SpeedChart.Text = "chart1";
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 767);
            this.Controls.Add(this.TabControls);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControls.ResumeLayout(false);
            this.SerialPortTab.ResumeLayout(false);
            this.StatusGroupBox.ResumeLayout(false);
            this.OnOffStatusGB.ResumeLayout(false);
            this.OnOffStatusGB.PerformLayout();
            this.SerialPortParametersGroupBox.ResumeLayout(false);
            this.SerialPortParametersGroupBox.PerformLayout();
            this.GPSDataTab.ResumeLayout(false);
            this.ReceivedDataGroupBox.ResumeLayout(false);
            this.ReceivedDataGroupBox.PerformLayout();
            this.PositionDataGB.ResumeLayout(false);
            this.CalculationGB.ResumeLayout(false);
            this.CalculationGB.PerformLayout();
            this.CurrentPostionGB.ResumeLayout(false);
            this.CurrentPostionGB.PerformLayout();
            this.PreviousPositionGB.ResumeLayout(false);
            this.PreviousPositionGB.PerformLayout();
            this.ReceivingOptionsGB.ResumeLayout(false);
            this.ReceivingOptionsGB.PerformLayout();
            this.GPSDataAnalysisTab.ResumeLayout(false);
            this.GPSDataVisualisationGB.ResumeLayout(false);
            this.GPSDataVisualisationGB.PerformLayout();
            this.SpeedRecordGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpeedChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControls;
        private System.Windows.Forms.TabPage SerialPortTab;
        private System.Windows.Forms.GroupBox StatusGroupBox;
        private System.Windows.Forms.GroupBox SerialPortParametersGroupBox;
        private System.Windows.Forms.TabPage GPSDataTab;
        private System.Windows.Forms.TabPage GPSDataAnalysisTab;
        private System.Windows.Forms.Label ParityBitsLabel;
        private System.Windows.Forms.Label StopBitsLabel;
        private System.Windows.Forms.Label DataBitsLabel;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.Label ComPortLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.ComboBox ParityBitsComboBox;
        private System.Windows.Forms.ComboBox StopBitsComboBox;
        private System.Windows.Forms.ComboBox DataBitsComboBox;
        private System.Windows.Forms.ComboBox BaudRateComboBox;
        private System.Windows.Forms.ComboBox ComPortComboBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox OnOffStatusGB;
        private System.Windows.Forms.Label OnOffLabel;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.GroupBox ReceivedDataGroupBox;
        private System.Windows.Forms.TextBox SingleLineTextBox;
        private System.Windows.Forms.TextBox ReceivedDataTextbox;
        private System.Windows.Forms.GroupBox ReceivingOptionsGB;
        private System.Windows.Forms.Button ClearDataButton;
        private System.Windows.Forms.Label DataLengthLabel;
        private System.Windows.Forms.CheckBox AddtoDataCheckBox;
        private System.Windows.Forms.CheckBox AlwaysUpdateCheckBox;
        private System.Windows.Forms.Label NumericalDataLength;
        private System.Windows.Forms.GroupBox PositionDataGB;
        private System.Windows.Forms.GroupBox CalculationGB;
        private System.Windows.Forms.GroupBox CurrentPostionGB;
        private System.Windows.Forms.GroupBox PreviousPositionGB;
        private System.Windows.Forms.TextBox Time1TB;
        private System.Windows.Forms.TextBox Lng1TB;
        private System.Windows.Forms.TextBox Lat1TB;
        private System.Windows.Forms.Label Time1Label;
        private System.Windows.Forms.Label Lng1Label;
        private System.Windows.Forms.Label Lat1Label;
        private System.Windows.Forms.TextBox TotalTimeTB;
        private System.Windows.Forms.TextBox TotalDistanceTB;
        private System.Windows.Forms.Label TotalTimeLabel;
        private System.Windows.Forms.Label TotalDistanceLabel;
        private System.Windows.Forms.TextBox CompassTB;
        private System.Windows.Forms.TextBox SpeedTB;
        private System.Windows.Forms.TextBox DistanceTB;
        private System.Windows.Forms.Label CompassLabel;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.TextBox Time2TB;
        private System.Windows.Forms.TextBox Lng2TB;
        private System.Windows.Forms.TextBox Lat2TB;
        private System.Windows.Forms.Label Time2Label;
        private System.Windows.Forms.Label Lng2Label;
        private System.Windows.Forms.Label Lat2Label;
        private System.Windows.Forms.GroupBox SpeedRecordGB;
        private System.Windows.Forms.GroupBox GPSDataVisualisationGB;
        private System.Windows.Forms.Button MapLocation;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.TextBox LongitudeTB;
        private System.Windows.Forms.Label LongitudeLabel;
        private System.Windows.Forms.TextBox LatitudeTB;
        private System.Windows.Forms.Label LatitudeLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart SpeedChart;
    }
}

