using EFCoreSınav.Data.TypeConfigurations;
using EFCoreSınav.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSınav.Data
{
    public class PlakDBContext:DbContext
    {
        public virtual DbSet<AdminBilgisi> AdminBilgileri { get; set; }
        public virtual DbSet<Album> Albumler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-6EM38CB\SQL2022; Database=PlakDB; Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminBilgileriTypeConfiguration());
            modelBuilder.ApplyConfiguration(new AlbumTypeConfiguration());
        }
    }
}
