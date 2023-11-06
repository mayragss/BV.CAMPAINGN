using BV.Campaingn.Domain.Interfaces;
using BV.Campaingn.Infrastructure.Context;
using BV.Campaingn.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV.Campaingn.Infrastructure;

public static class ServiceExtensions
{
    public static void ConfigurePersistenceApp(this IServiceCollection services,
                                                IConfiguration configuration)
    {

        var connectionString = configuration.GetConnectionString("EventCampaingnDb");

        services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString, b=> b.MigrationsAssembly("BV.Campaingn.Api"))); 

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IEventCampaingnRepository, EventCampaingnRepository>();

    }
}
