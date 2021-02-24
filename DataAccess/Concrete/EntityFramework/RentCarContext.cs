using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentCarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Server =(localdb)\mssqllocaldb;Database=RentCar;Trusted_Connection=true");
        }

        public DbSet<Car> tblCar { get; set; }
        public DbSet<Brand> tblBrand { get; set; }
        public DbSet<Color> tblColor { get; set; }
    }
}
