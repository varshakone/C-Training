using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstraintModelLibrary
{
    public class DBManipulation
    {
       readonly List<Employee> employees;
        public DBManipulation()
        {
                employees = new List<Employee>();
            employees.Add(new Employee() { Id=100,Name="Vijay"} );
            employees.Add(new Employee() { Id = 101, Name = "Vinay " });
            employees.Add(new Employee() { Id = 102, Name = "Anisha" });
            employees.Add(new Employee() { Id = 103, Name = "Iny Glanet" });
            employees.Add(new Employee() { Id = 103, Name = "Iny Glanet" });
        }
        public string NewEmployee(Employee employee)
        {
            string msg =null;
            int count =1;
            employees.Add(employee);
            if (count == 1)
            {
                msg = "Employee Registered successfuly";
            }
            return msg;
        }

        public int EditEmployee(int id)
        {
            
            int count = 1;
            //employees.Add(employee);
            
            return count;
        }
        public int DeleteEmployee(int id)
        {

            int count = 1;
            //employees.Add(employee);

            return count;
        }


        public List<Employee> GetAllEmployees()
        {
      

            return employees;
        }

        public Employee GetEmployee(int id)
        {
            var emp= employees.Single(e=> e.Id==id);

            return emp;
        }

        public int MaxSalaryEmployee()
        {
            int id = 0;
            try
            {

                if (id == 0)
                {
                    throw new ArgumentNullException();
                }
               
            }
            catch (ArgumentNullException ex)
            {
            }
            return id;
        }

        public void openFile(string fileName)
        {

        }
    }
}
