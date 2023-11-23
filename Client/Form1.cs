using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        private static readonly Socket clientSocket = new Socket
            (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private const int PORT = 69;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnectServer_Click(object sender, EventArgs e)
        {
            ConnectToServer();
            btnClear.Enabled = true;
            btnShow.Enabled = true;
            button1.Enabled = true;
            lbChooseSubject.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtLogs.Text = "";
            RequestLoop();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtLogs.Clear();
            SendString("receiveAll");
            ReceiveResponse();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }


        private void RequestLoop() //метод для отримання request
        {
            if (lbChooseSubject.Text != "")
            {
                SendRequest();
                ReceiveResponse();
            }
        }
        private void ConnectToServer() //метод для з'єдання із сервером
        {
            int attempts = 0;

            while (!clientSocket.Connected)
            {
                try
                {
                    attempts++;
                    txtLogs.AppendText("Connection attempt " + attempts);
                    clientSocket.Connect(IPAddress.Loopback, PORT);
                }
                catch (SocketException)
                {
                    txtLogs.Clear();
                }
            }

            txtLogs.Clear();
            txtLogs.AppendText("Connected");
        }

        private static void Exit() //метод для виходу із програми
        {
            SendString("exit");
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
            Environment.Exit(0);
        }
        private static void SendString(string text) //метод для надсилання request
        {
            byte[] buff = Encoding.ASCII.GetBytes(text);
            clientSocket.Send(buff, 0, buff.Length, SocketFlags.None);
        }

        private void SendRequest() //метод надсилання результату користувачеві
        {
            txtLogs.Clear();
            string request = lbChooseSubject.Text.Trim();
            SendString(request);

        }
        private void ReceiveResponse() //метод для отримання відповіді від серверу
        {
            var buff = new byte[2048];
            int received = clientSocket.Receive(buff, SocketFlags.None);
            if (received == 0) { txtLogs.AppendText("received 0"); Thread.Sleep(5000); return; }
            var data = new byte[received];
            Array.Copy(buff, data, received);
            string text = Encoding.ASCII.GetString(data);

            string[] formatted = text.Split('.');

            for (int i = 0; i < formatted.Length; i++)
            {
                txtLogs.AppendText(formatted[i] + Environment.NewLine);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLogs.Text = " ";
        }
    }
}
