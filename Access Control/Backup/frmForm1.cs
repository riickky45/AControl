using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Net;
using System.IO;

using CSL;

namespace CS461_Access_Control
{
    public partial class frmMain : Form
    {
        CS461_HL_API reader = new CS461_HL_API();
        TrustedServer server = new TrustedServer();
        CSL_Settings settings = new CSL_Settings();

        DataTable UserInfoTable = new DataTable();
        Object guiLock = new Object();

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Application.CurrentCulture = new System.Globalization.CultureInfo("en-us");

            this.Text = String.Format("CS461 Access Control (High Level API) - {0}", Application.ProductVersion);
            tsslClock.Text = String.Format("{0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
            reader.api_log_level = LOG_LEVEL.Info;
            reader.saveToLogInfo(String.Format("{0} ({1}) starting up ...", this.Text, Application.ProductVersion));
            reader.api_log_level = LOG_LEVEL.Disabled;

            frmWelcome formWelcome = new frmWelcome();
            formWelcome.Show();
            formWelcome.message = "Loading user settings ...";
            Application.DoEvents();
            loadUserSettings();
            loadUserInfo();

            tmrClock.Enabled = true;

            formWelcome.message = String.Format("Setup reader settings ({0}) ...", reader.getURI());
            Application.DoEvents();

            if (reader.connect())
            {
                setupReader();
                btnRead.PerformClick();
            }
            else
            {
                tsslStatus.Text = "Cannot connect to reader";
            }
            Application.DoEvents();

            server.TagReceiveEvent += new TagReceiveEventHandler(this.AccessControl_TagReceiveEvent);

            formWelcome.Close();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            updateLayout();
        }

