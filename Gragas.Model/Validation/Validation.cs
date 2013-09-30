using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Gragas.Model.Validation
{
    public class Validation
    {
        public bool Ip(string ip)
        {
            IPAddress ipAddress;

            if (ip.Split('.').Count() == 4)
            {
                return IPAddress.TryParse(ip, out ipAddress);
            }

            return false;
        }

        public bool Port(int port)
        {
            return (port > 0 && port <= 65535) ? true : false;
        }

    }
}