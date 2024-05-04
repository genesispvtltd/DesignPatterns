Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

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

