namespace  MyApp.Domain.Monney.CurrenciesExchange;

public class ConversionRate
{
    public ConversionRate(Currency sourceCurrency, Currency targetCurrency, decimal coefficient)
    {
        SourceCurrency = sourceCurrency;
        TargetCurrency = targetCurrency;
        Coefficient = coefficient;
    }

    public Currency SourceCurrency { get; }

    public Currency TargetCurrency { get; }

    public decimal Coefficient { get; }
}