using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entity;

namespace RepositoryLayer.Context
{
        public class RegistrationContext : DbContext

        {
            public RegistrationContext(DbContextOptions<RegistrationContext> options) : base(options)
            {

            }

            public virtual DbSet<Entity.UserEntity> Users { get; set; }
        }
    
}
