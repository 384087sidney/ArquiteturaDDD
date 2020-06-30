using System;

namespace DDD.Domain.Entities
{
    public class Conta : BaseEntity
    {
        public double Saldo { get; set; }
        public double LimiteCredito { get; set; } 
        public int IdCorrentista { get; set; }
    }
}
