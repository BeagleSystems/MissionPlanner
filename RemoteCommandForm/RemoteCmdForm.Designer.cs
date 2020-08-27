namespace RemoteCommandForm
{
    partial class RemoteCmdForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.videoControlGrp = new System.Windows.Forms.GroupBox();
            this.stopVideoButton = new System.Windows.Forms.Button();
            this.startVideoButton = new System.Windows.Forms.Button();
            this.diableVideoButton = new System.Windows.Forms.Button();
            this.enableVideoButton = new System.Windows.Forms.Button();
            this.mavControlGrp = new System.Windows.Forms.GroupBox();
            this.restartMavButton = new System.Windows.Forms.Button();
            this.checkMavButton = new System.Windows.Forms.Button();
            this.communicationControlGrp = new System.Windows.Forms.GroupBox();
            this.checkVPNButton = new System.Windows.Forms.Button();
            this.reconnectJoystickButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.getJoyStateTimer = new System.Windows.Forms.Timer(this.components);
            this.pitchBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.yawBar = new System.Windows.Forms.TrackBar();
            this.pitchBox = new System.Windows.Forms.TextBox();
            this.yawBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sentCountLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ackCountLabel = new System.Windows.Forms.Label();
            this.recenterButton = new System.Windows.Forms.Button();
            this.lookdownButton = new System.Windows.Forms.Button();
            this.motorOffButton = new System.Windows.Forms.Button();
            this.followYawOnButton = new System.Windows.Forms.Button();
            this.followYawOffButton = new System.Windows.Forms.Button();
            this.motorOnButton = new System.Windows.Forms.Button();
            this.zoomBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.focusBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.QuickLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.switchLabel = new System.Windows.Forms.Label();
            this.recordStateLabel = new System.Windows.Forms.Label();
            this.tcpSendButton = new System.Windows.Forms.Button();
            this.restartTcpButton = new System.Windows.Forms.Button();
            this.tcpGrpBox = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.remoteSSHTabControl = new System.Windows.Forms.TabControl();
            this.commTab = new System.Windows.Forms.TabPage();
            this.mavTab = new System.Windows.Forms.TabPage();
            this.videoTab = new System.Windows.Forms.TabPage();
            this.joystickTab = new System.Windows.Forms.TabPage();
            this.gimbalTab = new System.Windows.Forms.TabPage();
            this.refHomeCheckBox = new System.Windows.Forms.CheckBox();
            this.angleControlRadioButton = new System.Windows.Forms.RadioButton();
            this.RControlRadioButton = new System.Windows.Forms.RadioButton();
            this.setYawNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.setPitchNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.setRollNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.currentYawTextBox = new System.Windows.Forms.TextBox();
            this.currentPitchTextBox = new System.Windows.Forms.TextBox();
            this.currentRollTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sendPosButton = new System.Windows.Forms.Button();
            this.videoControlGrp.SuspendLayout();
            this.mavControlGrp.SuspendLayout();
            this.communicationControlGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pitchBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawBar)).BeginInit();
            this.tcpGrpBox.SuspendLayout();
            this.remoteSSHTabControl.SuspendLayout();
            this.commTab.SuspendLayout();
            this.mavTab.SuspendLayout();
            this.videoTab.SuspendLayout();
            this.joystickTab.SuspendLayout();
            this.gimbalTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setYawNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setPitchNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setRollNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drone IP";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(87, 37);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(114, 20);
            this.addressTextBox.TabIndex = 1;
            this.addressTextBox.Text = "192.168.10.202";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(87, 63);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(114, 20);
            this.usernameTextBox.TabIndex = 3;
            this.usernameTextBox.Text = "beagle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(87, 89);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(114, 20);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.Text = "beagle";
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 317);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(411, 320);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(207, 63);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(74, 20);
            this.connectButton.TabIndex = 7;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(207, 88);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(74, 20);
            this.disconnectButton.TabIndex = 8;
            this.disconnectButton.Text = "Close";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // videoControlGrp
            // 
            this.videoControlGrp.Controls.Add(this.stopVideoButton);
            this.videoControlGrp.Controls.Add(this.startVideoButton);
            this.videoControlGrp.Controls.Add(this.diableVideoButton);
            this.videoControlGrp.Controls.Add(this.enableVideoButton);
            this.videoControlGrp.Enabled = false;
            this.videoControlGrp.Location = new System.Drawing.Point(3, 6);
            this.videoControlGrp.Name = "videoControlGrp";
            this.videoControlGrp.Size = new System.Drawing.Size(391, 94);
            this.videoControlGrp.TabIndex = 9;
            this.videoControlGrp.TabStop = false;
            this.videoControlGrp.Text = "Video Control";
            // 
            // stopVideoButton
            // 
            this.stopVideoButton.Location = new System.Drawing.Point(220, 56);
            this.stopVideoButton.Name = "stopVideoButton";
            this.stopVideoButton.Size = new System.Drawing.Size(100, 35);
            this.stopVideoButton.TabIndex = 3;
            this.stopVideoButton.Text = "Stop Video Streaming Now";
            this.stopVideoButton.UseVisualStyleBackColor = true;
            this.stopVideoButton.Click += new System.EventHandler(this.stopVideoButton_Click);
            // 
            // startVideoButton
            // 
            this.startVideoButton.Location = new System.Drawing.Point(220, 15);
            this.startVideoButton.Name = "startVideoButton";
            this.startVideoButton.Size = new System.Drawing.Size(100, 35);
            this.startVideoButton.TabIndex = 2;
            this.startVideoButton.Text = "Start Video Streaming Now";
            this.startVideoButton.UseVisualStyleBackColor = true;
            this.startVideoButton.Click += new System.EventHandler(this.startVideoButton_Click);
            // 
            // diableVideoButton
            // 
            this.diableVideoButton.Location = new System.Drawing.Point(114, 21);
            this.diableVideoButton.Name = "diableVideoButton";
            this.diableVideoButton.Size = new System.Drawing.Size(100, 50);
            this.diableVideoButton.TabIndex = 1;
            this.diableVideoButton.Text = "Disable Video Streaming On Next Reboot";
            this.diableVideoButton.UseVisualStyleBackColor = true;
            this.diableVideoButton.Click += new System.EventHandler(this.diableVideoButton_Click);
            // 
            // enableVideoButton
            // 
            this.enableVideoButton.Location = new System.Drawing.Point(8, 21);
            this.enableVideoButton.Name = "enableVideoButton";
            this.enableVideoButton.Size = new System.Drawing.Size(100, 50);
            this.enableVideoButton.TabIndex = 0;
            this.enableVideoButton.Text = "AutoStart Video Streaming On Next Reboot";
            this.enableVideoButton.UseVisualStyleBackColor = true;
            this.enableVideoButton.Click += new System.EventHandler(this.enableVideoButton_Click);
            // 
            // mavControlGrp
            // 
            this.mavControlGrp.Controls.Add(this.restartMavButton);
            this.mavControlGrp.Controls.Add(this.checkMavButton);
            this.mavControlGrp.Enabled = false;
            this.mavControlGrp.Location = new System.Drawing.Point(6, 6);
            this.mavControlGrp.Name = "mavControlGrp";
            this.mavControlGrp.Size = new System.Drawing.Size(396, 108);
            this.mavControlGrp.TabIndex = 10;
            this.mavControlGrp.TabStop = false;
            this.mavControlGrp.Text = "MavProxy";
            // 
            // restartMavButton
            // 
            this.restartMavButton.Location = new System.Drawing.Point(87, 19);
            this.restartMavButton.Name = "restartMavButton";
            this.restartMavButton.Size = new System.Drawing.Size(75, 23);
            this.restartMavButton.TabIndex = 2;
            this.restartMavButton.Text = "Restart";
            this.restartMavButton.UseVisualStyleBackColor = true;
            this.restartMavButton.Click += new System.EventHandler(this.restartMavButton_Click);
            // 
            // checkMavButton
            // 
            this.checkMavButton.Location = new System.Drawing.Point(6, 19);
            this.checkMavButton.Name = "checkMavButton";
            this.checkMavButton.Size = new System.Drawing.Size(75, 23);
            this.checkMavButton.TabIndex = 1;
            this.checkMavButton.Text = "Status";
            this.checkMavButton.UseVisualStyleBackColor = true;
            this.checkMavButton.Click += new System.EventHandler(this.checkMavButton_Click);
            // 
            // communicationControlGrp
            // 
            this.communicationControlGrp.Controls.Add(this.checkVPNButton);
            this.communicationControlGrp.Enabled = false;
            this.communicationControlGrp.Location = new System.Drawing.Point(6, 7);
            this.communicationControlGrp.Name = "communicationControlGrp";
            this.communicationControlGrp.Size = new System.Drawing.Size(122, 51);
            this.communicationControlGrp.TabIndex = 11;
            this.communicationControlGrp.TabStop = false;
            this.communicationControlGrp.Text = "Communication";
            // 
            // checkVPNButton
            // 
            this.checkVPNButton.Location = new System.Drawing.Point(22, 19);
            this.checkVPNButton.Name = "checkVPNButton";
            this.checkVPNButton.Size = new System.Drawing.Size(75, 23);
            this.checkVPNButton.TabIndex = 0;
            this.checkVPNButton.Text = "VPN Log";
            this.checkVPNButton.UseVisualStyleBackColor = true;
            this.checkVPNButton.Click += new System.EventHandler(this.checkVPNButton_Click);
            // 
            // reconnectJoystickButton
            // 
            this.reconnectJoystickButton.Location = new System.Drawing.Point(19, 13);
            this.reconnectJoystickButton.Name = "reconnectJoystickButton";
            this.reconnectJoystickButton.Size = new System.Drawing.Size(100, 23);
            this.reconnectJoystickButton.TabIndex = 4;
            this.reconnectJoystickButton.Text = "Connect JoyStick";
            this.reconnectJoystickButton.UseVisualStyleBackColor = true;
            this.reconnectJoystickButton.Click += new System.EventHandler(this.reconnectJoystickButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pitch";
            // 
            // getJoyStateTimer
            // 
            this.getJoyStateTimer.Tick += new System.EventHandler(this.getJoyStateTimer_Tick);
            // 
            // pitchBar
            // 
            this.pitchBar.Location = new System.Drawing.Point(53, 42);
            this.pitchBar.Maximum = 255;
            this.pitchBar.Name = "pitchBar";
            this.pitchBar.Size = new System.Drawing.Size(164, 45);
            this.pitchBar.TabIndex = 15;
            this.pitchBar.Value = 128;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Yaw";
            // 
            // yawBar
            // 
            this.yawBar.Location = new System.Drawing.Point(53, 93);
            this.yawBar.Maximum = 255;
            this.yawBar.Name = "yawBar";
            this.yawBar.Size = new System.Drawing.Size(164, 45);
            this.yawBar.TabIndex = 19;
            this.yawBar.Value = 128;
            // 
            // pitchBox
            // 
            this.pitchBox.Location = new System.Drawing.Point(11, 58);
            this.pitchBox.Name = "pitchBox";
            this.pitchBox.Size = new System.Drawing.Size(46, 20);
            this.pitchBox.TabIndex = 20;
            this.pitchBox.Text = "128";
            // 
            // yawBox
            // 
            this.yawBox.Location = new System.Drawing.Point(11, 109);
            this.yawBox.Name = "yawBox";
            this.yawBox.Size = new System.Drawing.Size(46, 20);
            this.yawBox.TabIndex = 21;
            this.yawBox.Text = "128";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Sent";
            // 
            // sentCountLabel
            // 
            this.sentCountLabel.AutoSize = true;
            this.sentCountLabel.Location = new System.Drawing.Point(270, 142);
            this.sentCountLabel.Name = "sentCountLabel";
            this.sentCountLabel.Size = new System.Drawing.Size(13, 13);
            this.sentCountLabel.TabIndex = 23;
            this.sentCountLabel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Ack";
            // 
            // ackCountLabel
            // 
            this.ackCountLabel.AutoSize = true;
            this.ackCountLabel.Location = new System.Drawing.Point(383, 142);
            this.ackCountLabel.Name = "ackCountLabel";
            this.ackCountLabel.Size = new System.Drawing.Size(13, 13);
            this.ackCountLabel.TabIndex = 25;
            this.ackCountLabel.Text = "0";
            // 
            // recenterButton
            // 
            this.recenterButton.Location = new System.Drawing.Point(245, 61);
            this.recenterButton.Name = "recenterButton";
            this.recenterButton.Size = new System.Drawing.Size(75, 23);
            this.recenterButton.TabIndex = 26;
            this.recenterButton.Text = "LookFwd";
            this.recenterButton.UseVisualStyleBackColor = true;
            // 
            // lookdownButton
            // 
            this.lookdownButton.Location = new System.Drawing.Point(326, 61);
            this.lookdownButton.Name = "lookdownButton";
            this.lookdownButton.Size = new System.Drawing.Size(75, 23);
            this.lookdownButton.TabIndex = 27;
            this.lookdownButton.Text = "LookDown";
            this.lookdownButton.UseVisualStyleBackColor = true;
            // 
            // motorOffButton
            // 
            this.motorOffButton.Location = new System.Drawing.Point(326, 32);
            this.motorOffButton.Name = "motorOffButton";
            this.motorOffButton.Size = new System.Drawing.Size(75, 23);
            this.motorOffButton.TabIndex = 28;
            this.motorOffButton.Text = "MotorOff";
            this.motorOffButton.UseVisualStyleBackColor = true;
            // 
            // followYawOnButton
            // 
            this.followYawOnButton.Location = new System.Drawing.Point(245, 90);
            this.followYawOnButton.Name = "followYawOnButton";
            this.followYawOnButton.Size = new System.Drawing.Size(75, 23);
            this.followYawOnButton.TabIndex = 29;
            this.followYawOnButton.Text = "FollowYaw";
            this.followYawOnButton.UseVisualStyleBackColor = true;
            // 
            // followYawOffButton
            // 
            this.followYawOffButton.Location = new System.Drawing.Point(326, 90);
            this.followYawOffButton.Name = "followYawOffButton";
            this.followYawOffButton.Size = new System.Drawing.Size(75, 23);
            this.followYawOffButton.TabIndex = 30;
            this.followYawOffButton.Text = "FreeYaw";
            this.followYawOffButton.UseVisualStyleBackColor = true;
            // 
            // motorOnButton
            // 
            this.motorOnButton.Location = new System.Drawing.Point(245, 32);
            this.motorOnButton.Name = "motorOnButton";
            this.motorOnButton.Size = new System.Drawing.Size(75, 23);
            this.motorOnButton.TabIndex = 31;
            this.motorOnButton.Text = "MotorOn";
            this.motorOnButton.UseVisualStyleBackColor = true;
            // 
            // zoomBox
            // 
            this.zoomBox.Location = new System.Drawing.Point(61, 139);
            this.zoomBox.Name = "zoomBox";
            this.zoomBox.Size = new System.Drawing.Size(46, 20);
            this.zoomBox.TabIndex = 33;
            this.zoomBox.Text = "128";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Zoom";
            // 
            // focusBox
            // 
            this.focusBox.Location = new System.Drawing.Point(164, 139);
            this.focusBox.Name = "focusBox";
            this.focusBox.Size = new System.Drawing.Size(46, 20);
            this.focusBox.TabIndex = 35;
            this.focusBox.Text = "128";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Focus";
            // 
            // QuickLabel
            // 
            this.QuickLabel.AutoSize = true;
            this.QuickLabel.Location = new System.Drawing.Point(242, 16);
            this.QuickLabel.Name = "QuickLabel";
            this.QuickLabel.Size = new System.Drawing.Size(35, 13);
            this.QuickLabel.TabIndex = 36;
            this.QuickLabel.Text = "Quick";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Mode";
            // 
            // switchLabel
            // 
            this.switchLabel.AutoSize = true;
            this.switchLabel.Location = new System.Drawing.Point(298, 117);
            this.switchLabel.Name = "switchLabel";
            this.switchLabel.Size = new System.Drawing.Size(34, 13);
            this.switchLabel.TabIndex = 38;
            this.switchLabel.Text = "Video";
            // 
            // recordStateLabel
            // 
            this.recordStateLabel.AutoSize = true;
            this.recordStateLabel.Location = new System.Drawing.Point(354, 117);
            this.recordStateLabel.Name = "recordStateLabel";
            this.recordStateLabel.Size = new System.Drawing.Size(47, 13);
            this.recordStateLabel.TabIndex = 39;
            this.recordStateLabel.Text = "Stopped";
            // 
            // tcpSendButton
            // 
            this.tcpSendButton.Location = new System.Drawing.Point(125, 13);
            this.tcpSendButton.Name = "tcpSendButton";
            this.tcpSendButton.Size = new System.Drawing.Size(100, 23);
            this.tcpSendButton.TabIndex = 40;
            this.tcpSendButton.Text = "Start Control";
            this.tcpSendButton.UseVisualStyleBackColor = true;
            this.tcpSendButton.Click += new System.EventHandler(this.tcpSendButton_Click);
            // 
            // restartTcpButton
            // 
            this.restartTcpButton.Location = new System.Drawing.Point(22, 19);
            this.restartTcpButton.Name = "restartTcpButton";
            this.restartTcpButton.Size = new System.Drawing.Size(75, 23);
            this.restartTcpButton.TabIndex = 0;
            this.restartTcpButton.Text = "RestartTcpServer";
            this.restartTcpButton.UseVisualStyleBackColor = true;
            this.restartTcpButton.Click += new System.EventHandler(this.restartTcpButton_Click);
            // 
            // tcpGrpBox
            // 
            this.tcpGrpBox.Controls.Add(this.restartTcpButton);
            this.tcpGrpBox.Enabled = false;
            this.tcpGrpBox.Location = new System.Drawing.Point(134, 7);
            this.tcpGrpBox.Name = "tcpGrpBox";
            this.tcpGrpBox.Size = new System.Drawing.Size(122, 51);
            this.tcpGrpBox.TabIndex = 12;
            this.tcpGrpBox.TabStop = false;
            this.tcpGrpBox.Text = "TCP Server";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Run Remote Commands over SSH";
            // 
            // remoteSSHTabControl
            // 
            this.remoteSSHTabControl.Controls.Add(this.commTab);
            this.remoteSSHTabControl.Controls.Add(this.mavTab);
            this.remoteSSHTabControl.Controls.Add(this.videoTab);
            this.remoteSSHTabControl.Controls.Add(this.joystickTab);
            this.remoteSSHTabControl.Controls.Add(this.gimbalTab);
            this.remoteSSHTabControl.Location = new System.Drawing.Point(12, 115);
            this.remoteSSHTabControl.Name = "remoteSSHTabControl";
            this.remoteSSHTabControl.SelectedIndex = 0;
            this.remoteSSHTabControl.Size = new System.Drawing.Size(415, 196);
            this.remoteSSHTabControl.TabIndex = 42;
            // 
            // commTab
            // 
            this.commTab.Controls.Add(this.communicationControlGrp);
            this.commTab.Controls.Add(this.tcpGrpBox);
            this.commTab.Location = new System.Drawing.Point(4, 22);
            this.commTab.Name = "commTab";
            this.commTab.Padding = new System.Windows.Forms.Padding(3);
            this.commTab.Size = new System.Drawing.Size(407, 170);
            this.commTab.TabIndex = 0;
            this.commTab.Text = "Communication";
            this.commTab.UseVisualStyleBackColor = true;
            // 
            // mavTab
            // 
            this.mavTab.Controls.Add(this.mavControlGrp);
            this.mavTab.Location = new System.Drawing.Point(4, 22);
            this.mavTab.Name = "mavTab";
            this.mavTab.Padding = new System.Windows.Forms.Padding(3);
            this.mavTab.Size = new System.Drawing.Size(407, 170);
            this.mavTab.TabIndex = 1;
            this.mavTab.Text = "MavProxy";
            this.mavTab.UseVisualStyleBackColor = true;
            // 
            // videoTab
            // 
            this.videoTab.Controls.Add(this.videoControlGrp);
            this.videoTab.Location = new System.Drawing.Point(4, 22);
            this.videoTab.Name = "videoTab";
            this.videoTab.Size = new System.Drawing.Size(407, 170);
            this.videoTab.TabIndex = 2;
            this.videoTab.Text = "VIdeoControl";
            this.videoTab.UseVisualStyleBackColor = true;
            // 
            // joystickTab
            // 
            this.joystickTab.Controls.Add(this.tcpSendButton);
            this.joystickTab.Controls.Add(this.reconnectJoystickButton);
            this.joystickTab.Controls.Add(this.label4);
            this.joystickTab.Controls.Add(this.pitchBar);
            this.joystickTab.Controls.Add(this.label6);
            this.joystickTab.Controls.Add(this.recordStateLabel);
            this.joystickTab.Controls.Add(this.yawBar);
            this.joystickTab.Controls.Add(this.switchLabel);
            this.joystickTab.Controls.Add(this.pitchBox);
            this.joystickTab.Controls.Add(this.label10);
            this.joystickTab.Controls.Add(this.yawBox);
            this.joystickTab.Controls.Add(this.QuickLabel);
            this.joystickTab.Controls.Add(this.label5);
            this.joystickTab.Controls.Add(this.focusBox);
            this.joystickTab.Controls.Add(this.sentCountLabel);
            this.joystickTab.Controls.Add(this.label9);
            this.joystickTab.Controls.Add(this.label8);
            this.joystickTab.Controls.Add(this.zoomBox);
            this.joystickTab.Controls.Add(this.ackCountLabel);
            this.joystickTab.Controls.Add(this.label7);
            this.joystickTab.Controls.Add(this.recenterButton);
            this.joystickTab.Controls.Add(this.motorOnButton);
            this.joystickTab.Controls.Add(this.lookdownButton);
            this.joystickTab.Controls.Add(this.followYawOffButton);
            this.joystickTab.Controls.Add(this.motorOffButton);
            this.joystickTab.Controls.Add(this.followYawOnButton);
            this.joystickTab.Location = new System.Drawing.Point(4, 22);
            this.joystickTab.Name = "joystickTab";
            this.joystickTab.Size = new System.Drawing.Size(407, 170);
            this.joystickTab.TabIndex = 3;
            this.joystickTab.Text = "XboxController";
            this.joystickTab.UseVisualStyleBackColor = true;
            // 
            // gimbalTab
            // 
            this.gimbalTab.Controls.Add(this.sendPosButton);
            this.gimbalTab.Controls.Add(this.refHomeCheckBox);
            this.gimbalTab.Controls.Add(this.angleControlRadioButton);
            this.gimbalTab.Controls.Add(this.RControlRadioButton);
            this.gimbalTab.Controls.Add(this.setYawNumericUpDown);
            this.gimbalTab.Controls.Add(this.setPitchNumericUpDown);
            this.gimbalTab.Controls.Add(this.setRollNumericUpDown);
            this.gimbalTab.Controls.Add(this.label16);
            this.gimbalTab.Controls.Add(this.currentYawTextBox);
            this.gimbalTab.Controls.Add(this.currentPitchTextBox);
            this.gimbalTab.Controls.Add(this.currentRollTextBox);
            this.gimbalTab.Controls.Add(this.label15);
            this.gimbalTab.Controls.Add(this.label14);
            this.gimbalTab.Controls.Add(this.label13);
            this.gimbalTab.Controls.Add(this.label12);
            this.gimbalTab.Location = new System.Drawing.Point(4, 22);
            this.gimbalTab.Name = "gimbalTab";
            this.gimbalTab.Size = new System.Drawing.Size(407, 170);
            this.gimbalTab.TabIndex = 4;
            this.gimbalTab.Text = "GimbalPosControl";
            this.gimbalTab.UseVisualStyleBackColor = true;
            // 
            // refHomeCheckBox
            // 
            this.refHomeCheckBox.AutoSize = true;
            this.refHomeCheckBox.Location = new System.Drawing.Point(258, 121);
            this.refHomeCheckBox.Name = "refHomeCheckBox";
            this.refHomeCheckBox.Size = new System.Drawing.Size(104, 17);
            this.refHomeCheckBox.TabIndex = 16;
            this.refHomeCheckBox.Text = "Angle Ref Home";
            this.refHomeCheckBox.UseVisualStyleBackColor = true;
            // 
            // angleControlRadioButton
            // 
            this.angleControlRadioButton.AutoSize = true;
            this.angleControlRadioButton.Checked = true;
            this.angleControlRadioButton.Location = new System.Drawing.Point(136, 120);
            this.angleControlRadioButton.Name = "angleControlRadioButton";
            this.angleControlRadioButton.Size = new System.Drawing.Size(116, 17);
            this.angleControlRadioButton.TabIndex = 15;
            this.angleControlRadioButton.TabStop = true;
            this.angleControlRadioButton.Text = "Angle control mode";
            this.angleControlRadioButton.UseVisualStyleBackColor = true;
            this.angleControlRadioButton.CheckedChanged += new System.EventHandler(this.angleControlRadioButton_CheckedChanged);
            // 
            // RControlRadioButton
            // 
            this.RControlRadioButton.AutoSize = true;
            this.RControlRadioButton.Location = new System.Drawing.Point(12, 120);
            this.RControlRadioButton.Name = "RControlRadioButton";
            this.RControlRadioButton.Size = new System.Drawing.Size(104, 17);
            this.RControlRadioButton.TabIndex = 14;
            this.RControlRadioButton.Text = "RC control mode";
            this.RControlRadioButton.UseVisualStyleBackColor = true;
            this.RControlRadioButton.CheckedChanged += new System.EventHandler(this.RControlRadioButton_CheckedChanged);
            // 
            // setYawNumericUpDown
            // 
            this.setYawNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.setYawNumericUpDown.Location = new System.Drawing.Point(136, 81);
            this.setYawNumericUpDown.Name = "setYawNumericUpDown";
            this.setYawNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.setYawNumericUpDown.TabIndex = 10;
            // 
            // setPitchNumericUpDown
            // 
            this.setPitchNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.setPitchNumericUpDown.Location = new System.Drawing.Point(136, 55);
            this.setPitchNumericUpDown.Name = "setPitchNumericUpDown";
            this.setPitchNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.setPitchNumericUpDown.TabIndex = 9;
            // 
            // setRollNumericUpDown
            // 
            this.setRollNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.setRollNumericUpDown.Location = new System.Drawing.Point(136, 28);
            this.setRollNumericUpDown.Name = "setRollNumericUpDown";
            this.setRollNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.setRollNumericUpDown.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(144, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Set To";
            // 
            // currentYawTextBox
            // 
            this.currentYawTextBox.Location = new System.Drawing.Point(53, 80);
            this.currentYawTextBox.Name = "currentYawTextBox";
            this.currentYawTextBox.Size = new System.Drawing.Size(63, 20);
            this.currentYawTextBox.TabIndex = 6;
            // 
            // currentPitchTextBox
            // 
            this.currentPitchTextBox.Location = new System.Drawing.Point(53, 54);
            this.currentPitchTextBox.Name = "currentPitchTextBox";
            this.currentPitchTextBox.Size = new System.Drawing.Size(63, 20);
            this.currentPitchTextBox.TabIndex = 5;
            // 
            // currentRollTextBox
            // 
            this.currentRollTextBox.Location = new System.Drawing.Point(53, 28);
            this.currentRollTextBox.Name = "currentRollTextBox";
            this.currentRollTextBox.Size = new System.Drawing.Size(63, 20);
            this.currentRollTextBox.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(50, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Current Angle";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Yaw";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Pitch";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Roll";
            // 
            // sendPosButton
            // 
            this.sendPosButton.Location = new System.Drawing.Point(210, 78);
            this.sendPosButton.Name = "sendPosButton";
            this.sendPosButton.Size = new System.Drawing.Size(75, 23);
            this.sendPosButton.TabIndex = 21;
            this.sendPosButton.Text = "Send";
            this.sendPosButton.UseVisualStyleBackColor = true;
            this.sendPosButton.Click += new System.EventHandler(this.sendPosButton_Click);
            // 
            // RemoteCmdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 651);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.remoteSSHTabControl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label1);
            this.Name = "RemoteCmdForm";
            this.Text = "Run Remote Command on Drone";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RemoteCmdForm_FormClosing);
            this.videoControlGrp.ResumeLayout(false);
            this.mavControlGrp.ResumeLayout(false);
            this.communicationControlGrp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pitchBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawBar)).EndInit();
            this.tcpGrpBox.ResumeLayout(false);
            this.remoteSSHTabControl.ResumeLayout(false);
            this.commTab.ResumeLayout(false);
            this.mavTab.ResumeLayout(false);
            this.videoTab.ResumeLayout(false);
            this.joystickTab.ResumeLayout(false);
            this.joystickTab.PerformLayout();
            this.gimbalTab.ResumeLayout(false);
            this.gimbalTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setYawNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setPitchNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setRollNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox passwordTextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.GroupBox videoControlGrp;
        private System.Windows.Forms.GroupBox mavControlGrp;
        private System.Windows.Forms.GroupBox communicationControlGrp;
        private System.Windows.Forms.Button diableVideoButton;
        private System.Windows.Forms.Button enableVideoButton;
        private System.Windows.Forms.Button stopVideoButton;
        private System.Windows.Forms.Button startVideoButton;
        private System.Windows.Forms.Button checkVPNButton;
        private System.Windows.Forms.Button restartMavButton;
        private System.Windows.Forms.Button checkMavButton;
        private System.Windows.Forms.Button reconnectJoystickButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer getJoyStateTimer;
        private System.Windows.Forms.TrackBar pitchBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar yawBar;
        private System.Windows.Forms.TextBox pitchBox;
        private System.Windows.Forms.TextBox yawBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sentCountLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ackCountLabel;
        private System.Windows.Forms.Button recenterButton;
        private System.Windows.Forms.Button lookdownButton;
        private System.Windows.Forms.Button motorOffButton;
        private System.Windows.Forms.Button followYawOnButton;
        private System.Windows.Forms.Button followYawOffButton;
        private System.Windows.Forms.Button motorOnButton;
        private System.Windows.Forms.TextBox zoomBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox focusBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label QuickLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label switchLabel;
        private System.Windows.Forms.Label recordStateLabel;
        private System.Windows.Forms.Button tcpSendButton;
        private System.Windows.Forms.Button restartTcpButton;
        private System.Windows.Forms.GroupBox tcpGrpBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl remoteSSHTabControl;
        private System.Windows.Forms.TabPage commTab;
        private System.Windows.Forms.TabPage mavTab;
        private System.Windows.Forms.TabPage videoTab;
        private System.Windows.Forms.TabPage joystickTab;
        private System.Windows.Forms.TabPage gimbalTab;
        private System.Windows.Forms.TextBox currentYawTextBox;
        private System.Windows.Forms.TextBox currentPitchTextBox;
        private System.Windows.Forms.TextBox currentRollTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown setYawNumericUpDown;
        private System.Windows.Forms.NumericUpDown setPitchNumericUpDown;
        private System.Windows.Forms.NumericUpDown setRollNumericUpDown;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton angleControlRadioButton;
        private System.Windows.Forms.RadioButton RControlRadioButton;
        private System.Windows.Forms.CheckBox refHomeCheckBox;
        private System.Windows.Forms.Button sendPosButton;
    }
}

