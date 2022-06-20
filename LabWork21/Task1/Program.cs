using System;

namespace Task1
{
    internal sealed class Program
    {
        private static void Main()
        {
            var user = new User();
            user.MyEvent += Console.WriteLine;
            user.Login = "login";
            user.Password = "my_password";
            user.Login = "";
            user.Password = "my_p";
        }
    }
}
