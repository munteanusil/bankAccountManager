namespace Conventions
{
    public class UserManager  
    {
        private string userName;  

        public string Password { get; set; }

        public void GetUserDetails()  
        {
            string userId = "123";  
            Console.WriteLine("Fetching data for user " + userId);
        }
    }

}
