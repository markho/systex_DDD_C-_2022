namespace Together.Application.Services;

public class EventService : IEventService
{

    public EventAddResult add(string name, string coordinator, string place, float lat, float lng, int fee)
    {
        return new EventAddResult(Guid.NewGuid(), name, coordinator, place, lat, lng, fee);
    }

    public EventQueryResult[] query(float lat, float lng, float len)
    {
        EventQueryResult result = new EventQueryResult("name", "coord", "TPE", 24.5f, 121.3f, 500);
        EventQueryResult[] results = new EventQueryResult[] { result, result, result };
        return results;
    }
}