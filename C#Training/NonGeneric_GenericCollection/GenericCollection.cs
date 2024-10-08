using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGeneric_GenericCollection
{
    public class GenericCollection
    {

        public void listG()
        {
            List<Product> lstProduct = new List<Product>();

            lstProduct.Add(new Product() { Id = 122, Name = "Pen" });
            lstProduct.Add(new Product() { Id = 123, Name = "Pencil" });
            lstProduct.Add(new Product() { Id = 124, Name = "Pencil" });
            lstProduct.Add(new Product() { Id = 125, Name = "Pencil" });
            lstProduct.Add(new Product() { Id = 123, Name = "Pencil" });


            //select record with ID =123
            IEnumerable<Product> products = lstProduct.Where(p => p.Id == 123);
            foreach (Product product in products)
            {
                Console.WriteLine(    product.Id +" "+product.Name  );
            }

            //lstProduct.Sort();

            //Group records by ID

            Console.WriteLine( "After grouping elements" );
            foreach (var item in lstProduct.GroupBy(p => p.Id))
            {
                               
                //Console.WriteLine(item.Key );
                foreach (var i in item)
                {
                    Console.WriteLine(i.Id + " "+i.Name);
                }
            }


            //
            Console.WriteLine("Order by Ascending");
          var lstOrder =  lstProduct.OrderBy(p => p.Id);

            foreach (var item in lstOrder)
            {
                Console.WriteLine(item.Id + " "+item.Name);
            }

            Console.WriteLine("Order by Descending");
            var lstOrderDesc = lstProduct.OrderByDescending(p => p.Id);

            foreach (var item in lstOrderDesc)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
            Console.WriteLine("Find perticular record");
            var findp =  lstProduct.Find(p => p.Id == 125);
            Console.WriteLine(findp.Id + " "+findp.Name);

            Console.WriteLine("Find perticular record with single");
            var singlep = lstProduct.Single(p => p.Id == 126);

            Console.WriteLine(singlep.Id + " " + singlep.Name);

            Console.WriteLine("Find perticular record with single default");
            var singlepd = lstProduct.SingleOrDefault(p => p.Id == 126);

            Console.WriteLine(singlepd.Id + " " + singlepd.Name);

           
        }

        public void dictionary()
        {
            Dictionary<int,Product> products = new Dictionary<int,Product>();

            Product product = new Product() { Id =123,Name="pen"};
            products.Add(product.Id,product);


            Product product1 = new Product() { Id = 124, Name = "pen" };
            products.Add(product1.Id, product1);


            Product product2 = new Product() { Id = 125, Name = "pencil" };
            products.Add(product2.Id, product2);

            
            foreach (var item in products)
            {
                Console.WriteLine(item.Key + " "+item.Value.Name);
            }




        }
        public void stack()
        {

            Stack<int> stack = new Stack<int>();
            stack.Push(589);
            stack.Push(963);
            stack.Push(147);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());



        }

        public void queueGN()
        {
            Queue<object> C = new Queue<object>();
            C.Enqueue(589);
            C.Enqueue("Vijay");
            C.Enqueue("Purva");

            Console.WriteLine(C.Dequeue());
            Console.WriteLine(C.Dequeue());
            Console.WriteLine(C.Dequeue());
        }

    }
}
