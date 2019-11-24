namespace SalesTaxes
{
    public class ShoppingCartItem
    {
        const decimal TaxRate = 0.1m;
        const decimal ImpTaxRate = 0.05m;
        public Product Item { get; set; }
        public int Quantity { get; set; }
        public decimal Taxes
        {
            get
            {
                return decimal.Ceiling(Item.Price * (CalculateTaxRate() + CalculateImportRate()) * 20) / 20;
            }
        }

        private decimal CalculateTaxRate()
        {
            return Item.IsExempt
                ? 0
                : TaxRate;
        }

        private decimal CalculateImportRate()
        {
            return Item.IsImport
                ? ImpTaxRate
                : 0;
        }
    }
}
