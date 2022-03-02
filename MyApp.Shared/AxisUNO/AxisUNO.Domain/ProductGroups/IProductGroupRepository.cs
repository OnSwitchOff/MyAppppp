namespace  MyApp.Domain.ProductGroups;

public interface IProductGroupRepository
{
    public Task<ProductGroup> GetDefaultAsync();
}