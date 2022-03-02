using MyApp.Domain.Products;
using HarabaSourceGenerators.Common.Attributes;
using Microsoft.EntityFrameworkCore;

namespace  MyApp.Database.Domain.Products;

[Inject]
public partial class ProductRepository : IProductRepository
{
    private readonly DatabaseContext _databaseContext;

    public async ValueTask AddAsync(Product product)
    {
        await _databaseContext.Products.AddAsync(product);
    }

    public IAsyncEnumerable<Product> GetAllAsync(bool includeProductGroup = false)
    {
        if (includeProductGroup)
        {
            return _databaseContext.Products.Include(product => product.ProductGroup).AsAsyncEnumerable();
        }

        return _databaseContext.Products.Include(product => product.ProductGroup).AsAsyncEnumerable();
    }

    public Task<Product?> GetByIdAsync(int productId)
    {
        return _databaseContext.Products.FirstOrDefaultAsync(product => product.Id == productId);
    }
}