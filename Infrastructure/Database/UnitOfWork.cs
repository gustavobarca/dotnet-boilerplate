using Domain.Model;
using Domain.Services;
using Infrastructure.Database.Repositories;

namespace Infrastructure.Database;

public class UnitOfWork : IUnitOfWork
{
    private readonly DatabaseContext _context;
    public IUserRepository Users { get; }
    public IBasketRepository Baskets { get; }

    public UnitOfWork(DatabaseContext context)
    {
        _context = context;
        Users = new UserRepository(context);
        Baskets = new BasketRepository(context);
    }

    public async Task<int> Complete()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context?.Dispose(); 
        GC.SuppressFinalize(this);
    }
}