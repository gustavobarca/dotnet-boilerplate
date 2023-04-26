namespace Domain.Common;

public class DomainEvent
{
  protected DateTime OccuredOn;
  protected string Event;

  public string EventName() => Event;

  public DomainEvent(string eventName)
  {
    OccuredOn = DateTime.Now;
    Event = eventName;
  }
}
