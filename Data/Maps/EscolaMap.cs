using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using apiCiee.Models;

namespace apiCiee.Data.Maps 
{
    public class EscolaMap : IEntityTypeConfiguration<Escola> {
        //Mapeamento de dados da tabela escola no modelo ORM usando EntityFrameworkCore
        public void Configure(EntityTypeBuilder<Escola> builder){
             builder.ToTable("escola");
             builder.HasKey(x=> x.id);
             builder.Property(x => x.razaosocial).HasMaxLength(255).HasColumnType("varchar(255)");
             builder.Property(x => x.cnpj).HasMaxLength(45).HasColumnType("varchar(45)");
             builder.Property(x => x.logradouro).HasMaxLength(255).HasColumnType("varchar(255)");
             builder.Property(x => x.numero).HasMaxLength(45).HasColumnType("varchar(45)");
             builder.Property(x => x.complemento).HasMaxLength(255).HasColumnType("varchar(255)");
             builder.Property(x => x.cep).HasMaxLength(10).HasColumnType("varchar(10)");
             builder.Property(x => x.telefone).HasMaxLength(45).HasColumnType("varchar(45)");
             builder.Property(x => x.nomecontato).HasMaxLength(100).HasColumnType("varchar(100)");
             builder.Property(x => x.email).HasMaxLength(255).HasColumnType("varchar(255)");
             builder.Property(x => x.importado).HasMaxLength(4).HasColumnType("tinyint(4)");
             builder.Property(x => x.senha).HasMaxLength(255).HasColumnType("varchar(255)");
            //  builder.Property(x => x.created_at).HasColumnType("datetime");
            //  builder.Property(x => x.updated_at).HasColumnType("datetime");
             builder.Property(x => x.cidade).HasMaxLength(255).HasColumnType("varchar(255)");
             builder.Property(x => x.bairro).HasMaxLength(255).HasColumnType("varchar(255)");
             builder.Property(x => x.codescola).HasMaxLength(10).HasColumnType("varchar(255)");
        }
    }
}