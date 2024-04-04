namespace TaskAbstraction
{
    public class User : IAccount
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User(string fullname, string email)
        {
            FullName = fullname;
            Email = email;

        }
        public bool PasswordChecker(string password)
        {
            bool isValidPassword = false;
            do
            {
                Console.WriteLine("Sifre daxil edin");
                password = Console.ReadLine();
                if (password.Length < 8)
                {
                    Console.WriteLine("Sifre 8-den kicikdir");
                    continue;

                }
                bool checkUpper = false;
                bool checkLower = false;
                bool checkDigit = false;

                foreach (char c in password)
                {

                    if (char.IsUpper(c))
                    {
                        checkUpper = true;

                    }
                    if (char.IsLower(c))
                    {
                        checkLower = true;
                    }
                    if (char.IsDigit(c))
                    {
                        checkDigit = true;
                    }
                }
                if (!checkUpper)
                {
                    Console.WriteLine("sifrede en az 1 boyuk herf olmalidir");

                }
                if (!checkLower)
                {
                    Console.WriteLine("sifrede en az 1 kicik herf olmalidir");
                }
                if (!checkDigit)
                {
                    Console.WriteLine("sifrede en az 1 reqem olmalidir");
                }
                isValidPassword = checkDigit && checkLower && checkUpper;
            } while (!isValidPassword);



            Console.WriteLine("Sifre qebul olundu"); 
            return true;


        }

        public void ShowInfo()
        {
            Console.WriteLine(FullName);
            Console.WriteLine(Email);
        }
    }

}

