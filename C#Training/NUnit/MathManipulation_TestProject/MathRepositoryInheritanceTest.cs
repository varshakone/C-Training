using MathManipulation_BusinessLogicLayer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathManipulation_TestProject
{
    [TestFixture]
    abstract class MathRepo
    {
        [Test]
        public abstract void AdditionTest();
    }

    [TestFixture]
    internal class MathRepositoryInheritanceTest : MathRepo
    {
        [Test]
        public override void AdditionTest()
        {
            var repository = new MathRepository();
            var additionResult = repository.Addition(10, 20);


            //test result -

            Assert.AreEqual(30, additionResult);

        }
        
    }
}
