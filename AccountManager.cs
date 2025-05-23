namespace Conventions
{
    class AccountManager
    {
        public override string ToString()
        {
            return "";
           
        }

        List<BankAccount> Accounts = new List<BankAccount>();

        public void OpenAccount(int number, string name)
        {
            Accounts.Add(new BankAccount(number, name, 0, DateTime.UtcNow));
        }

        public void DisplayAccountDetails(int number)
        {
            var foundAccount = Accounts.FirstOrDefault(a => a.AccountNumber == number);
            if(foundAccount.AccountNumber == 0)
            {
                Console.WriteLine("Account not found!");
            }
            else
            {
                foundAccount.DisplayAccountDetails();
            }
        }

        public void Deposit(int number, int amount)
        {
            var foundAccount = Accounts.FirstOrDefault(a => a.AccountNumber == number);
            if (foundAccount.AccountNumber == 0)
            {
                Console.WriteLine("Account not found!");
            }
            else
            {
                foundAccount.Deposit(amount);
            }
        }

        public void Widraw(int number, int amount)
        {
            var foundAccount = Accounts.FirstOrDefault(a => a.AccountNumber == number);
            if (foundAccount.AccountNumber == 0)
            {
                Console.WriteLine("Account not found!");
            }
            else
            {
                foundAccount.Widraw(amount);
            }
        }
    }
}
