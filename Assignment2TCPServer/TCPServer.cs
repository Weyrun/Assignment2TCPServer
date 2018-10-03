using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

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

                string result;

                if (incommingStr == "TOGRAM")
                {

                }

                sw.WriteLine(incommingStr);
                sw.Flush();
            } //useing ending => close forbindelse til socket / Client
        }
    }
    
}