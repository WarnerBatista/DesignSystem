using TransportManagement;
using TransportManagement.Strategies;
using TransportManagement.Types;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/calculate-cost", () =>
{
    var manager = new TransportManager(TransportType.Air, new PremiumStrategy());

    return manager.Process(100);
});

app.Run();
