namespace Simple_ATM_Software;

public class Person
{
    private readonly string creditcard;
    private readonly string pin;
    private readonly double balance;

    public Person(string creditcard, string pin,double balance)
    {
        this.creditcard = creditcard;
        this.pin = pin;
        this.balance = balance;
    }

    public string GetCreditcard()
    {
        return creditcard;
    }

    public string GetPin()
    {
        return pin;
    }

    public double GetBalance()
    {
        return balance;
    }
}