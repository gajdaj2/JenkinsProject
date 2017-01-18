using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectJenkins
{
    [TestFixture]
    public class TestClass
    {

        public void TestMethod2()
        {
            Assert.Pass("Second Test");
        }

        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
        }
    }
}
