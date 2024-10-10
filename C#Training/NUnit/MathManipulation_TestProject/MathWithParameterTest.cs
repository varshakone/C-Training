using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathManipulation_BusinessLogicLayer;
using NUnit.Framework;

namespace MathManipulation_TestProject
{

    [TestFixture(5, 10)]
    [TestFixture(10,20)]
    internal class MathWithParameterTest
    {
        int firstNumber, secondNumber;
        public MathWithParameterTest(int number1, int number2)
        {
            firstNumber = number1;
            secondNumber = number2;
        }

        public void Initialization()
        {
        
        }

        [Test]
        public void AdditionTest()
        {
            var repository = new MathRepository();
            var additionResult = repository.Addition(firstNumber,secondNumber);


            //test result -

            Assert.AreEqual(30, additionResult);
            Assert.AreNotEqual(10, additionResult);
        }

        [Test]
        [TestCase(20,20,Author ="Vijay",Category ="math",Description ="test substraction of two numbers",TestName ="SubstractTest")]
        public void SubstractionTest(int firstnumber,int secondnumber)
        {
            var repository = new MathRepository();
            var subResult = repository.Substraction(firstnumber, secondnumber);


            //test result -

            Assert.AreEqual(-10, subResult);
            Assert.AreNotEqual(10,subResult);
        }
    }
}
