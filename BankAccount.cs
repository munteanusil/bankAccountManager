using Conventions.ExceptionsLesson;

namespace Conventions
{
    struct BankAccount
    {
        public int AccountNumber;
        string OwnerName;
        decimal Sold;
        DateTime Created;

        public BankAccount(int accountNumber, string ownerName, decimal sold, DateTime created)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Sold = sold;
            Created = created;
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($" Number: {AccountNumber},\n AccountHolder: {OwnerName},\n Balance: {Sold},\n DateCreated: {Created}");
        }

        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                Sold += amount;
            }
            else
            {
                Console.WriteLine("Please write a valid amount");
            }
        }

        public void Widraw(int amount)
        {
            if (amount > 0)
            {
                if (Sold >= amount)
                {
                    Sold -= amount;
                }
                else
                {
                    Console.WriteLine("Insuficent funds!");
                    throw new InsuficientFundsException("Insuficent funds!");
                }
            }
            else
            {
                Console.WriteLine("Please write a valid amount");
            }
        }
    }
}
