using TaskAbstraction;

namespace TaskAbstraction
{
internal class Program
{
    static void Main(string[] args)
    {
            User user = new User("Pasha","pasha@gmail.com");
            user.PasswordChecker("Salam123");
            user.ShowInfo();

    }
}
    
    
    }
