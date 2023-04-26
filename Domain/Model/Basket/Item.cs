using Domain.Common;

namespace Domain.Model;

public class Item : Entity
{
    public string Name { get; set; }
    public Guid BasketId { get; set; }

    protected Item() { }

    public Item(string name, Guid basketId)
    {
        Name = name;
        BasketId = basketId;
    }
}