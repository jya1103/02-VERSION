using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.IO;

/*FileName, DirectoryName, Attributes, Size, LastWrite, LastAccess, CreationTime, Security*/

namespace TrackFileActivites
{
    public partial class frmTrackFileActivites : Form
    {
        //This flag is for closing the application if it is raised from context menu.
        bool boolContextFormClose = false;

        string strWorkPath = "";

        private int hwdfrmTrackLog;

        //Import this function
        [DllImport("user32.dll")]
        public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

        public frmTrackFileActivites()
        {
            InitializeComponent();

            //Initialize the handle value for frmTrackLog
            hwdfrmTrackLog = -1;

            //Set the default location of the window
      this.Location = new System.Drawing.Point(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - 950, System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - 400);

            //If path is already defined, then display it in the track textbox
            /*Registory Path = My Computer\HKEY_LOCAL_MACHINE\SOFTWARE\TrackFileActivitesSumit\*/


            RegistryKey rk = Registry.LocalMachine;


            RegistryKey rkOpenTrack = rk.OpenSubKey("SOFTWARE\\" + "TrackFileActivitesSumit\\TrackPath");
            if (rkOpenTrack != null)
            {
                txtSetPath.Text = rkOpenTrack.GetValue("Path").ToString();
            }
//WorkPath
            /*
                        //If path is already defined, then display it in the work textbox
                        RegistryKey rkOpenWork = rk.OpenSubKey("SOFTWARE\\" + "TrackFileActivitesSumit\\WorkPath");
                        if (rkOpenWork != null)
                        {
                            txtWorkPath.Text = rkOpenWork.GetValue("Path").ToString();

                            //Set the Directory Path based on the date
                            strWorkPath = txtWorkPath.Text + "\\" + System.DateTime.Now.Day.ToString() + "-" + System.DateTime.Now.Month.ToString() + "-" + System.DateTime.Now.Year.ToString();
                            //Create the directory if it is not created
             
                            if (!Directory.Exists(strWorkPath))
                            {
                                Directory.CreateDirectory(strWorkPath);
                            }
                            //Set the File Name
                            strWorkPath = strWorkPath + "\\TrackFileActivities.log";
                            //Create the file if it is not created
                            if (!File.Exists(strWorkPath))
                            {
                                TextWriter tw = new StreamWriter(strWorkPath);
                                tw.Close();
                            }

                        } 
             */
        }


