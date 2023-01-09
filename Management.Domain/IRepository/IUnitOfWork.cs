namespace Management.Domain.IRepository;

public interface IUnitOfWork
{
    IGenericRepository<T>? GetRepository<T>() where T : class;
    Task SaveChangesAsync();
}