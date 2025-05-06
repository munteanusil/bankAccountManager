namespace Conventions
{
    public interface IDataBaseConnection  
    {
        void Connect(); 
    }

    public class MySqlDataBase : IDataBaseConnection  
    {
        private string connectionString;  

        public void Connect()  
        {
            Console.WriteLine("Connecting...");
        }
    }

}
