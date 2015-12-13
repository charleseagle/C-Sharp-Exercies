using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // string myStrings = "Go to your c:\\drive";
            //string myStrings = "My \"so called\" life";
            //string myStrings = "What if I need \na new line?";

            //string myStrings = string.Format("{0}!", "Bonzai");
            //string myStrings = string.Format("Make: {0} (Model: {1})", "BMW", "760i");

            //string myStrings = string.Format("{0:C}", 123.45);

            //string myStrings = string.Format("{0:N}", 123456789);
            //string myStrings = string.Format("{0:P}", .123);

            //string myStrings = string.Format("Phone number: {0:(###) ###-####}", 1234567890);
            /*
            string myStrings = "";
            for (int i = 0; i <100; i++)
            {
                //myStrings = myStrings + "--" + i.ToString();
                myStrings += "--" + i.ToString();
            }

            Console.WriteLine(myStrings);
            Console.ReadLine();
            */

            /*
            StringBuilder myStrings = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myStrings.Append("--");
                myStrings.Append(i);
            }
            */
            string myStrings = "That summer we took threes across the board";
            //myStrings = myStrings.Substring(5, 14);
            //myStrings = myStrings.ToUpper();

            //myStrings = myStrings.Replace(" ", "--");
            myStrings = string.Format("Length before: {0} -- After: {1}",
                myStrings.Length, myStrings.Trim().Length);

            Console.WriteLine(myStrings.ToString());
            Console.ReadLine();

        }
    }
}
