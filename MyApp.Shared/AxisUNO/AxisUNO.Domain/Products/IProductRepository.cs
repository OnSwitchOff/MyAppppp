namespace  MyApp.Domain.Products;

public interface IProductRepository
{
    Task<Product?> GetByIdAsync(int productId);

    ValueTask AddAsync(Product product);

    IAsyncEnumerable<Product> GetAllAsync(bool includeProductGroup = false);
}