using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Data_Provider
{
    public partial class MyDB : DbContext
    {
        public MyDB()
            : base("name=MyDB")
        {
        }

        public virtual DbSet<we_users> we_users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<we_users>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<we_users>()
                .Property(e => e.Uid)
                .IsFixedLength();

            modelBuilder.Entity<we_users>()
                .Property(e => e.Pwd)
                .IsFixedLength();
        }
    }
}
