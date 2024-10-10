using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathManipulation_BusinessLogicLayer
{
    public class MathRepository
    {

        public int Addition(int number1,int number2)
        {
            return number1 + number2;
        }

        public int Substraction(int number1, int number2)
        {
            return number1 - number2;
        }
        public int Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
