using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Extensie
{
    public partial class Model1 : DbContext
    {
        public object Clienti;

        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Clienti> Clientis { get; set; }
        public virtual DbSet<Comenzi> Comenzis { get; set; }
        public virtual DbSet<Produse> Produses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clienti>()
                .Property(e => e.Adresa_mail)
                .IsUnicode(false);
        }
    }
}
