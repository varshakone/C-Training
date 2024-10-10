using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MathManipulation_BusinessLogicLayer;

namespace MathManipulation_TestProject
{
    [TestFixture]
    public class MathRepositoryTest
    {

        //test method to test addition of two numbers - 10,20
        //expected result must be 30

        [Test]
        public void TestAddition()
        {
            var repository = new MathRepository();
            var additionResult = repository.Addition(10, 20);


            //test result -

            Assert.AreEqual(30, additionResult);
            

        }
        

    }
}
