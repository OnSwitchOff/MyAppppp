using BuildingBlocks.Domain.UnitOfWorks;
using BuildingBlocks.Infrastructure.Domain.UnitOfWorks.DataStorage;
using BuildingBlocks.Infrastructure.Domain.UnitOfWorks.DomainEventsDispatching;
using HarabaSourceGenerators.Common.Attributes;

namespace BuildingBlocks.Infrastructure.Domain.UnitOfWorks;

[Inject]
public partial class UnitOfWork : IUnitOfWork
{
    private readonly IDataStorage _dataStorageDispatcher;
    private readonly IDomainEventsDispatcher _domainEventsDispatcher;

    public async Task<int> CommitAsync(CancellationToken cancellationToken = default)
    {
        await _domainEventsDispatcher.DispatchEventsAsync(cancellationToken);

        return await _dataStorageDispatcher.SaveChangesAsync(cancellationToken);
    }
}