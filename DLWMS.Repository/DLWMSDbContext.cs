using DLWMS.Core;
using Microsoft.EntityFrameworkCore;
using System;

namespace DLWMS.Repository
{
    public class DLWMSDbContext : DbContext
    {

        public DLWMSDbContext(DbContextOptions<DLWMSDbContext> opcije):base(opcije)
        {

        }
        public virtual DbSet<Student> Students { get; set; }

    }
}
