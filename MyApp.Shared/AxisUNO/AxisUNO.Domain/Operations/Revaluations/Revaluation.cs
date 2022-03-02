using MyApp.Domain.Partners;
using MyApp.Domain.Payments;
using MyApp.Domain.Products;

namespace  MyApp.Domain.Operations.Revaluations;

public class Revaluation : Operation
{
    protected Revaluation(Partner partner, Payment payment, params OperationProduct[] operationProducts)
        : base(partner, payment, operationProducts)
    {
    }

    public override OperationType OperationType
    {
        get => OperationType.Revaluation;
    }
}