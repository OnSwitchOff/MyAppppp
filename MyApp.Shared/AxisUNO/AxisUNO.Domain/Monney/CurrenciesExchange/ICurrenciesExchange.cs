namespace  MyApp.Domain.Monney.CurrenciesExchange;

public interface ICurrenciesExchange
{
    List<ConversionRate> GetConversionRates();
}