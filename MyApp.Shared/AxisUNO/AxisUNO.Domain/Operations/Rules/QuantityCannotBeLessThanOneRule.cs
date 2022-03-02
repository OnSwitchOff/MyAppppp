using MyApp.Domain.Products;
using BuildingBlocks.Domain.BusinessRules;

namespace  MyApp.Domain.Operations.Rules;

internal class QuantityCannotBeLessThanOneRule : IBusinessRule
{
    private OperationProduct[] _operationProducts;

    public QuantityCannotBeLessThanOneRule(OperationProduct[] operationProducts)
    {
        _operationProducts = operationProducts;
    }

    /// <inheritdoc/>
    public string Message => "Quantity can not be less, than one.";

    /// <inheritdoc/>
    public bool BrokenWhen()
    {
        return _operationProducts.Any(product => product.Quantity < 1);
    }
}