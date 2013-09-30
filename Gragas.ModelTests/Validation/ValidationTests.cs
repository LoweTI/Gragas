using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gragas.Model.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Gragas.Model.Validation.Tests
{
    [TestClass()]
    public class ValidationTests
    {
        Validation validate = new Validation();

        [TestMethod()]
        public void ValidateTestIpisNotValid()
        {
            Assert.IsFalse(validate.Ip("1"));
        }

        [TestMethod()]
        public void ValidateTestIpisValid()
        {
            Assert.IsTrue(validate.Ip("192.168.1.1"));
        }

        [TestMethod()]
        public void ValidateTestIpisNumber()
        {
            Assert.IsFalse(validate.Ip("AAA"));
        }


        [TestMethod()]
        public void ValidateTestIpMaskisValid()
        {
            Assert.IsTrue(validate.Ip("192.168.1.1"));
        }

        [TestMethod()]
        public void ValidateTestOutOfRange255()
        {
            Assert.IsFalse(validate.Ip("266.168.1.1"));
        }

        [TestMethod()]
        public void IfPort_0_ReturnFalse()
        {
            Assert.IsFalse(validate.Port(0));
        }


        [TestMethod()]
        public void IfPortMoreThan65535ReturnFalse()
        {
            Assert.IsFalse(validate.Port(65536));
        }
       
        [TestMethod()]
        public void IfPortnegativeReturnFalse()
        {
            Assert.IsFalse(validate.Port(-1));
        }

        [TestMethod()]
        public void IfPortValidReturnTrue()
        {
            Assert.IsTrue(validate.Port(1));
        }
    }
}
