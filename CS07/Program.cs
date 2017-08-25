using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS07
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

            Console.WriteLine("\r\n===例子6===");
            Sample6();

            Console.ReadLine();
        }

        static void Sample1()
        {
            // 局部变量定义 
            int a = 10;

            // while 循环执行 
            while (a < 20)
            {
                Console.WriteLine("a 的值： {0}", a);
                a++;
            }
        }

        static void Sample2()
        {
            /* 局部变量定义 */
            int a = 10;

            /* do 循环执行 */
            do
            {
                Console.WriteLine("a 的值： {0}", a);
                a = a + 1;
            } while (a < 10);
        }

        static void Sample3()
        {
            /* for 循环执行 */
            for (int a = 10; a < 20; a ++)
            {
                Console.WriteLine("a 的值： {0}", a);
            }
        }

        static void Sample4()
        {
            int[] myArray = new int[] { 0, 1, 1, 2, 3, 5, 8, 12 };
            foreach (int item in myArray)
            {
                System.Console.WriteLine(item);
            }
        }

        static void Sample5()
        {
            // 局部变量定义
            int a = 10;

            // while 循环执行
            while (a < 20)
            {
                a++;
                if (a > 15)
                {
                    // 使用 break 语句终止 loop 
                    break;
                }
                Console.WriteLine("a 的值： {0}", a);
            }
        }


        static void Sample6()
        {
            // 局部变量定义
            int a = 10;
            // while 循环执行
            while (a < 15)
            {
                a++;
                if (a == 12)
                {
                    // 使用continue跳过迭代
                    continue;
                }
                Console.WriteLine("a 的值： {0}", a);
            }
        }

    }
}
