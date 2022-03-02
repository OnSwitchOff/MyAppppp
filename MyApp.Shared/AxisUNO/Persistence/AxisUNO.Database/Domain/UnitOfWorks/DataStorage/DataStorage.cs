using BuildingBlocks.Infrastructure.Domain.UnitOfWorks.DataStorage;
using HarabaSourceGenerators.Common.Attributes;

namespace  MyApp.Database.Domain.UnitOfWorks.DataStorage;

[Inject]
public partial class DataStorage : IDataStorage
{
    private readonly DatabaseContext _context;

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await _context.SaveChangesAsync(cancellationToken);
    }
}