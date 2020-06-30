using DDD.Domain.Entities;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDD.Infra.Data.Mapping
{
    public class ContaMap : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.ToTable("Conta");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Saldo)
              .HasColumnName("Saldo");

            builder.Property(c => c.LimiteCredito)
              .HasColumnName("LimiteCredito");

            builder.Property(c => c.IdCorrentista)
              .HasColumnName("IdCorrentista");
        }
    }
}