using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDemo.Models
{
    class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1,1433;Database=Master;User Id=SA;Password;Macbook123#");
            //optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=soch;Integrated Security=True");
        }
    }
}
