namespace Domain.Common;

public class AggregateRoot : Entity
{
    public IEnumerable<DomainEvent> Events;

    public AggregateRoot()
    {
        Events = new List<DomainEvent>();
    }

    public void AddEvent(DomainEvent domainEvent)
    {
        Events.Append(domainEvent);
    }
}