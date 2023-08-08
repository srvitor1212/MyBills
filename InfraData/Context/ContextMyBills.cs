using InfraData.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Shared.Context
{
    public class ContextMyBills : DbContext
    {
        public ContextMyBills(DbContextOptions<ContextMyBills> options) : base(options) { }

        DbSet<Entrada> Entradas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Entrada>(
            //    conf =>
            //    {
            //        conf.HasKey();
            //    });

            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ContextMyBills).Assembly);
        }
    }
}
