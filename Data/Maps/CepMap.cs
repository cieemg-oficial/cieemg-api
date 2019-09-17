using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using apiCiee.Models;

namespace apiCiee.Data.Maps
{
    public class CepMap : IEntityTypeConfiguration<Cep> {
        public void Configure(EntityTypeBuilder<Cep> builder){
            builder.ToTable("cep");
            builder.HasKey(x => x.id);
            builder.Property(x => x.cep).HasMaxLength(10).HasColumnType("varchar(10)");
            builder.Property(x => x.logradouro).HasMaxLength(70).HasColumnType("varchar(70)");
            builder.Property(x => x.bairro).HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(x => x.cidade).HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(x => x.uf).HasMaxLength(2).HasColumnType("varchar(2)");
            builder.Property(x => x.regiao).HasMaxLength(2).HasColumnType("varchar(2)");
        }
    }
}