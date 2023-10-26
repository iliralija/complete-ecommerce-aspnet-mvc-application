using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services;

public class ActorsService : IActorService
{
    
    private readonly AppDbContext _context;

    public ActorsService(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Actor>> GetAll()
    {
        var result = await _context.Actors.ToListAsync();
        return result;
    }

    public Actor GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Add(Actor actor)
    {
        _context.Actors.Add(actor);
        _context.SaveChanges();
    }

    public Actor Update(int id, Actor newActor)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}