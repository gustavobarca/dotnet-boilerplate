using Domain.Model;

namespace Domain.Services;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IBasketRepository Baskets { get; }
    Task<int> Complete();
}