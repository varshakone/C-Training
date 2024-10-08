using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerApp
{
    internal class StudentList
    {
        Student[] students;

        public StudentList()
        {
            students = new Student[5];
        }

        //indexer
        public Student this[int index]
        {
            get { return students[index]; }
            set {
                if (index <= students.Length - 1)
                {
                    students[index] = value;

                }
                else
                {
                    throw new IndexOutOfRangeException();
                }

            }
        }
    }
}
