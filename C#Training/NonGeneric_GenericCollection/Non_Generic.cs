using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NonGeneric_GenericCollection
{
    public class Non_GenericCollection
    {

        public void arrayListNG()
        {
            
            ArrayList list = new ArrayList();
            list.Add(123);
            list.Add("Akshay");
            list.Add("Vijay");
            list.Add(123.123);
            list.Add('A');
            list.Add(new Product() { Id = 100, Name = "Vinay" });


            //retireve data
            foreach (var item in list)
            {
                if (item is Product)
                {
                    var product = item as Product;
                    Console.WriteLine(product.Id+" "+product.Name);
                }
                else if(item is int)
                {
                    Console.WriteLine(Convert.ToInt32(item));
                }
                else
                {
                    Console.WriteLine(item);
                }
              
            }
            Console.WriteLine(  "\n \n Using IEnumerator");
            IEnumerator enumerator =  list.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            Console.WriteLine("\n Using Indexer");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i] );
            }

            //insertion
            list.Insert(0, new Product() { Id = 102, Name = "Akash" });

            Console.WriteLine("\n After insertion");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            //remove element
            list.RemoveAt(3);
            Console.WriteLine("\n After Deleting element");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            //sorting element
            //list.Sort();
            //Console.WriteLine("\n After sorting element");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //search element
           var searchResult= list.Contains("Vijay");
            Console.WriteLine("Element found or not {0}",searchResult);


        }

        public void hashTable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "Purva Patil");
            hashtable.Add(3, "Anisha");
            hashtable.Add(2, "Akshat Jain");
            hashtable.Add('A', new Product() { Id = 103, Name = "Shreya" });

            Console.WriteLine("Using Inderxer to iterate");

            for (int i = 0; i < hashtable.Count; i++)
            {
                if (hashtable['A'] is Product)
                {
                    var result = (Product)hashtable['A'];
                    Console.WriteLine(result.Id + " " + result.Name);
                }

            }

            Console.WriteLine("Using Foreach uses internally GetEnumerator");
            foreach (DictionaryEntry item in hashtable)
            {
                
                Console.WriteLine( item.Key.ToString() + item.Value.ToString());
            }

           
        }
        public void stack()
        {

            Stack stack = new Stack();
            stack.Push(589);
            stack.Push("Vijay");
            stack.Push("Purva");

            Console.WriteLine(  stack.Pop());
            Console.WriteLine(  stack.Pop());
            Console.WriteLine(stack.Pop()   );



        }

        public void queueGN()
        {
            Queue C = new Queue();
            C.Enqueue(589);
            C.Enqueue("Vijay");
            C.Enqueue("Purva");

            Console.WriteLine(  C.Dequeue());
            Console.WriteLine(C.Dequeue());
            Console.WriteLine(C.Dequeue());
        }
        }
    }

