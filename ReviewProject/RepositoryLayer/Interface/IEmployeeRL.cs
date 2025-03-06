using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Entity;
using RepositoryLayer.Service;

namespace RepositoryLayer.Interface
{
    public interface IEmployeeRL
    {
        EmployeeEntity AddEmployee(EmployeeEntity employee);
        EmployeeEntity UpdateEmployee(int id, EmployeeEntity employee);
        bool DeleteEmployee(int id);
        EmployeeEntity GetEmployeeById(int id);
        List<EmployeeEntity> GetAllEmployees();
        
    }
}
