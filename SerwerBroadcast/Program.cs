using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SerwerBroadcast
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient udpClient = new UdpClient();
            Byte[] sendByte = Encoding.UTF8.GetBytes("Message");
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 2222);
            udpClient.Send(sendByte, sendByte.Length, endPoint);
            udpClient.Close();
        }
    }
}
