using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using System.Windows.Forms.DataVisualization.Charting;

namespace MECH423_Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StreamWriter outputFile;
        long timeIntervals = 0;

        ConcurrentQueue<Int32> adcQueue = new ConcurrentQueue<Int32>(); // store data packet transmission
        ConcurrentQueue<Int32> xQueue = new ConcurrentQueue<Int32>();
        ConcurrentQueue<Int32> yQueue = new ConcurrentQueue<Int32>();

        // SCPI queue
        ConcurrentQueue<String> commandQueue = new ConcurrentQueue<String>();
        ConcurrentQueue<String> debugMsgQueue = new ConcurrentQueue<String>();


        int runState = 0; // 0 for STOP, 1 for RUN
        int Xsteps = 0, Ysteps = 0;

        int ADCsps = 0;
        int tappingFreq = 0; // Frequency of probe
        int stepperSpeedX = 0, stepperSpeedY = 0;
        int UARTrate = 100; // [Hz] - 100 default
        bool UART_TFR_ON = false;

        bool bufferReady = true;

        /* unit conversion */
        int adcCounts, XpositionSteps, YpositionSteps;
        double zMM, xMM, yMM;
        double counts_to_cN = 0.03;
        double counts_offset = 0.00;
        double force_to_mm = (1.0 / 19600) * 1000;  // 19600 cN/m

        double sampleWidthX = 2, sampleWidthY = 2;
        double XYResolution = 0.5;
        double probeAdjustResolution = 1.0;
        bool testRunning = false;

        int Xmm2steps = 800, Ymm2steps = 400;
        double Xsteps2mm = 1.0 / 800, Ysteps2mm = 1.0 / 400;

        int sampleRows, sampleColumns;
        int maxPlotDataPoints = 30;

        // ~~~~~~~~~~~~~~~~~ FORM LOADING ~~~~~~~~~~~~~~~~~~~~~
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCOMPorts.Items.Clear();
            comboBoxCOMPorts.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (comboBoxCOMPorts.Items.Count == 0)
                comboBoxCOMPorts.Text = "No COM ports!";
            else if (comboBoxCOMPorts.Items.Count > 2)
                comboBoxCOMPorts.SelectedIndex = 2; // Select COM4 by default

            //MessageBox.Show("MECH 423 - FINAL PROJECT \n\nDavid Antoniuk and Joshua Ho\n08-DEC-2023 \n\nClick OK to begin.");
            textBoxStatus.AppendText("Startup Sequence Complete \r\n--> Click ENABLE to begin \r\n");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Dispose();
        }

        // ~~~~~~~~~~~~~~~~~ SERIAL PORT ~~~~~~~~~~~~~~~~~~~~~
        private void comboBoxCOMPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.Dispose();
            string newCOMPort = comboBoxCOMPorts.Text;
            serialPort1.PortName = newCOMPort; // update serial port COM if changed from dropdown
        }

        private void comboBoxCOMPorts_DropDownClosed(object sender, EventArgs e)
        {
            labelSerial.Focus(); // Added to remove highlighting of dropdown menu entries
        }

        private void buttonConnectDisconnect_Click(object sender, EventArgs e)
        {
            string nameCOMPort = "";
            if (comboBoxCOMPorts.Text != "")
                nameCOMPort = comboBoxCOMPorts.Text;
            else
                MessageBox.Show("No COM Port Selected", "Error");

            // Open or close port, depending on current state
            if (serialPort1.IsOpen)
            {
                serialPort1.Dispose();
                buttonConnectDisconnect.Text = "Connect Serial"; // If disconnected, change button to connect
            }
            else if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = nameCOMPort;
                serialPort1.Open();
                buttonConnectDisconnect.Text = "Disconnect Serial"; // If connected, change button to disconnect
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string bufferString = serialPort1.ReadLine();
            int adcCounts, Xposition, Yposition;

            if (bufferString.Contains("__DATA__"))
            {
                string[] split = bufferString.Split(',');

                //Console.WriteLine(bufferString); // for debugging

                adcCounts = Convert.ToInt32(split[1]);
                Xposition = Convert.ToInt32(split[2]);
                Yposition = Convert.ToInt32(split[3]);

                adcQueue.Enqueue(adcCounts);
                xQueue.Enqueue(Xposition);
                yQueue.Enqueue(Yposition);
            }

            if (bufferString.Contains(">"))
            {
                bufferReady = true;
            }
        }

        private void buttonClearOutgoing_Click(object sender, EventArgs e)
        {
            textBoxSerialOut.Text = ""; // clear outgoing data
        }

        private void buttonClearIncoming_Click(object sender, EventArgs e)
        {
            textBoxSerialIn.Text = ""; // clear incoming data
        }


        // ~~~~~~~~~~~~~~~~~ SAVE TO FILE ~~~~~~~~~~~~~~~~~~~~~
        private void buttonFilename_Click(object sender, EventArgs e)
        {
            SaveFileDialog myDialogBox = new SaveFileDialog();
            myDialogBox.InitialDirectory = @"C:\Users\david\Documents\UBC Engineering\Year 4 Mechatronics\MECH 423 - Mechatronic Product Design\MECH423_Final_Project_Data";
            myDialogBox.ShowDialog();
            textBoxFileName.Text = myDialogBox.FileName.ToString() + ".CSV";
        }

        private void checkBoxSaveToFile_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSaveToFile.Checked == true)
                outputFile = new StreamWriter(textBoxFileName.Text);
            else
                outputFile.Close();
        }

        // ~~~~~~~~~~~~~~~~~ COMMANDS ~~~~~~~~~~~~~~~~~~~~~

        private void buttonHomeXY_Click(object sender, EventArgs e)
        {
            String homeCmd = "coil:lift; XY:SP 3000,3000; Join; XY:abs 0,0; Join; coil:off; XY:SP 100,100";
            sendSCPI(homeCmd);
            textBoxStepperSpeedX.Text = 100.ToString();
            textBoxStepperSpeedY.Text = 100.ToString();
        }

        private void buttonZeroX_Click(object sender, EventArgs e)
        {
            sendSCPI("X:zero");
        }

        private void buttonZeroY_Click(object sender, EventArgs e)
        {
            sendSCPI("Y:zero");
        }

        private void buttonStepX_Click(object sender, EventArgs e)
        {
            Xsteps = Convert.ToInt32(textBoxXSteps.Text);
            sendSCPI("X:step " + textBoxXSteps.Text);
        }

        private void buttonStepY_Click(object sender, EventArgs e)
        {
            Ysteps = Convert.ToInt32(textBoxYSteps.Text);
            sendSCPI("Y:step " + textBoxYSteps.Text);
        }

        private void buttonStepXY_Click(object sender, EventArgs e)
        {
            Xsteps = Convert.ToInt32(textBoxXSteps.Text);
            Ysteps = Convert.ToInt32(textBoxYSteps.Text);
            sendSCPI("XY:step " + textBoxXSteps.Text + "," + textBoxYSteps.Text);
        }

        private void buttonStepXabs_Click(object sender, EventArgs e)
        {
            Xsteps = Convert.ToInt32(textBoxXStepsABS.Text);
            sendSCPI("Join; X:abs " + textBoxXStepsABS.Text);
        }

        private void buttonStepYabs_Click(object sender, EventArgs e)
        {
            Ysteps = Convert.ToInt32(textBoxYStepsABS.Text);
            sendSCPI("Join; Y:abs " + textBoxYStepsABS.Text);
        }

        private void buttonMoveXYabs_Click(object sender, EventArgs e)
        {
            Xsteps = Convert.ToInt32(textBoxXStepsABS.Text);
            Ysteps = Convert.ToInt32(textBoxYStepsABS.Text);
            sendSCPI("Join; XY:abs " + textBoxXStepsABS.Text + "," + textBoxYStepsABS.Text);
        }

        private void buttonSetStepperSpeed_Click(object sender, EventArgs e)
        {
            stepperSpeedX = Convert.ToInt32(textBoxStepperSpeedX.Text);
            stepperSpeedY = Convert.ToInt32(textBoxStepperSpeedY.Text);
            sendSCPI("XY:SP " + textBoxStepperSpeedX.Text + "," + textBoxStepperSpeedY.Text);
        }

        private void buttonEnable_Click(object sender, EventArgs e)
        {
            runState = 1; // ENABLED
            updateStatusIcon();
            textBoxStatus.AppendText("System enabled \r\n");

            sendSCPI("XY:EN");

            UART_TFR_ON = false;
            buttonStartUART_Click(sender, e); // Call button click function for UART enable/disable
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            runState = 0; // STOPPED
            updateStatusIcon();
            textBoxStatus.AppendText("E-STOP activated \r\n");
            sendSCPI("XY:DIS");
            sendSCPI("coil:off");
        }

        private void buttonADCsps_Click(object sender, EventArgs e)
        {
            ADCsps = Convert.ToInt32(textBoxADCsps.Text);
            sendSCPI("adc:drate " + textBoxADCsps.Text);
        }

        private void buttonADCreset_Click(object sender, EventArgs e)
        {
            sendSCPI("adc:reset");
        }

        private void buttonProbeLift_Click(object sender, EventArgs e)
        {
            sendSCPI("coil:lift");
        }

        private void buttonProbeDrop_Click(object sender, EventArgs e)
        {
            sendSCPI("coil:drop");
        }

        private void buttonADCoffs_Click(object sender, EventArgs e)
        {
            sendSCPI("adc:offs");
        }

        private void buttonCancelTest_Click(object sender, EventArgs e)
        {
            testRunning = false;
            timer2.Enabled = false;
            textBoxStatus.AppendText("Test paused by user\r\n");
            buttonTestReset.Enabled = true;
            bufferReady = true;
        }

        private void buttonProbeEnable_Click(object sender, EventArgs e)
        {
            sendSCPI("coil:on");
        }

        private void buttonTestReset_Click(object sender, EventArgs e)
        {
            if(testRunning == false)
            {
                commandQueue = new ConcurrentQueue<String>();
                debugMsgQueue = new ConcurrentQueue<String>();
                textBoxStatus.AppendText("Command queue reset\r\n");
                buttonStart.Text = "START MEASUREMENT";
            }
            else
            {
                textBoxStatus.AppendText("Cannot reset while test running\r\n");
            }
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            sendSCPI("sys:log 0; pause 200; meas?");
            bufferReady = true;         // Force true. Not necessarily the best but it works around sys:log toggling issues
        }

        private void buttonProbeDisable_Click(object sender, EventArgs e)
        {
            sendSCPI("coil:off");
        }

        private void buttonSetTappingFreq_Click(object sender, EventArgs e)
        {
            tappingFreq = Convert.ToInt32(textBoxTappingFreq.Text);
            sendSCPI("coil:f " + textBoxTappingFreq.Text); 
        }

        private void buttonUARTsetTransferRate_Click(object sender, EventArgs e)
        {
            UARTrate = Convert.ToInt32(textBoxUARTdataRate.Text);
            sendSCPI("SYS:drate " + textBoxUARTdataRate.Text);
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            probeAdjustResolution = (double)numericUpDownAdjust.Value;
            Ysteps = (int)(probeAdjustResolution * Ymm2steps);
            sendSCPI("Y:step " + Ysteps);
        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            probeAdjustResolution = (double)numericUpDownAdjust.Value;
            Ysteps = (int)(probeAdjustResolution * Ymm2steps*-1);
            sendSCPI("Y:step " + Ysteps);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            probeAdjustResolution = (double)numericUpDownAdjust.Value;
            Xsteps = (int)(probeAdjustResolution * Xmm2steps*-1); // CHECK DIRECTIONS
            sendSCPI("X:step " + Xsteps);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            probeAdjustResolution = (double)numericUpDownAdjust.Value;
            Xsteps = (int)(probeAdjustResolution * Xmm2steps); // CHECK DIRECTIONS
            sendSCPI("X:step " + Xsteps);
        }

        private void buttonSendManualCommand_Click(object sender, EventArgs e)
        {
            sendSCPI(textBoxManualCommand.Text);
        }

        private void buttonClearChart_Click(object sender, EventArgs e)
        {
            chart1.Series["Zdata"].Points.Clear();
        }

        private void buttonStartUART_Click(object sender, EventArgs e)
        {
            if (UART_TFR_ON == false)
            {
                UART_TFR_ON = true;
                sendSCPI("SYS:log 1");
                textBoxUARTonOff.Text = "ON";
                buttonStartUART.Text = "Stop UART Transfer";
            }
            else if (UART_TFR_ON == true)
            {
                UART_TFR_ON = false;
                sendSCPI("SYS:log 0");
                textBoxUARTonOff.Text = "OFF";
                buttonStartUART.Text = "Start UART Transfer";
            }
        }

        private void startTest()
        {
            if (testRunning == true)
            {
                textBoxStatus.AppendText("Test already running\r\n");
            }
            if (testRunning == false && buttonStart.Text.Contains("RESUME MEASUREMENT"))
            {
                testRunning = true;
                textBoxStatus.AppendText("Measurement started\r\n");
                timer2.Enabled = true;          // Start the async timer
            }
            if (testRunning == false && buttonStart.Text.Contains("START MEASUREMENT"))
            {
                testRunning = true; // Reset this to start
                buttonStart.Text = "RESUME MEASUREMENT";
                buttonTestReset.Enabled = false;
                textBoxStatus.AppendText("Measurement started\r\n");
                timer2.Enabled = true;          // Start the async timer
                sampleWidthX = (double)numericUpDownXWidth.Value;
                sampleWidthY = (double)numericUpDownYWidth.Value;
                XYResolution = (double)numericUpDownResolution.Value;

                sampleRows = (int)(sampleWidthY / XYResolution) + 1;
                sampleColumns = (int)(sampleWidthX / XYResolution) + 1;

                int incrementX = (int)(XYResolution * Xmm2steps);
                int incrementY = (int)(XYResolution * Ymm2steps);

                int Xtarget = 0;
                int Ytarget = 0;

                sendSCPIasync("coil:lift; XY:sp 3000,3000; XY:abs 0,0; join", "SETUP\r\n");

                for (int currentRow = 0; currentRow < sampleRows; currentRow++) // Step along Y axis
                {
                    sendSCPIasync("join;XY:sp 120,120", "SET SPEED\r\n");  // Set slow speed for scans
                    Ytarget = incrementY * currentRow;
                    sendSCPIasync("join;Y:abs " + (Ytarget), "INCREMENT Y\r\n");
                    sendSCPIasync("join;coil:off", $"Measuring row {currentRow + 1} of {sampleRows}...\r\n");         // Drop or switch off coil for measurement                                                                                                 //textBoxStatus.AppendText("Measuring row " + (currentRow+1) + " of " + sampleRows + "...\r\n");
                    sendSCPIasync("pause 600");
                    for (int currentColumn = 0; currentColumn < sampleColumns; currentColumn++)
                    {
                        Xtarget = incrementX * currentColumn;
                        sendSCPIasync("join;X:abs " + (Xtarget), "INCREMENT X\r\n");
                        sendSCPIasync("join;pause 150", $"MEASURE X{Xtarget} Y{Ytarget}\r\n");
                    }
                    //sendSCPIasync("join", $"MEASURE X{Xtarget} Y{Ytarget}\r\n");
                    sendSCPIasync("join; coil:lift", "LIFT PROBE\r\n");                       // Lift coil for travel
                    sendSCPIasync("join; XY:sp 5000,5000; X:abs 0", "Row done\r\n");  // Reset X at fast speed
                }
                sendSCPIasync("join;coil:lift;XY:sp 4000,4000;XY:abs 0,0", "RESET PROBE\r\n");
                sendSCPIasync("join;coil:off", "Measurement grid complete\r\n");
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            startTest();
        }
        private void buttonClearStatus_Click(object sender, EventArgs e)
        {
            textBoxStatus.Text = ""; // Clear status messages
        }

        // ~~~~~~~~~~~~~~~~~ TIMERS ~~~~~~~~~~~~~~~~~~~~~

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (adcQueue.TryDequeue(out adcCounts))
            {
                zMM = counts_to_cN * adcCounts * force_to_mm;
                textBoxZPosition.Text = adcCounts.ToString();
            }
                
            if (xQueue.TryDequeue(out XpositionSteps))
            {
                xMM = XpositionSteps * Xsteps2mm;
                textBoxXPosition.Text = (xMM).ToString("00.000");
            }
            if (yQueue.TryDequeue(out YpositionSteps))
            {
                yMM = YpositionSteps * Ysteps2mm;
                textBoxYPosition.Text = (yMM).ToString("00.000");
                textBoxSerialIn.AppendText(adcCounts.ToString() + " , " + XpositionSteps.ToString() + " , " + YpositionSteps.ToString() + " // ");
                
               /* if (checkBoxSaveToFile.Checked == true) // Save to File if enabled
                {
                    timeIntervals++;
                    outputFile.Write(timeIntervals.ToString() + ", " 
                                  + XpositionSteps.ToString() + ", " 
                                  + YpositionSteps.ToString() + ", " 
                                  + adcCounts1.ToString() + "\n");
                }*/
            }
        }


        // Timer2 specifically for async test execution
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen && (bufferReady))
            {
                bufferReady = false;
                String output, debugOut;
                if (commandQueue.TryDequeue(out output) && debugMsgQueue.TryDequeue(out debugOut))
                {
                    serialPort1.WriteLine(output);
                    textBoxSerialOut.AppendText(output); // display outgoing string in text box
                    textBoxSerialOut.AppendText(" // ");

                    textBoxStatus.AppendText(debugOut);

                    if (debugOut.Contains("MEASURE"))
                    {
                        string x = textBoxXPosition.Text;
                        string y = textBoxYPosition.Text;
                        string z = textBoxZPosition.Text;
                        /*double x = xMM;
                        double y = yMM;
                        double z = adcCounts;*/
                        textBoxStatus.AppendText($"{x},{y},{z}\r\n");
                        if (checkBoxSaveToFile.Checked == true) // Save to File if enabled
                        {
                            outputFile.Write(x.ToString() + ", "
                                           + y.ToString() + ", "
                                           + z.ToString() + "\n");
                        }

                        chart1.Series["Zdata"].Points.AddY(Convert.ToInt32(z));

                        if (chart1.Series["Zdata"].Points.Count() >= maxPlotDataPoints)
                        {
                            chart1.Series["Zdata"].Points.RemoveAt(0);
                            chart1.ResetAutoValues();
                        }
                    }

                    if (debugOut.Contains("Measurement grid complete\r\n"))
                    {
                        testRunning = false;
                        buttonStart.Text = "START MEASUREMENT";
                        timer2.Enabled = false;
                    }
                }
            }
        }

        // ~~~~~~~~~~~~~~~~~ FUNCTIONS ~~~~~~~~~~~~~~~~~~~~~

        private void clearDataQueues()
        {
            adcQueue = new ConcurrentQueue<int>();
            xQueue = new ConcurrentQueue<int>();
            yQueue = new ConcurrentQueue<int>();
        }
        private void sendSCPI(string outputString)
        {
            DateTime startTime, endTime;
            startTime = DateTime.Now;
            double timeout = 1000;

            // This is blocking, with a 1 second timeout in case of desync.
            while (true)
            {
                endTime = DateTime.Now;
                Double elapsedMillisecs = ((TimeSpan)(endTime - startTime)).TotalMilliseconds;
                if (serialPort1.IsOpen && (bufferReady||elapsedMillisecs > timeout))
                {
                    serialPort1.WriteLine(outputString);
                    textBoxSerialOut.AppendText(outputString); // display outgoing string in text box
                    textBoxSerialOut.AppendText(" // ");
                    break;
                }
                else if (!serialPort1.IsOpen)
                {
                    // MessageBox.Show("ERROR: Serial port is not open. Cannot send data.");
                    textBoxStatus.AppendText("ERROR: Serial port is not open\r\n");
                    break;
                }

                bufferReady = false;
            }
        }

        private void sendSCPIasync(string outputString, string debugMsg = "")
        {
            // This is not blocking.
            commandQueue.Enqueue(outputString);
            debugMsgQueue.Enqueue(debugMsg);
        }

        private void updateStatusIcon()
        {
            if (runState == 1)
                pictureBox_Status.BackColor = Color.PaleGreen;
            else
                pictureBox_Status.BackColor = Color.Red;
        }
    }
}





