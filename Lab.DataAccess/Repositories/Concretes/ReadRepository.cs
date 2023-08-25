using Lab.Core.Entities;
using Lab.DataAccess.Contexts;
using Lab.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lab.DataAccess.Repositories.Concretes;

public class ReadRepository<T> : IReadRepository<T> where T : BaseClass
{
    private readonly LabDbContext _context;

    public ReadRepository(LabDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public T GetById(int id)
    {
        return Table.FirstOrDefault( t => t.Id == id);
    }
}
