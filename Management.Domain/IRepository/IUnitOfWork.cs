namespace Management.Domain.Repository;

public interface IUnitOfWork
{
    IGenericRepository<T>? GetRepository<T>() where T : class;
    Task SaveChangesAsync();
}