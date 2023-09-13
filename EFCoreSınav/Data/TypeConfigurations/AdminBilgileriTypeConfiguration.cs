using EFCoreSınav.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSınav.Data.TypeConfigurations
{
    public class AdminBilgileriTypeConfiguration : IEntityTypeConfiguration<AdminBilgisi>
    {
        public void Configure(EntityTypeBuilder<AdminBilgisi> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(x=>x.ID)
                   .UseIdentityColumn(1,1);

            builder.Property(x => x.KullaniciAdi)
                   .IsRequired()
                   .HasMaxLength(40);

            builder.HasIndex(x => x.KullaniciAdi)
                   .IsUnique();

            builder.Property(x => x.Sifre)
                   .IsRequired();
                   
        }
    }
}
