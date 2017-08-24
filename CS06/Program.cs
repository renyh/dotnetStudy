using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===if例子===");
            Sample_if();

            Console.WriteLine("\r\n===swith例子===");
            Sample_swith();

            Console.ReadKey();
        }

        // if例子
        static void Sample_if()
        {
            string comparison;
            Console.WriteLine("Enter a number:");
            string str1 = Console.ReadLine();
            double var1 = Convert.ToDouble(str1);


            Console.WriteLine("Enter another number:");
            string str2 = Console.ReadLine();
            double var2 = Convert.ToDouble(str2);
            if (var1 < var2)
                comparison = "less than";
            else
            {
                if (var1 == var2)
                    comparison = "equal to";
                else
                    comparison = "greater than";
            }
            Console.WriteLine("The first number is " + comparison + " the second number.");
        }

        // swith例子
        static void Sample_swith()
        {
            const string myName = "benjamin";
            const string niceName = "andrea";
            const string sillyName = "ploppy";
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            switch (name.ToLower())
            {
                case myName:
                    Console.WriteLine("You have the same name as me!");
                    break;
                case niceName:
                    Console.WriteLine("My, what a nice name you have!");
                    break;
                case sillyName:
                    Console.WriteLine("That's a very silly name.");
                    break;
            }
            Console.WriteLine("Hello " + name + "!");
        }
    }
}