        private void btnSetPath_Click(object sender, EventArgs e)
        {
            try
            {
                //If path is already defined, then set the selected path for folderBrowserDialog control
                RegistryKey rk = Registry.LocalMachine;
                RegistryKey rkOpen = rk.OpenSubKey("SOFTWARE\\" + "TrackFileActivitesSumit\\TrackPath");
                if (rkOpen != null)
                {
                    this.folderBrowserDialog.SelectedPath = rkOpen.GetValue("Path").ToString();
                }
                //If OK is selected then display the path in textbox and update the Registry Key
                folderBrowserDialog.Description = "Please select the path for tracking.";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSetPath.Text = folderBrowserDialog.SelectedPath;

                    RegistryKey rkCreate = rk.CreateSubKey("SOFTWARE\\" + "TrackFileActivitesSumit\\TrackPath");
                    rkCreate.SetValue("Path", txtSetPath.Text);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*
        private void btnWorkPath_Click(object sender, EventArgs e)
        {
            try
            {
                //If path is already defined, then set the selected path for folderBrowserDialog control
                RegistryKey rk = Registry.LocalMachine;
                RegistryKey rkOpen = rk.OpenSubKey("SOFTWARE\\" + "TrackFileActivitesSumit\\WorkPath");
                if (rkOpen != null)
                {
                    this.folderBrowserDialog.SelectedPath = rkOpen.GetValue("Path").ToString();
                }
                //If OK is selected then display the path in textbox and update the Registry Key
                folderBrowserDialog.Description = "Please select the path for working.";
                folderBrowserDialog.ShowNewFolderButton = true;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtWorkPath.Text = folderBrowserDialog.SelectedPath;

                    RegistryKey rkCreate = rk.CreateSubKey("SOFTWARE\\" + "TrackFileActivitesSumit\\WorkPath");
                    rkCreate.SetValue("Path", txtWorkPath.Text);
                }

                //Set the Directory Path based on the date
                strWorkPath = txtWorkPath.Text + "\\" + System.DateTime.Now.Day.ToString() + "-" + System.DateTime.Now.Month.ToString() + "-" + System.DateTime.Now.Year.ToString();
                //Create the directory if it is not created
                if (!Directory.Exists(strWorkPath))
                {
                    Directory.CreateDirectory(strWorkPath);
                }
                //Set the File Name
                strWorkPath = strWorkPath + "\\TrackFileActivities.log";
                //Create the file if it is not created
                if (!File.Exists(strWorkPath))
                {
                    TextWriter tw = new StreamWriter(strWorkPath);
                    tw.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  //fin btnWorkPath_Click
        */

        private void btnStartTracking_Click(object sender, EventArgs e)
        {
            try
            {
                // if ((txtSetPath.Text.Length != 0) && (txtWorkPath.Text.Length != 0))
                if ((txtSetPath.Text.Length != 0) )
                {

                    //Set the working folder Path (strWorkPath) based on the date
                    strWorkPath = "." + "\\" + System.DateTime.Now.Day.ToString() + "-" + System.DateTime.Now.Month.ToString() + "-" + System.DateTime.Now.Year.ToString();
                    //Create the directory if it is not created
                    if (!Directory.Exists(strWorkPath))
                    {
                        Directory.CreateDirectory(strWorkPath);
                    }
                    //Set the File Name
                    strWorkPath = strWorkPath + "\\TrackFileActivities.log"; textBox2.Text = strWorkPath;
                    //Create the file if it is not created
                    if (!File.Exists(strWorkPath))
                    {
                        TextWriter tw = new StreamWriter(strWorkPath);
                        tw.Close();
                    }

                    txtSetPath.Enabled = false;
                    textBox2.Enabled = false;
                    notifyIcon.Text = "Track File Activites [running]";
                    btnStartTracking.Enabled = false;
                    btnStopTracking.Enabled = true;

                    btnSetPath.Enabled = false;
                    //btnWorkPath.Enabled = false;
                    cmbFilters.Enabled = false;
                    chkIncludeSubdirectories.Enabled = false;
                    gbNotifyFilter.Enabled = false;

                    this.fileSystemWatcher.EnableRaisingEvents = false;

                    if (chkAttributes.Checked == true)
                    {
                        fileSystemWatcher.NotifyFilter = fileSystemWatcher.NotifyFilter | NotifyFilters.Attributes;
                    }
                    if (chkCreationTime.Checked == true)
                    {
                        fileSystemWatcher.NotifyFilter = fileSystemWatcher.NotifyFilter | NotifyFilters.CreationTime;
                    }
                    if (chkDirectoryName.Checked == true)
                    {
                        fileSystemWatcher.NotifyFilter = fileSystemWatcher.NotifyFilter | NotifyFilters.DirectoryName;
                    }
                    if (chkFileName.Checked == true)
                    {
                        fileSystemWatcher.NotifyFilter = fileSystemWatcher.NotifyFilter | NotifyFilters.FileName;
                    }
                    if (chkLastAccess.Checked == true)
                    {
                        fileSystemWatcher.NotifyFilter = fileSystemWatcher.NotifyFilter | NotifyFilters.LastAccess;
                    }
                    if (chkLastWrite.Checked == true)
                    {
                        fileSystemWatcher.NotifyFilter = fileSystemWatcher.NotifyFilter | NotifyFilters.LastWrite;
                    }
                    if (chkSecurity.Checked == true)
                    {
                        fileSystemWatcher.NotifyFilter = fileSystemWatcher.NotifyFilter | NotifyFilters.Security;
                    }
                    if (chkSize.Checked == true)
                    {
                        fileSystemWatcher.NotifyFilter = fileSystemWatcher.NotifyFilter | NotifyFilters.Size;
                    }

                    fileSystemWatcher.Path = txtSetPath.Text;
                    fileSystemWatcher.Filter = cmbFilters.Text;
                    fileSystemWatcher.IncludeSubdirectories = chkIncludeSubdirectories.Checked;
                    fileSystemWatcher.EnableRaisingEvents = true;
                }
                else
                {
                    MessageBox.Show("Either of the path is not defined. Please define the path for Track File Activities and Working Path for Log.", "Please define Tracking and Working path ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // fin btnStartTracking_Click




        private void btnStopTracking_Click(object sender, EventArgs e)
        {
            notifyIcon.Text = "Track File Activites [not running]";
            btnStartTracking.Enabled = true;
            btnStopTracking.Enabled = false;

            btnSetPath.Enabled = true;
          //  btnWorkPath.Enabled = true;
            cmbFilters.Enabled = true;
            chkIncludeSubdirectories.Enabled = true;
            gbNotifyFilter.Enabled = true;


            fileSystemWatcher.EnableRaisingEvents = false;
        }
      
        private void frmTrackFileActivites_FormClosing(object sender, FormClosingEventArgs e)
        {
            //If the flag is "false", then it means that it is it is raised by clicking X button in the form (not raised from context menu)
            if (boolContextFormClose == false)
            {
                e.Cancel = true;
                TopMost = false;
                this.WindowState = FormWindowState.Minimized;

              //  notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
              //  notifyIcon.BalloonTipTitle = "Track File Activity ...";
               // notifyIcon.BalloonTipText = "Track File Activity is still running in background.\nDouble click me to open options again.";
              //  notifyIcon.ShowBalloonTip(5);
            }
            //Otherwise the close event is raised from context menu and ask the user whether he wants to close the application
            else
            {
                if (MessageBox.Show("Do you want to close \"Track File Activites\"?", "Track File Activites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
     
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TopMost = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString() == "Open Options")
            {
                TopMost = true;
                this.WindowState = FormWindowState.Normal;
            }
            if (e.ClickedItem.ToString() == "Open Log")
            {
                //Display frmTrackLog if the form is not already opened
                if (hwdfrmTrackLog == -1)
                {
                    frmTrackLog objfrmTrackLog = new frmTrackLog(strWorkPath);
                    objfrmTrackLog.Disposed += new EventHandler(frmTrackLog_Disposed);
                    hwdfrmTrackLog = objfrmTrackLog.Handle.ToInt32();
                    objfrmTrackLog.Show();
                }
            }
            if (e.ClickedItem.ToString() == "Exit")
            {
                boolContextFormClose = true;
                Application.Exit();
            }
        }
       
        public void frmTrackLog_Disposed(object sender, EventArgs e)
        {
            //When the form is disposed, set the handle back
            hwdfrmTrackLog = -1;
        }

        private void fileSystemWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            string sLog = Convert.ToString(DateTime.Now) + " | " + e.ChangeType + " | " + e.FullPath + Environment.NewLine;
            // string sLog = e.ChangeType + " ---- " + e.FullPath + Environment.NewLine;
            AppendText(sLog);

            StreamWriter sw = File.AppendText(strWorkPath);
            sw.WriteLine(e.ChangeType + "|" + e.FullPath + "|" + DateTime.Now.ToLongTimeString());
            sw.Flush();
            sw.Close();
        }

        private void fileSystemWatcher_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            string sLog = Convert.ToString(DateTime.Now) + " | " + e.ChangeType + " | " + e.FullPath + Environment.NewLine;
            // string sLog = e.ChangeType + " ---- " + e.FullPath + Environment.NewLine;
           AppendText(sLog);
          
            StreamWriter sw = File.AppendText(strWorkPath);
            sw.WriteLine(e.ChangeType + "|" + e.FullPath + "|" + DateTime.Now.ToLongTimeString());
            sw.Flush();
            sw.Close();
        }

        

        private void fileSystemWatcher_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            string sLog = Convert.ToString(DateTime.Now) + " | " + e.ChangeType + " | " + e.FullPath + Environment.NewLine;
            AppendText(sLog);
            StreamWriter sw = File.AppendText(strWorkPath);
            sw.WriteLine(e.ChangeType + "|" + e.FullPath + "|" + DateTime.Now.ToLongTimeString());
            sw.Flush();
            sw.Close();
        }

        private void fileSystemWatcher_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            string sLog = Convert.ToString(DateTime.Now) + " | " + e.ChangeType + " | " + e.FullPath + Environment.NewLine;
            AppendText(sLog);
            StreamWriter sw = File.AppendText(strWorkPath);
            sw.WriteLine(e.ChangeType + "|" + e.OldFullPath + " to " + e.FullPath + "|" + DateTime.Now.ToLongTimeString());
            sw.Flush();
            sw.Close();
        }
        private void AppendText(string sLog)
        {
            textBox1.AppendText(sLog);
        }

    }

}