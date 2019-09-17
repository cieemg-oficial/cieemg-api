using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using apiCiee.Models;


namespace apiCiee.Data.Maps
{
    public class CursoMap : IEntityTypeConfiguration<Curso> {
        public void Configure(EntityTypeBuilder<Curso> builder) {
            builder.ToTable("curso");
        }
    }
}