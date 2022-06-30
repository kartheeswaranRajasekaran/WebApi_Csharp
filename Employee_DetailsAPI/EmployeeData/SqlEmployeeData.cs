using Employee_DetailsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Employee_DetailsAPI.EmployeeData
{
    public class SqlEmployeeData : IEmployeeData
    {
        private EmployeeContext _employeecontext;
        public SqlEmployeeData(EmployeeContext employeeContext)
        {
            _employeecontext = employeeContext;
        }
        public Employee AddEmployee(Employee employee)
        {
            employee.EmpId = Guid.NewGuid();
            _employeecontext.EmployeeTable.Add(employee);
            _employeecontext.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            _employeecontext.EmployeeTable.Remove(employee);
            _employeecontext.SaveChanges();
        }

        public Employee EditEmployee(Employee employee)
        {
            var ExistingEmployee = _employeecontext.EmployeeTable.Find(employee.EmpId);
            if(ExistingEmployee != null)
            {
                ExistingEmployee.EmpName = employee.EmpName;
                ExistingEmployee.EmpPhone = employee.EmpPhone;
                ExistingEmployee.EmpEmail = employee.EmpEmail;
                ExistingEmployee.DOB = employee.DOB;
                ExistingEmployee.Department = employee.Department;
                ExistingEmployee.JobTitle = employee.JobTitle;
                _employeecontext.EmployeeTable.Update(ExistingEmployee);
                _employeecontext.SaveChanges();
            }
            return employee;
        }

        public Employee GetEmployee(Guid EmpId)
        {
            var employee= _employeecontext.EmployeeTable.Find(EmpId);
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            var employeelist = _employeecontext.EmployeeTable.ToList();
            return employeelist;
        }
    }
}
