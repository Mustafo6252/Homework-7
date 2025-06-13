namespace Homework7;

public class BankAccount
{
    private  int nextAccountId = 0001;

    public int accountId;
    public decimal balance;
    public string ownerName;
    public bool isFrozen;

    public BankAccount(decimal initialBalance, string ownerName)
    {
        this.accountId = nextAccountId++;
        this.balance = initialBalance;
        this.ownerName = ownerName;
        isFrozen = false;
    }

    public void deposit(decimal amount)
    {
        if (isFrozen)
        {
            Console.WriteLine("Deposit failed: Account is frozen.");
            return;
        }
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive.");
            return;
        }

        this.balance += amount;
        Console.WriteLine($"Deposit successful: {amount} deposited. New balance: {balance}");
    }

    public void withdraw(decimal amount)
    {
        if (isFrozen)
        {
            Console.WriteLine("Withdraw failed: Account is frozen.");
            return;
        }
        if (amount <= 0)
        {
            Console.WriteLine("Withdraw amount must be positive.");
            return;
        }
        if (amount > balance)
        {
            Console.WriteLine("Withdraw failed: Insufficient balance.");
            return;
        }

        this.balance -= amount;
        Console.WriteLine($"Withdraw successful: {amount} withdrawn. New balance: {balance}");
    }

    public void FreezeAccount()
    {
        this.isFrozen = true;
        Console.WriteLine("Account is frozen.");
    }

    public void UnfreezeAccount()
    {
        this.isFrozen = false;
        Console.WriteLine("Account is unfrozen.");
    }

    public void Info()
    {
        Console.WriteLine("------- Info about account -------");
        Console.WriteLine($"Account ID: {this.accountId}");
        Console.WriteLine($"Owner Name: {this.ownerName}");
        Console.WriteLine($"Balance: {this.balance}");
        Console.WriteLine($"Frozen: {this.isFrozen}");
    }
}