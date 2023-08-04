namespace Domain.Common;

public class AggregateRoot : Entity
{
    public List<DomainEvent> Events;

    public AggregateRoot()
    {
        Events = new List<DomainEvent>();
    }

    public void AddEvent(DomainEvent domainEvent)
    {
        Events.Add(domainEvent);
    }
}