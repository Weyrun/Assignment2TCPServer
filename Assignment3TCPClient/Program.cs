using System;

namespace Assignment3TCPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client");
            Console.WriteLine("Press ESC to close");

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {             
                TCPClient client = new TCPClient();
                client.start();
            }
        }
    }
}
