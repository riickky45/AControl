using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Text.RegularExpressions;

using CSL;

namespace CS461_Access_Control
{
    public partial class frmSettings : Form
    {
        CSL_Settings s;
        Regex rxIP = new Regex(@"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$"); //For IP Address validation

        public frmSettings(CSL.CS461_HL_API reader, CSL.CSL_Settings settings)
        {
            s = settings;

            InitializeComponent();
            
            cbLogLevel.Items.Add("Disable");
            cbLogLevel.Items.Add("Info");
            cbLogLevel.Items.Add("Verbose");

            cbModProfile.Items.Add("Profile0");
            cbModProfile.Items.Add("Profile1");
            cbModProfile.Items.Add("Profile2");
            cbModProfile.Items.Add("Profile3");
            cbModProfile.Items.Add("Profile4");

            cbDuplicateEliminationMethod.Items.Add("Autonomous Time Trigger");
            cbDuplicateEliminationMethod.Items.Add("Polling Trigger by Client");

            cbSearchMode.Items.Add("Default");
            cbSearchMode.Items.Add("Single Target Large Population Inventory");

            cbRxSensitivity.Items.Add("Maximum sensitivity");
            cbRxSensitivity.Items.Add("Variable sensitivity");

            cbAnt1Pwr.BeginUpdate();
            cbAnt2Pwr.BeginUpdate();
            cbAnt3Pwr.BeginUpdate();
            cbAnt4Pwr.BeginUpdate();
            for (double d = 15.00; d <= 30.00; d += 0.25)
            {
                cbAnt1Pwr.Items.Add(d.ToString("N2"));
                cbAnt2Pwr.Items.Add(d.ToString("N2"));
                cbAnt3Pwr.Items.Add(d.ToString("N2"));
                cbAnt4Pwr.Items.Add(d.ToString("N2"));
            }
            cbAnt1Pwr.EndUpdate();
            cbAnt2Pwr.EndUpdate();
            cbAnt3Pwr.EndUpdate();
            cbAnt4Pwr.EndUpdate();

            cbAnt1RSSI.BeginUpdate();
            cbAnt2RSSI.BeginUpdate();
            cbAnt3RSSI.BeginUpdate();
            cbAnt4RSSI.BeginUpdate();
            for (int i = -70; i <= -30.00; i++)
            {
                cbAnt1RSSI.Items.Add(i.ToString());
                cbAnt2RSSI.Items.Add(i.ToString());
                cbAnt3RSSI.Items.Add(i.ToString());
                cbAnt4RSSI.Items.Add(i.ToString());
            }
            cbAnt1RSSI.EndUpdate();
            cbAnt2RSSI.EndUpdate();
            cbAnt3RSSI.EndUpdate();
            cbAnt4RSSI.EndUpdate();

            cbTagICModel.BeginUpdate();
            cbTagICModel.Items.Add("GenericTID32");
            cbTagICModel.Items.Add("GenericTID64");
            cbTagICModel.Items.Add("Monza");
            cbTagICModel.Items.Add("Monaco");
            cbTagICModel.Items.Add("Monza ID");
            cbTagICModel.Items.Add("NXP");
            cbTagICModel.EndUpdate();

            cbMemoryBanks.BeginUpdate();
            cbMemoryBanks.Items.Add("None");
            cbMemoryBanks.Items.Add("Bank0");
            cbMemoryBanks.Items.Add("Bank2");
            cbMemoryBanks.Items.Add("Bank3");
            cbMemoryBanks.EndUpdate();

            cbAntennaPortScheme.BeginUpdate();
            cbAntennaPortScheme.Items.Add("Combined");
            cbAntennaPortScheme.Items.Add("Separated");
            cbAntennaPortScheme.EndUpdate();

            IPHostEntry he = Dns.GetHostEntry(System.Environment.MachineName);
            for (int i = 0; i < he.AddressList.Length; i++)
            {
                cbLocalIP.Items.Add(he.AddressList[i].ToString());
            }

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            txtURI.Text = s.Text("CS461/Reader/URI", "http://192.168.25.248/");
            txtName.Text = s.Text("CS461/Reader/Login/Name", "root");
            txtPass.Text = s.Text("CS461/Reader/Login/Password", "csl2006");
            cbModProfile.Text = s.Text("CS461/Reader/ModulationProfile", "Profile0");
            numSession.Value = (decimal)s.Int16("CS461/Reader/Session", 1);
            numPopulation.Value = (decimal)s.Int16("CS461/Reader/PopulationEstimation", 32);
            cbSearchMode.Text = s.Text("CS461/Reader/InventorySearchMode", "Default");
            cbRxSensitivity.Text = s.Text("CS461/Reader/ReceiveSensitivity", "Maximum sensitivity");

            cbAnt1Pwr.Text = s.Text("CS461/Reader/Antennas/Ant1/Power", "30.00");
            cbAnt2Pwr.Text = s.Text("CS461/Reader/Antennas/Ant2/Power", "30.00");
            cbAnt3Pwr.Text = s.Text("CS461/Reader/Antennas/Ant3/Power", "30.00");
            cbAnt4Pwr.Text = s.Text("CS461/Reader/Antennas/Ant4/Power", "30.00");

            chkAnt1.Checked = s.Boolean("CS461/Reader/Antennas/Ant1/Enabled", false);
            chkAnt2.Checked = s.Boolean("CS461/Reader/Antennas/Ant2/Enabled", false);
            chkAnt3.Checked = s.Boolean("CS461/Reader/Antennas/Ant3/Enabled", false);
            chkAnt4.Checked = s.Boolean("CS461/Reader/Antennas/Ant4/Enabled", false);

            cbAnt1RSSI.Text = s.Text("CS461/Reader/Antennas/Ant1/RSSI", "-70.00");
            cbAnt2RSSI.Text = s.Text("CS461/Reader/Antennas/Ant2/RSSI", "-70.00");
            cbAnt3RSSI.Text = s.Text("CS461/Reader/Antennas/Ant3/RSSI", "-70.00");
            cbAnt4RSSI.Text = s.Text("CS461/Reader/Antennas/Ant4/RSSI", "-70.00");

            cbDuplicateEliminationMethod.Text = s.Text("CS461/Reader/DuplicationElimination/Method", "Autonomous Time Trigger");
            numDuplicateElimination.Value = (decimal)s.Int16("CS461/Reader/DuplicationElimination/Time", 1000);

            cbLogLevel.Text = s.Text("CS461/Application/LogLevel", "Info");
            numListeningPort.Value = (decimal)s.Int16("CS461/Application/ServerPort", 9090);

            numHttp.Value = (decimal)s.Int16("CS461/SocketTimeout/Http", 30000);
            numTcp.Value = (decimal)s.Int16("CS461/SocketTimeout/Tcp", 30000);

            cbTagICModel.Text = s.Text("CS461/Reader/TagIC", "GenericTID32");
            cbMemoryBanks.Text = s.Text("CS461/Reader/AdditionalMemoryBank", "None");
            cbAntennaPortScheme.SelectedIndex = s.Text("CS461/Reader/DuplicationElimination/AntennaPortScheme", "false").Equals("true") ? 1 : 0;
            cbLocalIP.Text = s.Text("CS461/Application/LocalIP", "0.0.0.0");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            defaultSettings();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            s.Save();
            this.Close();
        }

