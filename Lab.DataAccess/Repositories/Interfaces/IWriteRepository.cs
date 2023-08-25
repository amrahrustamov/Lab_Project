using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Core.Entities;

namespace Lab.DataAccess.Repositories.Interfaces
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseClass
    {
        void CreateEntity(T entity);
    }
}
