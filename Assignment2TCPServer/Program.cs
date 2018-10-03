using System;

namespace Assignment2TCPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Server");
            
                TCPServer server = new TCPServer();
                server.start();

            Console.ReadLine();
        }
    }
}