        private void defaultSettings()
        {
            txtURI.Text = "http://192.168.25.248/";
            txtName.Text = "root";
            txtPass.Text = "csl2006";
            cbModProfile.Text = "Profile0";
            numSession.Value = 1;
            numPopulation.Value = 32;
            cbSearchMode.Text = "Default";
            cbRxSensitivity.Text = "Maximum sensitivity";

            cbAnt1Pwr.Text = "30.00";
            cbAnt2Pwr.Text = "30.00";
            cbAnt3Pwr.Text = "30.00";
            cbAnt4Pwr.Text = "30.00";

            chkAnt1.Checked = true;
            chkAnt2.Checked = false;
            chkAnt3.Checked = false;
            chkAnt4.Checked = false;

            cbAnt1RSSI.Text = "-70.00";
            cbAnt2RSSI.Text = "-70.00";
            cbAnt3RSSI.Text = "-70.00";
            cbAnt4RSSI.Text = "-70.00";

            cbDuplicateEliminationMethod.Text = "Autonomous Time Trigger";
            numDuplicateElimination.Value = 1000;

            cbLogLevel.Text = "Info";
            numListeningPort.Value = 9090;

            numHttp.Value = 30000;
            numTcp.Value = 30000;

            cbTagICModel.Text = "GenericTID32";
            cbMemoryBanks.Text = "None";
            cbAntennaPortScheme.SelectedIndex = 0;
            cbLocalIP.SelectedIndex = 0;
        }

