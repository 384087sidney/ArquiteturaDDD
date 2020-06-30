using DDD.Domain.Entities;
using DDD.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using System;


namespace DDD.Infra.Data.Context
{
    public class SQLiteContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Utilizando um servidor SQLite local. Aqui poderíamos configurar qualquer outro banco de dados.
            
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlite("DataSource=Banco.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
             
            modelBuilder.Entity<Conta>(new ContaMap().Configure);
            modelBuilder.Entity<Correntista>(new CorrentistaMap().Configure);
        }
    }
}