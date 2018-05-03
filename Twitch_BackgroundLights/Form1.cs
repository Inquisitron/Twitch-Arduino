using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchLib;

namespace Twitch_BackgroundLights
{
    public partial class Form1 : Form
    {
        delegate void SetTextCallback(string Text);
        private SerialPort objSerialPort;
        private TwitchClient objTwitchClient;
        private string strUser = "USER NAME GOES HERE";
        private string strToken = "TOKEN ID GOES HERE";

        private void Demo()
        {
            this.txtOuput.Clear();
            string strChannel = this.txtChannel.Text;

            WebClient objWebClient = new WebClient();
            objWebClient.Headers.Add("Client-ID", strToken);
            objWebClient.Headers.Add("Accept", "application/vnd.twitchtv.v5+json");
            objWebClient.Headers.Add("Authorization", "OAuth " + strToken);
            String strJSON = objWebClient.DownloadString("https://api.twitch.tv/kraken" + "/channel/" + strChannel);
            this.txtOuput.Text = strJSON;

            // channel
            // teams
            // user
            // streams
            // ingests
        }
        
        public Form1()
        {
            InitializeComponent();

            this.objSerialPort = new SerialPort();
            this.objSerialPort.DataReceived += objSerialPort_DataReceived;
        }

        void objTwitchClient_OnMessageReceived(object sender, TwitchLib.Events.Client.OnMessageReceivedArgs e)
        {
            SetText(e.ChatMessage.Message);
            EvaluateMessage(e.ChatMessage.Message);
        }

        private void EvaluateMessage(string Message)
        {
            if (Message.ToLower().Contains("light:"))
            {
                string strColor = Message.ToLower().Replace("light:", "");
                Light(strColor);
            }
            if (Message.ToLower().Contains("lol"))
            {
                Light("R");
            }
            if (Message.ToLower().Contains("NWAF"))
            {
                Light("B");
            }
        }

        private void Light(string Color)
        {
            if (this.objSerialPort.IsOpen)
            {
                switch (Color.ToLower())
                {
                    case "y":
                        this.objSerialPort.Write("Y");
                        break;
                    case "g":
                        this.objSerialPort.Write("G");
                        break;
                    case "r":
                        this.objSerialPort.Write("R");
                        break;
                    case "b":
                        this.objSerialPort.Write("B");
                        break;
                    default:
                        break;
                }
            }
        }

        private void SetText(string Text)
        {
            if (this.txtOuput.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { Text });
            }
            else
            {
                this.txtOuput.Text += Text + Environment.NewLine;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string strChannel = this.txtChannel.Text.ToLower();
            try
            {
                TwitchLib.Models.Client.ConnectionCredentials objConnectionCredentials = new TwitchLib.Models.Client.ConnectionCredentials(strUser, "oauth:" + strToken);
                this.objTwitchClient = new TwitchClient(objConnectionCredentials, strChannel);
                this.objTwitchClient.OnMessageReceived += objTwitchClient_OnMessageReceived;
                this.objTwitchClient.Connect();
            }
            catch (Exception ex)
            {
                this.txtOuput.Text += ex.Message;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.objTwitchClient.Disconnect();
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            Light("Y");
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            Light("R");
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            Light("B");
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            Light("G");
        }

        private void btnArduinoGo_Click(object sender, EventArgs e)
        {
            if (!this.objSerialPort.IsOpen)
            {
                this.objSerialPort.BaudRate = 9600;
                this.objSerialPort.PortName = this.txtPort.Text;
                this.objSerialPort.Open();
                this.objSerialPort.DtrEnable = true;
            }
        }

        void objSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SetText(this.objSerialPort.ReadExisting());
        }

        private void btnArduinoStop_Click(object sender, EventArgs e)
        {
            if (this.objSerialPort.IsOpen)
            {
                this.objSerialPort.Close();
            }
        }
    }
}

/*
const int pinY = 14;
const int pinG = 15;
const int pinR = 7;
const int pinB = 6;

bool bY = 0;
bool bG = 0;
bool bR = 0;
bool bB = 0;

void setup() {
  pinMode(pinY, OUTPUT);
  pinMode(pinG, OUTPUT);
  pinMode(pinR, OUTPUT);
  pinMode(pinB, OUTPUT);

  digitalWrite(pinY, bY);
  digitalWrite(pinG, bG);
  digitalWrite(pinR, bR);
  digitalWrite(pinB, bB);

  Serial.begin(9600);
}

void loop() {
  if (Serial.available()) {
    char cSelection = Serial.read();
    switch (cSelection) {
      case 'y':
      case 'Y':
        bY = !bY;
        digitalWrite(pinY, bY);
        break;
      case 'g':
      case 'G':
        bG = !bG;
        digitalWrite(pinG, bG);
        break;
      case 'r':
      case 'R':
        bR = !bR;
        digitalWrite(pinR, bR);
        break;
      case 'b':
      case 'B':
        bB = !bB;
        digitalWrite(pinB, bB);
        break;
      default:
        Serial.println(cSelection);
        break;
    }
  }
}
*/