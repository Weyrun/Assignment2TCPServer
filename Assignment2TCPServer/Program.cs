using System;

namespace Assignment2TCPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TCPServer server = new TCPServer();
            server.start();
        }
    }
}
