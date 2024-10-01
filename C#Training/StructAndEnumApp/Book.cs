using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAndEnumApp
{


    enum publishMonth
    {
        January = 1, February, March, April, May, june, July
    }


    internal struct Book
    {
        
        public int Id;
        public string Name;
        public string Title;
        public publishMonth publishingMonth ;

        public Book(int id, string name, string title, publishMonth month)
        {
            Id = id;
            Name = name;
            Title = title;
            publishingMonth = month;
        }
        public string getBookList()
        {
            return Id + " "+Name + " " + Title +" "+publishingMonth;
        }
            
      }
}
