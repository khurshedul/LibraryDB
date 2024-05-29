using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class EmployeeService : BaseService<Employee>, IEmployeeService
    {
        public string GetEmployeeName(Employee employee)
        {
            return employee.Name;
        }
    }
}
