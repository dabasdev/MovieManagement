﻿namespace Management.Domain.Repository;

public interface IGenericRepository<T> where T : class
{
    T? GetById(int id);
    IEnumerable<T?> GetAll();
    void Add(T? entity);
    void Update(T? entity);
    void Delete(T? entity);

    //Async Methods
    Task<T?> GetByIdAsync(int id);
    Task<IEnumerable<T?>> GetAllAsync();
    Task AddAsync(T? entity);
    Task UpdateAsync(T? entity);
    Task DeleteAsync(T? entity);
}