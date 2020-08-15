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
            this.sendTcpTimer = new System.Windows.Forms.Timer(this.components);
            this.tcpSendButton = new System.Windows.Forms.Button();
            this.restartTcpButton = new System.Windows.Forms.Button();
            this.tcpGrpBox = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.videoControlGrp.SuspendLayout();
            this.mavControlGrp.SuspendLayout();
            this.communicationControlGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pitchBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawBar)).BeginInit();
            this.tcpGrpBox.SuspendLayout();
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
            this.richTextBox1.Location = new System.Drawing.Point(12, 126);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(550, 312);
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
            this.videoControlGrp.Location = new System.Drawing.Point(568, 12);
            this.videoControlGrp.Name = "videoControlGrp";
            this.videoControlGrp.Size = new System.Drawing.Size(220, 124);
            this.videoControlGrp.TabIndex = 9;
            this.videoControlGrp.TabStop = false;
            this.videoControlGrp.Text = "Video Control";
            // 
            // stopVideoButton
            // 
            this.stopVideoButton.Location = new System.Drawing.Point(114, 78);
            this.stopVideoButton.Name = "stopVideoButton";
            this.stopVideoButton.Size = new System.Drawing.Size(100, 35);
            this.stopVideoButton.TabIndex = 3;
            this.stopVideoButton.Text = "Stop Video Streaming Now";
            this.stopVideoButton.UseVisualStyleBackColor = true;
            this.stopVideoButton.Click += new System.EventHandler(this.stopVideoButton_Click);
            // 
            // startVideoButton
            // 
            this.startVideoButton.Location = new System.Drawing.Point(8, 77);
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
            this.mavControlGrp.Location = new System.Drawing.Point(415, 12);
            this.mavControlGrp.Name = "mavControlGrp";
            this.mavControlGrp.Size = new System.Drawing.Size(147, 108);
            this.mavControlGrp.TabIndex = 10;
            this.mavControlGrp.TabStop = false;
            this.mavControlGrp.Text = "MavProxy";
            // 
            // restartMavButton
            // 
            this.restartMavButton.Location = new System.Drawing.Point(36, 76);
            this.restartMavButton.Name = "restartMavButton";
            this.restartMavButton.Size = new System.Drawing.Size(75, 23);
            this.restartMavButton.TabIndex = 2;
            this.restartMavButton.Text = "Restart";
            this.restartMavButton.UseVisualStyleBackColor = true;
            this.restartMavButton.Click += new System.EventHandler(this.restartMavButton_Click);
            // 
            // checkMavButton
            // 
            this.checkMavButton.Location = new System.Drawing.Point(36, 35);
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
            this.communicationControlGrp.Location = new System.Drawing.Point(287, 12);
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
            this.reconnectJoystickButton.Location = new System.Drawing.Point(576, 147);
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
            this.label4.Location = new System.Drawing.Point(573, 176);
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
            this.pitchBar.Location = new System.Drawing.Point(610, 176);
            this.pitchBar.Maximum = 255;
            this.pitchBar.Name = "pitchBar";
            this.pitchBar.Size = new System.Drawing.Size(164, 45);
            this.pitchBar.TabIndex = 15;
            this.pitchBar.Value = 128;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Yaw";
            // 
            // yawBar
            // 
            this.yawBar.Location = new System.Drawing.Point(610, 227);
            this.yawBar.Maximum = 255;
            this.yawBar.Name = "yawBar";
            this.yawBar.Size = new System.Drawing.Size(164, 45);
            this.yawBar.TabIndex = 19;
            this.yawBar.Value = 128;
            // 
            // pitchBox
            // 
            this.pitchBox.Location = new System.Drawing.Point(568, 192);
            this.pitchBox.Name = "pitchBox";
            this.pitchBox.Size = new System.Drawing.Size(46, 20);
            this.pitchBox.TabIndex = 20;
            this.pitchBox.Text = "128";
            // 
            // yawBox
            // 
            this.yawBox.Location = new System.Drawing.Point(568, 243);
            this.yawBox.Name = "yawBox";
            this.yawBox.Size = new System.Drawing.Size(46, 20);
            this.yawBox.TabIndex = 21;
            this.yawBox.Text = "128";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Sent";
            // 
            // sentCountLabel
            // 
            this.sentCountLabel.AutoSize = true;
            this.sentCountLabel.Location = new System.Drawing.Point(607, 425);
            this.sentCountLabel.Name = "sentCountLabel";
            this.sentCountLabel.Size = new System.Drawing.Size(13, 13);
            this.sentCountLabel.TabIndex = 23;
            this.sentCountLabel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(679, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Ack";
            // 
            // ackCountLabel
            // 
            this.ackCountLabel.AutoSize = true;
            this.ackCountLabel.Location = new System.Drawing.Point(720, 425);
            this.ackCountLabel.Name = "ackCountLabel";
            this.ackCountLabel.Size = new System.Drawing.Size(13, 13);
            this.ackCountLabel.TabIndex = 25;
            this.ackCountLabel.Text = "0";
            // 
            // recenterButton
            // 
            this.recenterButton.Location = new System.Drawing.Point(618, 343);
            this.recenterButton.Name = "recenterButton";
            this.recenterButton.Size = new System.Drawing.Size(75, 23);
            this.recenterButton.TabIndex = 26;
            this.recenterButton.Text = "LookFwd";
            this.recenterButton.UseVisualStyleBackColor = true;
            // 
            // lookdownButton
            // 
            this.lookdownButton.Location = new System.Drawing.Point(699, 343);
            this.lookdownButton.Name = "lookdownButton";
            this.lookdownButton.Size = new System.Drawing.Size(75, 23);
            this.lookdownButton.TabIndex = 27;
            this.lookdownButton.Text = "LookDown";
            this.lookdownButton.UseVisualStyleBackColor = true;
            // 
            // motorOffButton
            // 
            this.motorOffButton.Location = new System.Drawing.Point(699, 314);
            this.motorOffButton.Name = "motorOffButton";
            this.motorOffButton.Size = new System.Drawing.Size(75, 23);
            this.motorOffButton.TabIndex = 28;
            this.motorOffButton.Text = "MotorOff";
            this.motorOffButton.UseVisualStyleBackColor = true;
            // 
            // followYawOnButton
            // 
            this.followYawOnButton.Location = new System.Drawing.Point(618, 372);
            this.followYawOnButton.Name = "followYawOnButton";
            this.followYawOnButton.Size = new System.Drawing.Size(75, 23);
            this.followYawOnButton.TabIndex = 29;
            this.followYawOnButton.Text = "FollowYaw";
            this.followYawOnButton.UseVisualStyleBackColor = true;
            // 
            // followYawOffButton
            // 
            this.followYawOffButton.Location = new System.Drawing.Point(699, 372);
            this.followYawOffButton.Name = "followYawOffButton";
            this.followYawOffButton.Size = new System.Drawing.Size(75, 23);
            this.followYawOffButton.TabIndex = 30;
            this.followYawOffButton.Text = "FreeYaw";
            this.followYawOffButton.UseVisualStyleBackColor = true;
            // 
            // motorOnButton
            // 
            this.motorOnButton.Location = new System.Drawing.Point(618, 314);
            this.motorOnButton.Name = "motorOnButton";
            this.motorOnButton.Size = new System.Drawing.Size(75, 23);
            this.motorOnButton.TabIndex = 31;
            this.motorOnButton.Text = "MotorOn";
            this.motorOnButton.UseVisualStyleBackColor = true;
            // 
            // zoomBox
            // 
            this.zoomBox.Location = new System.Drawing.Point(618, 273);
            this.zoomBox.Name = "zoomBox";
            this.zoomBox.Size = new System.Drawing.Size(46, 20);
            this.zoomBox.TabIndex = 33;
            this.zoomBox.Text = "128";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(573, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Zoom";
            // 
            // focusBox
            // 
            this.focusBox.Location = new System.Drawing.Point(721, 273);
            this.focusBox.Name = "focusBox";
            this.focusBox.Size = new System.Drawing.Size(46, 20);
            this.focusBox.TabIndex = 35;
            this.focusBox.Text = "128";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(679, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Focus";
            // 
            // QuickLabel
            // 
            this.QuickLabel.AutoSize = true;
            this.QuickLabel.Location = new System.Drawing.Point(615, 298);
            this.QuickLabel.Name = "QuickLabel";
            this.QuickLabel.Size = new System.Drawing.Size(35, 13);
            this.QuickLabel.TabIndex = 36;
            this.QuickLabel.Text = "Quick";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(568, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Mode";
            // 
            // switchLabel
            // 
            this.switchLabel.AutoSize = true;
            this.switchLabel.Location = new System.Drawing.Point(568, 348);
            this.switchLabel.Name = "switchLabel";
            this.switchLabel.Size = new System.Drawing.Size(34, 13);
            this.switchLabel.TabIndex = 38;
            this.switchLabel.Text = "Video";
            // 
            // recordStateLabel
            // 
            this.recordStateLabel.AutoSize = true;
            this.recordStateLabel.Location = new System.Drawing.Point(568, 377);
            this.recordStateLabel.Name = "recordStateLabel";
            this.recordStateLabel.Size = new System.Drawing.Size(47, 13);
            this.recordStateLabel.TabIndex = 39;
            this.recordStateLabel.Text = "Stopped";
            // 
            // sendTcpTimer
            // 
            this.sendTcpTimer.Interval = 500;
            this.sendTcpTimer.Tick += new System.EventHandler(this.sendTcpTimer_Tick);
            // 
            // tcpSendButton
            // 
            this.tcpSendButton.Location = new System.Drawing.Point(682, 147);
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
            this.tcpGrpBox.Location = new System.Drawing.Point(287, 69);
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
            // RemoteCmdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tcpGrpBox);
            this.Controls.Add(this.tcpSendButton);
            this.Controls.Add(this.recordStateLabel);
            this.Controls.Add(this.switchLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.QuickLabel);
            this.Controls.Add(this.focusBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.zoomBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.motorOnButton);
            this.Controls.Add(this.followYawOffButton);
            this.Controls.Add(this.followYawOnButton);
            this.Controls.Add(this.motorOffButton);
            this.Controls.Add(this.lookdownButton);
            this.Controls.Add(this.recenterButton);
            this.Controls.Add(this.ackCountLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sentCountLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yawBox);
            this.Controls.Add(this.pitchBox);
            this.Controls.Add(this.yawBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pitchBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reconnectJoystickButton);
            this.Controls.Add(this.communicationControlGrp);
            this.Controls.Add(this.mavControlGrp);
            this.Controls.Add(this.videoControlGrp);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.richTextBox1);
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
        private System.Windows.Forms.Timer sendTcpTimer;
        private System.Windows.Forms.Button tcpSendButton;
        private System.Windows.Forms.Button restartTcpButton;
        private System.Windows.Forms.GroupBox tcpGrpBox;
        private System.Windows.Forms.Label label11;
    }
}

