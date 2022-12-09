using Together.Application.Common.Interfaces;
using Together.Domain.Entity;

namespace Together.Application.Services;

public class EventService : IEventService
{
    private readonly IEventRepository repository;

    public EventService(IEventRepository repository)
    {
        this.repository = repository;
    }

    public EventAddResult add(string name, string coordinator, string place, float lat, float lng, int fee)
    {
        var event1 = new Event{Name = name, Coordinator=coordinator,Place = place, Lat=lat, Lng=lng, Fee=fee};
        repository.AddEvent(event1);
        return new EventAddResult(Guid.NewGuid(), name, coordinator, place, lat, lng, fee);
    }

    public EventQueryResult[] query(float lat, float lng, float len)
    {
        EventQueryResult result = new EventQueryResult("name", "coord", "TPE", 24.5f, 121.3f, 500);
        EventQueryResult[] results = new EventQueryResult[] { result, result, result };
        return results;
    }
}