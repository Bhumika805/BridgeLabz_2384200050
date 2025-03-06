using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Entity
{
    [Table("Employees")]
   public class EmployeeEntity
   {
       public int Id { get; set; }
       public string Name { get; set; }
       public string Email { get; set; }
       public string Department { get; set; }
   }

}