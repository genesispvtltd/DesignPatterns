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