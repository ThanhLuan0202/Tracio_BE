using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracio.Data
{
    internal interface IUnitOfWork : IDisposable
    {
        void CommitTransaction();
        void RollbackTransaction();
        int SaveChanges();
        void BeginTransaction();
    }
}
