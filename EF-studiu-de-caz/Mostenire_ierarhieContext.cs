using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_studiu_de_caz
{
    public class Mostenire_ierarhieContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public Mostenire_ierarhieContext():base("Data Source=(localdb)/MSSQLLocalDB;Initial Catalog=EF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False") { }
    

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>()
            .Map<FullTimeEmployee>(m => m.Requires("EmployeeType")
            .HasValue(1))
            .Map<HourlyEmployee>(m => m.Requires("EmployeeType")
            .HasValue(2));
        }

    }

    public abstract class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; protected set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    public class FullTimeEmployee : Employee
    {
        public decimal? Salary { get; set; }
    }
    public class HourlyEmployee : Employee
    {
        public decimal? Wage { get; set; }

    }
}
