using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NonGeneric_GenericCollection;

namespace NonGeneric_GenericCollectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Non_GenericCollection non_GenericCollection= new Non_GenericCollection();
            //non_GenericCollection.arrayListNG();
            //non_GenericCollection.hashTable();
            //  non_GenericCollection.stack();
            //non_GenericCollection.queueGN();


            GenericCollection generic = new NonGeneric_GenericCollection.GenericCollection();
            //generic.listG();
            //generic.dictionary();
            Console.WriteLine("----Stack---");
            generic.stack();

            Console.WriteLine("----Queue---");
            generic.queueGN();
            

            Console.ReadKey();
        }
    }
}
