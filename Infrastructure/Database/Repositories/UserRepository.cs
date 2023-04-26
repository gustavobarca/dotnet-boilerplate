using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database.Repositories;

public class UserRepository : IUserRepository
{
    private readonly DbContext _context;

    public UserRepository(DbContext context) => _context = context;

    public async Task<User> Find(Guid id)
    {
        User? result = await _context.Set<User>().FindAsync(id.ToString());

        return result;
    }

    public async Task<User> Store(User user)
    {
        var result = await _context.Set<User>().AddAsync(user);

        return result.Entity;
    }
}