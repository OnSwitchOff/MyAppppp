using BuildingBlocks.Domain.ValueObjects;

namespace  MyApp.Domain.Products.Measures;

public record Measure : ValueObject
{
    public Measure(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }
}