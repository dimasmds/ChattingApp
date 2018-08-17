using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Media;

namespace ChattingApp
{
    public partial class Form1 : Form
    {
        Socket socket;
        EndPoint epLocal, epRemote;
        SoundPlayer soundPlayer;

        public Form1()
        {
            InitializeComponent();
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            tbClient1Ip.Text = getLocaIP();
            buttonSend.Enabled = false;
            soundPlayer = new SoundPlayer("notify.wav");
        }

        private void buttonExpand_Click(object sender, EventArgs e)
        {
            if(buttonExpand.Text == "Hide")
            {
                for(int i = 268; i >= 30; i=i-3)
                {
                    panelConfig.Height = i;
                    buttonExpand.Text = "Configuration";
                }
               
            }
            else
            {
                for (int i = 30; i <= 268; i=i+4)
                {
                    panelConfig.Height = i;
                    buttonExpand.Text = "Hide";
                    Application.DoEvents();
                }
            }
        }

        private void MessegeCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = socket.EndReceiveFrom(aResult, ref epRemote);
                if(size > 0)
                {
                    byte[] receiveData = new byte[1464];
                    receiveData = (byte[])aResult.AsyncState;
                    ASCIIEncoding Encoding = new ASCIIEncoding();
                    string ReceiveMessege = Encoding.GetString(receiveData);

                    listBoxChat.Items.Add("Friend: " + ReceiveMessege);
                    soundPlayer.Play();
                }

                byte[] buffer = new byte[1500];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new
                     AsyncCallback(MessegeCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(tbClient1Ip.Text), Convert.ToInt32(tbClient1Port.Text));
                socket.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(tbClient2Ip.Text), Convert.ToInt32(tbClient2Port.Text));
                socket.Connect(epRemote);

                byte[] buffer = new byte[1500];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessegeCallBack), buffer);
                buttonSave.Text = "Connected";
                buttonSave.Enabled = false;
                buttonSend.Enabled = true;
                textBoxChat.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            sendMessege();
        }

        private void sendMessege()
        {
            try
            {
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = encoding.GetBytes(textBoxChat.Text);

                socket.Send(msg);
                listBoxChat.Items.Add("You: " + textBoxChat.Text);
                textBoxChat.Clear();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttoMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private string getLocaIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
    }
}
