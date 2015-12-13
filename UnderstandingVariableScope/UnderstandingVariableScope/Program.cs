using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingVariableScope
{
    class Program
    {
        //private static string k = "";

        static void Main(string[] args)
        {
            Car car = new Car();
            car.DoSomething();
            /*
            string j = "";
           
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                j = i.ToString();
                k = i.ToString();
                if (i == 9)
                {
                    string l = i.ToString();
                }
                //Console.WriteLine("l: " + l);

            }
            //Console.WriteLine(i);
            Console.WriteLine("Outside of the for: " + j);
            //Console.WriteLine("k: " + k);
            helperMethod();
            */
            Console.ReadLine();
        }
        /*
        static void helperMethod()
        {
            Console.WriteLine("k from the helperMethod: " + k);
        }
        */
    }
    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }
        private string helperMethod()
        {
            return "Hello World!";
        }
    }
}
