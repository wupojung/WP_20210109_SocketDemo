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
        private static byte[] result = new byte[1024];
        private static int _port = 8885;
        private Socket clientSocket;
        private Thread receiveMessageThread;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            receiveMessageThread?.Abort();
        }

    

        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse(tbIP.Text);
            _port = int.Parse(tbPort.Text);

            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect(new IPEndPoint(ip, 8885)); //配置伺服器IP與埠
            ShowMsg($"[系統]連線伺服器成功...");
            receiveMessageThread = new Thread(ReceiveMessage);
            receiveMessageThread.Start();
        }
        private void ReceiveMessage()
        {
            while (true)
            {
                int receiveLength = clientSocket.Receive(result);
                string msg = Encoding.ASCII.GetString(result, 0, receiveLength);
                Console.WriteLine("接收伺服器訊息：{0}", msg);
                ShowMsg($"[系統]{msg}");
            }
        }

        private void ShowMsg(string msg, bool newLine = true)
        {
            Console.WriteLine(msg);
            AppendTextByThreadSafe(rtbMsg, (newLine ? "\n " : "") + msg);
        }

        private delegate void AppendTextByThreadSafeDelegate(Control control, string text);

        public static void AppendTextByThreadSafe(Control control, string text)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new AppendTextByThreadSafeDelegate(AppendTextByThreadSafe), new object[] { control, text });
            }
            else
            {
                RichTextBox target = (RichTextBox)control;
                target.AppendText(text);
                target.SelectionStart = target.Text.Length;
                target.ScrollToCaret();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            clientSocket.Send(Encoding.ASCII.GetBytes(tbMsg.Text));
        }
    }
}
