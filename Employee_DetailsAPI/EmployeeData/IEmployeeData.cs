using Employee_DetailsAPI.Models;
using System;
using System.Collections.Generic;

namespace Employee_DetailsAPI.EmployeeData
{
    public interface IEmployeeData
    {
        List<Employee> GetEmployees();

        Employee GetEmployee(Guid EmpId);
        Employee AddEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        Employee EditEmployee(Employee employee);
    }
}
