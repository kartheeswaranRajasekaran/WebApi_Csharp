using Employee_DetailsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_DetailsAPI.EmployeeData
{
  /*
    public class MockEmployeeData : IEmployeeData
    {

        private List<Employee> employees = new List<Employee>()
    {
        new Employee
        {
            EmpId =Guid.NewGuid(),
            EmpName= "Kartheeswaran",
           // EmpPhone=9025826572,
            EmpEmail="kartheeswaran@gmail.com",
            DOB=DateTime.Now,
            Department="Developer",
            JobTitle="Frontend Developer"
        },
         new Employee
        {
            EmpId =Guid.NewGuid(),
            EmpName= "Muneeshwar",
           // EmpPhone=8754263922,
            EmpEmail="muneeshwar@gmail.com",
            DOB=DateTime.Now,
            Department="Tester",
            JobTitle="Tester"
        }

    };


        public Employee AddEmployee(Employee employee)
        {
            employee.EmpId = Guid.NewGuid();
            employees.Add(employee);
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public Employee EditEmployee(Employee employee)
        {
            var Existingemployee = GetEmployee(employee.EmpId);
            Existingemployee.EmpName = employee.EmpName;
            Existingemployee.EmpPhone = employee.EmpPhone;
            Existingemployee.EmpEmail = employee.EmpEmail;
            Existingemployee.DOB = employee.DOB;
            Existingemployee.Department = employee.Department;
            Existingemployee.JobTitle = employee.JobTitle;
            return Existingemployee;
        }

        public Employee GetEmployee(Guid EmpId)
        {
            return employees.SingleOrDefault(x => x.EmpId == EmpId);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }*/
}
