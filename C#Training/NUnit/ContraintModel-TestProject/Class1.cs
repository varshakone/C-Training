using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ConstraintModelLibrary;
using NUnit.Framework;

namespace ContraintModel_TestProject
{
    [TestFixture]
    public class DBManipulationTest
    {

        //String Constraint
        [Test]
        [TestCase]
        public void NewEmployeeTest()
        {
            Employee employee = new Employee() { Id = 100, Name = "abc" };
            string expectedResult = "Employee Registered successfuly";
            DBManipulation dBManipulation = new DBManipulation();   
           var result= dBManipulation.NewEmployee(employee);

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Does.Contain("Employee"));
            Assert.That(result, Does.Match(expectedResult));
            Assert.That(result, Does.EndWith("successfuly"));
            Assert.That(result, Does.StartWith("Employee"));
        }

        //conditional
        [Test]
        [TestCase]
        public void EditEmployeeTest()
        {
            
            DBManipulation dBManipulation = new DBManipulation();
            var result = dBManipulation.EditEmployee(100);

            Assert.That(result, Is.Not.EqualTo(0));
            Assert.That(result, Is.GreaterThan(0));
            Assert.That(result > 0, Is.True);
        }

        //collection and compound constraint
        [Test]
        [TestCase]
        public void AllEmployeeTest()
        {
            int[] sarray = {1,1,2,2,3};
            DBManipulation dBManipulation = new DBManipulation();
            var result = dBManipulation.GetAllEmployees();

            Assert.That(result, Is.All.Not.Null);
            Assert.That(result, Is.InstanceOf((typeof(List<Employee>))));
            Assert.That(result, Is.Unique);
            Assert.That(result.Count, Is.GreaterThanOrEqualTo(1));
           // Assert.That(sarray, Is.Unique);

            //compund constraint
            Assert.That(result.Count, Is.GreaterThanOrEqualTo(1) & Is.LessThanOrEqualTo(5));

        }

        //comparison constraint
        [Test]
        [TestCase]
        public void DeleteEmployeeTest()
        {

            DBManipulation dBManipulation = new DBManipulation();
            var result = dBManipulation.DeleteEmployee(100);

            Assert.That(result, Is.Not.EqualTo(0));
            Assert.That(result, Is.GreaterThan(0));
            Assert.That(result > 0, Is.True);
            Assert.That(result, Is.LessThan(1));
            Assert.That(result, Is.GreaterThanOrEqualTo(1));

        }

        //Type Constraint
        [Test]
        [TestCase]
        public void EmployeeTest()
        {

            DBManipulation dBManipulation = new DBManipulation();
            var result = dBManipulation.GetEmployee(100);

            Assert.That(result, Is.Not.Null);
            Assert.That(result,Is.InstanceOf(typeof(Employee)));

        }

        //Exception Constraint
        [Test]
        public void MaxSalaryEmployeeTest()
        {

            DBManipulation dBManipulation = new DBManipulation();
            TestDelegate testDelegate = () => {

              var result=  dBManipulation.MaxSalaryEmployee();
                if(result == 0)
                {
                    throw new ArgumentNullException();
                }
                
            };

            Assert.That(testDelegate, Throws.Exception.TypeOf(typeof(ArgumentNullException)),"Method throws exception");

        }

        //File/Directory constraint
        [Test]
        [TestCase]
        public void OpenFileTest()
        {
            string path = "C:\\Users\\DELL\\OneDrive\\Desktop\\Employeexyz.txt";

            Assert.That(path,Does.Exist);
           
        }
    }
}
