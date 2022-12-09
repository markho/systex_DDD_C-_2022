using Together.Application.Common.Interfaces;
using Together.Domain.Entity;

namespace Together.Infrastructure.Persistence;

public class EventMemRepository : IEventRepository
{
    private static readonly List<Event> _events = new();
    public void AddEvent(Event e)
    {
        _events.Add(e);
    }

    public Event[] GetAll()
    {
        return _events.ToArray();
    }
}