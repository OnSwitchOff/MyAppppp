using MyApp.Domain.ProductGroups.Events;
using MyApp.Domain.ProductGroups.Rules;
using MyApp.Domain.Products;
using BuildingBlocks.Domain.Entities;

namespace  MyApp.Domain.ProductGroups;

public class ProductGroup : Entity
{
    private List<Product> _products;

    private ProductGroup(string name, string path, decimal discount)
    {
        Name = name;
        Path = path;
        Discount = discount;
        _products = new();
    }

    public int Id { get; private set; }

    public string Name { get; private set; }

    public string Path { get; private set; }

    public decimal Discount { get; private set; }

    public IReadOnlyCollection<Product> Products
    {
        get => _products;
    }

    public static ProductGroup Create(string name, IGroupPathGenerator generator, decimal discount, List<Product>? products = null)
    {
        CheckRule(new NameMustNotBeEmptyRule(name));
        CheckRule(new PathMustNotBeEmptyRule(name));
        CheckRule(new DiscountCanNotBeNegativeRule(discount));

        return new ProductGroup(name, generator.GetGroupPath(), discount)
        {
            _products = products ?? new(),
        };
    }

    public void ChangeDicount(decimal newDiscount)
    {
        CheckRule(new DiscountCanNotBeNegativeRule(newDiscount));

        Discount = newDiscount;
        AddDomainEvent(new ProductGroupDiscountChangedEvent(Id, Discount));
    }
}