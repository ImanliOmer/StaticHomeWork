using Static.Model;
using System;

namespace Static
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                User user1 = new User();
                Console.WriteLine("FullName: ");
                user1.Fullname =Console.ReadLine();

                Console.WriteLine("Gmail: ");
                user1.Gmail = Console.ReadLine();

                Console.WriteLine("Password: ");
                user1.Password = Console.ReadLine();
                user1.ShowInfo();
                
                Console.WriteLine("==============================");
                Console.WriteLine("baglamaq ucun ESC basin:");
                Console.WriteLine("davaam etmek ucun ENTER:");

                   

            } while (Console.ReadKey().Key != ConsoleKey.Escape);




        }
    }
}
