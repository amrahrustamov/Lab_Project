namespace Lab.DataAccess.Repositories.Interfaces;

public interface IReadRepository<T>:IRepository<T> where T : class
{
    T GetById(int id);
}
