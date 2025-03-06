using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface IRegistrationBL
    {
        string Registration(string value);
        List<EmployeeEntity> GetAllEmployees();
    }

}
