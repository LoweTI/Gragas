using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Gragas.Model.Ping
{
    public class IPPort
    {

        public bool ListenPort(string ip)
        {

            try
            {
                IPAddress ipAddress;

                if (ip.Split('.').Count() == 4)
                {
                    return IPAddress.TryParse(ip, out ipAddress);
                }

            }
            catch (Exception ex)
            {

                throw new Exception("IP inválido");
            }

            return false;



        }
    }
}
