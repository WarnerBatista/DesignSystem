using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RealStateManagement;
using RealStateManagement.Strategies;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton<RealStateManager>();
    })
    .Build();

var manager = host.Services.GetRequiredService<RealStateManager>();

manager.AddProperty(PropertyFactory.Create(PropertyType.Apartment, 100, 4, new PremiumRentStrategy(), 5));
manager.AddProperty(PropertyFactory.Create(PropertyType.House, 80, 3, new DiscountRentStrategy(), true));
manager.AddProperty(PropertyFactory.Create(PropertyType.Office, 200, 6, new DiscountRentStrategy(), 50));

manager.ReportRents();