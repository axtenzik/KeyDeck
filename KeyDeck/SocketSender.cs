using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KeyDeck
{
    class SocketSender
    {
        private Thread socketServer;
        public static string data = null;
        private static string response;
        private IPAddress ipAddress = new IPAddress(new byte[] {127, 0, 0, 1 });
        private int port = 4444;

        public void SocketStart()
        {
            socketServer = new Thread(new ThreadStart(this.ServerStart));
            socketServer.IsBackground = true;
            socketServer.Start();
        }

        public void SocketStart(int connectionPort)
        {
            port = connectionPort;

            socketServer = new Thread(new ThreadStart(this.ServerStart));
            socketServer.IsBackground = true;
            socketServer.Start();
        }

        public void SocketStart(IPAddress address, int connectionPort)
        {
            ipAddress = address;
            port = connectionPort;

            socketServer = new Thread(new ThreadStart(this.ServerStart));
            socketServer.IsBackground = true;
            socketServer.Start();
        }

        public void ServerStart()
        {
            byte[] bytes = new byte[1024];

            //IPHostEntry ipHost = Dns.GetHostEntry("");
            //IPAddress ipAddress = ipHost.AddressList[0];
            //IPAddress ipAddress = new IPAddress(new byte[] { 127, 0, 0, 1 });
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, port);

            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(ipEndPoint);
                listener.Listen(10);
                Socket handler = listener.Accept();

                while (true)
                {
                    //Socket handler = listener.Accept();
                    data = null;

                    while (true)
                    {
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if (data.IndexOf("<EOF>") > -1)
                        {
                            //Console.WriteLine(data);
                            break;
                        }
                    }

                    string reply = "";
                    if (response == null)
                    {
                        reply = "pong";
                    }
                    else
                    {
                        reply = response;
                        response = null;
                    }

                    reply += "<EOF>";

                    byte[] msg = Encoding.ASCII.GetBytes(reply);

                    handler.Send(msg);
                    //handler.Shutdown(SocketShutdown.Both);
                    //handler.Close();
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
            }
        }

        public void AddToString(string toAdd)
        {
            response = toAdd;
        }
    }
}
