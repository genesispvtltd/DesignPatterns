public class CreditCardFactory
{
   public static CreditCard GetCreditCard(string cardType)
        {
            CreditCard cardDetails = null;
            
            if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }
            
            return cardDetails;
        }


}