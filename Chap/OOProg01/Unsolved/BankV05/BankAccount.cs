
/// <summary>
/// This class represents a very simple bank account.
/// Only the amount of money on the account is represented.
/// </summary>
public class BankAccount
{
    // instance fields
    private double _balance;
    private string _name;


    // constructor
    public BankAccount(string name)
    {
        _balance = 0.0;
        _name = name;
    }

    //a property 
    public double Balance
    {
        get { return _balance; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }


    // methods
    public void Deposit(double amount)
    {
        _balance += amount;
    }

    public void Withdraw(double amount)
    {
        _balance -= amount;
    }
}

