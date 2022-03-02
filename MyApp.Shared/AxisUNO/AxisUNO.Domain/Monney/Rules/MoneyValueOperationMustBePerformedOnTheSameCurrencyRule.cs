using BuildingBlocks.Domain.BusinessRules;

namespace  MyApp.Domain.Monney.Rules;

public class MoneyValueOperationMustBePerformedOnTheSameCurrencyRule : IBusinessRule
{
    private readonly MoneyValue _value1;
    private readonly MoneyValue _value2;

    public MoneyValueOperationMustBePerformedOnTheSameCurrencyRule(MoneyValue value1, MoneyValue value2)
    {
        _value1 = value1;
        _value2 = value2;
    }

    /// <inheritdoc/>
    public string Message => "Money value currencies must be the same";

    /// <summary>
    /// Cheks currencies, that must be the same
    /// </summary>
    /// <returns>True, when rule is broken, because an operation has different currencies</returns>
    public bool BrokenWhen() => _value1 != _value2;
}