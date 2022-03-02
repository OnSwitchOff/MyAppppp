using BuildingBlocks.Domain.BusinessRules;

namespace  MyApp.Domain.ProductGroups.Rules
{
    internal class DiscountCanNotBeNegativeRule : IBusinessRule
    {
        private readonly decimal _discount;

        public DiscountCanNotBeNegativeRule(decimal discount)
        {
            _discount = discount;
        }

        /// <inheritdoc/>
        public string Message => "Discount can't be less, than zero";

        /// <inheritdoc/>
        public bool BrokenWhen()
        {
            return _discount < 0;
        }
    }
}