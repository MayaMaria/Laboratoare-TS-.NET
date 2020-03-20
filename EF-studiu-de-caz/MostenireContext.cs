using Swashbuckle.AspNetCore.Swagger;
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
    public class MostenireContext : DbContext
    {
        public DbSet<Business> businesses { get; set; }

        public MostenireContext():base("Data Source=(localdb)/MSSQLLocalDB;Initial Catalog=EF_mostenire;" +
            "Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False") { }
   
    }

    [Table("Business", Schema = "TSP_mostenire")]
    public class Business
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusinessId { get; protected set; }
        public string Name { get; set; }
        public string LicenseNumber { get; set; }
    }

    [Table("eCommerce", Schema = "TSP_mostenire")]
    public class eCommerce : Business
    {
        public string URL { get; set; }
    }
    [Table("Retail", Schema = "TSP_mostenire")]
    public class Retail : Business
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIPCode { get; set; }
    }
}
