using MyStore.Core.Helpers;

namespace MyStore.Core
{
    public class Product : Entity
    {
        public string Name { get; }
        public string InternalCode { get; }
        public decimal CostPrice { get; }
        public decimal SalePrice { get; }

        public Product(string name, string internalCode, decimal costPrice, decimal salePrice)
        {
            Name = name;
            InternalCode = internalCode;
            CostPrice = costPrice;
            SalePrice = salePrice;
        }

        public override bool Valid()
        {
            return Validator.StringLengthIsValid(Name, 6, 100)
                && Validator.DecimalGreaterThan(CostPrice, 0)
                && Validator.DecimalGreaterThan(SalePrice, 0);
        }
    }
}
