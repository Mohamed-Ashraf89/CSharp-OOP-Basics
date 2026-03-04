class BankAccount
{
    public int AccountNumber { get; set; }
    public string OwnerName { get; set; }
    public double Balance { get; set; }
    public static int TotalAccounts { get; set; }
    public static string BankName { get; set; }

    //Static Constructor
    static BankAccount()
    {
        BankName = "Egypt Bank";
        TotalAccounts = 0;
    }

    //Default Constructor
    public BankAccount()
    {
        AccountNumber = GenerateAccountNumber();
        OwnerName = "Unknown";
        Balance = 0;
        TotalAccounts ++;
    }

    //Parametarized Constructor
    public BankAccount(string ownerName, double balance)
    {
        AccountNumber = GenerateAccountNumber();
        OwnerName = ownerName;
        Balance = balance;
        TotalAccounts++;
    }

    //Copied Constructor
    public BankAccount (BankAccount bankAccount)
    {
        AccountNumber = GenerateAccountNumber();
        OwnerName = bankAccount.OwnerName;
        Balance = bankAccount.Balance;
        TotalAccounts ++;
    }

    //Deposit Method
    public void Deposit(double amount)
    {
        if(amount > 0)
        {
            Balance += amount;
        }
        else
        {
            Console.WriteLine("Invalid deposit amount!");
        }
    }

    //Withdraw Method
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
        }
        else
        {
            Console.WriteLine("Invalid Withdraw amount!");
        }
    }

    //Display Account Info Method
    public void DisplayAccountInfo()
    {
        Console.WriteLine("----------- Account Info -----------");
        Console.WriteLine($"Bank Name      : {BankName}");
        Console.WriteLine($"Account Number : {AccountNumber}");
        Console.WriteLine($"Owner Name     : {OwnerName}");
        Console.WriteLine($"Balance        : {Balance}");
    }

    //Generate Account Number Method
    private static int lastAccountNumber = 1000;
    private static int GenerateAccountNumber()
    {
        return ++lastAccountNumber;
    }
}
