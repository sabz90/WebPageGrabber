using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WebPageGrabber
{
    public partial class MainForm : Form
    {
        Thread GrabberThread;

        public MainForm()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void ReEnableGrabButton()
        {
            btGrab.Enabled = true;
            btAbort.Enabled = false;
        }
        private void btAbort_Click(object sender, EventArgs e)
        {

            try
            {
                GrabberThread.Abort();
                MessageBox.Show("Task aborted!");
                ReEnableGrabButton();
                UpdateStatusText("Task aborted!");
                label6.Text = "Task Aborted!";                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error aborting " + Environment.NewLine + "Details: " + ex.Message);
            }


        }
        private void btGrab_Click(object sender, EventArgs e)
        {

            try
            {
                //So the user has clicked the Grab Button! Before we start grabbing, we need to validate all the Input.

                //We start by gathering settings and this will be null if any setting is invalid
                SettingsObject settings = GetSettings();

                if (settings != null)
                {
                    //The settings are valid and we are good to go! 
                    btGrab.Enabled = false;
                    progressBar1.Value = 0;


                    //Create a new webGrabber object to start our work! :D
                    WebPageGrabber Grabber = new WebPageGrabber(settings);
                    GrabberThread = new Thread(() => Grabber.StartGrab());
                    GrabberThread.Start();

                    btAbort.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occured!" + Environment.NewLine + Environment.NewLine + "Details: " + Environment.NewLine + ex.Message);
            }
        }
        private SettingsObject GetSettings()
        {

            
            

            //Check if entered URL is valid
            if (!Utilities.IsUrlValid(tbURL.Text))
            {
                UpdateStatusText("Invalid URL! Make sure you begin with http://");
                return null;
            }

            //Get Destination Folder
            string DestinationFolder = Utilities.GetFolderSelection();
            if (DestinationFolder == string.Empty || !System.IO.Directory.Exists(DestinationFolder))
            {
                //Error due to invalid Directory.
                UpdateStatusText("Invalid Directory! Please try again and select a correct directory.");     
                return null;
            }
            

            //Check Other Settings
            tbSavePath.Text = DestinationFolder;
            tbProgress.Clear();

            //validate depth


            //Create new Settings Object:
            SettingsObject Settings = new SettingsObject(this);
            Settings.DestinationFolder = DestinationFolder;
            Settings.Depth = Convert.ToInt16( tbDepth.Text);
            Settings.URL = tbURL.Text;
            
            

            return Settings;
        }

        private void UpdateStatusText(string msg)
        {
            lbStatusText.Text = msg;

            tbProgress.Text += msg + Environment.NewLine;
            tbProgress.SelectionStart = tbProgress.Text.Length;
            tbProgress.ScrollToCaret();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbDepth.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tbDepth.Text.Remove(tbDepth.Text.Length - 1);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cbResolveRelativePath_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
