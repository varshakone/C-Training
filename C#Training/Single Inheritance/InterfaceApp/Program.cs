using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
   abstract class Product
    {
        int productId;
        string name;
        int price;
        public abstract void getProductList();
        
    }
    class Amazon : Product,IPayment
        {
        public string paymentID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void getProductList()
        {
            Console.WriteLine( "Amazon - Cloth list" );
        }

        public string payment(int amount)
        {

            //
            return "Payment done successfully with Amazon";
        }
    }
    class Dmart : Product ,IPayment 
    {
        public string paymentID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void getProductList()
        {
            Console.WriteLine( "Dmart - Grocery List" );
        }

        public string payment(int amount)
        {
            return "Payment done successfully with Dmart";
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Amazon amazon = new Amazon();
            Product product =amazon ;
            
            amazon.getProductList();
            Console.WriteLine(  amazon.payment(1));


            Dmart d = new Dmart();
            IPayment payment =d;
            d.getProductList();
            Console.WriteLine(   payment.payment(2));

            Console.ReadKey(true);
        }
    }
}
