using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static Random roll = new Random();
        public static ConsoleKeyInfo info;
        public static int actualroll = 0;
        public static int dealerroll = 0;

        static void Main(string[] args)
        {
            while (info.Key != ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("Press R for roll.\nPress H for hold.");
                while (actualroll <= 21)
                {
                    if (actualroll != 21)
                    {
                        info = Console.ReadKey(true);
                    }
                    if (info.Key == ConsoleKey.R)
                    {
                        actualroll += roll.Next(1, 7);
                        Console.WriteLine($"The player rolls {actualroll} total");
                        if (actualroll > 21)
                        {
                            Console.WriteLine("YOU LOSE!");
                            break;
                        }
                    }
                    if (info.Key == ConsoleKey.H || actualroll == 21)
                    {
                        while (dealerroll <= 18)
                        {
                            dealerroll += roll.Next(1, 7);
                            Console.WriteLine($"The dealer rolls {dealerroll} total");
                        }
                        if (actualroll <= 21 && actualroll > 0)
                        {
                            if (actualroll == dealerroll)
                            {
                                Console.WriteLine("TIE!");
                                break;
                            }
                            else if (actualroll < dealerroll && dealerroll <= 21)
                            {
                                Console.WriteLine("DEALER WON!");
                                break;
                            }
                            else if (dealerroll > 21)
                            {
                                Console.WriteLine("DEALER LOST!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("YOU WIN!");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("DEALER WON!");
                            break;
                        }
                    }
                }
                actualroll = 0;
                dealerroll = 0;
                Console.ReadKey();
            }
        }
    }
}
