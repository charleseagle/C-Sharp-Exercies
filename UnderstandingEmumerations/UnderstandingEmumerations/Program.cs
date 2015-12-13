using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingEmumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            //Console.WriteLine("Hello World!");
            Console.WriteLine("Type in a superhero's name to see his nickname: ");
            string userValues = Console.ReadLine();

            SuperHero myValue;

            if (Enum.TryParse<SuperHero>(userValues, true, out myValue))
            {
                switch (myValue)
                {
                    case SuperHero.Batman:
                        Console.WriteLine("Caped crusader");
                        break;
                    case SuperHero.GreenLantern:
                        Console.WriteLine("Man of steel");

                        break;
                    case SuperHero.Superman:
                        Console.WriteLine("Emerald knight");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Does not compute");

            }
            
            Console.ReadLine();
        }
    }

    enum SuperHero
    {
        Batman,
        Superman,
        GreenLantern

    }
}
