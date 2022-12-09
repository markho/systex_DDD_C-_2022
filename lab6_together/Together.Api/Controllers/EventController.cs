using Microsoft.AspNetCore.Mvc;
using Together.Application.Services;
using Together.Contract.Controller;

namespace Together.Api.Controllers;

[ApiController]
[Route("api")]
public class EventController : ControllerBase
{
    private readonly IEventService eventService;

    public EventController(IEventService eventService)
    {
        this.eventService = eventService;
    }

    [HttpPost("add-event")]
    public IActionResult AddEvent(AddEventRequest request)
    {
        var result = eventService.add(request.name, request.coordinator, request.place, request.lat,
        request.lng, request.fee);
        AddEventResponse response = new AddEventResponse(
            result.Id, result.name, result.coordinator,
            result.place, result.lat, result.lng, result.fee
        );
        return Ok(response);
    }
    [HttpPost("query-event")]
    public IActionResult QueryEvent(QueryEventRequest request)
    {
        QueryEventResponse res = new QueryEventResponse("nane", "mark", "tpe", 20.4f, 121.3f, 1000);
        QueryEventResponse[] events = new QueryEventResponse[] { res, res, res, res };
        return Ok(events);
    }

}