namespace BuilderPattern.Domain
{
    public class CreditCardBuilder : ICreditCardBuilder
    {
        private CreditCard _creditCard;

        private CreditCardBuilder()
        {
            _creditCard = new CreditCard();
        }

        public static ICreditCardBuilder Configure()
        {
            return new CreditCardBuilder();
        }

        public ICreditCardBuilder WithHolderName(string horlderName)
        {
            _creditCard.HolderName = horlderName;

            return this;
        }

        public ICreditCardBuilder WithCardNumber(long cardNumber)
        {
            _creditCard.CardNumber = cardNumber;

            return this;
        }

        public ICreditCardBuilder WithCVV(int cvv)
        {
            _creditCard.CVV = cvv;

            return this;
        }

        public ICreditCardBuilder WithExpirationDate(DateTimeOffset expirationDate)
        {
            _creditCard.ExpirationDate = expirationDate;

            return this;
        }

        public ICreditCardBuilder WithCreditLimit(decimal creditLimit)
        {
            _creditCard.CreditLimit = creditLimit;

            return this;
        }

        public ICreditCardBuilder WithBankName(string bankName)
        {
            _creditCard.BankName = bankName;

            return this;
        }

        public CreditCard Build()
        {
            return _creditCard;
        }
    }
}