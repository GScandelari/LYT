using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace LogYourTime
{
    public partial class Form1 : Form
    {
        String output;
        DateTime Start, End, Pause;
        TimeSpan duration;
        MemoryStream userInput = new MemoryStream();
        internal SaveFileDialog SaveFileDialog1;
        bool paused = false;

        public Form1()
        {
            InitializeComponent();
            Disclaimer();

        }

        //Form load
        private void Form1_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnSaveLogs.Enabled = true;
            output = "Welcome to LogYourTime." +
                "\nBefore starting tracking your time" +
                "\nEnter with the Case ID and then click on Start to begin." +
                "\n_______________________________________________\n";
            LogOutPut(output);
        }


        //Buttons

        //Start tracking
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (txbCaseID.Text == "")
            {
                output = "Case ID is empty.";
                LogOutPut(output);
            }

            else
            {
                btnStart.Enabled = false;
                btnPause.Enabled = true;
                btnStop.Enabled = true;
                btnSaveLogs.Enabled = false;
                txbCaseID.Enabled = false;
                paused = false;

                Start = DateTime.Now;

                output = "\nCase ID: " + txbCaseID.Text +
                    " Started at: " + DateTime.Now.ToLongTimeString() +
                    " Date: " + DateTime.Now.ToShortDateString();
                LogOutPut(output);
            }
        }

        //pause button
        private void BtnPause_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = true;
            btnSaveLogs.Enabled = false;
            txbCaseID.Enabled = false;

            paused = true;

            Pause = DateTime.Now;
            duration = duration + (Pause - Start);

            output = "Case ID: " + txbCaseID.Text +
                " Ended at: " + DateTime.Now.ToLongTimeString() +
                " Date: " + DateTime.Now.ToShortDateString() +
                "\n\rTotal Duration so far (D:H:m:s): " +
                duration.Days.ToString() + ":" +
                duration.Hours.ToString() + ":" +
                duration.Minutes.ToString() + ":" +
                duration.Seconds.ToString() +
                "\nClick on 'Stop' to stop the counter." +
                "\nClick on 'Start' to continue the counter.";
            LogOutPut(output);
        }

        //Stop counter
        private void BtnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnSaveLogs.Enabled = true;
            txbCaseID.Enabled = true;

            End = DateTime.Now;
            if (paused == false)
            {
                duration = duration + (End - Start);
                output = "Case ID: " + txbCaseID.Text +
                    " Ended at: " + DateTime.Now.ToLongTimeString() +
                    " Date: " + DateTime.Now.ToShortDateString() +
                    "\n\rTotal Duration (D:H:m:s): " +
                    duration.Days.ToString() + ":" +
                    duration.Hours.ToString() + ":" +
                    duration.Minutes.ToString() + ":" +
                    duration.Seconds.ToString() +
                    "\n_______________________________________________\n";
                LogOutPut(output);
                duration = duration - duration;
            }
            else if (paused)
            {
                output = "Case ID: " + txbCaseID.Text +
                    " Ended at: " + DateTime.Now.ToLongTimeString() +
                    " Date: " + DateTime.Now.ToShortDateString() +
                    "\n\rTotal Duration (D:H:m:s): " +
                    duration.Days.ToString() + ":" +
                    duration.Hours.ToString() + ":" +
                    duration.Minutes.ToString() + ":" +
                    duration.Seconds.ToString() +
                    "\n_______________________________________________\n";
                LogOutPut(output);
                duration = duration - duration;
            }
            paused = false;
        }

        //Saving logs
        private void BtnSaveLogs_Click(object sender, EventArgs e)
        {
            SaveFileDialog1 = new SaveFileDialog();
            txbLogs.SaveFile(userInput, RichTextBoxStreamType.PlainText);
            userInput.WriteByte(13);

            // Set the file name to myTimeTracking + datetime in binary, set the type filter
            // to text files, and set the initial directory to the 
            // MyDocuments folder.

            DateTime time = DateTime.Now;
            String s = time.ToString("yyyy-MM-dd-HHmmss");
            SaveFileDialog1.FileName = "myTimeTracking-" + s.ToString() + ".txt";

            // DefaultExt is only used when "All files" is selected from 
            // the filter box and no extension is specified by the user.
            SaveFileDialog1.DefaultExt = "txt";
            SaveFileDialog1.Filter =
                "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            SaveFileDialog1.InitialDirectory =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Call ShowDialog and check for a return value of DialogResult.OK,
            // which indicates that the file was saved. 
            DialogResult result = SaveFileDialog1.ShowDialog();
            Stream fileStream;

            if (result == DialogResult.OK)
            {
                // Open the file, copy the contents of memoryStream to fileStream,
                // and close fileStream. Set the memoryStream.Position value to 0 
                // to copy the entire stream. 
                fileStream = SaveFileDialog1.OpenFile();
                userInput.Position = 0;
                userInput.WriteTo(fileStream);
                fileStream.Close();
                tslblSaveStatus.Text = "Saved in: " + time.ToShortTimeString();
            }
            
        }

        //Form control

        //AutoScroll trigger
        private void TxbLogs_TextChanged(object sender, EventArgs e)
        {
            txbLogs.SelectionStart = txbLogs.Text.Length;
            txbLogs.ScrollToCaret();
        }

        //output data on richtextbox
        private void LogOutPut(String data)
        {
            if (!string.IsNullOrWhiteSpace(txbLogs.Text))
            {
                txbLogs.AppendText("\r\n" + data);
            }
            else
            {
                txbLogs.AppendText(data);
            }
            txbLogs.ScrollToCaret();
        }

        private void DisclaimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Disclaimer();
        }

        private void SourceCodeOnGitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/GScandelari/LYT");
            Process.Start(sInfo);
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This page is under construction. Please contact Guilherme Scandelari for further information on gscandelar@wiley.com",
                "Help page not available",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        //Closing event
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to Exit?\nAll logs will be lost if they are not saved.",
                       Form1.ActiveForm.Text + " - Exit",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //Get datetime
        private void DateTimePicker_getDate(object sender, EventArgs e)
        {
            lblDateTime_Date.Text = DateTime.Today.ToLongDateString();
        }

        private void Disclaimer()
        {
            MessageBox.Show("This software is an Open Source project and was created by `Guilherme Stanke Scandelar` for testing and non-profit purposes." +
                "\nThe code is available at https://github.com/GScandelari/LYT",
                "Disclaimer",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}
