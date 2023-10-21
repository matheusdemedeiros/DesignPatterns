namespace BuilderPattern.Domain
{
    public interface ICreditCardBuilder
    {
        ICreditCardBuilder WithHolderName(string holderName);
        ICreditCardBuilder WithCardNumber(long cardNumber);
        ICreditCardBuilder WithBankName(string bankName);
        ICreditCardBuilder WithCVV(int cvv);
        ICreditCardBuilder WithExpirationDate(DateTimeOffset expirationDate);
        ICreditCardBuilder WithCreditLimit(decimal creditLimit);
        CreditCard Build();
    }
}