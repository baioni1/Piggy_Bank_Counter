using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piggy_Bank_Counter_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many pennies?");
            int pennies = int.Parse(Console.ReadLine());
            Console.WriteLine("How many nickels?");
            int nickels = int.Parse(Console.ReadLine());
            Console.WriteLine("How many dimes?");
            int dimes = int.Parse(Console.ReadLine());
            Console.WriteLine("How many quarters?");
            int quarters = int.Parse(Console.ReadLine());
            Console.WriteLine("How many half dollars?");
            int halfDollars = int.Parse(Console.ReadLine());
            Console.WriteLine("How many gold dollars?");
            int goldDollars = int.Parse(Console.ReadLine());

            int TotalMoneyInCents = (pennies) + (nickels * 5) + (dimes * 10) + (quarters * 25) + (halfDollars * 50) + (goldDollars * 100);

            double TotalMoneyInDollars = Convert.ToDouble(TotalMoneyInCents) / 100;

            Console.WriteLine("You have ${0} dollars:" , TotalMoneyInDollars);

            if(TotalMoneyInDollars >= 20)
            {
                TotalMoneyInDollars -= TotalMoneyInDollars % 20;
                Console.WriteLine("You will receive {0} $20 bills returned:", TotalMoneyInDollars/20);

            }
        }
    }
}
