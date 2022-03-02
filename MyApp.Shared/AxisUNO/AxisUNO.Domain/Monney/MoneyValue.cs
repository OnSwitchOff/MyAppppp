using MyApp.Domain.Monney.CurrenciesExchange;
using MyApp.Domain.Monney.Rules;
using BuildingBlocks.Domain.ValueObjects;

namespace  MyApp.Domain.Monney;

public record MoneyValue : ValueObject
{
    public MoneyValue(decimal value, Currency currency)
    {
        Value = value;
        Currency = currency;
    }

    public decimal Value { get; }

    public Currency Currency { get; }

    public static MoneyValue operator +(MoneyValue moneyValueLeft, MoneyValue moneyValueRight)
    {
        CheckRule(new MoneyValueOperationMustBePerformedOnTheSameCurrencyRule(moneyValueLeft, moneyValueRight));

        return new MoneyValue(moneyValueLeft.Value + moneyValueRight.Value, moneyValueLeft.Currency);
    }

    public static MoneyValue operator *(decimal coefficient, MoneyValue moneyValue)
    {
        return new MoneyValue(moneyValue.Value * coefficient, moneyValue.Currency);
    }
}