namespace MECH423_Final_Project
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
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label labelXPosition;
            System.Windows.Forms.Label labelYPosition;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label labelADC;
            System.Windows.Forms.Label labelSPS;
            System.Windows.Forms.Label labelProbe;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label labelSteppers;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label18;
            System.Windows.Forms.Label label19;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.Label label21;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelSerial = new System.Windows.Forms.Label();
            this.comboBoxCOMPorts = new System.Windows.Forms.ComboBox();
            this.buttonConnectDisconnect = new System.Windows.Forms.Button();
            this.buttonFilename = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.checkBoxSaveToFile = new System.Windows.Forms.CheckBox();
            this.buttonHomeXY = new System.Windows.Forms.Button();
            this.pictureBox_Status = new System.Windows.Forms.PictureBox();
            this.button_Stop = new System.Windows.Forms.Button();
            this.buttonEnable = new System.Windows.Forms.Button();
            this.textBoxXPosition = new System.Windows.Forms.TextBox();
            this.textBoxYPosition = new System.Windows.Forms.TextBox();
            this.textBoxZPosition = new System.Windows.Forms.TextBox();
            this.buttonClearChart = new System.Windows.Forms.Button();
            this.buttonStepX = new System.Windows.Forms.Button();
            this.buttonStepY = new System.Windows.Forms.Button();
            this.textBoxXSteps = new System.Windows.Forms.TextBox();
            this.textBoxYSteps = new System.Windows.Forms.TextBox();
            this.buttonClearOutgoing = new System.Windows.Forms.Button();
            this.textBoxSerialOut = new System.Windows.Forms.TextBox();
            this.buttonClearIncoming = new System.Windows.Forms.Button();
            this.textBoxSerialIn = new System.Windows.Forms.TextBox();
            this.textBoxADCsps = new System.Windows.Forms.TextBox();
            this.buttonADCsps = new System.Windows.Forms.Button();
            this.buttonADCreset = new System.Windows.Forms.Button();
            this.buttonProbeLift = new System.Windows.Forms.Button();
            this.buttonProbeDrop = new System.Windows.Forms.Button();
            this.buttonProbeEnable = new System.Windows.Forms.Button();
            this.buttonProbeDisable = new System.Windows.Forms.Button();
            this.buttonSetTappingFreq = new System.Windows.Forms.Button();
            this.textBoxTappingFreq = new System.Windows.Forms.TextBox();
            this.textBoxYStepsABS = new System.Windows.Forms.TextBox();
            this.textBoxXStepsABS = new System.Windows.Forms.TextBox();
            this.buttonStepYabs = new System.Windows.Forms.Button();
            this.buttonStepXabs = new System.Windows.Forms.Button();
            this.buttonMoveXYabs = new System.Windows.Forms.Button();
            this.buttonStepXY = new System.Windows.Forms.Button();
            this.textBoxStepperSpeedX = new System.Windows.Forms.TextBox();
            this.buttonSetStepperSpeed = new System.Windows.Forms.Button();
            this.textBoxStepperSpeedY = new System.Windows.Forms.TextBox();
            this.buttonZeroX = new System.Windows.Forms.Button();
            this.buttonZeroY = new System.Windows.Forms.Button();
            this.textBoxUARTdataRate = new System.Windows.Forms.TextBox();
            this.buttonUARTdataRate = new System.Windows.Forms.Button();
            this.buttonStartUART = new System.Windows.Forms.Button();
            this.textBoxUARTonOff = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDownXWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownResolution = new System.Windows.Forms.NumericUpDown();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonClearStatus = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.numericUpDownAdjust = new System.Windows.Forms.NumericUpDown();
            this.buttonADCoffs = new System.Windows.Forms.Button();
            this.buttonCancelTest = new System.Windows.Forms.Button();
            this.buttonTestReset = new System.Windows.Forms.Button();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.textBoxManualCommand = new System.Windows.Forms.TextBox();
            this.buttonSendManualCommand = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label11 = new System.Windows.Forms.Label();
            labelXPosition = new System.Windows.Forms.Label();
            labelYPosition = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            labelADC = new System.Windows.Forms.Label();
            labelSPS = new System.Windows.Forms.Label();
            labelProbe = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            labelSteppers = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdjust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            label11.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(689, 215);
            label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(218, 20);
            label11.TabIndex = 176;
            label11.Text = "Save Output Data to File:";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelXPosition
            // 
            labelXPosition.AutoSize = true;
            labelXPosition.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelXPosition.Location = new System.Drawing.Point(966, 317);
            labelXPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelXPosition.Name = "labelXPosition";
            labelXPosition.Size = new System.Drawing.Size(111, 19);
            labelXPosition.TabIndex = 207;
            labelXPosition.Text = "X Position [mm]";
            // 
            // labelYPosition
            // 
            labelYPosition.AutoSize = true;
            labelYPosition.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelYPosition.Location = new System.Drawing.Point(966, 352);
            labelYPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelYPosition.Name = "labelYPosition";
            labelYPosition.Size = new System.Drawing.Size(111, 19);
            labelYPosition.TabIndex = 209;
            labelYPosition.Text = "Y Position [mm]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(916, 392);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(162, 19);
            label1.TabIndex = 211;
            label1.Text = "Z Position [ADC counts]";
            // 
            // label8
            // 
            label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(5, 77);
            label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(218, 20);
            label8.TabIndex = 235;
            label8.Text = "Outgoing Commands:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelADC
            // 
            labelADC.AutoSize = true;
            labelADC.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelADC.Location = new System.Drawing.Point(304, 408);
            labelADC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelADC.Name = "labelADC";
            labelADC.Size = new System.Drawing.Size(44, 23);
            labelADC.TabIndex = 238;
            labelADC.Text = "ADC";
            // 
            // labelSPS
            // 
            labelSPS.AutoSize = true;
            labelSPS.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSPS.Location = new System.Drawing.Point(588, 445);
            labelSPS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelSPS.Name = "labelSPS";
            labelSPS.Size = new System.Drawing.Size(71, 17);
            labelSPS.TabIndex = 239;
            labelSPS.Text = "[samples/s]";
            // 
            // labelProbe
            // 
            labelProbe.AutoSize = true;
            labelProbe.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelProbe.Location = new System.Drawing.Point(304, 563);
            labelProbe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelProbe.Name = "labelProbe";
            labelProbe.Size = new System.Drawing.Size(64, 23);
            labelProbe.TabIndex = 241;
            labelProbe.Text = "PROBE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(590, 673);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(31, 17);
            label3.TabIndex = 248;
            label3.Text = "[Hz]";
            // 
            // labelSteppers
            // 
            labelSteppers.AutoSize = true;
            labelSteppers.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSteppers.Location = new System.Drawing.Point(304, 91);
            labelSteppers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelSteppers.Name = "labelSteppers";
            labelSteppers.Size = new System.Drawing.Size(152, 23);
            labelSteppers.TabIndex = 249;
            labelSteppers.Text = "STEPPER MOTORS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(494, 128);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(45, 17);
            label4.TabIndex = 250;
            label4.Text = "[steps]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(494, 167);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 17);
            label5.TabIndex = 251;
            label5.Text = "[steps]";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(494, 245);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(45, 17);
            label6.TabIndex = 257;
            label6.Text = "[steps]";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(494, 205);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(45, 17);
            label7.TabIndex = 256;
            label7.Text = "[steps]";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(493, 282);
            label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(55, 17);
            label9.TabIndex = 261;
            label9.Text = "[steps/s]";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(492, 320);
            label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(55, 17);
            label10.TabIndex = 264;
            label10.Text = "[steps/s]";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new System.Drawing.Point(257, 318);
            label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(31, 17);
            label12.TabIndex = 269;
            label12.Text = "[Hz]";
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(8, 495);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(218, 20);
            label2.TabIndex = 231;
            label2.Text = "Incoming Data Packets:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(689, 94);
            label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(149, 19);
            label13.TabIndex = 277;
            label13.Text = "Y Sample Width [mm]";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new System.Drawing.Point(689, 37);
            label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(149, 19);
            label14.TabIndex = 275;
            label14.Text = "X Sample Width [mm]";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new System.Drawing.Point(689, 153);
            label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(136, 19);
            label15.TabIndex = 281;
            label15.Text = "XY Resolution [mm]";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.Location = new System.Drawing.Point(686, 11);
            label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(249, 23);
            label16.TabIndex = 282;
            label16.Text = "MEASUREMENT PARAMETERS";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.Location = new System.Drawing.Point(690, 531);
            label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(135, 23);
            label17.TabIndex = 283;
            label17.Text = "SYSTEM STATUS";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label18.Location = new System.Drawing.Point(894, 38);
            label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(147, 19);
            label18.TabIndex = 290;
            label18.Text = "Adjust Probe Position";
            // 
            // label19
            // 
            label19.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label19.Location = new System.Drawing.Point(6, 387);
            label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(218, 20);
            label19.TabIndex = 297;
            label19.Text = "Send Manual SCPI Command:";
            label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label20.Location = new System.Drawing.Point(308, 282);
            label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(103, 17);
            label20.TabIndex = 300;
            label20.Text = "X Stepper Speed:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label21.Location = new System.Drawing.Point(308, 321);
            label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(103, 17);
            label21.TabIndex = 301;
            label21.Text = "Y Stepper Speed:";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DtrEnable = true;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labelSerial
            // 
            this.labelSerial.AutoSize = true;
            this.labelSerial.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSerial.Location = new System.Drawing.Point(83, 11);
            this.labelSerial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSerial.Name = "labelSerial";
            this.labelSerial.Size = new System.Drawing.Size(111, 23);
            this.labelSerial.TabIndex = 168;
            this.labelSerial.Text = "SERIAL PORT";
            // 
            // comboBoxCOMPorts
            // 
            this.comboBoxCOMPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCOMPorts.FormattingEnabled = true;
            this.comboBoxCOMPorts.Location = new System.Drawing.Point(8, 43);
            this.comboBoxCOMPorts.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCOMPorts.Name = "comboBoxCOMPorts";
            this.comboBoxCOMPorts.Size = new System.Drawing.Size(102, 24);
            this.comboBoxCOMPorts.TabIndex = 167;
            this.comboBoxCOMPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxCOMPorts_SelectedIndexChanged);
            this.comboBoxCOMPorts.DropDownClosed += new System.EventHandler(this.comboBoxCOMPorts_DropDownClosed);
            // 
            // buttonConnectDisconnect
            // 
            this.buttonConnectDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectDisconnect.Location = new System.Drawing.Point(117, 42);
            this.buttonConnectDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnectDisconnect.Name = "buttonConnectDisconnect";
            this.buttonConnectDisconnect.Size = new System.Drawing.Size(158, 24);
            this.buttonConnectDisconnect.TabIndex = 166;
            this.buttonConnectDisconnect.Text = "Connect Serial";
            this.buttonConnectDisconnect.UseVisualStyleBackColor = true;
            this.buttonConnectDisconnect.Click += new System.EventHandler(this.buttonConnectDisconnect_Click);
            // 
            // buttonFilename
            // 
            this.buttonFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilename.Location = new System.Drawing.Point(690, 239);
            this.buttonFilename.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFilename.Name = "buttonFilename";
            this.buttonFilename.Size = new System.Drawing.Size(141, 25);
            this.buttonFilename.TabIndex = 175;
            this.buttonFilename.Text = "Select Filename";
            this.buttonFilename.UseVisualStyleBackColor = true;
            this.buttonFilename.Click += new System.EventHandler(this.buttonFilename_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFileName.Location = new System.Drawing.Point(690, 271);
            this.textBoxFileName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(465, 23);
            this.textBoxFileName.TabIndex = 174;
            // 
            // checkBoxSaveToFile
            // 
            this.checkBoxSaveToFile.AutoSize = true;
            this.checkBoxSaveToFile.Checked = true;
            this.checkBoxSaveToFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSaveToFile.Location = new System.Drawing.Point(848, 245);
            this.checkBoxSaveToFile.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxSaveToFile.Name = "checkBoxSaveToFile";
            this.checkBoxSaveToFile.Size = new System.Drawing.Size(108, 17);
            this.checkBoxSaveToFile.TabIndex = 173;
            this.checkBoxSaveToFile.Text = "Save Data to File";
            this.checkBoxSaveToFile.UseVisualStyleBackColor = true;
            this.checkBoxSaveToFile.CheckedChanged += new System.EventHandler(this.checkBoxSaveToFile_CheckedChanged);
            // 
            // buttonHomeXY
            // 
            this.buttonHomeXY.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonHomeXY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHomeXY.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHomeXY.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHomeXY.Location = new System.Drawing.Point(884, 175);
            this.buttonHomeXY.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHomeXY.Name = "buttonHomeXY";
            this.buttonHomeXY.Size = new System.Drawing.Size(271, 32);
            this.buttonHomeXY.TabIndex = 177;
            this.buttonHomeXY.Text = "RETURN HOME";
            this.buttonHomeXY.UseVisualStyleBackColor = false;
            this.buttonHomeXY.Click += new System.EventHandler(this.buttonHomeXY_Click);
            // 
            // pictureBox_Status
            // 
            this.pictureBox_Status.BackColor = System.Drawing.Color.White;
            this.pictureBox_Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Status.Location = new System.Drawing.Point(610, 19);
            this.pictureBox_Status.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Status.Name = "pictureBox_Status";
            this.pictureBox_Status.Size = new System.Drawing.Size(49, 47);
            this.pictureBox_Status.TabIndex = 194;
            this.pictureBox_Status.TabStop = false;
            // 
            // button_Stop
            // 
            this.button_Stop.BackColor = System.Drawing.Color.LightCoral;
            this.button_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Stop.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Stop.Location = new System.Drawing.Point(459, 19);
            this.button_Stop.Margin = new System.Windows.Forms.Padding(2);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(138, 47);
            this.button_Stop.TabIndex = 193;
            this.button_Stop.Text = "STOP";
            this.button_Stop.UseVisualStyleBackColor = false;
            this.button_Stop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonEnable
            // 
            this.buttonEnable.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonEnable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEnable.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnable.Location = new System.Drawing.Point(308, 19);
            this.buttonEnable.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEnable.Name = "buttonEnable";
            this.buttonEnable.Size = new System.Drawing.Size(138, 47);
            this.buttonEnable.TabIndex = 192;
            this.buttonEnable.Text = "ENABLE";
            this.buttonEnable.UseVisualStyleBackColor = false;
            this.buttonEnable.Click += new System.EventHandler(this.buttonEnable_Click);
            // 
            // textBoxXPosition
            // 
            this.textBoxXPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxXPosition.Location = new System.Drawing.Point(1082, 313);
            this.textBoxXPosition.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxXPosition.Name = "textBoxXPosition";
            this.textBoxXPosition.Size = new System.Drawing.Size(73, 28);
            this.textBoxXPosition.TabIndex = 206;
            this.textBoxXPosition.Text = "0";
            this.textBoxXPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxYPosition
            // 
            this.textBoxYPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYPosition.Location = new System.Drawing.Point(1082, 349);
            this.textBoxYPosition.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxYPosition.Name = "textBoxYPosition";
            this.textBoxYPosition.Size = new System.Drawing.Size(73, 28);
            this.textBoxYPosition.TabIndex = 208;
            this.textBoxYPosition.Text = "0";
            this.textBoxYPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxZPosition
            // 
            this.textBoxZPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZPosition.Location = new System.Drawing.Point(1082, 388);
            this.textBoxZPosition.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxZPosition.Name = "textBoxZPosition";
            this.textBoxZPosition.Size = new System.Drawing.Size(73, 28);
            this.textBoxZPosition.TabIndex = 210;
            this.textBoxZPosition.Text = "0";
            this.textBoxZPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonClearChart
            // 
            this.buttonClearChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearChart.Location = new System.Drawing.Point(690, 424);
            this.buttonClearChart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearChart.Name = "buttonClearChart";
            this.buttonClearChart.Size = new System.Drawing.Size(64, 92);
            this.buttonClearChart.TabIndex = 212;
            this.buttonClearChart.Text = "Clear Chart";
            this.buttonClearChart.UseVisualStyleBackColor = true;
            this.buttonClearChart.Click += new System.EventHandler(this.buttonClearChart_Click);
            // 
            // buttonStepX
            // 
            this.buttonStepX.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonStepX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStepX.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStepX.Location = new System.Drawing.Point(308, 124);
            this.buttonStepX.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStepX.Name = "buttonStepX";
            this.buttonStepX.Size = new System.Drawing.Size(106, 28);
            this.buttonStepX.TabIndex = 226;
            this.buttonStepX.Text = "STEP X";
            this.buttonStepX.UseVisualStyleBackColor = false;
            this.buttonStepX.Click += new System.EventHandler(this.buttonStepX_Click);
            // 
            // buttonStepY
            // 
            this.buttonStepY.BackColor = System.Drawing.Color.Azure;
            this.buttonStepY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStepY.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStepY.Location = new System.Drawing.Point(308, 162);
            this.buttonStepY.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStepY.Name = "buttonStepY";
            this.buttonStepY.Size = new System.Drawing.Size(106, 28);
            this.buttonStepY.TabIndex = 227;
            this.buttonStepY.Text = "STEP Y";
            this.buttonStepY.UseVisualStyleBackColor = false;
            this.buttonStepY.Click += new System.EventHandler(this.buttonStepY_Click);
            // 
            // textBoxXSteps
            // 
            this.textBoxXSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxXSteps.Location = new System.Drawing.Point(418, 124);
            this.textBoxXSteps.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxXSteps.Name = "textBoxXSteps";
            this.textBoxXSteps.Size = new System.Drawing.Size(72, 28);
            this.textBoxXSteps.TabIndex = 228;
            this.textBoxXSteps.Text = "0";
            this.textBoxXSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxYSteps
            // 
            this.textBoxYSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYSteps.Location = new System.Drawing.Point(418, 162);
            this.textBoxYSteps.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxYSteps.Name = "textBoxYSteps";
            this.textBoxYSteps.Size = new System.Drawing.Size(72, 28);
            this.textBoxYSteps.TabIndex = 229;
            this.textBoxYSteps.Text = "0";
            this.textBoxYSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonClearOutgoing
            // 
            this.buttonClearOutgoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearOutgoing.Location = new System.Drawing.Point(8, 259);
            this.buttonClearOutgoing.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearOutgoing.Name = "buttonClearOutgoing";
            this.buttonClearOutgoing.Size = new System.Drawing.Size(267, 28);
            this.buttonClearOutgoing.TabIndex = 234;
            this.buttonClearOutgoing.Text = "Clear Outgoing Data";
            this.buttonClearOutgoing.UseVisualStyleBackColor = true;
            this.buttonClearOutgoing.Click += new System.EventHandler(this.buttonClearOutgoing_Click);
            // 
            // textBoxSerialOut
            // 
            this.textBoxSerialOut.Location = new System.Drawing.Point(8, 100);
            this.textBoxSerialOut.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSerialOut.Multiline = true;
            this.textBoxSerialOut.Name = "textBoxSerialOut";
            this.textBoxSerialOut.Size = new System.Drawing.Size(267, 151);
            this.textBoxSerialOut.TabIndex = 233;
            // 
            // buttonClearIncoming
            // 
            this.buttonClearIncoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearIncoming.Location = new System.Drawing.Point(7, 670);
            this.buttonClearIncoming.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearIncoming.Name = "buttonClearIncoming";
            this.buttonClearIncoming.Size = new System.Drawing.Size(269, 28);
            this.buttonClearIncoming.TabIndex = 232;
            this.buttonClearIncoming.Text = "Clear Incoming Data";
            this.buttonClearIncoming.UseVisualStyleBackColor = true;
            this.buttonClearIncoming.Click += new System.EventHandler(this.buttonClearIncoming_Click);
            // 
            // textBoxSerialIn
            // 
            this.textBoxSerialIn.Location = new System.Drawing.Point(8, 518);
            this.textBoxSerialIn.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSerialIn.Multiline = true;
            this.textBoxSerialIn.Name = "textBoxSerialIn";
            this.textBoxSerialIn.Size = new System.Drawing.Size(268, 141);
            this.textBoxSerialIn.TabIndex = 230;
            // 
            // textBoxADCsps
            // 
            this.textBoxADCsps.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxADCsps.Location = new System.Drawing.Point(487, 439);
            this.textBoxADCsps.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxADCsps.Name = "textBoxADCsps";
            this.textBoxADCsps.Size = new System.Drawing.Size(98, 28);
            this.textBoxADCsps.TabIndex = 236;
            this.textBoxADCsps.Text = "0";
            this.textBoxADCsps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonADCsps
            // 
            this.buttonADCsps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADCsps.Location = new System.Drawing.Point(308, 439);
            this.buttonADCsps.Margin = new System.Windows.Forms.Padding(2);
            this.buttonADCsps.Name = "buttonADCsps";
            this.buttonADCsps.Size = new System.Drawing.Size(175, 28);
            this.buttonADCsps.TabIndex = 237;
            this.buttonADCsps.Text = "Set ADC Sample Rate";
            this.buttonADCsps.UseVisualStyleBackColor = true;
            this.buttonADCsps.Click += new System.EventHandler(this.buttonADCsps_Click);
            // 
            // buttonADCreset
            // 
            this.buttonADCreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADCreset.Location = new System.Drawing.Point(308, 478);
            this.buttonADCreset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonADCreset.Name = "buttonADCreset";
            this.buttonADCreset.Size = new System.Drawing.Size(175, 28);
            this.buttonADCreset.TabIndex = 240;
            this.buttonADCreset.Text = "ADC Reset";
            this.buttonADCreset.UseVisualStyleBackColor = true;
            this.buttonADCreset.Click += new System.EventHandler(this.buttonADCreset_Click);
            // 
            // buttonProbeLift
            // 
            this.buttonProbeLift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProbeLift.Location = new System.Drawing.Point(308, 591);
            this.buttonProbeLift.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProbeLift.Name = "buttonProbeLift";
            this.buttonProbeLift.Size = new System.Drawing.Size(175, 28);
            this.buttonProbeLift.TabIndex = 242;
            this.buttonProbeLift.Text = "Lift";
            this.buttonProbeLift.UseVisualStyleBackColor = true;
            this.buttonProbeLift.Click += new System.EventHandler(this.buttonProbeLift_Click);
            // 
            // buttonProbeDrop
            // 
            this.buttonProbeDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProbeDrop.Location = new System.Drawing.Point(308, 629);
            this.buttonProbeDrop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProbeDrop.Name = "buttonProbeDrop";
            this.buttonProbeDrop.Size = new System.Drawing.Size(175, 28);
            this.buttonProbeDrop.TabIndex = 243;
            this.buttonProbeDrop.Text = "Drop";
            this.buttonProbeDrop.UseVisualStyleBackColor = true;
            this.buttonProbeDrop.Click += new System.EventHandler(this.buttonProbeDrop_Click);
            // 
            // buttonProbeEnable
            // 
            this.buttonProbeEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProbeEnable.Location = new System.Drawing.Point(487, 591);
            this.buttonProbeEnable.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProbeEnable.Name = "buttonProbeEnable";
            this.buttonProbeEnable.Size = new System.Drawing.Size(172, 28);
            this.buttonProbeEnable.TabIndex = 244;
            this.buttonProbeEnable.Text = "Enable Tapping";
            this.buttonProbeEnable.UseVisualStyleBackColor = true;
            this.buttonProbeEnable.Click += new System.EventHandler(this.buttonProbeEnable_Click);
            // 
            // buttonProbeDisable
            // 
            this.buttonProbeDisable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProbeDisable.Location = new System.Drawing.Point(487, 629);
            this.buttonProbeDisable.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProbeDisable.Name = "buttonProbeDisable";
            this.buttonProbeDisable.Size = new System.Drawing.Size(172, 28);
            this.buttonProbeDisable.TabIndex = 245;
            this.buttonProbeDisable.Text = "Disable Tapping";
            this.buttonProbeDisable.UseVisualStyleBackColor = true;
            this.buttonProbeDisable.Click += new System.EventHandler(this.buttonProbeDisable_Click);
            // 
            // buttonSetTappingFreq
            // 
            this.buttonSetTappingFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetTappingFreq.Location = new System.Drawing.Point(308, 667);
            this.buttonSetTappingFreq.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSetTappingFreq.Name = "buttonSetTappingFreq";
            this.buttonSetTappingFreq.Size = new System.Drawing.Size(175, 28);
            this.buttonSetTappingFreq.TabIndex = 246;
            this.buttonSetTappingFreq.Text = "Set Tapping Frequency";
            this.buttonSetTappingFreq.UseVisualStyleBackColor = true;
            this.buttonSetTappingFreq.Click += new System.EventHandler(this.buttonSetTappingFreq_Click);
            // 
            // textBoxTappingFreq
            // 
            this.textBoxTappingFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTappingFreq.Location = new System.Drawing.Point(488, 667);
            this.textBoxTappingFreq.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTappingFreq.Name = "textBoxTappingFreq";
            this.textBoxTappingFreq.Size = new System.Drawing.Size(98, 28);
            this.textBoxTappingFreq.TabIndex = 247;
            this.textBoxTappingFreq.Text = "0";
            this.textBoxTappingFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxYStepsABS
            // 
            this.textBoxYStepsABS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYStepsABS.Location = new System.Drawing.Point(418, 239);
            this.textBoxYStepsABS.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxYStepsABS.Name = "textBoxYStepsABS";
            this.textBoxYStepsABS.Size = new System.Drawing.Size(72, 28);
            this.textBoxYStepsABS.TabIndex = 255;
            this.textBoxYStepsABS.Text = "0";
            this.textBoxYStepsABS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxXStepsABS
            // 
            this.textBoxXStepsABS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxXStepsABS.Location = new System.Drawing.Point(418, 200);
            this.textBoxXStepsABS.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxXStepsABS.Name = "textBoxXStepsABS";
            this.textBoxXStepsABS.Size = new System.Drawing.Size(72, 28);
            this.textBoxXStepsABS.TabIndex = 254;
            this.textBoxXStepsABS.Text = "0";
            this.textBoxXStepsABS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonStepYabs
            // 
            this.buttonStepYabs.BackColor = System.Drawing.Color.Azure;
            this.buttonStepYabs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStepYabs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStepYabs.Location = new System.Drawing.Point(308, 239);
            this.buttonStepYabs.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStepYabs.Name = "buttonStepYabs";
            this.buttonStepYabs.Size = new System.Drawing.Size(106, 28);
            this.buttonStepYabs.TabIndex = 253;
            this.buttonStepYabs.Text = "STEP Y ABS";
            this.buttonStepYabs.UseVisualStyleBackColor = false;
            this.buttonStepYabs.Click += new System.EventHandler(this.buttonStepYabs_Click);
            // 
            // buttonStepXabs
            // 
            this.buttonStepXabs.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonStepXabs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStepXabs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStepXabs.Location = new System.Drawing.Point(308, 200);
            this.buttonStepXabs.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStepXabs.Name = "buttonStepXabs";
            this.buttonStepXabs.Size = new System.Drawing.Size(106, 28);
            this.buttonStepXabs.TabIndex = 252;
            this.buttonStepXabs.Text = "STEP X ABS";
            this.buttonStepXabs.UseVisualStyleBackColor = false;
            this.buttonStepXabs.Click += new System.EventHandler(this.buttonStepXabs_Click);
            // 
            // buttonMoveXYabs
            // 
            this.buttonMoveXYabs.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonMoveXYabs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoveXYabs.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveXYabs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMoveXYabs.Location = new System.Drawing.Point(565, 204);
            this.buttonMoveXYabs.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMoveXYabs.Name = "buttonMoveXYabs";
            this.buttonMoveXYabs.Size = new System.Drawing.Size(94, 56);
            this.buttonMoveXYabs.TabIndex = 258;
            this.buttonMoveXYabs.Text = "MOVE XY ABS";
            this.buttonMoveXYabs.UseVisualStyleBackColor = false;
            this.buttonMoveXYabs.Click += new System.EventHandler(this.buttonMoveXYabs_Click);
            // 
            // buttonStepXY
            // 
            this.buttonStepXY.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonStepXY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStepXY.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStepXY.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStepXY.Location = new System.Drawing.Point(565, 128);
            this.buttonStepXY.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStepXY.Name = "buttonStepXY";
            this.buttonStepXY.Size = new System.Drawing.Size(94, 56);
            this.buttonStepXY.TabIndex = 259;
            this.buttonStepXY.Text = "STEP XY";
            this.buttonStepXY.UseVisualStyleBackColor = false;
            this.buttonStepXY.Click += new System.EventHandler(this.buttonStepXY_Click);
            // 
            // textBoxStepperSpeedX
            // 
            this.textBoxStepperSpeedX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStepperSpeedX.Location = new System.Drawing.Point(418, 277);
            this.textBoxStepperSpeedX.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStepperSpeedX.Name = "textBoxStepperSpeedX";
            this.textBoxStepperSpeedX.Size = new System.Drawing.Size(72, 28);
            this.textBoxStepperSpeedX.TabIndex = 260;
            this.textBoxStepperSpeedX.Text = "100";
            this.textBoxStepperSpeedX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonSetStepperSpeed
            // 
            this.buttonSetStepperSpeed.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSetStepperSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSetStepperSpeed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetStepperSpeed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSetStepperSpeed.Location = new System.Drawing.Point(565, 282);
            this.buttonSetStepperSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSetStepperSpeed.Name = "buttonSetStepperSpeed";
            this.buttonSetStepperSpeed.Size = new System.Drawing.Size(95, 56);
            this.buttonSetStepperSpeed.TabIndex = 262;
            this.buttonSetStepperSpeed.Text = "SET SPEED";
            this.buttonSetStepperSpeed.UseVisualStyleBackColor = false;
            this.buttonSetStepperSpeed.Click += new System.EventHandler(this.buttonSetStepperSpeed_Click);
            // 
            // textBoxStepperSpeedY
            // 
            this.textBoxStepperSpeedY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStepperSpeedY.Location = new System.Drawing.Point(418, 315);
            this.textBoxStepperSpeedY.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStepperSpeedY.Name = "textBoxStepperSpeedY";
            this.textBoxStepperSpeedY.Size = new System.Drawing.Size(72, 28);
            this.textBoxStepperSpeedY.TabIndex = 263;
            this.textBoxStepperSpeedY.Text = "100";
            this.textBoxStepperSpeedY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonZeroX
            // 
            this.buttonZeroX.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonZeroX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZeroX.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZeroX.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonZeroX.Location = new System.Drawing.Point(1075, 74);
            this.buttonZeroX.Margin = new System.Windows.Forms.Padding(2);
            this.buttonZeroX.Name = "buttonZeroX";
            this.buttonZeroX.Size = new System.Drawing.Size(80, 32);
            this.buttonZeroX.TabIndex = 265;
            this.buttonZeroX.Text = "ZERO X";
            this.buttonZeroX.UseVisualStyleBackColor = false;
            this.buttonZeroX.Click += new System.EventHandler(this.buttonZeroX_Click);
            // 
            // buttonZeroY
            // 
            this.buttonZeroY.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonZeroY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZeroY.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZeroY.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonZeroY.Location = new System.Drawing.Point(1075, 117);
            this.buttonZeroY.Margin = new System.Windows.Forms.Padding(2);
            this.buttonZeroY.Name = "buttonZeroY";
            this.buttonZeroY.Size = new System.Drawing.Size(80, 32);
            this.buttonZeroY.TabIndex = 266;
            this.buttonZeroY.Text = "ZERO Y";
            this.buttonZeroY.UseVisualStyleBackColor = false;
            this.buttonZeroY.Click += new System.EventHandler(this.buttonZeroY_Click);
            // 
            // textBoxUARTdataRate
            // 
            this.textBoxUARTdataRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUARTdataRate.Location = new System.Drawing.Point(176, 313);
            this.textBoxUARTdataRate.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUARTdataRate.Name = "textBoxUARTdataRate";
            this.textBoxUARTdataRate.Size = new System.Drawing.Size(78, 28);
            this.textBoxUARTdataRate.TabIndex = 267;
            this.textBoxUARTdataRate.Text = "50";
            this.textBoxUARTdataRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonUARTdataRate
            // 
            this.buttonUARTdataRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUARTdataRate.Location = new System.Drawing.Point(8, 313);
            this.buttonUARTdataRate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUARTdataRate.Name = "buttonUARTdataRate";
            this.buttonUARTdataRate.Size = new System.Drawing.Size(164, 28);
            this.buttonUARTdataRate.TabIndex = 268;
            this.buttonUARTdataRate.Text = "Set UART Transfer Rate";
            this.buttonUARTdataRate.UseVisualStyleBackColor = true;
            this.buttonUARTdataRate.Click += new System.EventHandler(this.buttonUARTsetTransferRate_Click);
            // 
            // buttonStartUART
            // 
            this.buttonStartUART.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartUART.Location = new System.Drawing.Point(8, 347);
            this.buttonStartUART.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStartUART.Name = "buttonStartUART";
            this.buttonStartUART.Size = new System.Drawing.Size(164, 28);
            this.buttonStartUART.TabIndex = 270;
            this.buttonStartUART.Text = "Start UART Transfer";
            this.buttonStartUART.UseVisualStyleBackColor = true;
            this.buttonStartUART.Click += new System.EventHandler(this.buttonStartUART_Click);
            // 
            // textBoxUARTonOff
            // 
            this.textBoxUARTonOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUARTonOff.Location = new System.Drawing.Point(177, 347);
            this.textBoxUARTonOff.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUARTonOff.Name = "textBoxUARTonOff";
            this.textBoxUARTonOff.Size = new System.Drawing.Size(78, 28);
            this.textBoxUARTonOff.TabIndex = 271;
            this.textBoxUARTonOff.Text = "OFF";
            this.textBoxUARTonOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(690, 305);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(217, 39);
            this.buttonStart.TabIndex = 273;
            this.buttonStart.Text = "START MEASUREMENT";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // numericUpDownXWidth
            // 
            this.numericUpDownXWidth.DecimalPlaces = 1;
            this.numericUpDownXWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownXWidth.Location = new System.Drawing.Point(691, 59);
            this.numericUpDownXWidth.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownXWidth.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownXWidth.Name = "numericUpDownXWidth";
            this.numericUpDownXWidth.Size = new System.Drawing.Size(142, 28);
            this.numericUpDownXWidth.TabIndex = 278;
            this.numericUpDownXWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownYWidth
            // 
            this.numericUpDownYWidth.DecimalPlaces = 1;
            this.numericUpDownYWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownYWidth.Location = new System.Drawing.Point(691, 116);
            this.numericUpDownYWidth.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownYWidth.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownYWidth.Name = "numericUpDownYWidth";
            this.numericUpDownYWidth.Size = new System.Drawing.Size(142, 28);
            this.numericUpDownYWidth.TabIndex = 279;
            this.numericUpDownYWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownResolution
            // 
            this.numericUpDownResolution.DecimalPlaces = 2;
            this.numericUpDownResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownResolution.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownResolution.Location = new System.Drawing.Point(692, 176);
            this.numericUpDownResolution.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownResolution.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownResolution.Name = "numericUpDownResolution";
            this.numericUpDownResolution.Size = new System.Drawing.Size(141, 28);
            this.numericUpDownResolution.TabIndex = 280;
            this.numericUpDownResolution.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(691, 565);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxStatus.Size = new System.Drawing.Size(464, 159);
            this.textBoxStatus.TabIndex = 284;
            this.textBoxStatus.TextChanged += new System.EventHandler(this.textBoxStatus_TextChanged);
            // 
            // buttonClearStatus
            // 
            this.buttonClearStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearStatus.Location = new System.Drawing.Point(839, 527);
            this.buttonClearStatus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearStatus.Name = "buttonClearStatus";
            this.buttonClearStatus.Size = new System.Drawing.Size(176, 32);
            this.buttonClearStatus.TabIndex = 285;
            this.buttonClearStatus.Text = "Clear Status Messages";
            this.buttonClearStatus.UseVisualStyleBackColor = true;
            this.buttonClearStatus.Click += new System.EventHandler(this.buttonClearStatus_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackColor = System.Drawing.Color.White;
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUp.Location = new System.Drawing.Point(941, 61);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(51, 49);
            this.buttonUp.TabIndex = 286;
            this.buttonUp.UseVisualStyleBackColor = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackColor = System.Drawing.Color.White;
            this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDown.Location = new System.Drawing.Point(941, 116);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(51, 49);
            this.buttonDown.TabIndex = 287;
            this.buttonDown.UseVisualStyleBackColor = false;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.White;
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRight.Location = new System.Drawing.Point(998, 86);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(51, 49);
            this.buttonRight.TabIndex = 288;
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.White;
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLeft.Location = new System.Drawing.Point(884, 87);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(51, 49);
            this.buttonLeft.TabIndex = 289;
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // numericUpDownAdjust
            // 
            this.numericUpDownAdjust.DecimalPlaces = 1;
            this.numericUpDownAdjust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAdjust.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownAdjust.Location = new System.Drawing.Point(998, 142);
            this.numericUpDownAdjust.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownAdjust.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownAdjust.Name = "numericUpDownAdjust";
            this.numericUpDownAdjust.Size = new System.Drawing.Size(51, 22);
            this.numericUpDownAdjust.TabIndex = 291;
            this.numericUpDownAdjust.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonADCoffs
            // 
            this.buttonADCoffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADCoffs.Location = new System.Drawing.Point(487, 477);
            this.buttonADCoffs.Name = "buttonADCoffs";
            this.buttonADCoffs.Size = new System.Drawing.Size(172, 30);
            this.buttonADCoffs.TabIndex = 292;
            this.buttonADCoffs.Text = "ADC set offset";
            this.buttonADCoffs.UseVisualStyleBackColor = true;
            this.buttonADCoffs.Click += new System.EventHandler(this.buttonADCoffs_Click);
            // 
            // buttonCancelTest
            // 
            this.buttonCancelTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelTest.Location = new System.Drawing.Point(690, 350);
            this.buttonCancelTest.Name = "buttonCancelTest";
            this.buttonCancelTest.Size = new System.Drawing.Size(217, 31);
            this.buttonCancelTest.TabIndex = 293;
            this.buttonCancelTest.Text = "Pause Measurement";
            this.buttonCancelTest.UseVisualStyleBackColor = true;
            this.buttonCancelTest.Click += new System.EventHandler(this.buttonCancelTest_Click);
            // 
            // buttonTestReset
            // 
            this.buttonTestReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTestReset.Location = new System.Drawing.Point(690, 387);
            this.buttonTestReset.Name = "buttonTestReset";
            this.buttonTestReset.Size = new System.Drawing.Size(217, 30);
            this.buttonTestReset.TabIndex = 294;
            this.buttonTestReset.Text = "Reset Test";
            this.buttonTestReset.UseVisualStyleBackColor = true;
            this.buttonTestReset.Click += new System.EventHandler(this.buttonTestReset_Click);
            // 
            // buttonQuery
            // 
            this.buttonQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuery.Location = new System.Drawing.Point(9, 444);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(266, 28);
            this.buttonQuery.TabIndex = 295;
            this.buttonQuery.Text = "Query measurement";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // textBoxManualCommand
            // 
            this.textBoxManualCommand.Location = new System.Drawing.Point(9, 411);
            this.textBoxManualCommand.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxManualCommand.Multiline = true;
            this.textBoxManualCommand.Name = "textBoxManualCommand";
            this.textBoxManualCommand.Size = new System.Drawing.Size(197, 27);
            this.textBoxManualCommand.TabIndex = 296;
            // 
            // buttonSendManualCommand
            // 
            this.buttonSendManualCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendManualCommand.Location = new System.Drawing.Point(210, 411);
            this.buttonSendManualCommand.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSendManualCommand.Name = "buttonSendManualCommand";
            this.buttonSendManualCommand.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonSendManualCommand.Size = new System.Drawing.Size(66, 27);
            this.buttonSendManualCommand.TabIndex = 298;
            this.buttonSendManualCommand.Text = "Send";
            this.buttonSendManualCommand.UseVisualStyleBackColor = true;
            this.buttonSendManualCommand.Click += new System.EventHandler(this.buttonSendManualCommand_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(763, 424);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Name = "Zdata";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(392, 91);
            this.chart1.TabIndex = 299;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 741);
            this.Controls.Add(label21);
            this.Controls.Add(label20);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonSendManualCommand);
            this.Controls.Add(label19);
            this.Controls.Add(this.textBoxManualCommand);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.buttonTestReset);
            this.Controls.Add(this.buttonCancelTest);
            this.Controls.Add(this.buttonADCoffs);
            this.Controls.Add(this.numericUpDownAdjust);
            this.Controls.Add(label18);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonClearStatus);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(label17);
            this.Controls.Add(label16);
            this.Controls.Add(label15);
            this.Controls.Add(this.numericUpDownResolution);
            this.Controls.Add(this.numericUpDownYWidth);
            this.Controls.Add(this.numericUpDownXWidth);
            this.Controls.Add(label13);
            this.Controls.Add(label14);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxUARTonOff);
            this.Controls.Add(this.buttonStartUART);
            this.Controls.Add(label12);
            this.Controls.Add(this.buttonUARTdataRate);
            this.Controls.Add(this.textBoxUARTdataRate);
            this.Controls.Add(this.buttonZeroY);
            this.Controls.Add(this.buttonZeroX);
            this.Controls.Add(label10);
            this.Controls.Add(this.textBoxStepperSpeedY);
            this.Controls.Add(this.buttonSetStepperSpeed);
            this.Controls.Add(label9);
            this.Controls.Add(this.textBoxStepperSpeedX);
            this.Controls.Add(this.buttonStepXY);
            this.Controls.Add(this.buttonMoveXYabs);
            this.Controls.Add(label6);
            this.Controls.Add(label7);
            this.Controls.Add(this.textBoxYStepsABS);
            this.Controls.Add(this.textBoxXStepsABS);
            this.Controls.Add(this.buttonStepYabs);
            this.Controls.Add(this.buttonStepXabs);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(labelSteppers);
            this.Controls.Add(label3);
            this.Controls.Add(this.textBoxTappingFreq);
            this.Controls.Add(this.buttonSetTappingFreq);
            this.Controls.Add(this.buttonProbeDisable);
            this.Controls.Add(this.buttonProbeEnable);
            this.Controls.Add(this.buttonProbeDrop);
            this.Controls.Add(this.buttonProbeLift);
            this.Controls.Add(labelProbe);
            this.Controls.Add(this.buttonADCreset);
            this.Controls.Add(labelSPS);
            this.Controls.Add(labelADC);
            this.Controls.Add(this.buttonADCsps);
            this.Controls.Add(this.textBoxADCsps);
            this.Controls.Add(label8);
            this.Controls.Add(this.buttonClearOutgoing);
            this.Controls.Add(this.textBoxSerialOut);
            this.Controls.Add(this.buttonClearIncoming);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBoxSerialIn);
            this.Controls.Add(this.textBoxYSteps);
            this.Controls.Add(this.textBoxXSteps);
            this.Controls.Add(this.buttonStepY);
            this.Controls.Add(this.buttonStepX);
            this.Controls.Add(this.buttonClearChart);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBoxZPosition);
            this.Controls.Add(labelYPosition);
            this.Controls.Add(this.textBoxYPosition);
            this.Controls.Add(labelXPosition);
            this.Controls.Add(this.textBoxXPosition);
            this.Controls.Add(this.pictureBox_Status);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.buttonEnable);
            this.Controls.Add(this.buttonHomeXY);
            this.Controls.Add(label11);
            this.Controls.Add(this.buttonFilename);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.checkBoxSaveToFile);
            this.Controls.Add(this.labelSerial);
            this.Controls.Add(this.comboBoxCOMPorts);
            this.Controls.Add(this.buttonConnectDisconnect);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1200, 780);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MECH 423 Final Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdjust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ComboBox comboBoxCOMPorts;
        private System.Windows.Forms.Button buttonConnectDisconnect;
        private System.Windows.Forms.Label labelSerial;
        private System.Windows.Forms.Button buttonFilename;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.CheckBox checkBoxSaveToFile;
        private System.Windows.Forms.Button buttonHomeXY;
        private System.Windows.Forms.PictureBox pictureBox_Status;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button buttonEnable;
        private System.Windows.Forms.TextBox textBoxXPosition;
        private System.Windows.Forms.TextBox textBoxYPosition;
        private System.Windows.Forms.TextBox textBoxZPosition;
        private System.Windows.Forms.Button buttonClearChart;
        private System.Windows.Forms.Button buttonStepX;
        private System.Windows.Forms.Button buttonStepY;
        private System.Windows.Forms.TextBox textBoxXSteps;
        private System.Windows.Forms.TextBox textBoxYSteps;
        private System.Windows.Forms.Button buttonClearOutgoing;
        private System.Windows.Forms.TextBox textBoxSerialOut;
        private System.Windows.Forms.Button buttonClearIncoming;
        private System.Windows.Forms.TextBox textBoxSerialIn;
        private System.Windows.Forms.TextBox textBoxADCsps;
        private System.Windows.Forms.Button buttonADCsps;
        private System.Windows.Forms.Button buttonADCreset;
        private System.Windows.Forms.Button buttonProbeLift;
        private System.Windows.Forms.Button buttonProbeDrop;
        private System.Windows.Forms.Button buttonProbeEnable;
        private System.Windows.Forms.Button buttonProbeDisable;
        private System.Windows.Forms.Button buttonSetTappingFreq;
        private System.Windows.Forms.TextBox textBoxTappingFreq;
        private System.Windows.Forms.TextBox textBoxYStepsABS;
        private System.Windows.Forms.TextBox textBoxXStepsABS;
        private System.Windows.Forms.Button buttonStepYabs;
        private System.Windows.Forms.Button buttonStepXabs;
        private System.Windows.Forms.Button buttonMoveXYabs;
        private System.Windows.Forms.Button buttonStepXY;
        private System.Windows.Forms.TextBox textBoxStepperSpeedX;
        private System.Windows.Forms.Button buttonSetStepperSpeed;
        private System.Windows.Forms.TextBox textBoxStepperSpeedY;
        private System.Windows.Forms.Button buttonZeroX;
        private System.Windows.Forms.Button buttonZeroY;
        private System.Windows.Forms.TextBox textBoxUARTdataRate;
        private System.Windows.Forms.Button buttonUARTdataRate;
        private System.Windows.Forms.Button buttonStartUART;
        private System.Windows.Forms.TextBox textBoxUARTonOff;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown numericUpDownXWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownYWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownResolution;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonClearStatus;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownAdjust;
        private System.Windows.Forms.Button buttonADCoffs;
        private System.Windows.Forms.Button buttonCancelTest;
        private System.Windows.Forms.Button buttonTestReset;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.TextBox textBoxManualCommand;
        private System.Windows.Forms.Button buttonSendManualCommand;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

