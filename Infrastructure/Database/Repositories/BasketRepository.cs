using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database.Repositories;

public class BasketRepository : IBasketRepository
{
    private readonly DbContext _context;

    public BasketRepository(DbContext context) => _context = context;

    public async Task<Basket?> Find(Guid id)
    {
        Basket? basket = await _context.Set<Basket>().Include(b => b.Items).Where(b => b.Id == id).FirstOrDefaultAsync();

        return basket;
    }

    public async Task<Basket> Store(Basket basket)
    {
        var result = await _context.Set<Basket>().AddAsync(basket);

        return result.Entity;
    }
}