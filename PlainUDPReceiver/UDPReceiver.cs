using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace PlainUDPReceiver
{
    class UDPReceiver
    {
        private readonly int PORT;

        public UDPReceiver(int port)
        {
            PORT = port;
        }
        public void Start()
        {
            using (UdpClient client = new UdpClient(PORT))
            {
                byte[] buffer = new byte[2048];

                IPEndPoint SenderEP = new IPEndPoint(IPAddress.Any, 11001);


            }
        }
    }
}
