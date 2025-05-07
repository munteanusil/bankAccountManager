namespace Conventions
{
    class AccountManager
    {
        BankAccount Account;

        public void OpenAccount(int number, string name)
        {
            Account = new BankAccount(number, name, 0, DateTime.UtcNow);
        }

        public void DisplayAccountDetails(int number)
        {
            if (Account.AccountNumber != number)
            {
                Console.WriteLine("Account not found!");
            }
            else
            {
                Account.DisplayAccountDetails();
            }
        }

        public void Deposit(int number, int amount)
        {
            if (Account.AccountNumber != number)
            {
                Console.WriteLine("Account not found!");
            }
            else
            {
                Account.Deposit(amount);
            }
        }

        public void Widraw(int number, int amount)
        {
            if (Account.AccountNumber != number)
            {
                Console.WriteLine("Account not found!");
            }
            else
            {
                Account.Widraw(amount);
            }
        }
    }
}
