using Microsoft.AspNetCore.Mvc;
using Together.Contract.Controller;

namespace Together.Api.Controllers;

[ApiController]
[Route("api")]
public class EventController : ControllerBase
{
    [HttpPost("add-event")]
    public IActionResult AddEvent(AddEventRequest request)
    {
        AddEventResponse response = new AddEventResponse(
            Guid.NewGuid(), request.name, request.coordinator,
            request.place, request.lat, request.lng, request.fee
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