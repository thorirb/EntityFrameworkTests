using EntityFrameworkTest.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest.EF
{
    public class CarsDBContext : DbContext
    {
        public CarsDBContext() : base()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<CarsDBContext>());
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Driver> Drivers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure domain classes using modelBuilder here..
            modelBuilder.Entity<Driver>().HasKey(x => x.DriverID).Property(x => x.DriverID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }
}
