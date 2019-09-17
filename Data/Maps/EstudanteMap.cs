using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using apiCiee.Models;

namespace apiCiee.Data.Maps
{
    public class EstudanteMap : IEntityTypeConfiguration<Estudante> {
        public void Configure(EntityTypeBuilder<Estudante> builder){
            builder.ToTable("estudante");
            builder.HasKey(x => x.id);
            builder.Property(x => x.nome).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(x => x.cpf).HasMaxLength(14).HasColumnType("varchar(14)");
            builder.Property(x => x.logradouro).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(x => x.numero).HasMaxLength(45).HasColumnType("varchar(45)");
            builder.Property(x => x.complemento).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(x => x.cep).HasMaxLength(10).HasColumnType("varchar(10)");
            builder.Property(x => x.telefone).HasMaxLength(45).HasColumnType("varchar(45)");
            builder.Property(x => x.email).HasMaxLength(45).HasColumnType("varchar(45)");
            builder.Property(x => x.cidade).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(x => x.bairro).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(x => x.senha).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(x => x.nomepai).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(x => x.nomemae).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(x => x.estadocivil).HasMaxLength(1).HasColumnType("varchar(1)");
            builder.Property(x => x.sexo).HasMaxLength(1).HasColumnType("varchar(1)");
            builder.Property(x => x.dt_nascimento).HasColumnType("date");
            builder.Property(x => x.horario).HasMaxLength(20).HasColumnType("varchar(20)");
            builder.Property(x => x.rg).HasMaxLength(45).HasColumnType("varchar(45)");
            builder.Property(x => x.orgaoexpedidor).HasMaxLength(45).HasColumnType("varchar(45)");
            builder.Property(x => x.periodoano).HasMaxLength(2).HasColumnType("varchar(2)");
            builder.Property(x => x.previsaoformatura).HasMaxLength(8).HasColumnType("varchar(8)");
            builder.Property(x => x.curso_id).HasMaxLength(11).HasColumnType("int(11)");
            builder.Property(x => x.escola_id).HasMaxLength(11).HasColumnType("int(11)");
            builder.Property(x => x.dt_cadastro).HasColumnType("date");
            builder.Property(x => x.uf).HasMaxLength(2).HasColumnType("varchar(2)");
            builder.Property(x => x.idade).HasMaxLength(11).HasColumnType("int(11)");
            builder.Property(x => x.estagiario_ativo).HasMaxLength(1).HasColumnType("varchar(1)");
            builder.Property(x => x.dt_atualizacao).HasColumnType("date");
            builder.Property(x => x.periodo).HasMaxLength(4).HasColumnType("tinyint(4)");
            builder.Property(x => x.ano).HasMaxLength(11).HasColumnType("int(11)");
            builder.Property(x => x.previsao_semestre).HasMaxLength(1).HasColumnType("tinyint(1)");
            builder.Property(x => x.previsao_ano).HasMaxLength(4).HasColumnType("int(4)");
            builder.Property(x => x.previsao_mes).HasMaxLength(2).HasColumnType("tinyint(2)");
            builder.Property(x => x.deficiencia).HasMaxLength(2).HasColumnType("varchar(2)");
            builder.Property(x => x.deficiencia_descricao).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(x => x.telefone1).HasMaxLength(20).HasColumnType("varchar(20)");
            builder.Property(x => x.telefone2).HasMaxLength(20).HasColumnType("varchar(20)");
            builder.Property(x => x.ctps).HasMaxLength(20).HasColumnType("varchar(20)");
            builder.Property(x => x.candidato_selecionado).HasMaxLength(11).HasColumnType("int(11)");
            builder.Property(x => x.anoingresso).HasMaxLength(11).HasColumnType("int(11)");
            builder.Property(x => x.semestreingresso).HasMaxLength(11).HasColumnType("int(11)");
            builder.Property(x => x.cpf_pai).HasMaxLength(14).HasColumnType("varchar(14)");
            builder.Property(x => x.cpf_mae).HasMaxLength(14).HasColumnType("varchar(14)");
            builder.Property(x => x.notificacao).HasMaxLength(2).HasColumnType("varchar(2)");
            builder.Property(x => x.dt_alteracao_notificacao).HasColumnType("date");
        }
    }
}