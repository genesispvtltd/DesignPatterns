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