using Together.Application;
using Together.Application.Services;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    //builder.Services.AddScoped<IEventService,EventService>();
    builder.Services.AddApplication();
}

var app = builder.Build();
{
    app.UseHttpsRedirection();

    app.MapControllers();

    app.Run();
}
