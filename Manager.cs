namespace Conventions2
{
    public class UserManager  
    {
        private List<User> allUsers;  

        public UserManager()
        {
            allUsers = new List<User>();
        }

        public void AddUser(string name, int age)  
        {
            var newUser = new User
            {
                UserName = name,  
                UserAge = age
            };

            allUsers.Add(newUser);
        }

        public void PrintTopUsers(int nr) 
        {
            for (int i = 0; i < nr && i < allUsers.Count; i++)
            {
                Console.WriteLine(allUsers[i].UserName);
            }
        }

        public void StartSessionForUser(string name)  
        {
            Console.WriteLine("Starting session for " + name);
        }
    }

    public class User 
    {
        public string UserName;  
        public int UserAge;

        public void Login()  
        {
            Console.WriteLine(UserName + " has logged in.");
        }
    }

    public enum SessionType
    {    
        Web, 
        App
    }

}
