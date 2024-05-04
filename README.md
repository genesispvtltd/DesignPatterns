Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.
Example:
```
public interface ICreditCard
{
    public decimal GetDiscount();
    public string GetCardType();
}

public abstract class CreditCard:ICreditCard
{
    public string BankName{get;set;}
    public string Type {get;set;}
    public string Number{get;set;}
    public decimal Limit{get;set;}

    public abstract decimal GetDiscount();  
    public abstract string GetCardType(); 
}

public class Platinum:CreditCard
{
  public override  decimal GetDiscount()
  {
     return 200M;
  }

  public override string GetCardType(){
    return "Platinum";
  }
}

public class Gold:CreditCard
{
  public override  decimal GetDiscount()
  {
     return 300M;
  }

  public override string GetCardType(){
    return "Gold";
  }

}

public class CreditCardFactory
{
   public static CreditCard GetCreditCard(string cardType)
        {
            CreditCard cardDetails = null;
            
            if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }
            else if(cardType == "Gold"){
                cardDetails = new Gold();
            }
            
            return cardDetails;
        }
}

```

