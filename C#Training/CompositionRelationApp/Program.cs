using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionRelationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            course.Id = 123;
            Student student=new Student("Vijay",101,411036,"Pune","Maharashtra","Near dande chowk",course.Id);
            

        }
    }
}
