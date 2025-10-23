
BankAccount account = new BankAccount();
Console.WriteLine($"Balance is {account.Balance}");

account.Deposit(500);
Console.WriteLine($"Balance is {account.Balance}");


account.Deposit(-1000);
Console.WriteLine($"Balance is {account.Balance}");

account.Withdraw(600);
Console.WriteLine($"Balance is {account.Balance}");
