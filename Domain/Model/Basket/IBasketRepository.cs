namespace Domain.Model;

public interface IBasketRepository
{
    Task<Basket?> Find(Guid id);
    Task<Basket> Store(Basket basket);
}