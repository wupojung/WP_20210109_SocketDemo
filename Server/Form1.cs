using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        private static byte[] result = new byte[1024];
        private static int _port = 8885;
        static Socket serverSocket;

        private IList<Socket> clientPool;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clientPool = new List<Socket>();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            tbPort.Text = _port.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //釋放資源
            serverSocket.Close();
            clientPool.Clear();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse(cbbIP.Text);
            _port = int.Parse(tbPort.Text);

            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Bind(new IPEndPoint(ip, _port));
            serverSocket.Listen(10);    //設定最多10個排隊連線請求
            ShowMsg($"[系統]正在監聽{serverSocket.LocalEndPoint.ToString()}...");
            //通過Clientsoket傳送資料
            Thread myThread = new Thread(ListenClientConnect);
            myThread.Start();

        }


        private void ListenClientConnect()
        {
            //利用無窮回圈 接待 client
            while (true)
            {
                Socket clientSocket = serverSocket.Accept();  //client 進入!        
                clientPool.Add(clientSocket);                
                clientSocket.Send(Encoding.ASCII.GetBytes("Server Say Hello"));
                ShowMsg($"[系統]偵測到客戶端{ clientSocket.RemoteEndPoint.ToString()}連入系統...");
                Thread receiveThread = new Thread(ReceiveMessage);   //綁定接收處理
                receiveThread.Start(clientSocket);
            }
        }


        private void ReceiveMessage(object clientSocket)
        {
            Socket myClientSocket = (Socket)clientSocket;  //因為執行序只能傳遞 object,所以才需要在將資料強制轉回 (又稱解箱)

            while (true)
            {
                try
                {
                    //通過clientSocket接收資料
                    int receiveNumber = myClientSocket.Receive(result);  //受到的資料長度
                    string msg = Encoding.ASCII.GetString(result, 0, receiveNumber);
                    ShowMsg($"接收客戶端{myClientSocket.RemoteEndPoint.ToString()}訊息{msg}");
                    foreach (var socket in clientPool)
                    {
                        socket.Send(Encoding.ASCII.GetBytes(msg));
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    myClientSocket.Shutdown(SocketShutdown.Both);
                    myClientSocket.Dispose();
                    //myClientSocket.Close();
                    
                    break;
                }
            }

        }


        private void ShowMsg(string msg, bool newLine = true)
        {
            Console.WriteLine(msg);

            //AppendTextByThreadSafe(rtbMsg, );
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

    
    }
}