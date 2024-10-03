using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{ 
    public class StringM
    {
        public StringM()
        {
            StringManipulation stringManipulation = new StringManipulation();   
            
        }
    }
    public class StringManipulation
    {


        //private member
        private int stringLength(string str)
        {
            return str.Length;
        }

        //public member - within assembly and ouside of the assembly any where
        public string stringConcatination(string firstname,string lastname)
        {
            var length =stringLength(firstname);
            var name = string.Format("My Full Name is  {0} and Length of First Name {1}", firstname + lastname,length);
            return name;
        }


        //within namespace/project
        internal string newName(out string name)
        {
            name = "Vijay";
            
            return name;
        }

        //within and outside project but in derived class
        protected string nameUpper(string str)
        {
            return str.ToUpper();
        }

        //within project anywhere and uotside project  in derived class
        protected internal string nameLower(string str)
        { 
            return str.ToLower(); 
        }
    }
}
