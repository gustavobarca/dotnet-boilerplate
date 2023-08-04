using Domain.Common;
using Domain.Model;
using Domain.Services;

namespace Application;

public class BasketService
{
    private readonly IUnitOfWork _unitOfWork;

    public BasketService(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

    public async Task<Basket?> GetBasket(Guid basketId)
    {
        Basket? basket = await _unitOfWork.Baskets.Find(basketId);
        
        await _unitOfWork.Complete();

        return basket;
    }

    public async Task<Basket?> CreateBasket(Guid userId)
    {
        Basket basket = new(userId);
        
        await _unitOfWork.Baskets.Store(basket);
        await _unitOfWork.Complete();

        return basket;
    }

    public async Task AddItem(Guid basketId, string itemName)
    {
        Basket? basket = await _unitOfWork.Baskets.Find(basketId) ?? throw new ApplicationLayerException("The basket does not exist");
        basket.AddItem(itemName);

        await _unitOfWork.Complete();
    }

    public async void RemoveItem(Guid basketId, string itemId)
    {
        Basket? basket = await _unitOfWork.Baskets.Find(basketId) ?? throw new ApplicationLayerException("The basket does not exist");

        basket.RemoveItem(new Guid(itemId));

        await _unitOfWork.Baskets.Store(basket);
        await _unitOfWork.Complete();
    }

    public async void UpdateItem(Guid basketId, string itemId, string newItemName)
    {
        Basket? basket = await _unitOfWork.Baskets.Find(basketId) ?? throw new ApplicationLayerException("The basket does not exist");

        basket.ChangeItemName(new Guid(itemId), newItemName);

        await _unitOfWork.Baskets.Store(basket);
        await _unitOfWork.Complete();
    }
}
