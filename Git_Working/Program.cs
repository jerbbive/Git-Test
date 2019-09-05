using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Working
{
    class Program
    {
        static void Main(string[] args)
        {
            int int_choice;

            Random random = new System.Random();
            int num = random.Next(0, 100);

            Console.WriteLine("Hello World!");
            Console.WriteLine(num);

            Console.WriteLine("Please guess a number.");
            string choice = Console.ReadLine();
            int.TryParse(choice, out int_choice);

            while(int_choice != num)
            {
                if(int_choice > num)
                {
                    Console.WriteLine("Guess too high.");
                }
                else
                {
                    Console.WriteLine("Guess too low");
                }
                Console.WriteLine("Please another guess a number.");
                choice = Console.ReadLine();
                int.TryParse(choice, out int_choice);
            }
            Console.WriteLine("You Guessed Correctly!");

            



            Console.WriteLine("Push any key to exit.");
            Console.ReadKey();
        }
    }
}
