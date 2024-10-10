using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ClassLibrary1;

namespace TestProject
{
    [TestFixture]
    public class ClassTest
    {

        [Test]
        public void TestAddition()
        {
            Class1 class1 = new Class1();
            var testResult = class1.Addition(10, 20);
            Assert.AreEqual(testResult,30);
        }
    }
}
