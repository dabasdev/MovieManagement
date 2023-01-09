using Management.Domain.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Management.DataAccess.Implementation;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly DbContext _context;
    private readonly Dictionary<Type, object?> _repositories;

    public UnitOfWork(DbContext context)
    {
        _context = context;
        _repositories = new Dictionary<Type, object?>();
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public IGenericRepository<T> GetRepository<T>() where T : class
    {
        if (_repositories.TryGetValue(typeof(T), out var repository)) return (IGenericRepository<T>)repository!;

        IGenericRepository<T>? newRepository = new GenericRepository<T>(_context);
        _repositories.Add(typeof(T), newRepository);
        return newRepository;
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}