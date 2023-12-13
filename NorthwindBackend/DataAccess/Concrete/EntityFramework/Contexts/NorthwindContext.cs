using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class NorthwindContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
           
        }

        public DbSet<Product> products { get; set; }
        
        public DbSet<Category> categories { get; set; }

        public DbSet<OperationClaim> operationClaims { get; set; }

        public DbSet<User> users { get; set; }

        public DbSet<UserOperationClaim> userOperationClaims { get; set; }





    }
}
