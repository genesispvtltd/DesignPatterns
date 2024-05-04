public abstract class CreditCard:ICreditCard
{
    public string BankName{get;set;}
    public string Type {get;set;}
    public string Number{get;set;}
    public decimal Limit{get;set;}

    public abstract decimal GetDiscount();
    

     public abstract string GetCardType();

    
}