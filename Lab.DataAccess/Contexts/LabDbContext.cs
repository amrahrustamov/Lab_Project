using Lab.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab.DataAccess.Contexts;

public class LabDbContext:DbContext
{
    public LabDbContext(DbContextOptions<LabDbContext> options) : base(options)
    {

    }

    public DbSet<Employee> Employees { get; set; } = null!;
    //public DbSet<Departament> Departaments { get; set; } = null!;
}
