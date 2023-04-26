using Application;
using Microsoft.AspNetCore.Mvc;

namespace DotnetBoilerplate.Controllers;

[ApiController]
[Route("baskets")]
public class BasketController : ControllerBase
{
    private readonly BasketService service;

    public BasketController(BasketService basketService)
    {
        service = basketService;
    }

    [HttpPost]
    public async Task<IActionResult> Create(Guid userId)
    {
        await service.CreateBasket(userId);

        return CreatedAtAction(nameof(Create), null);
    }

    [HttpPost]
    [Route("/{basketId}/items")]
    public async Task<IActionResult> AddItem(Guid basketId, string itemName)
    {
        await service.AddItem(basketId, itemName);

        return CreatedAtAction(nameof(AddItem), null);
    }

    [HttpGet]
    [Route("{basketId}")]
    public async Task<IActionResult> Get(Guid basketId)
    {
        var basket = await service.GetBasket(basketId);

        return Ok(basket);
    }
}
