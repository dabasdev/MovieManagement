using Management.DataAccess.Implementation;
using Management.Domain.Entities;
using Management.Domain.IServices;
using Microsoft.EntityFrameworkCore;

namespace Management.DataAccess.Services;

public class ActorServices : GenericRepository<Actor> , IActorService
{
    public ActorServices(DbContext context) : base(context) { }
}