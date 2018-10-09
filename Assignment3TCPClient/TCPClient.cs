using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Assignment3TCPClient
{
    internal class TCPClient
    {
        private const int PORT = 7;

        public TCPClient()
        {
        }

        public void start()
        {
            using (TcpClient socket = new TcpClient(IPAddress.Loopback.ToString(), PORT))
            {
                NetworkStream ns = socket.GetStream();

                using (StreamReader sr = new StreamReader(ns))
                using (StreamWriter sw = new StreamWriter(ns))
                {                   
                    sw.WriteLine(Console.ReadLine());
                    sw.Flush();

                    string line = sr.ReadLine();
                    
                    Console.WriteLine(line);
                }
            }
        }
    }
}