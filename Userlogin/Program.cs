using System;

namespace Userlogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
           User user = new User();
            
            Console.Write("username: ");
            user.Username=Console.ReadLine();
            Console.Write("password: ");
            user.Password=Console.ReadLine();
           
            Console.WriteLine("Sisteme daxil oldunuz!");
        }
    }
}
