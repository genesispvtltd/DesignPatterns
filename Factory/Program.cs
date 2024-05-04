namespace Factory;

class Program
{
    static void Main(string[] args)
    {
        CreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");
            
            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetDiscount());
                
            }
        Console.WriteLine("Hello, World!");
    }
}
