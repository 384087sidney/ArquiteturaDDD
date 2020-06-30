using DDD.Domain;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces;
using DDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDD.Infra.Data.Repository
{
    public class ContaRepository : BaseRepository<Conta>
    {
        private SQLiteContext context = new SQLiteContext();
 
    }
}