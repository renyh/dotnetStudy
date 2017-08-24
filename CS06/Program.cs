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
            Console.WriteLine("===例子1===");
            Sample1();

            Console.WriteLine("\r\n===例子2===");
            Sample2();

            Console.WriteLine("\r\n===例子3===");
            Sample3();

            Console.WriteLine("\r\n===例子4===");
            Sample4();

            Console.WriteLine("\r\n===例子5===");
            Sample5();

            Console.WriteLine("\r\n===C#入门经典if例子===");
            Sample_if();

            Console.WriteLine("\r\n===C#入门经典swith例子===");
            Sample_swith();

            Console.ReadKey();
        }

        // 例子1
        static void Sample1()
        {
            int value1 = 11;
            int value2 = value1 > 10 ? 1 : 0;
            Console.WriteLine("value2=" + value2);
        }

        // 例子2
        static void Sample2()
        {
            // 局部变量定义
            int a = 10;

            // 使用 if 语句检查布尔条件
            if (a < 20)
            {
                // 如果条件为真，则输出下面的语句 
                Console.WriteLine("a 小于 20");
            }
            Console.WriteLine("a 的值是 {0}", a);
        }

        static void Sample3()
        {
            // 局部变量定义 
            int a = 100;

            // 检查布尔条件 
            if (a < 20)
            {
                // 如果条件为真，则输出下面的语句 
                Console.WriteLine("a 小于 20");
            }
            else
            {
                // 如果条件为假，则输出下面的语句 
                Console.WriteLine("a 大于 20");
            }
            Console.WriteLine("a 的值是 {0}", a);
        }

        static void Sample4()
        {
            /* 局部变量定义 */
            int a = 100;

            /* 检查布尔条件 */
            if (a == 10)
            {
                /* 如果 if 条件为真，则输出下面的语句 */
                Console.WriteLine("a 的值是 10");
            }
            else if (a == 20)
            {
                /* 如果 else if 条件为真，则输出下面的语句 */
                Console.WriteLine("a 的值是 20");
            }
            else if (a == 30)
            {
                /* 如果 else if 条件为真，则输出下面的语句 */
                Console.WriteLine("a 的值是 30");
            }
            else
            {
                /* 如果上面条件都不为真，则输出下面的语句 */
                Console.WriteLine("没有匹配的值");
            }
            Console.WriteLine("a 的准确值是 {0}", a);
        }

        static void Sample5()
        {
            /* 局部变量定义 */
            char grade = 'B';

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("很棒！");
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine("做得好");
                    break;
                case 'D':
                    Console.WriteLine("您通过了");
                    break;
                case 'F':
                    Console.WriteLine("最好再试一下");
                    break;
                default:
                    Console.WriteLine("无效的成绩");
                    break;
            }
            Console.WriteLine("您的成绩是 {0}", grade);
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
