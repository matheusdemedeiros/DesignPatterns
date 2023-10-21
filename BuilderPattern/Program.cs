using BuilderPattern.Domain;

var nubankCreditCard = CreditCardBuilder.Configure()
    .WithHolderName("João")
    .WithCardNumber(987654321)
    .WithBankName("Nubank")
    .WithCVV(487)
    .WithExpirationDate(DateTimeOffset.Now.AddYears(8))
    .WithCreditLimit(6000)
    .Build();

var itauCreditCard = CreditCardBuilder.Configure()
    .WithHolderName("Maria")
    .WithCardNumber(3534624563)
    .WithBankName("Itaú")
    .WithCVV(654)
    .WithExpirationDate(DateTimeOffset.Now.AddYears(6))
    .WithCreditLimit(7000)
    .Build();


Console.WriteLine(nubankCreditCard);
Console.WriteLine(itauCreditCard);

Console.ReadLine();