using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bars1
{
    internal class mb_tcp
    {
        string ip = "192.168.0.102";
        int port = 502;

        // ips
        private string _ips;
        public string ips
        {
            get { return _ips; }
            set 
            { 
                if ((_ips != value) && (value != null))
                _ips = value;
            }
        }

        // tcp query from master
        public void Rx(bool need_answer, bool link_enabled, string pol, string portt)
        {
            int porttt = Convert.ToInt32(portt);
            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(pol), porttt);
            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            if (!link_enabled)
            {
               
                    tcpSocket.Bind(tcpEndPoint);


                    tcpSocket.Listen(1);
                    link_enabled = true;
                    while (true)
                    {
                        var listener = tcpSocket.Accept();
                        bag = new byte[256];
                        var size = 0;
                        var data = new StringBuilder();
                        do
                        {
                            size = listener.Receive(bag);
                            data.Append(Encoding.UTF8.GetString(bag, 0, size));
                        } while (listener.Available > 0);

                        if (need_answer) Tx();
                        //tcpSocket.Disconnect(true);
                        //tcpSocket.Close();
                        link_enabled = false;
                    }
                }
            else
                {
                    //tcpSocket.Disconnect(true);
                    tcpSocket.Close();
                    tcpSocket.Dispose();

                    tcpEndPoint = null;
                    link_enabled = false;
                }

        }

        // tcp answer from slave
        public void Tx()
        {
            //byte[] tre = new byte[] { 0, 0, 0, 0, 0, 7, 1, 3, 4, 194, 246, 189, 93 };
            //listener.Send(for_answer);
        }

        // bags from master
        private byte[] _bag;
        public byte[] bag
        {
            get { return _bag; }
            set { _bag = value; }
        }
    }
}
