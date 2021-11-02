namespace HTPCAVRVolume
{
    partial class HTPCAVRVolume
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
            this.btnVolUp = new System.Windows.Forms.Button();
            this.btnVolDown = new System.Windows.Forms.Button();
            this.btnToggleMute = new System.Windows.Forms.Button();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.lblDevice = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btnVolUp
            // 
            this.btnVolUp.Location = new System.Drawing.Point(112, 65);
            this.btnVolUp.Name = "btnVolUp";
            this.btnVolUp.Size = new System.Drawing.Size(81, 25);
            this.btnVolUp.TabIndex = 0;
            this.btnVolUp.Text = "VolUp";
            this.btnVolUp.UseVisualStyleBackColor = true;
            this.btnVolUp.Click += new System.EventHandler(this.BtnVolUp_Click);
            // 
            // btnVolDown
            // 
            this.btnVolDown.Location = new System.Drawing.Point(12, 65);
            this.btnVolDown.Name = "btnVolDown";
            this.btnVolDown.Size = new System.Drawing.Size(94, 25);
            this.btnVolDown.TabIndex = 1;
            this.btnVolDown.Text = "VolDown";
            this.btnVolDown.UseVisualStyleBackColor = true;
            this.btnVolDown.Click += new System.EventHandler(this.BtnVolDown_Click);
            // 
            // btnToggleMute
            // 
            this.btnToggleMute.Location = new System.Drawing.Point(199, 65);
            this.btnToggleMute.Name = "btnToggleMute";
            this.btnToggleMute.Size = new System.Drawing.Size(88, 25);
            this.btnToggleMute.TabIndex = 3;
            this.btnToggleMute.Text = "Mute/UnMute";
            this.btnToggleMute.UseVisualStyleBackColor = true;
            this.btnToggleMute.Click += new System.EventHandler(this.BtnToggleMute_Click);
            // 
            // cmbDevice
            // 
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Items.AddRange(new object[] {
            "DenonMarantz",
            "StormAudio"});
            this.cmbDevice.Location = new System.Drawing.Point(62, 12);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(131, 21);
            this.cmbDevice.TabIndex = 4;
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(12, 15);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(44, 13);
            this.lblDevice.TabIndex = 5;
            this.lblDevice.Text = "Device:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(12, 42);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(20, 13);
            this.lblIP.TabIndex = 6;
            this.lblIP.Text = "IP:";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(62, 39);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(131, 20);
            this.tbIP.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(199, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 47);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "HTPCAVRVolume";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // HTPCAVRVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 100);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.lblDevice);
            this.Controls.Add(this.cmbDevice);
            this.Controls.Add(this.btnToggleMute);
            this.Controls.Add(this.btnVolDown);
            this.Controls.Add(this.btnVolUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HTPCAVRVolume";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTPCAVRVolume";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HTPCAVRVolume_FormClosed);
            this.Load += new System.EventHandler(this.HTPCAVRVolume_Load);
            this.Shown += new System.EventHandler(this.HTPCAVRVolume_Shown);
            this.Resize += new System.EventHandler(this.HTPCAVRVolume_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolUp;
        private System.Windows.Forms.Button btnVolDown;
        private System.Windows.Forms.Button btnToggleMute;
        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

