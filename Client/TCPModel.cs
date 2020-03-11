using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Client
{
    class TCPModel
    {
        private TcpListener TCPListener;
        string YourIP;
        int port_of_friend;

        public TCPModel(string ip, int port)
        {
            YourIP = ip;
            port_of_friend = port;
            TCPListener = new TcpListener(IPAddress.Parse(ip), port);
        }

        public void Listen()
        {
            try
            {
                TCPListener.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.StackTrace);
            }
        }

        public Socket AcceptNewConnection()
        {
            Socket socket = TCPListener.AcceptSocket();
            return socket;
        }

        public void Shutdown()
        {
            TCPListener.Stop();
        }



    }
}
