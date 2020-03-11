using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace Client
{
    class TCPClient
    {
        private TcpClient tcpClient;
        private Stream stream;
        private byte[] byteSend;
        private string Ip_Of_Server;
        private int port_Of_Server;

        public TCPClient(string ip, int port)
        {
            Ip_Of_Server = ip;
            port_Of_Server = port;
            tcpClient = new TcpClient();
            byteSend = new byte[10000];
        }

        public int Connect_To_Server()
        {
            try
            {
                tcpClient.Connect(IPAddress.Parse(Ip_Of_Server), port_Of_Server);
                stream = tcpClient.GetStream();
                Console.WriteLine("OK!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.StackTrace);
                return -1;
            }
            return 1;
        }

        public int SendData(byte[] bytesend)
        {
            try
            {
                Array.Clear(byteSend, 0, byteSend.Length);

                byteSend = bytesend;
                stream.Write(bytesend, 0, byteSend.Length);
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.StackTrace);
                return -1;
            }
        }

        public void CloseConnection()
        {
            this.tcpClient.Close();
        }

    }
}

