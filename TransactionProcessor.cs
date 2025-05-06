namespace Conventions
{
    public enum PaymentMethod 
    {
        Cash,       
        CreditCard  
    }

    public class TransactionProcessor  
    {
        public const decimal TAXRATE = 0.2m;  

        public void ProcessPayment(PaymentMethod method)  
        {
            Console.WriteLine("Processing " + method.ToString());
        }
    }

}
