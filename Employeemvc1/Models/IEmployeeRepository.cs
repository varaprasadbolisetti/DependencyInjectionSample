using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employeemvc1.Models
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
    }
}