// 3D Surface Plot Example to explore... 
/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using delRendererFunction = Plot3D.Graph3D.delRendererFunction;
using cPoint3D = Plot3D.Graph3D.cPoint3D;
using eRaster = Plot3D.Graph3D.eRaster;
using cScatter = Plot3D.Graph3D.cScatter;
using eNormalize = Plot3D.Graph3D.eNormalize;
using eSchema = Plot3D.ColorSchema.eSchema;

namespace _3D_Chart_Graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formula_Click(object sender, EventArgs e)
        {
            SetFormula("12 * sin(x) * cos(y) / (sqrt(sqrt(x * x + y * y)) + 0.2)");
            graph3D1.Raster = (eRaster)1;
            Color[] c_Colors = Plot3D.ColorSchema.GetSchema((eSchema)1);
            graph3D1.SetColorScheme(c_Colors, 3);
        }

        private void show_all_Click(object sender, EventArgs e)
        {
            new Plot3D.Graph3DMainForm().ShowDialog();
        }

        private void surface_Click(object sender, EventArgs e)
        {
            #region Data
            int[,] values = new int[,]
            {
        { 34767, 34210, 33718, 33096, 32342, 31851, 31228, 30867, 31457, 30867, 30266, 28934, 27984, 26492, 25167, 25167, 25167},
        { 34669, 34210, 33653, 33096, 32539, 32047, 31490, 30933, 31293, 30671, 29983, 28803, 27886, 26492, 25167, 25167, 25167},
        { 34603, 34144, 33718, 33227, 32768, 32342, 31719, 30999, 31228, 30333, 29622, 28606, 27886, 26492, 25167, 25167, 25167},
        { 34472, 34079, 33653, 33161, 32768, 32408, 31785, 31162, 30802, 30048, 29360, 28312, 27755, 26367, 25049, 25049, 25049},
        { 34210, 33784, 33423, 33161, 32801, 32408, 31785, 31097, 30474, 29622, 29000, 28115, 27623, 26367, 25049, 25049, 25049},
        { 33980, 33587, 33161, 32935, 32588, 32342, 31621, 30802, 29852, 29000, 28377, 27689, 27421, 26367, 25049, 25049, 25049},
        { 33522, 33227, 32702, 32615, 32452, 31851, 30933, 30179, 29295, 28358, 27984, 27132, 27301, 26367, 25049, 25049, 25049},
        { 32672, 32178, 31916, 31469, 31246, 30540, 29852, 29065, 28377, 27623, 27263, 26706, 26935, 26367, 25049, 25049, 25049},
        { 30769, 30423, 29917, 29231, 29392, 28705, 28075, 27726, 27263, 26691, 26417, 26182, 26575, 26575, 25246, 25246, 25246},
        { 27525, 27518, 26701, 27334, 27682, 27402, 26903, 26707, 26444, 25887, 25719, 25690, 26122, 26122, 26122, 26122, 26122},
        { 23475, 23888, 24478, 25330, 26212, 26199, 25701, 25664, 25740, 25013, 24904, 25068, 25374, 25374, 25374, 25374, 25374},
        { 20677, 21445, 22544, 23593, 24441, 24785, 24538, 24644, 24773, 24299, 24062, 24576, 24510, 24510, 24510, 24510, 24510},
        { 18743, 19792, 20808, 22086, 22805, 23167, 23486, 23366, 23757, 23411, 23691, 23822, 23822, 23822, 23822, 23822, 23822},
        { 17334, 18579, 19497, 20775, 21463, 21848, 22288, 22446, 22643, 22446, 22643, 22708, 23069, 23069, 23069, 23069, 23069},
        { 16155, 17236, 18350, 19399, 20251, 20677, 21016, 21332, 21660, 21791, 21889, 21955, 22217, 22217, 22217, 22217, 22217},
        { 14746, 15860, 17039, 17990, 18842, 19595, 20050, 20349, 20546, 20840, 20972, 20972, 21332, 21332, 21332, 21332, 21332},
        { 13337, 14516, 15729, 16679, 17564, 18514, 18907, 19169, 19399, 19661, 19792, 19594, 20152, 20152, 20152, 20152, 20152},
        { 12452, 13435, 14615, 15499, 16253, 17105, 17596, 17924, 18153, 18285, 18428, 18776, 19104, 19104, 19104, 19104, 19104},
        { 11469, 12354, 13533, 14287, 15008, 15925, 16187, 16482, 16690, 16976, 17105, 17302, 17531, 17531, 17531, 17531, 17531},
        { 10486, 11370, 12255, 13009, 13861, 14746, 15172, 15368, 15434, 15630, 15794, 15991, 16351, 16351, 16351, 16351, 16351},
        { 9684, 10387, 11141, 11796, 12546, 13337, 14029, 14320, 14549, 14811, 14939, 15434, 15794, 15794, 15794, 15794, 15794},
        { 9059, 9634, 10617, 11141, 11838, 12681, 13411, 13861, 14121, 14624, 14868, 15172, 15368, 15368, 15368, 15368, 15368},
            };
            #endregion
            SetSurface(values);
            graph3D1.Raster = (eRaster)3;
            Color[] c_Colors = Plot3D.ColorSchema.GetSchema((eSchema)2);
            graph3D1.SetColorScheme(c_Colors, 3);
        }
        private void SetFormula(string s_Formula)
        {
            try
            {
                delRendererFunction f_Function = Plot3D.FunctionCompiler.Compile(s_Formula);

                // IMPORTANT: Normalize maintainig the relation between X,Y,Z values otherwise the function will be distorted.
                graph3D1.SetFunction(f_Function, new PointF(-10, -10), new PointF(10, 10), 0.5, eNormalize.MaintainXYZ);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetSurface(int[,] s32_Values)
        {
            cPoint3D[,] i_Points3D = new cPoint3D[s32_Values.GetLength(0), s32_Values.GetLength(1)];
            for (int X = 0; X < s32_Values.GetLength(0); X++)
            {
                for (int Y = 0; Y < s32_Values.GetLength(1); Y++)
                {
                    i_Points3D[X, Y] = new cPoint3D(X * 10, Y * 500, s32_Values[X, Y]);
                }
            }

            // Setting one of the strings = null results in hiding this legend
            graph3D1.AxisX_Legend = "MAP (kPa)";
            graph3D1.AxisY_Legend = "Engine Speed (rpm)";
            graph3D1.AxisZ_Legend = "ADS";

            // IMPORTANT: Normalize X,Y,Z separately because there is an extreme mismatch
            // between X values (< 300) and Z values (> 30000)
            graph3D1.SetSurfacePoints(i_Points3D, eNormalize.Separate);
        }
    }
}
*/