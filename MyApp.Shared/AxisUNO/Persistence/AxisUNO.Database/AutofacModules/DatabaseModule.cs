using Autofac;
using MyApp.Database.Domain.Products;
using MyApp.Database.Domain.UnitOfWorks.DataStorage;
using MyApp.Database.Domain.UnitOfWorks.DomainEventsDispatching;
using MyApp.Database.Services.DatabaseMigration;
using MyApp.Domain.Products;
using BuildingBlocks.Application.Services.DatabaseMigration;
using BuildingBlocks.Infrastructure.Domain.UnitOfWorks.DataStorage;
using BuildingBlocks.Infrastructure.Domain.UnitOfWorks.DomainEventsDispatching;
using Microsoft.EntityFrameworkCore;

namespace  MyApp.Database.AutofacModules;

public sealed class DatabaseModule : Module
{
    private readonly DbContextOptions<DatabaseContext> _dbContextOptions;

    public DatabaseModule(DbContextOptions<DatabaseContext> dbContextOptions)
    {
        _dbContextOptions = dbContextOptions;
    }

    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<DatabaseContext>().WithParameter("options", _dbContextOptions).SingleInstance();

        builder.RegisterType<DomainEventsProvider>().As<IDomainEventsProvider>().InstancePerLifetimeScope();
        builder.RegisterType<DatabaseMigrationService>().As<IDatabaseMigrationService>().InstancePerLifetimeScope();
        builder.RegisterType<DataStorage>().As<IDataStorage>().InstancePerLifetimeScope();

        builder.RegisterType<ProductRepository>().As<IProductRepository>().InstancePerLifetimeScope();
    }
}