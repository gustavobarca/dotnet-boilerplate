using Domain.Common;

namespace Domain.Model;

public class Basket : AggregateRoot
{
    public Guid UserId { get; set; }

    public virtual ICollection<Item> Items { get; set; }

    protected Basket() {}

    public Basket(Guid userId)
    {
        UserId = userId;
        Items = new List<Item>();
    }

    public void AddItem(string name)
    {
        Items.Add(new Item(name, Id));
    }

    public void RemoveItem(Guid itemId)
    {
        Item? foundItem = Items.Where(item => item.Id == itemId).FirstOrDefault();

        if (foundItem == null) return;

        Items.Remove(foundItem);
    }

    public void ChangeItemName(Guid itemId, string newName)
    {
        Item? foundItem = Items.Where(item => item.Id == itemId).FirstOrDefault();

        if (foundItem == null) return;

        foundItem.Name = newName;
    }
}