using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using MyApp.Application.AutofacModules;
using MyApp.AutofacModules;
using MyApp.Configurations.Database;
using MyApp.Database.AutofacModules;
using MyApp.Infrastructure.AutofacModules;

namespace  MyApp.Configurations;

internal static class Startup
{
    internal static IServiceProvider ConfigureServices()
    {
        var builder = new ContainerBuilder();

        builder.RegisterModule<ActivationModule>();

        builder.RegisterModule<NavigationModule>();

        builder.RegisterModule<LoggingModule>();

        builder.RegisterModule<MediatorModule>();

        builder.RegisterModule<ProcessingModule>();

        builder.RegisterModule<ApplicationServicesModule>();

        builder.RegisterModule(
            new DatabaseModule(
                DatabaseConfiguration.GetOprions()));

        return new AutofacServiceProvider(builder.Build());
    }
}