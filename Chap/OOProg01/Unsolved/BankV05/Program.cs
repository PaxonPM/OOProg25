
var myAccount = new BankAccount("John Doe");

Console.WriteLine($"Account name is: {myAccount.Name}");

myAccount.Deposit(2000);
Console.WriteLine($"Account balance is : {myAccount.Balance}");

myAccount.Withdraw(1500);
Console.WriteLine($"Account balance is : {myAccount.Balance}");
myAccount.Name = "Brian Bents";
Console.WriteLine($"Account name is: {myAccount.Name}");

