using RM.Data.Interfaces;
using RM.Domain.Entities;
using RM.Domain.Entities.Interfaces;

namespace RM.Data.Repositories
{
    public class TransacaoRepository : Repository<Transacao>, ITransacaoRepository
    {
        public TransacaoRepository(IMongoContext context) : base(context)
        {
        }
    }
}
