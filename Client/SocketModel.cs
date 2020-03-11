using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class SocketModel
    {
        private Socket socket;
        private byte[] byte_receive;
        private string remoteEndPoint;

        public SocketModel(Socket s)
        {
            socket = s;
            byte_receive = new byte[10000];
        }

        public SocketModel(Socket s, int length)
        {
            socket = s;
            byte_receive = new byte[length];
        }

        public string GetRemoteEndpoint()
        {
            string str = "";
            try
            {
                str = Convert.ToString(socket.RemoteEndPoint);
                remoteEndPoint = str;
            }
            catch (Exception e)
            {
                string str1 = "Error..... " + e.StackTrace;
                Console.WriteLine(str1);
                str = "Socket is closed with " + remoteEndPoint;
            }
            return str;
        }

        //receive data from client
        public byte[] ReceiveData()
        {

            Array.Clear(byte_receive, 0, byte_receive.Length);
            try
            {
                socket.Receive(byte_receive);

                //str = System.Text.Encoding.UTF8.GetString(byte_receive);
            }
            catch (Exception e)
            {
                string str1 = "Error..... " + e.StackTrace;
                Console.WriteLine(str1);

            }
            return byte_receive;
        }


        //close sockket
        public void CloseSocket()
        {
            socket.Close();
        }

    }
}
