using RM.Data.Interfaces;
using RM.Domain.Entities;
using RM.Domain.Entities.Interfaces;
using System;

namespace RM.Data.Repositories
{
    public class ContaCorrenteRepository : Repository<ContaCorrente>, IContaCorrenteRepository
    {
        public ContaCorrenteRepository(IMongoContext context) : base(context)
        {
        }
    }
}
