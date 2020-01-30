using RM.Data.Interfaces;
using RM.Domain.Entities;
using RM.Domain.Entities.Interfaces;

namespace RM.Data.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(IMongoContext context) : base(context)
        {
        }
    }
}
