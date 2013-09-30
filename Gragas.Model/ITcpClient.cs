using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Gragas.Model
{
    public interface ITcpClient
    {
        bool ConnectPort(string ip, int port);
        
    }
}
