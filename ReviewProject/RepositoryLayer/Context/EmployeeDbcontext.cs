using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entity;
using RepositoryLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Context
{
    public class EmployeeDbcontext : DbContext
    {
        public EmployeeDbcontext(DbContextOptions<EmployeeDbcontext> options) : base(options) { }

        public DbSet<EmployeeEntity> Employees { get; set; }
    }
}