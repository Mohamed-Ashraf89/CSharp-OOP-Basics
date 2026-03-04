static void Main(string[] args)
{
    BankAccount account1 =new BankAccount();
    account1.DisplayAccountInfo();

    Console.WriteLine();

    BankAccount account2 =new BankAccount("Mohamed",1000);
    account2.DisplayAccountInfo();
    Console.WriteLine();

    account2.Deposit(500);
    account2.Withdraw(1000);
    account2.DisplayAccountInfo();

    Console.WriteLine();

    BankAccount account3 = new BankAccount(account2);
    account3.DisplayAccountInfo();

    Console.WriteLine();

    Console.WriteLine($"Total accounts created: {BankAccount.TotalAccounts}");

}
