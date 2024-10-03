using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionRelationApp
{
    internal class Student
    {
        public string Name;
        public int Id;
        public Address Address;
        public int courseId;

        public Student(string name,int id, int pin, string city, string state, string landmark,int courseid)
        {
                Name = name;
            Id = id;
            Address = new Address();
            Address.Landmark= landmark;
            Address.City= city;
            Address.State= state;
            Address.Pin= pin;
            courseId= courseid;
        }

        public string getStudentDetails()
        {
            return null;
        }
    }
}
