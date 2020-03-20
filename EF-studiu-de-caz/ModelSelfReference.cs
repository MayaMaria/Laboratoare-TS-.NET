using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_studiu_de_caz
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelSelfReference : DbContext
    {
        // Your context has been configured to use a 'ModelSelfReference' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EF_studiu_de_caz.ModelSelfReference' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelSelfReference' 
        // connection string in the application configuration file.
        public ModelSelfReference()
            : base("Data Source=(localdb)/MSSQLLocalDB;Initial Catalog=EF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<SelfReference> SelfReferences { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SelfReference>()
                .HasMany(m => m.References)
                .WithOptional(m => m.ParentSelfReference);
        }
    
    }

    public class SelfReference
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SelfReferenceId { get; private set; }
        public string Name { get; set; }
        public int? ParentSelfReferenceId { get; private set; }
        [ForeignKey("ParentSelfReferenceId")]
        public SelfReference ParentSelfReference { get; set; }
        public virtual ICollection<SelfReference> References { get; set; }
        public SelfReference()
        {
            References = new HashSet<SelfReference>();
        }
    }
}