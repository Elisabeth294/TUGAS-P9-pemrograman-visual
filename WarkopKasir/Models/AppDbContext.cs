// Models/AppDbContext.cs
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using WarkopKasir.Models;

namespace WarkopKasir.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produk> Produks { get; set; }
        public DbSet<Transaksi> Transaksis { get; set; }
        public DbSet<TransaksiItem> TransaksiItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Jika ada konfigurasi lebih lanjut
        }
    }
}
