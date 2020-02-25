using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using jk582215_MIS4200_2.Models; // This is needed to access the models
using System.Data.Entity; // this is needed to access the DbContext object
namespace MIS4200jk582215.DAL
{
    public class MIS4200Context : DbContext // inherits from DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context,jk582215_MIS4200_2.Migrations.MISContext.Configuration>("DefaultConnection"));
        }
        // Include each object here. The value inside <> is the name of the class,
        // the value outside should generally be the plural of the class name
        // and is the name used to reference the entity in code
        public DbSet<PetOwner> PetOwners { get; set; }
        public DbSet<Pets> Pets { get; set; }
        public DbSet<Vet> Vets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}