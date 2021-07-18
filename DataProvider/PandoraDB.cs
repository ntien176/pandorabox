using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataProvider
{
    public partial class PandoraDB : DbContext
    {
        public PandoraDB()
            : base("name=PandoraDB")
        {
        }

        public virtual DbSet<PandoraTable> PandoraTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PandoraTable>()
                .Property(e => e.ID)
                .IsFixedLength();
        }
    }
}
