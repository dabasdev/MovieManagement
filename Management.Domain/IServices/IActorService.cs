using Management.Domain.Entities;
using Management.Domain.IRepository;

namespace Management.Domain.IServices;

public interface IActorService : IGenericRepository<Actor>
{
}