using System;

namespace Assignment3TCPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TCPClient client = new TCPClient();
            client.start();
        }
    }
}
