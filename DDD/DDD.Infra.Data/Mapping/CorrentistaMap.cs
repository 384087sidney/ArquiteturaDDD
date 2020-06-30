using DDD.Domain.Entities;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDD.Infra.Data.Mapping
{
    public class CorrentistaMap : IEntityTypeConfiguration<Correntista>
    {
        public void Configure(EntityTypeBuilder<Correntista> builder)
        {
            builder.ToTable("Correntista");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
              .HasColumnName("Nome");

            builder.Property(c => c.CPF)
              .HasColumnName("CPF");

            builder.Property(c => c.Telefone)
              .HasColumnName("Telefone");

            builder.Property(c => c.Endereco)
              .HasColumnName("Endereco");
        }
    }
}