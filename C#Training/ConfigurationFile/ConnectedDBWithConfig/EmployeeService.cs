using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectedDBWithConfig
{
    public class EmployeeService
    {
         EmployeeRepository employeeRepository;
        //public EmployeeService(EmployeeRepository employeeRepository)
        //{
        //    this.employeeRepository = employeeRepository;
        //}

      public EmployeeRepository EmployeeRepository
        {
            get { return employeeRepository; }
            set
            {
                employeeRepository = value;
            }
        }

        public string newEmployee(Employee employee)
        {
            return employeeRepository.newEmployee(employee);
        }
    }
}
