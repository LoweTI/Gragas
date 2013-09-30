using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Gragas.Model.Service
{
    public class Listen
    {

        public bool Port(string ip,int port)
        {
            TcpClientExtensions a = new TcpClientExtensions();
            a.ConnectPort("123.123.123.123", 80);
            return false;

        }
        
    }
}
