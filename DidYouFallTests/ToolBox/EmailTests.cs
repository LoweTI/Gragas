using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DidYouFall.Repository;
using DidYouFall.ToolBox;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DidYouFall.ToolBox.Tests
{
    [TestClass()]
    public class EmailTests
    {
        Server server = new Server()
        {
            IP = "127.0.0.1",
            Name = "Servido teste",
            Contactemail = "suporte@hebara.com.br",
        };

        [TestMethod()]
        public void OfflineEmailTest()
        {
            Email.OfflineEmail(server).sendMail();
        }

        [TestMethod()]
        public void OnlineEmailTest()
        {
            Email.OnlineEmail(server).sendMail();
        }
    }
}
