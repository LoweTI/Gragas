using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gragas.Model.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Net.Sockets;
namespace Gragas.Model.Service.Tests
{
    [TestClass()]
    public class ListenTests
    {
        Mock<TcpClientExtensions> TcpMock;

        [TestMethod()]
        public void PortTest()
        {
            TcpMock = new Mock<TcpClientExtensions>();
            TcpMock.Setup(x => x.ConnectPort(It.IsAny<string>(), It.IsAny<int>())).Returns(false); 
            Assert.Fail();
        }
    }
}
