using System;
using System.Threading.Tasks;

namespace RM.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
    }
}
