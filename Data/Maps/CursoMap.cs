using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using apiCiee.Models;


namespace apiCiee.Data.Maps
{
    public class CursoMap : IEntityTypeConfiguration<Curso> {
        public void Configure(EntityTypeBuilder<Curso> builder) {
            builder.ToTable("curso");
            builder.HasKey(x => x.id);
            builder.Property(x => x.idescola).HasMaxLength(11).HasColumnType("int(11)");
            builder.Property(x => x.idcurso).HasMaxLength(11).HasColumnType("int(11)");
            builder.Property(x => x.descricao).HasMaxLength(70).HasColumnType("varchar(70)");
            builder.Property(x => x.duracao).HasMaxLength(11).HasColumnType("varchar(2)");
        }
    }
}