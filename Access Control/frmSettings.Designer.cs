namespace CS461_Access_Control
{
    partial class frmSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMemoryBanks = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbTagICModel = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.numSession = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.cbSearchMode = new System.Windows.Forms.ComboBox();
            this.cbModProfile = new System.Windows.Forms.ComboBox();
            this.numPopulation = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtURI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRxSensitivity = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.numListeningPort = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.chkAnt4 = new System.Windows.Forms.CheckBox();
            this.chkAnt3 = new System.Windows.Forms.CheckBox();
            this.chkAnt2 = new System.Windows.Forms.CheckBox();
            this.chkAnt1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numTcp = new System.Windows.Forms.NumericUpDown();
            this.numHttp = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbLocalIP = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbLogLevel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbAnt4RSSI = new System.Windows.Forms.ComboBox();
            this.cbAnt3RSSI = new System.Windows.Forms.ComboBox();
            this.cbAnt2RSSI = new System.Windows.Forms.ComboBox();
            this.cbAnt1RSSI = new System.Windows.Forms.ComboBox();
            this.cbAnt4Pwr = new System.Windows.Forms.ComboBox();
            this.cbAnt3Pwr = new System.Windows.Forms.ComboBox();
            this.cbAnt2Pwr = new System.Windows.Forms.ComboBox();
            this.cbAnt1Pwr = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbAntennaPortScheme = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.numDuplicateElimination = new System.Windows.Forms.NumericUpDown();
            this.cbDuplicateEliminationMethod = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numListeningPort)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTcp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHttp)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuplicateElimination)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMemoryBanks);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cbTagICModel);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.numSession);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbSearchMode);
            this.groupBox1.Controls.Add(this.cbModProfile);
            this.groupBox1.Controls.Add(this.numPopulation);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtURI);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reader";
            // 
            // cbMemoryBanks
            // 
            this.cbMemoryBanks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMemoryBanks.FormattingEnabled = true;
            this.cbMemoryBanks.Location = new System.Drawing.Point(146, 233);
            this.cbMemoryBanks.Name = "cbMemoryBanks";
            this.cbMemoryBanks.Size = new System.Drawing.Size(136, 21);
            this.cbMemoryBanks.TabIndex = 14;
            this.cbMemoryBanks.SelectedIndexChanged += new System.EventHandler(this.cbMemoryBanks_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 236);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "Additional Memory Banks:";
            // 
            // cbTagICModel
            // 
            this.cbTagICModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTagICModel.FormattingEnabled = true;
            this.cbTagICModel.Location = new System.Drawing.Point(146, 207);
            this.cbTagICModel.Name = "cbTagICModel";
            this.cbTagICModel.Size = new System.Drawing.Size(136, 21);
            this.cbTagICModel.TabIndex = 12;
            this.cbTagICModel.SelectedIndexChanged += new System.EventHandler(this.cbTagICModel_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 210);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Tag IC Model:";
            // 
            // numSession
            // 
            this.numSession.Location = new System.Drawing.Point(146, 128);
            this.numSession.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numSession.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSession.Name = "numSession";
            this.numSession.Size = new System.Drawing.Size(136, 20);
            this.numSession.TabIndex = 10;
            this.numSession.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSession.ValueChanged += new System.EventHandler(this.numSession_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Session:";
            // 
            // cbSearchMode
            // 
            this.cbSearchMode.FormattingEnabled = true;
            this.cbSearchMode.Location = new System.Drawing.Point(146, 180);
            this.cbSearchMode.Name = "cbSearchMode";
            this.cbSearchMode.Size = new System.Drawing.Size(136, 21);
            this.cbSearchMode.TabIndex = 8;
            this.cbSearchMode.SelectedIndexChanged += new System.EventHandler(this.cbSearchMode_SelectedIndexChanged);
            // 
            // cbModProfile
            // 
            this.cbModProfile.FormattingEnabled = true;
            this.cbModProfile.Location = new System.Drawing.Point(146, 101);
            this.cbModProfile.Name = "cbModProfile";
            this.cbModProfile.Size = new System.Drawing.Size(136, 21);
            this.cbModProfile.TabIndex = 7;
            this.cbModProfile.SelectedIndexChanged += new System.EventHandler(this.cbModProfile_SelectedIndexChanged);
            // 
            // numPopulation
            // 
            this.numPopulation.Location = new System.Drawing.Point(146, 154);
            this.numPopulation.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.numPopulation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPopulation.Name = "numPopulation";
            this.numPopulation.Size = new System.Drawing.Size(136, 20);
            this.numPopulation.TabIndex = 6;
            this.numPopulation.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPopulation.ValueChanged += new System.EventHandler(this.numPopulation_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Inventory Search Mode:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Modulation Profile:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Population Estimation:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(99, 75);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(183, 20);
            this.txtPass.TabIndex = 2;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtURI
            // 
            this.txtURI.Location = new System.Drawing.Point(99, 22);
            this.txtURI.Name = "txtURI";
            this.txtURI.Size = new System.Drawing.Size(183, 20);
            this.txtURI.TabIndex = 0;
            this.txtURI.TextChanged += new System.EventHandler(this.txtURI_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "&URI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Login Name:";
            // 
            // cbRxSensitivity
            // 
            this.cbRxSensitivity.FormattingEnabled = true;
            this.cbRxSensitivity.Location = new System.Drawing.Point(146, 17);
            this.cbRxSensitivity.Name = "cbRxSensitivity";
            this.cbRxSensitivity.Size = new System.Drawing.Size(136, 21);
            this.cbRxSensitivity.TabIndex = 12;
            this.cbRxSensitivity.SelectedIndexChanged += new System.EventHandler(this.cbRxSensitivity_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Receive Sensitivity:";
            // 
            // numListeningPort
            // 
            this.numListeningPort.Location = new System.Drawing.Point(125, 46);
            this.numListeningPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numListeningPort.Name = "numListeningPort";
            this.numListeningPort.Size = new System.Drawing.Size(121, 20);
            this.numListeningPort.TabIndex = 3;
            this.numListeningPort.Value = new decimal(new int[] {
            9090,
            0,
            0,
            0});
            this.numListeningPort.ValueChanged += new System.EventHandler(this.numListeningPort_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "TCP Listening Port:";
            // 
            // chkAnt4
            // 
            this.chkAnt4.AutoSize = true;
            this.chkAnt4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAnt4.Location = new System.Drawing.Point(23, 151);
            this.chkAnt4.Name = "chkAnt4";
            this.chkAnt4.Size = new System.Drawing.Size(32, 17);
            this.chkAnt4.TabIndex = 8;
            this.chkAnt4.Text = "4";
            this.chkAnt4.UseVisualStyleBackColor = true;
            this.chkAnt4.CheckedChanged += new System.EventHandler(this.chkAnt4_CheckedChanged);
            // 
            // chkAnt3
            // 
            this.chkAnt3.AutoSize = true;
            this.chkAnt3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAnt3.Location = new System.Drawing.Point(23, 123);
            this.chkAnt3.Name = "chkAnt3";
            this.chkAnt3.Size = new System.Drawing.Size(32, 17);
            this.chkAnt3.TabIndex = 7;
            this.chkAnt3.Text = "3";
            this.chkAnt3.UseVisualStyleBackColor = true;
            this.chkAnt3.CheckedChanged += new System.EventHandler(this.chkAnt3_CheckedChanged);
            // 
            // chkAnt2
            // 
            this.chkAnt2.AutoSize = true;
            this.chkAnt2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAnt2.Location = new System.Drawing.Point(23, 96);
            this.chkAnt2.Name = "chkAnt2";
            this.chkAnt2.Size = new System.Drawing.Size(32, 17);
            this.chkAnt2.TabIndex = 6;
            this.chkAnt2.Text = "2";
            this.chkAnt2.UseVisualStyleBackColor = true;
            this.chkAnt2.CheckedChanged += new System.EventHandler(this.chkAnt2_CheckedChanged);
            // 
            // chkAnt1
            // 
            this.chkAnt1.AutoSize = true;
            this.chkAnt1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAnt1.Location = new System.Drawing.Point(23, 69);
            this.chkAnt1.Name = "chkAnt1";
            this.chkAnt1.Size = new System.Drawing.Size(32, 17);
            this.chkAnt1.TabIndex = 5;
            this.chkAnt1.Text = "1";
            this.chkAnt1.UseVisualStyleBackColor = true;
            this.chkAnt1.CheckedChanged += new System.EventHandler(this.chkAnt1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numTcp);
            this.groupBox2.Controls.Add(this.numHttp);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(325, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 76);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Socket Timeout";
            // 
            // numTcp
            // 
            this.numTcp.Location = new System.Drawing.Point(154, 49);
            this.numTcp.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.numTcp.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTcp.Name = "numTcp";
            this.numTcp.Size = new System.Drawing.Size(89, 20);
            this.numTcp.TabIndex = 1;
            this.numTcp.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTcp.ValueChanged += new System.EventHandler(this.numTcp_ValueChanged);
            // 
            // numHttp
            // 
            this.numHttp.Location = new System.Drawing.Point(154, 23);
            this.numHttp.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.numHttp.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numHttp.Name = "numHttp";
            this.numHttp.Size = new System.Drawing.Size(89, 20);
            this.numHttp.TabIndex = 0;
            this.numHttp.Value = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numHttp.ValueChanged += new System.EventHandler(this.numHttp_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "&TCP Connection (msec):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "&HTTP Connection (msec):";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbLocalIP);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.numListeningPort);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbLogLevel);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(322, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 110);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Others";
            // 
            // cbLocalIP
            // 
            this.cbLocalIP.FormattingEnabled = true;
            this.cbLocalIP.Location = new System.Drawing.Point(125, 72);
            this.cbLocalIP.Name = "cbLocalIP";
            this.cbLocalIP.Size = new System.Drawing.Size(121, 21);
            this.cbLocalIP.TabIndex = 5;
            this.cbLocalIP.SelectedIndexChanged += new System.EventHandler(this.cbLocalIP_SelectedIndexChanged);
            this.cbLocalIP.TextUpdate += new System.EventHandler(this.cbLocalIP_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 75);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "Local IP Address:";
            // 
            // cbLogLevel
            // 
            this.cbLogLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLogLevel.FormattingEnabled = true;
            this.cbLogLevel.Location = new System.Drawing.Point(125, 19);
            this.cbLogLevel.Name = "cbLogLevel";
            this.cbLogLevel.Size = new System.Drawing.Size(121, 21);
            this.cbLogLevel.TabIndex = 3;
            this.cbLogLevel.SelectedIndexChanged += new System.EventHandler(this.cbLogLevel_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Log Level:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(111, 423);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "S&ave Settings";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(388, 423);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(126, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "L&oad Default Settings";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbRxSensitivity);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.cbAnt4RSSI);
            this.groupBox4.Controls.Add(this.cbAnt3RSSI);
            this.groupBox4.Controls.Add(this.cbAnt2RSSI);
            this.groupBox4.Controls.Add(this.cbAnt1RSSI);
            this.groupBox4.Controls.Add(this.cbAnt4Pwr);
            this.groupBox4.Controls.Add(this.cbAnt3Pwr);
            this.groupBox4.Controls.Add(this.cbAnt2Pwr);
            this.groupBox4.Controls.Add(this.cbAnt1Pwr);
            this.groupBox4.Controls.Add(this.chkAnt4);
            this.groupBox4.Controls.Add(this.chkAnt1);
            this.groupBox4.Controls.Add(this.chkAnt3);
            this.groupBox4.Controls.Add(this.chkAnt2);
            this.groupBox4.Location = new System.Drawing.Point(322, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(304, 188);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Antennas";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(199, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "RSSI (dBm)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(69, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Output Power (dBm)";
            // 
            // cbAnt4RSSI
            // 
            this.cbAnt4RSSI.FormattingEnabled = true;
            this.cbAnt4RSSI.Location = new System.Drawing.Point(188, 149);
            this.cbAnt4RSSI.Name = "cbAnt4RSSI";
            this.cbAnt4RSSI.Size = new System.Drawing.Size(94, 21);
            this.cbAnt4RSSI.TabIndex = 16;
            this.cbAnt4RSSI.SelectedIndexChanged += new System.EventHandler(this.cbAnt4RSSI_SelectedIndexChanged);
            // 
            // cbAnt3RSSI
            // 
            this.cbAnt3RSSI.FormattingEnabled = true;
            this.cbAnt3RSSI.Location = new System.Drawing.Point(188, 122);
            this.cbAnt3RSSI.Name = "cbAnt3RSSI";
            this.cbAnt3RSSI.Size = new System.Drawing.Size(94, 21);
            this.cbAnt3RSSI.TabIndex = 15;
            this.cbAnt3RSSI.SelectedIndexChanged += new System.EventHandler(this.cbAnt3RSSI_SelectedIndexChanged);
            // 
            // cbAnt2RSSI
            // 
            this.cbAnt2RSSI.FormattingEnabled = true;
            this.cbAnt2RSSI.Location = new System.Drawing.Point(188, 95);
            this.cbAnt2RSSI.Name = "cbAnt2RSSI";
            this.cbAnt2RSSI.Size = new System.Drawing.Size(94, 21);
            this.cbAnt2RSSI.TabIndex = 14;
            this.cbAnt2RSSI.SelectedIndexChanged += new System.EventHandler(this.cbAnt2RSSI_SelectedIndexChanged);
            // 
            // cbAnt1RSSI
            // 
            this.cbAnt1RSSI.FormattingEnabled = true;
            this.cbAnt1RSSI.Location = new System.Drawing.Point(188, 67);
            this.cbAnt1RSSI.Name = "cbAnt1RSSI";
            this.cbAnt1RSSI.Size = new System.Drawing.Size(94, 21);
            this.cbAnt1RSSI.TabIndex = 13;
            this.cbAnt1RSSI.SelectedIndexChanged += new System.EventHandler(this.cbAnt1RSSI_SelectedIndexChanged);
            // 
            // cbAnt4Pwr
            // 
            this.cbAnt4Pwr.FormattingEnabled = true;
            this.cbAnt4Pwr.Location = new System.Drawing.Point(61, 149);
            this.cbAnt4Pwr.Name = "cbAnt4Pwr";
            this.cbAnt4Pwr.Size = new System.Drawing.Size(121, 21);
            this.cbAnt4Pwr.TabIndex = 12;
            this.cbAnt4Pwr.SelectedIndexChanged += new System.EventHandler(this.cbAnt4Pwr_SelectedIndexChanged);
            // 
            // cbAnt3Pwr
            // 
            this.cbAnt3Pwr.FormattingEnabled = true;
            this.cbAnt3Pwr.Location = new System.Drawing.Point(61, 121);
            this.cbAnt3Pwr.Name = "cbAnt3Pwr";
            this.cbAnt3Pwr.Size = new System.Drawing.Size(121, 21);
            this.cbAnt3Pwr.TabIndex = 11;
            this.cbAnt3Pwr.SelectedIndexChanged += new System.EventHandler(this.cbAnt3Pwr_SelectedIndexChanged);
            // 
            // cbAnt2Pwr
            // 
            this.cbAnt2Pwr.FormattingEnabled = true;
            this.cbAnt2Pwr.Location = new System.Drawing.Point(61, 94);
            this.cbAnt2Pwr.Name = "cbAnt2Pwr";
            this.cbAnt2Pwr.Size = new System.Drawing.Size(121, 21);
            this.cbAnt2Pwr.TabIndex = 10;
            this.cbAnt2Pwr.SelectedIndexChanged += new System.EventHandler(this.cbAnt2Pwr_SelectedIndexChanged);
            // 
            // cbAnt1Pwr
            // 
            this.cbAnt1Pwr.FormattingEnabled = true;
            this.cbAnt1Pwr.Location = new System.Drawing.Point(61, 67);
            this.cbAnt1Pwr.Name = "cbAnt1Pwr";
            this.cbAnt1Pwr.Size = new System.Drawing.Size(121, 21);
            this.cbAnt1Pwr.TabIndex = 9;
            this.cbAnt1Pwr.SelectedIndexChanged += new System.EventHandler(this.cbAnt1Pwr_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbAntennaPortScheme);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.numDuplicateElimination);
            this.groupBox5.Controls.Add(this.cbDuplicateEliminationMethod);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(12, 293);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(304, 113);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Duplicate Elimination";
            // 
            // cbAntennaPortScheme
            // 
            this.cbAntennaPortScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAntennaPortScheme.FormattingEnabled = true;
            this.cbAntennaPortScheme.Location = new System.Drawing.Point(146, 76);
            this.cbAntennaPortScheme.Name = "cbAntennaPortScheme";
            this.cbAntennaPortScheme.Size = new System.Drawing.Size(136, 21);
            this.cbAntennaPortScheme.TabIndex = 16;
            this.cbAntennaPortScheme.SelectedIndexChanged += new System.EventHandler(this.cbAntennaPortScheme_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 79);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "Antenna Port Scheme:";
            // 
            // numDuplicateElimination
            // 
            this.numDuplicateElimination.Location = new System.Drawing.Point(146, 50);
            this.numDuplicateElimination.Maximum = new decimal(new int[] {
            1800000,
            0,
            0,
            0});
            this.numDuplicateElimination.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numDuplicateElimination.Name = "numDuplicateElimination";
            this.numDuplicateElimination.Size = new System.Drawing.Size(136, 20);
            this.numDuplicateElimination.TabIndex = 3;
            this.numDuplicateElimination.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numDuplicateElimination.ValueChanged += new System.EventHandler(this.numDuplicateElimination_ValueChanged);
            // 
            // cbDuplicateEliminationMethod
            // 
            this.cbDuplicateEliminationMethod.FormattingEnabled = true;
            this.cbDuplicateEliminationMethod.Location = new System.Drawing.Point(101, 22);
            this.cbDuplicateEliminationMethod.Name = "cbDuplicateEliminationMethod";
            this.cbDuplicateEliminationMethod.Size = new System.Drawing.Size(181, 21);
            this.cbDuplicateEliminationMethod.TabIndex = 2;
            this.cbDuplicateEliminationMethod.SelectedIndexChanged += new System.EventHandler(this.cbDuplicateEliminationMethod_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Time (msec):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Method:";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 458);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numListeningPort)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTcp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHttp)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuplicateElimination)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numTcp;
        private System.Windows.Forms.NumericUpDown numHttp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numListeningPort;
        private System.Windows.Forms.CheckBox chkAnt1;
        private System.Windows.Forms.CheckBox chkAnt2;
        private System.Windows.Forms.CheckBox chkAnt4;
        private System.Windows.Forms.CheckBox chkAnt3;
        private System.Windows.Forms.ComboBox cbLogLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbAnt1Pwr;
        private System.Windows.Forms.ComboBox cbAnt4Pwr;
        private System.Windows.Forms.ComboBox cbAnt3Pwr;
        private System.Windows.Forms.ComboBox cbAnt2Pwr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numPopulation;
        private System.Windows.Forms.ComboBox cbModProfile;
        private System.Windows.Forms.ComboBox cbSearchMode;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numDuplicateElimination;
        private System.Windows.Forms.ComboBox cbDuplicateEliminationMethod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numSession;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbRxSensitivity;
        private System.Windows.Forms.ComboBox cbAnt2RSSI;
        private System.Windows.Forms.ComboBox cbAnt1RSSI;
        private System.Windows.Forms.ComboBox cbAnt4RSSI;
        private System.Windows.Forms.ComboBox cbAnt3RSSI;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbMemoryBanks;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbTagICModel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbAntennaPortScheme;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbLocalIP;
        private System.Windows.Forms.Label label20;

    }
}