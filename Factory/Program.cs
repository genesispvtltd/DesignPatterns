namespace Factory;

class Program
{
    static void Main(string[] args)
    {
        CreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");                 
        Console.WriteLine("CardType : " + cardDetails.GetCardType());
        Console.WriteLine("CreditLimit : " + cardDetails.GetDiscount());                      
         CreditCard goldCardDetails = CreditCardFactory.GetCreditCard("Gold");                
        Console.WriteLine("CardType : " + goldCardDetails.GetCardType());
        Console.WriteLine("CreditLimit : " + goldCardDetails.GetDiscount());                        
    }
}
