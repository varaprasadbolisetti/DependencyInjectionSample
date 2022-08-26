using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employeemvc1.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employeeslist;
        public EmployeeRepository()
        {
            employeeslist = new List<Employee>()
            {
                new Employee(){ id=101,Name="prasad",salary=15000,adds="Bvrm"},
                new Employee(){id=102,Name="veera",salary=30000,adds="HYD"},
                new Employee(){id=103,Name="madhu",salary=40000,adds="Bvrm"}


            };
        }

        public List<Employee> GetEmployees()
        {
            return employeeslist.ToList();
        }
    }
}
