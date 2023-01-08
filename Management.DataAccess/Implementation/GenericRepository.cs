using Management.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Management.DataAccess.Implementation;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly DbContext _context;
    private readonly DbSet<T> _dbSet;

    public GenericRepository(DbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }


    public T? GetById(int id)
    {
        return  _dbSet.Find(id);
    }

    public IEnumerable<T?> GetAll()
    {
        return _dbSet.ToList();
    }

    public void Add(T? entity)
    {
        _dbSet.Add(entity);
    }

    public void Update(T? entity)
    {
        _dbSet.Update(entity);
    }

    public void Delete(T? entity)
    {
        _dbSet.Remove(entity);
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<IEnumerable<T?>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task AddAsync(T? entity)
    {
        await _dbSet.AddAsync(entity);

        //await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T? entity)
    {
        _dbSet.Update(entity);
        //await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(T? entity)
    {
        _dbSet.Remove(entity);
        //await _context.SaveChangesAsync();
    }

}