        private void updateLayout()
        {


        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            tsslClock.Text = String.Format("{0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrClock.Enabled = false;
            tmrTimeout.Enabled = false;
        }

        delegate void update_UserInfo_Delegate(string id);

        private void update_UserInfo(string id)
        {
            if (InvokeRequired)
            {
                update_UserInfo_Delegate task = new update_UserInfo_Delegate(update_UserInfo);
                BeginInvoke(task, new object[] { id });
            }
            else
            {
                lock (guiLock)
                {
                    if (txtID.Text.Equals(id) == false)
                    {
                        reader.saveToLogInfo(String.Format("{0}, {1}", txtID.Text, id));
                        string mediaFile = null;
                        DataRow[] rows = UserInfoTable.Select(String.Format("ID = '{0}'", id));

                        if (rows.Length > 0)
                        {
                            btnAccessLog.Enabled = true;
                            string time = String.Format("{0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
                            txtTime.Text = time;
                            txtID.Text = rows[0].ItemArray[0].ToString();
                            txtName.Text = rows[0].ItemArray[1].ToString();
                            txtTitle.Text = rows[0].ItemArray[2].ToString();
                            txtCompany.Text = rows[0].ItemArray[3].ToString();
                            txtLocation.Text = rows[0].ItemArray[4].ToString();
                            mediaFile = System.Environment.CurrentDirectory + "\\Photo\\" + rows[0].ItemArray[5].ToString();
                            try
                            {
                                picPhoto.ImageLocation = mediaFile;
                                picPhoto.Load();
                            }
                            catch
                            {
                                tsslStatus.Text = String.Format("Cannot load picture {0}", rows[0].ItemArray[5].ToString());
                            }
                            mediaFile = System.Environment.CurrentDirectory + "\\Audio\\" + rows[0].ItemArray[6].ToString();
                            try
                            {
                                player.SoundLocation = mediaFile;
                                player.Load();
                                Application.DoEvents();
                                player.Play();
                                Application.DoEvents();
                            }
                            catch
                            {
                                tsslStatus.Text = String.Format("Cannot play file {0}", rows[0].ItemArray[6].ToString());
                            }

                            tmrTimeout.Enabled = false;
                            tmrTimeout.Enabled = true;
                            saveAccessTime(id, time, txtLocation.Text);
                        }
                        else
                        {
                            btnAccessLog.Enabled = false;
                            txtID.Text = id;
                            txtCompany.Text = "";
                            txtName.Text = "";
                            txtTitle.Text = "";
                            txtLocation.Text = "";
                            txtTime.Text = String.Format("{0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
                            picPhoto.ImageLocation = System.Environment.CurrentDirectory + "\\Photo\\noAccess.jpg";
                            player.SoundLocation = System.Environment.CurrentDirectory + "\\Audio\\noAccess.wav";
                            try
                            {
                                player.Play();
                                Application.DoEvents();
                            }
                            catch
                            {
                            }
                            tmrTimeout.Enabled = false;
                            tmrTimeout.Enabled = true;
                        }
                    }
                    else
                    {
                        tmrTimeout.Enabled = false;
                        tmrTimeout.Enabled = true;
                    }
                }
            }
        }

        private void startReadTags()
        {
            tmrTimeout.Enabled = true;
            btnRead.Text = "Pause";
            tsslReadPause.Text = "Reading...";
            tsslReadPause.BackColor = Color.Green;
            tsslStatus.Text = "Read tags operation started";
            settingsToolStripMenuItem.Enabled = false;

            reader.purgeAllTags();

            server.Start();
        }

        private void stopReadTags()
        {
            tmrTimeout.Enabled = false;
            btnRead.Text = "Start";
            tsslReadPause.Text = "Paused";
            tsslReadPause.BackColor = Color.Red;
            tsslStatus.Text = "Read tags operation paused";
            settingsToolStripMenuItem.Enabled = true;

            server.Stop();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (btnRead.Text == "Pause")
                stopReadTags();
            else
                startReadTags();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings formSetting = new frmSettings(reader, settings);
            formSetting.ShowDialog();

            frmWelcome formWelcome = new frmWelcome();
            formWelcome.Show();
            formWelcome.message = "Loading user settings ...";
            Application.DoEvents();
            loadUserSettings();

            formWelcome.message = String.Format("Setup reader settings ({0}) ...", reader.getURI());
            Application.DoEvents();

            if (reader.connect())
            {
                if (setupReader() == true)
                {
                    tsslStatus.Text = "Connected to reader";
                }
                else
                {
                    tsslStatus.Text = "Cannot connect to reader";
                }
            }
            else
            {
                tsslStatus.Text = "Cannot connect to reader";
            }

            formWelcome.Close();
        }

        private void loadUserSettings()
        {
            lock (this)
            {
                reader.login_name = settings.Text("CS461/Reader/Login/Name", "root");
                reader.login_password = settings.Text("CS461/Reader/Login/Password", "csl2006");
                reader.http_timeout = settings.Int16("CS461/SocketTimeout/Http", 30000);
                reader.api_log_level = reader.LogLevel(settings.Text("CS461/Application/LogLevel", "Info"));
                reader.setURI(settings.Text("CS461/Reader/URI", "http://192.168.25.208/"));

                server.api_log_level = reader.LogLevel(settings.Text("CS461/Application/LogLevel", "Info"));
                try
                {
                    server.tcp_port = int.Parse(settings.Text("CS461/Application/ServerPort", "9090"));
                }
                catch
                {
                    server.tcp_port = 9090;
                }
            }
        }

        private void loadUserInfo()
        {
            //Create data table
            UserInfoTable.Columns.Add("ID", typeof(String));
            UserInfoTable.Columns.Add("Name", typeof(String));
            UserInfoTable.Columns.Add("Title", typeof(String));
            UserInfoTable.Columns.Add("Company", typeof(String));
            UserInfoTable.Columns.Add("Location", typeof(String));
            UserInfoTable.Columns.Add("Photo filename", typeof(String));
            UserInfoTable.Columns.Add("Voice filename", typeof(String));

            UserInfoTable.PrimaryKey = new DataColumn[] { UserInfoTable.Columns["ID"] };

            String line = null;
            string[] fields = null;
            try
            {
                StreamReader sr = new StreamReader(System.Environment.CurrentDirectory + "\\db.csv");
                sr.ReadLine();
                while (sr.EndOfStream == false)
                {
                    line = sr.ReadLine();
                    fields = line.Split(',');

                    object[] o = new object[7];
                    for (int i = 0; i < 7; i++)
                    {
                        o[i] = fields[i].Trim();
                    }
                    UserInfoTable.LoadDataRow(o, LoadOption.OverwriteChanges);
                }
            }
            catch
            {
            }
        }

        private bool setupReader()
        {
            if (reader.connect() == false)
            {
                tsslStatus.Text = "Cannot connect to reader";
                return false;
            }

            //Disable all events
            System.Collections.ArrayList eventList;
            eventList = reader.listEvent();
            if (eventList != null)
            {
                foreach (EVENT_INFO e in eventList)
                {
                    reader.enableEvent(e.id, false);
                }
            }

            //Setup Operation Profile
            OPERATION_PROFILE profile = new OPERATION_PROFILE();

            profile.profile_id = "Default Profile";
            profile.profile_enable = true;
            profile.modulation_profile = settings.Text("CS461/Reader/ModulationProfile", "Profile0");
            profile.population = settings.Int16("CS461/Reader/PopulationEstimation", 10);
            profile.session_no = settings.Int16("CS461/Reader/Session", 1);
            profile.ant1_power = settings.Text("CS461/Reader/Antennas/Ant1/Power", "30.00");
            profile.ant2_power = settings.Text("CS461/Reader/Antennas/Ant2/Power", "30.00");
            profile.ant3_power = settings.Text("CS461/Reader/Antennas/Ant3/Power", "30.00");
            profile.ant4_power = settings.Text("CS461/Reader/Antennas/Ant4/Power", "30.00");
            profile.ant1_enable = settings.Boolean("CS461/Reader/Antennas/Ant1/Enabled", false);
            profile.ant2_enable = settings.Boolean("CS461/Reader/Antennas/Ant2/Enabled", false);
            profile.ant3_enable = settings.Boolean("CS461/Reader/Antennas/Ant3/Enabled", false);
            profile.ant4_enable = settings.Boolean("CS461/Reader/Antennas/Ant4/Enabled", false);
            profile.window_time = settings.Int16("CS461/Reader/DuplicationElimination/Time", 1000);
            profile.trigger = settings.Text("CS461/Reader/DuplicationElimination/Method", "Autonomous Time Trigger");
            profile.capture_mode = "Time Window";
            profile.tagModel = settings.Text("CS461/Reader/TagIC", "GenericTID32");
            profile.memoryBank = settings.Text("CS461/Reader/AdditionalMemoryBank", "None");
            profile.antennaPortScheme = settings.Text("CS461/Reader/DuplicationElimination/AntennaPortScheme", "true");

            if (reader.setOperProfile_TxPowers(profile) == false)
            {
                tsslStatus.Text = "Fail to set operation profile";
                return false;
            }

            //Setup Trusted Server
            SERVER_INFO svr = new SERVER_INFO();
            svr.id = "AccessControlDemoServer";
            svr.desc = "Access Control Demo Server";
            svr.ip = settings.Text("CS461/Application/LocalIP", "0.0.0.0");
            svr.server_port = settings.Text("CS461/Application/ServerPort", "9090");
            svr.mode = "Listening Port on Server Side";
            svr.enable = true;

            if (reader.setServerID(svr) == false)
            {
                if (reader.modServerID(svr) == false)
                {
                    tsslStatus.Text = "Fail to set trusted server";
                    return false;
                }
            }

            //Setup Triggering Logic
            reader.delTriggeringLogic("AccessControlDemoLogic");

            TRIGGER_INFO trigger = new TRIGGER_INFO();
            trigger.id = "AccessControlDemoLogic";
            trigger.desc = "Access Control Demo";
            trigger.mode = "Read Any Tags (any ID, 1 trigger per tag)"; //For firmware 2.1.0 or later
            trigger.capture_point = "";
            trigger.capture_point += settings.Boolean("CS461/Reader/Antennas/Ant1/Enabled", false) ? "1" : "";
            trigger.capture_point += settings.Boolean("CS461/Reader/Antennas/Ant2/Enabled", false) ? "2" : "";
            trigger.capture_point += settings.Boolean("CS461/Reader/Antennas/Ant3/Enabled", false) ? "3" : "";
            trigger.capture_point += settings.Boolean("CS461/Reader/Antennas/Ant4/Enabled", false) ? "4" : "";

            if (reader.addTriggeringLogic(trigger) == false)
            {
                trigger.mode = "Read Any Tags";     //For firmware 2.0.9, 2.0.10
                if (reader.addTriggeringLogic(trigger) == false)
                {
                    tsslStatus.Text = "Fail to set triggering logic";
                    return false;
                }
            }

            //Setup Resultant Action
            reader.delResultantAction("AccessControlDemoAction");

            RESULTANT_ACTION_INFO action1 = new RESULTANT_ACTION_INFO();
            action1.id = "AccessControlDemoAction";
            action1.desc = "Access Control Demo";
            if (profile.trigger.Equals("Autonomous Time Trigger") == true)
            {
                action1.mode = "Instant Alert to Server";
            }
            else
            {
                action1.mode = "Batch Alert to Server";
            }
            action1.server_id = svr.id;
            action1.report_id = "Default Report";

            if (reader.addResultantAction(action1) == false)
            {
                tsslStatus.Text = "Fail to set resultant action";
                return false;
            }

            //Setup Event
            reader.delEvent("AccessControlDemoEvent");

            EVENT_INFO eventInfo = new EVENT_INFO();
            eventInfo.id = "AccessControlDemoEvent";
            eventInfo.desc = "Access Control Demo";
            eventInfo.profile = profile.profile_id;
            eventInfo.trigger = trigger.id;
            eventInfo.action = action1.id;
            eventInfo.log = false;
            eventInfo.enable = true;
            eventInfo.enabling = "Always On";
            eventInfo.disabling = "Never Stop";

            if (reader.addEvent(eventInfo) == false)
            {
                tsslStatus.Text = "Fail to set event";
                return false;
            }

            return true;
        }

        private void tmrTimeout_Tick(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtTitle.Text = "";
            txtTime.Text = "";
            txtCompany.Text = "";
            txtLocation.Text = "";
            picPhoto.ImageLocation = "";
            tmrTimeout.Enabled = false;
            btnAccessLog.Enabled = false;
        }

        private void saveAccessTime(string id, string time, string location)
        {
            StreamWriter sw = null;
            string fout = System.Environment.CurrentDirectory + "\\AccessTime.log";
            if (File.Exists(fout) == false)
            {
                //create log file
                sw = new StreamWriter(fout, true);
                sw.WriteLine("id, access time");
                sw.Close();
            }

            sw = new StreamWriter(fout, true);
            sw.WriteLine(String.Format("{0}, {1}, {2}", id, time, location));
            sw.Close();
        }

        private void btnAccessLog_Click(object sender, EventArgs e)
        {
            string[] info = new string[4];
            info[0] = txtID.Text;
            info[1] = txtName.Text;
            info[2] = txtTitle.Text;
            info[3] = txtCompany.Text;
            Form frmAccess = new frmAccessLog(info);
            frmAccess.ShowDialog();
        }

        public void AccessControl_TagReceiveEvent(object sender, TagReceiveEventArgs e)
        {
            if (e.rxTag != null)
            {
                TAG t = (TAG)e.rxTag;
                update_UserInfo(t.TagOrigId);
                reader.saveToLogInfo(String.Format("Tag Receive Event received: {0}", t.TagOrigId));
            }
            else
            {
                reader.saveToLogInfo("Tag Receive Event received: None");
            }
        }
    }
}