using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gragas.Model.Ping;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gragas.Model.Ping.Tests
{
    [TestClass()]
    public class IPPortTests
    {
        [TestMethod()]
        public void ListenPortTestIpisNotValid()
        {
            IPPort ipPort = new IPPort();
           Assert.AreEqual(ipPort.ListenPort("1"), false);
        }

        [TestMethod()]
        public void ListenPortTestIpisValid()
        {
            IPPort ipPort = new IPPort();
            Assert.AreEqual(ipPort.ListenPort("192.168.1.1"), true);
        }

        [TestMethod()]
        public void ListenPortTestIpisNumber()
        {
            IPPort ipPort = new IPPort();
            Assert.AreEqual(ipPort.ListenPort("AAA"), false);
        }


        [TestMethod()]
        public void ListenPortTestIpMaskisValid()
        {
            IPPort ipPort = new IPPort();
            Assert.AreEqual(ipPort.ListenPort("192.168.1.1"), true);
        }

        [TestMethod()]
        public void ListenPortTestOutOfRange255()
        {
            IPPort ipPort = new IPPort();
            Assert.AreEqual(ipPort.ListenPort("266.168.1.1"), false);
        }


    }
}
