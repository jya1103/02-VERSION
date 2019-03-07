using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Text.RegularExpressions;

namespace TrackFileActivites
{
    public partial class frmTrackLog : Form
    {
        string strWorkPath = "";

        public frmTrackLog(string strCWorkPath)
        {
            InitializeComponent();

            try
            {
                strWorkPath = strCWorkPath;

                txtLogPath.Text = strCWorkPath;

                DirectoryInfo d = new DirectoryInfo(txtLogPath.Text);

                Text = "Track File Activites Log for " + d.Parent.Name + " ...";

                timer.Interval = Convert.ToInt16(txtRefreshInterval.Text) * 60000;

                //Check if Work path is already present in the Registry or close the log window
                /*Registory Path = My Computer\HKEY_LOCAL_MACHINE\SOFTWARE\TrackFileActivitesSumit\*/
                RegistryKey rk = Registry.LocalMachine;
                RegistryKey rkOpenWork = rk.OpenSubKey("SOFTWARE\\" + "TrackFileActivitesSumit\\WorkPath");
                if (rkOpenWork == null)
                {
                    MessageBox.Show("There is no working path defined. Cannot fetch any log data for Track File Activites", "Working Path is not defined ...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmTrackLog_Load(object sender, EventArgs e)
        {
            DisplayLogInListView();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DisplayLogInListView();
        }

        private void txtRefreshInterval_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Match matchRegEx;
                matchRegEx = Regex.Match(txtRefreshInterval.Text, "[1-9]+", RegexOptions.IgnoreCase);
                if (matchRegEx.Success)
                {
                    int value = Convert.ToInt16(txtRefreshInterval.Text);
                    timer.Interval = Convert.ToInt16(txtRefreshInterval.Text) * 60000;
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Please enter any integer value greater than or equal to 1", "Auto Interval Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRefreshInterval.Text = "1";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnManualRefresh_Click(object sender, EventArgs e)
        {
            DisplayLogInListView();
        }

        public void DisplayLogInListView()
        {
            try
            {
                timer.Enabled = false;

                if (!File.Exists(txtLogPath.Text.Replace("TrackFileActivities.log", "") + "Copy of TrackFileActivities.log"))
                {
                    File.Copy(txtLogPath.Text, txtLogPath.Text.Replace("TrackFileActivities.log", "") + "Copy of TrackFileActivities.log");
                }
                else
                {
                    File.Delete(txtLogPath.Text.Replace("TrackFileActivities.log", "") + "Copy of TrackFileActivities.log");
                    File.Copy(txtLogPath.Text, txtLogPath.Text.Replace("TrackFileActivities.log", "") + "Copy of TrackFileActivities.log");
                }

                listViewLog.Items.Clear();
                Match matchRegEx;
                ListViewItem lvItem;
                string strReadLog = "";
                string[] strReadLogColl;
                TextReader tr = new StreamReader(txtLogPath.Text.Replace("TrackFileActivities.log", "") + "Copy of TrackFileActivities.log");
                while ((strReadLog = tr.ReadLine()) != null)
                {
                    bool boolFlag = false;
                    strReadLogColl = strReadLog.Split('|');
                    if ((chkCreated.Checked == true) && (strReadLogColl[0] == "Created"))
                    {
                        matchRegEx = Regex.Match(strReadLogColl[1], txtPath.Text, RegexOptions.IgnoreCase);
                        if (matchRegEx.Success)
                        {
                            DateTime dtCompStartTime = Convert.ToDateTime(dtStartTime.Value.ToShortDateString() + " " + strReadLogColl[2]);
                            DateTime dtCompEndTime = Convert.ToDateTime(dtEndTime.Value.ToShortDateString() + " " + strReadLogColl[2]);
                            if ((dtCompStartTime >= dtStartTime.Value) && (dtCompEndTime <= dtEndTime.Value))
                            {
                                boolFlag = true;
                            }
                        }
                    }
                    if ((chkDeleted.Checked == true) && (strReadLogColl[0] == "Deleted"))
                    {
                        matchRegEx = Regex.Match(strReadLogColl[1], txtPath.Text, RegexOptions.IgnoreCase);
                        if (matchRegEx.Success)
                        {
                            DateTime dtCompStartTime = Convert.ToDateTime(dtStartTime.Value.ToShortDateString() + " " + strReadLogColl[2]);
                            DateTime dtCompEndTime = Convert.ToDateTime(dtEndTime.Value.ToShortDateString() + " " + strReadLogColl[2]);
                            if ((dtCompStartTime >= dtStartTime.Value) && (dtCompEndTime <= dtEndTime.Value))
                            {
                                boolFlag = true;
                            }
                        }
                    }
                    if ((chkRenamed.Checked == true) && (strReadLogColl[0] == "Renamed"))
                    {
                        matchRegEx = Regex.Match(strReadLogColl[1], txtPath.Text, RegexOptions.IgnoreCase);
                        if (matchRegEx.Success)
                        {
                            DateTime dtCompStartTime = Convert.ToDateTime(dtStartTime.Value.ToShortDateString() + " " + strReadLogColl[2]);
                            DateTime dtCompEndTime = Convert.ToDateTime(dtEndTime.Value.ToShortDateString() + " " + strReadLogColl[2]);
                            if ((dtCompStartTime >= dtStartTime.Value) && (dtCompEndTime <= dtEndTime.Value))
                            {
                                boolFlag = true;
                            }
                        }
                    }
                    if ((chkChanged.Checked == true) && (strReadLogColl[0] == "Changed"))
                    {
                        matchRegEx = Regex.Match(strReadLogColl[1], txtPath.Text, RegexOptions.IgnoreCase);
                        if (matchRegEx.Success)
                        {
                            DateTime dtCompStartTime = Convert.ToDateTime(dtStartTime.Value.ToShortDateString() + " " + strReadLogColl[2]);
                            DateTime dtCompEndTime = Convert.ToDateTime(dtEndTime.Value.ToShortDateString() + " " + strReadLogColl[2]);
                            if ((dtCompStartTime >= dtStartTime.Value) && (dtCompEndTime <= dtEndTime.Value))
                            {
                                boolFlag = true;
                            }
                        }
                    }
                    lvItem = new ListViewItem(strReadLogColl[0]);
                    lvItem.SubItems.Add(strReadLogColl[1]);
                    lvItem.SubItems.Add(strReadLogColl[2]);
                    if (strReadLogColl[0] == "Created")
                    {
                        lvItem.ForeColor = Color.Blue;
                    }
                    else if (strReadLogColl[0] == "Changed")
                    {
                        lvItem.ForeColor = Color.Brown;
                    }
                    else if (strReadLogColl[0] == "Deleted")
                    {
                        lvItem.ForeColor = Color.Red;
                    }
                    else if (strReadLogColl[0] == "Renamed")
                    {
                        lvItem.ForeColor = Color.Green;
                    }
                    if (boolFlag == true)
                    {
                        listViewLog.Items.Add(lvItem);
                    }
                }
                tr.Close();
                File.Delete(txtLogPath.Text.Replace("TrackFileActivities.log", "") + "Copy of TrackFileActivities.log");
                timer.Enabled = true;
                if (listViewLog.Items.Count > 0)
                {
                    listViewLog.EnsureVisible(listViewLog.Items.Count - 1);
                    listViewLog.Items[listViewLog.Items.Count - 1].Selected = true;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void listViewLog_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            try
            {
                ListViewSorter Sorter = new ListViewSorter();
                listViewLog.ListViewItemSorter = Sorter;
                if (!(listViewLog.ListViewItemSorter is ListViewSorter))
                    return;
                Sorter = (ListViewSorter)listViewLog.ListViewItemSorter;

                if (Sorter.LastSort == e.Column)
                {
                    if (listViewLog.Sorting == SortOrder.Ascending)
                        listViewLog.Sorting = SortOrder.Descending;
                    else
                        listViewLog.Sorting = SortOrder.Ascending;
                }
                else
                {
                    if (listViewLog.Sorting == SortOrder.Ascending)
                        listViewLog.Sorting = SortOrder.Descending;
                    else
                        listViewLog.Sorting = SortOrder.Ascending;
                }
                Sorter.ByColumn = e.Column;

                listViewLog.Sort();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public class ListViewSorter : System.Collections.IComparer
        {
            public int Compare(object o1, object o2)
            {
                if (!(o1 is ListViewItem))
                    return (0);
                if (!(o2 is ListViewItem))
                    return (0);

                ListViewItem lvi1 = (ListViewItem)o2;
                string str1 = lvi1.SubItems[ByColumn].Text;
                ListViewItem lvi2 = (ListViewItem)o1;
                string str2 = lvi2.SubItems[ByColumn].Text;

                int result;
                if (lvi1.ListView.Sorting == SortOrder.Ascending)
                    result = String.Compare(str1, str2);
                else
                    result = String.Compare(str2, str1);

                LastSort = ByColumn;

                return (result);
            }


            public int ByColumn
            {
                get { return Column; }
                set { Column = value; }
            }
            int Column = 0;

            public int LastSort
            {
                get { return LastColumn; }
                set { LastColumn = value; }
            }
            int LastColumn = 0;
        }

        private void chkPath_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPath.Checked == true)
            {
                txtPath.Enabled = true;
            }
            else
            {
                txtPath.Text = "";
                txtPath.Enabled = false;
            }
        }

        private void chkTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTime.Checked == true)
            {
                dtStartTime.Enabled = true;
                dtEndTime.Enabled = true;
            }
            else
            {
                dtStartTime.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString() + " 12:00:00 AM");
                dtEndTime.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString() + " 11:59:59 PM");
                dtStartTime.Enabled = false;
                dtEndTime.Enabled = false;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.InitialDirectory = strWorkPath;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtLogPath.Text = openFileDialog.FileName;

                    DirectoryInfo d = new DirectoryInfo(txtLogPath.Text);

                    Text = "Track File Activites Log for " + d.Parent.Name + " ...";

                    DisplayLogInListView();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}