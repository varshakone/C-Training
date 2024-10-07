using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventApp
{
    //step 1 declare delegate
    delegate void buttonHandler(string first_name,String lastname);

    class button
    {
        //step 2 declare event in class where event raises
        public buttonHandler click;

        public void eventHandler(string first_name, String lastname)
        {
            Console.WriteLine("Full Name {0}", first_name + " " + lastname);
        }

        public void raiseEvent(string fn, string ln)
        {
            //step4 raise or start event
            click(fn, ln);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //step3 register/hookingup method with event
            button buttonclick= new button();
            buttonclick.click  = new buttonHandler(buttonclick.eventHandler);
            buttonclick.raiseEvent("abcd", "xyz");

            Console.ReadKey();


        }
    }
}
