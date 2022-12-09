namespace Together.Application.Services;

public interface IEventService
{
    EventAddResult add(String name, String coordinator, String place, 
    float lat, float lng, int fee);
    EventQueryResult[] query(float lat, float lng, float len);
}