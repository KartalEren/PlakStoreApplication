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
    public class AlbumTypeConfiguration : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(x=>x.ID)
                   .UseIdentityColumn(1,1);

            builder.Property(x => x.AlbumAdi)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.Property(x=>x.AlbumunSanatcisi)
                   .IsRequired()
                   .HasMaxLength(40);

            builder.Property(x => x.AlbumCikisTarihi)
                   .IsRequired();

            builder.Property(x => x.AlbumFiyati)
                   .IsRequired();

            builder.Property(x => x.SatisaDevamEdiyorMu)
                   .IsRequired();

            builder.Property(x=>x.IndirimOrani)
                   .HasMaxLength(3);



        }
    }
}
