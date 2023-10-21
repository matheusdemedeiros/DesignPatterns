namespace BuilderPattern.Domain
{
    public class CreditCard
    {
        public string HolderName { get; set; }

        public long CardNumber { get; set; }

        public int CVV { get; set; }

        public DateTimeOffset ExpirationDate { get; set; }

        public decimal CreditLimit { get; set; }

        public string BankName { get; set; }

        public override string ToString()
        {
            return $"Holder: {HolderName} - Number: {CardNumber} - CVV: {CVV} - BankName: {BankName}";
        }
    }
}