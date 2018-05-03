namespace Twitch_BackgroundLights
{
    partial class Form1
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
            this.lblChannel = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.txtOuput = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnArduinoGo = new System.Windows.Forms.Button();
            this.btnArduinoStop = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(12, 47);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(46, 13);
            this.lblChannel.TabIndex = 0;
            this.lblChannel.Text = "Channel";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(191, 42);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(64, 44);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(121, 20);
            this.txtChannel.TabIndex = 2;
            // 
            // txtOuput
            // 
            this.txtOuput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOuput.Location = new System.Drawing.Point(12, 71);
            this.txtOuput.Multiline = true;
            this.txtOuput.Name = "txtOuput";
            this.txtOuput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOuput.Size = new System.Drawing.Size(620, 370);
            this.txtOuput.TabIndex = 3;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(272, 42);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Location = new System.Drawing.Point(353, 13);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(23, 23);
            this.btnYellow.TabIndex = 10;
            this.btnYellow.Text = "Y";
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Lime;
            this.btnGreen.Location = new System.Drawing.Point(353, 42);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(23, 23);
            this.btnGreen.TabIndex = 11;
            this.btnGreen.Text = "G";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(382, 42);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(23, 23);
            this.btnBlue.TabIndex = 12;
            this.btnBlue.Text = "B";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(382, 13);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(23, 23);
            this.btnRed.TabIndex = 13;
            this.btnRed.Text = "R";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnArduinoGo
            // 
            this.btnArduinoGo.Location = new System.Drawing.Point(191, 15);
            this.btnArduinoGo.Name = "btnArduinoGo";
            this.btnArduinoGo.Size = new System.Drawing.Size(75, 23);
            this.btnArduinoGo.TabIndex = 14;
            this.btnArduinoGo.Text = "Go";
            this.btnArduinoGo.UseVisualStyleBackColor = true;
            this.btnArduinoGo.Click += new System.EventHandler(this.btnArduinoGo_Click);
            // 
            // btnArduinoStop
            // 
            this.btnArduinoStop.Location = new System.Drawing.Point(272, 15);
            this.btnArduinoStop.Name = "btnArduinoStop";
            this.btnArduinoStop.Size = new System.Drawing.Size(75, 23);
            this.btnArduinoStop.TabIndex = 15;
            this.btnArduinoStop.Text = "Stop";
            this.btnArduinoStop.UseVisualStyleBackColor = true;
            this.btnArduinoStop.Click += new System.EventHandler(this.btnArduinoStop_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(64, 16);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(121, 20);
            this.txtPort.TabIndex = 17;
            this.txtPort.Text = "COM6";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(12, 19);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 16;
            this.lblPort.Text = "Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 453);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.btnArduinoStop);
            this.Controls.Add(this.btnArduinoGo);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txtOuput);
            this.Controls.Add(this.txtChannel);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblChannel);
            this.Name = "Form1";
            this.Text = "Background Lights - twitch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.TextBox txtOuput;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnArduinoGo;
        private System.Windows.Forms.Button btnArduinoStop;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
    }
}

