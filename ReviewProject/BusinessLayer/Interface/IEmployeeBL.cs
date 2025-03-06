using ModelLayer.Model;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface IEmployeeBL
    {
        EmployeeEntity AddEmployee(EmployeeEntity employee);
        EmployeeEntity UpdateEmployee(int id, EmployeeEntity employee);
        bool DeleteEmployee(int id);
        EmployeeEntity GetEmployeeById(int id);
        List<EmployeeEntity> GetAllEmployees();
    }
    

}
