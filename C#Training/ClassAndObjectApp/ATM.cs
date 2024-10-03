using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectApp
{
    enum cardType { credit,debit}
    class ATM
    {
     //States of ATM Class /Fiels member/Data member
       private bool cardStatus;
       int pin;
       cardType cardType;
       bool isCardValid;
       Int64 ammount;

       




        //Property member // give either read access or write access

        //write only property with set accessor

        internal   int _Pin
        {
          
            //allows to write/assign the pin to pin data field
            set { 

            
                if(value.ToString().Length == 4)
                {
                   this.pin = value;
                }
                   
            }
        }

        //Read and write only property with set accessor and get accessor
      internal  Int64 _Amount
        {
            get
            {
                return ammount;
            }

            //allows to write/assign the pin to pin data field
            set {
                ammount = value;
                }  




        }

        //Aotu implemented property
        //behavior of ATM
        internal string withdraw()
        {
            return "Withdrawal done successfully";
        }
           
        
    }
}
