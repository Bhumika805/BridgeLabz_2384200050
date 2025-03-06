using BusinessLayer.Interface;
using RepositoryLayer.Interface;
using RepositoryLayer.Entity;
using RepositoryLayer.Service;
using System.Collections.Generic;

namespace BusinessLayer.Service
{
   public class EmployeeBL : IEmployeeBL
        {
            private readonly IEmployeeRL _employeeRL;

            public EmployeeBL(IEmployeeRL employeeRL)
            {
                _employeeRL = employeeRL;
            }

            public EmployeeEntity AddEmployee(EmployeeEntity employee)
            {
                return _employeeRL.AddEmployee(employee);
            }

            public EmployeeEntity UpdateEmployee(int id, EmployeeEntity employee)
            {
                return _employeeRL.UpdateEmployee(id, employee);
            }

            public bool DeleteEmployee(int id)
            {
                return _employeeRL.DeleteEmployee(id);
            }

            public EmployeeEntity GetEmployeeById(int id)
            {
                return _employeeRL.GetEmployeeById(id);
            }

            public List<EmployeeEntity> GetAllEmployees()
            {
                return _employeeRL.GetAllEmployees();
            }
        
   }

}
