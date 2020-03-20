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
    public class Model_scenariu2 : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public Model_scenariu2() : base("Data Source=(localdb)/MSSQLLocalDB;Initial Catalog=EF_scenariu2;" +
            "Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        { }
 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .Map(m =>
            {
                m.Properties(p => new { p.SKU, p.Description, p.Price });
                m.ToTable("Product", "BazaDeDate");
            })
            .Map(m =>
            {
                m.Properties(p => new { p.SKU, p.ImageURL });
                m.ToTable("ProductWebInfo", "BazaDeDate");
            });

        }
    }

    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SKU { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
    }
}
