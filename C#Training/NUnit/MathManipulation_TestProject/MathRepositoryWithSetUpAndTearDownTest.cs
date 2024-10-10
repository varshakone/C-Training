using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathManipulation_BusinessLogicLayer;

namespace MathManipulation_TestProject
{
    [TestFixture]
    internal class MathRepositoryWithSetUpAndTearDownTest
    {
        MathRepository _mathRepository;
        

        [SetUp]
        public void Initialization()
        {
            _mathRepository= new MathRepository();
        }

        [Test]
        [TestCase(10, 20,ExpectedResult =30)]
        [MaxTime(40)]
        public int AdditionTest(int n1,int n2)
        {
           
            var additionResult = _mathRepository.Addition(n1,n2);


            //test result -
            return additionResult;
           
        }

        [Test]
        [TestCase(10, 20, 200)]
        [Repeat(5)]
        public void MultiplicationTest(int n1, int n2,int exptresult)
        {

            var mulResult = _mathRepository.Multiplication(n1, n2);
            //test result -
            Assert.That(mulResult,Is.EqualTo(exptresult));
        }

        [Test]
        [TestCase(10,20,ExpectedResult =-10)]
        [Ignore("No longer needed")]
        public int SubstractionTest(int n1, int n2)
        {

            var subResult = _mathRepository.Substraction(n1, n2);


            //test result -

            return subResult;
        }

        [TearDown]
        public void DeInitalize()
        {
            _mathRepository = null;
        }

    }
}
