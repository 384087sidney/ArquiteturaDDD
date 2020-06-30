using FluentValidation;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces;
using DDD.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using DDD.Domain;

namespace DDD.Service.Services
{
    public class ContaService : BaseService<Conta>
    {
        private BaseRepository<Conta> repository = new BaseRepository<Conta>();
        public double Creditar(int id, double valor)
        {
            var objAtual = repository.Select(id);
            objAtual.Saldo += valor;

            repository.Update(objAtual);
            return objAtual.Saldo;
        }

        public double Debitar(int id, double valor)
        {
            var objAtual = repository.Select(id);

            if (valor > objAtual.Saldo + objAtual.LimiteCredito)
            {
                throw new ArgumentException("Saldo para saque insuficiente");
            }

            if(valor > 50000)
            {
                Console.WriteLine("Operações de	crédito	acima de 50000 reais");
            }


            objAtual.Saldo -= valor;

            repository.Update(objAtual);
            return objAtual.Saldo;
        }
    }
}