        private void txtURI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Uri u = new Uri(txtURI.Text);
                txtURI.BackColor = Color.White;
                s.Set("CS461/Reader/URI", txtURI.Text);
            }
            catch
            {
                txtURI.BackColor = Color.Red;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/Login/Name", txtName.Text);
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/Login/Password", txtPass.Text);
        }

        private void cbModProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/ModulationProfile", cbModProfile.Text);
        }

        private void numSession_ValueChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/Session", numSession.Value.ToString());
        }

        private void numPopulation_ValueChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/PopulationEstimation", numPopulation.Value.ToString());
        }

        private void cbSearchMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/InventorySearchMode", cbSearchMode.Text);
        }

        private void cbRxSensitivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/ReceiveSensitivity", cbRxSensitivity.Text);
            if (cbRxSensitivity.SelectedIndex == 0)
            {
                cbAnt1RSSI.Enabled = false;
                cbAnt2RSSI.Enabled = false;
                cbAnt3RSSI.Enabled = false;
                cbAnt4RSSI.Enabled = false;
            }
            else
            {
                cbAnt1RSSI.Enabled = true;
                cbAnt2RSSI.Enabled = true;
                cbAnt3RSSI.Enabled = true;
                cbAnt4RSSI.Enabled = true;
            }
        }

        private void cbDuplicateEliminationMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/DuplicationElimination/Method", cbDuplicateEliminationMethod.Text);
        }

        private void numDuplicateElimination_ValueChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/DuplicationElimination/Time", numDuplicateElimination.Value.ToString());
        }

        private void chkAnt1_CheckedChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/Antennas/Ant1/Enabled", chkAnt1.Checked ? "true" : "false");
        }

        private void chkAnt2_CheckedChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/Antennas/Ant2/Enabled", chkAnt2.Checked ? "true" : "false");
        }

        private void chkAnt3_CheckedChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/Antennas/Ant3/Enabled", chkAnt3.Checked ? "true" : "false");
        }

        private void chkAnt4_CheckedChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/Antennas/Ant4/Enabled", chkAnt4.Checked ? "true" : "false");
        }

        private void cbAnt1Pwr_SelectedIndexChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/Antennas/Ant1/Power", cbAnt1Pwr.Text);
        }

        private void cbAnt2Pwr_SelectedIndexChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/Antennas/Ant2/Power", cbAnt2Pwr.Text);
        }

        private void cbAnt3Pwr_SelectedIndexChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/Antennas/Ant3/Power", cbAnt3Pwr.Text);
        }

        private void cbAnt4Pwr_SelectedIndexChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/Antennas/Ant4/Power", cbAnt4Pwr.Text);
        }

        private void cbAnt1RSSI_SelectedIndexChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/Antennas/Ant1/RSSI", cbAnt1RSSI.Text);
        }

        private void cbAnt2RSSI_SelectedIndexChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/Antennas/Ant2/RSSI", cbAnt2RSSI.Text);
        }

        private void cbAnt3RSSI_SelectedIndexChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/Antennas/Ant3/RSSI", cbAnt3RSSI.Text);
        }

        private void cbAnt4RSSI_SelectedIndexChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/Antennas/Ant4/RSSI", cbAnt4RSSI.Text);
        }

        private void cbLogLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Application/LogLevel", cbLogLevel.Text);
        }

        private void numListeningPort_ValueChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Application/ServerPort", numListeningPort.Value.ToString());
        }

        private void numHttp_ValueChanged(object sender, EventArgs e)
        {
            s.Set("CS461/SocketTimeout/Http", numHttp.Value.ToString());
        }

        private void numTcp_ValueChanged(object sender, EventArgs e)
        {
            s.Set("CS461/SocketTimeout/Tcp", numTcp.Value.ToString());
        }

        private void cbTagICModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/TagIC", cbTagICModel.Text);
        }

        private void cbMemoryBanks_SelectedIndexChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/AdditionalMemoryBank", cbMemoryBanks.Text);
        }

        private void cbAntennaPortScheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            s.Set("CS461/Reader/DuplicationElimination/AntennaPortScheme", cbAntennaPortScheme.SelectedIndex == 1 ? "true" : "false");
        }

        private void cbLocalIP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rxIP.IsMatch(cbLocalIP.Text) == true)
            {
                cbLocalIP.BackColor = Color.White;
                s.Set("CS461/Application/LocalIP", cbLocalIP.Text);
            }
            else
            {
                cbLocalIP.BackColor = Color.Red;
            }
        }
    }
}