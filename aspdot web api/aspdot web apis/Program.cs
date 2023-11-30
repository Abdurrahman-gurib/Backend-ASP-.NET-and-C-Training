using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeLibrary
{


    public interface IEmployeeOperations
    {
        List<Employee> GetAllEmployees(string path);
        void  AddEmployee(Employee employee);

        Employee GetEmployee(string employeeId);

    }
}
