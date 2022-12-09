using Together.Application.Services;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddScoped<IEventService,EventService>();
}

var app = builder.Build();
{
    app.UseHttpsRedirection();

    app.MapControllers();

    app.Run();
}
