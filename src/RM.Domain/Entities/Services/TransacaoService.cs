using RM.Domain.Core.Interfaces;
using RM.Domain.Core.Services;
using RM.Domain.Entities.Interfaces;

namespace RM.Domain.Entities.Services
{
    public class TransacaoService : BaseService, ITransacaoService
    {
        public TransacaoService(INotifier notificador) : base(notificador)
        {
        }
    }
}
