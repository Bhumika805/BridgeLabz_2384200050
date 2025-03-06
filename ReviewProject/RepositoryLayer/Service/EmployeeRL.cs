using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Service
{
   public class EmployeeRL : IEmployeeRL
   {
            private readonly EmployeeDbcontext _context;

            public EmployeeRL(EmployeeDbcontext context)
            {
                _context = context;
            }

            public EmployeeEntity AddEmployee(EmployeeEntity employee)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return employee;
            }

            public EmployeeEntity UpdateEmployee(int id, EmployeeEntity employee)
            {
                var existingEmployee = _context.Employees.FirstOrDefault(e => e.Id == id);
                if (existingEmployee != null)
                {
                    existingEmployee.Name = employee.Name;
                    existingEmployee.Email = employee.Email;
                    existingEmployee.Department = employee.Department;
                    _context.SaveChanges();
                    return existingEmployee;
                }
                return null;
            }

            public bool DeleteEmployee(int id)
            {
                var employee = _context.Employees.FirstOrDefault(e => e.Id == id);
                if (employee != null)
                {
                    _context.Employees.Remove(employee);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }

            public EmployeeEntity GetEmployeeById(int id)
            {
                return _context.Employees.FirstOrDefault(e => e.Id == id);
            }

            public List<EmployeeEntity> GetAllEmployees()
            {
                return _context.Employees.ToList();
            }
   }
}


