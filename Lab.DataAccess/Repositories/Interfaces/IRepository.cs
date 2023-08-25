using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab.DataAccess.Repositories.Interfaces;

public interface IRepository<T> where T:BaseClass
{
    DbSet<T> Table { get; }
}
