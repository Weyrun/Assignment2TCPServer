using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Assignment1DLL;

namespace Assignment2TCPServer
{
    internal class TCPServer
    {
        private const int PORT = 7;

        public void start()
        {
            TcpListener serverListener = new TcpListener(IPAddress.Loopback, PORT);
            serverListener.Start();

            while (true)
            {
                TcpClient socket = serverListener.AcceptTcpClient();

                Task.Run(() =>
                {
                    TcpClient tempClient = socket;
                    DoClient(tempClient);

                });
            }
        }

        public void DoClient(TcpClient socket)
        {
            using (StreamReader sr = new StreamReader(socket.GetStream()))
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))
            {
                
                string incommingStr = sr.ReadLine();
                string[] input = incommingStr.Split(' ');
                string command = input[0];
                double number = Convert.ToDouble(input[1]);
                string result = "";

                if (command == "TOGRAM")
                {
                    result = $"Result = {Convertion.ConvertToGram(number)} g";
                }
                if (command == "TOOUNCES")
                {
                    result = $"Result = {Convertion.ConvertToOunces(number)} oz";
                }
                
                Console.WriteLine($"{command} {number}");
                Console.WriteLine(result);
                sw.WriteLine(result);
                sw.Flush();
            }
        }
    }
    
}