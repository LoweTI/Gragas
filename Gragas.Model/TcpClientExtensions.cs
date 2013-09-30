using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Gragas.Model
{
    public class TcpClientExtensions : ITcpClient
    {
        public bool ConnectPort(string ip, int port)
        {
            try
            {
                ConnectPort(ip, port);
                return true;
            }
            catch (Exception)
            {
                
                return false;
            }
            
        }

    }
}
