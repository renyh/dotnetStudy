using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS04
{
    class Program
    {
        static void Main(string[] args)
        {
            // 调例子1函数
            Console.WriteLine("例子1执行结果：");
            sample1();

            // 调例子2函数
            Console.WriteLine("\n例子2执行结果：");
            sample2();

            // 调例子3函数
            Console.WriteLine("\n例子3执行结果：");
            sample3();

            // 等待用户任意输入，然后结束
            Console.ReadKey();
        }

        // 例子1
        static void sample1()
        {
            Console.WriteLine("a=21 b=10");
            int a = 21;
            int b = 10;
            int c;

            c = a + b;
            Console.WriteLine("a+b={0}", c);
            c = a - b;
            Console.WriteLine("a-b={0}", c);
            c = a * b;
            Console.WriteLine("a*b={0}", c);
            c = a / b;
            Console.WriteLine("a/b={0}", c);
            c = a % b;
            Console.WriteLine("a%b={0}", c);

        }

        // 例子2
        static void sample2()
        {
            Console.WriteLine("a=1");
            int a = 1;
            int b;

            // a++ 先赋值再进行自增运算
            b = a++;
            Console.WriteLine("b=a++结果: a={0},b={1}", a,b);

            // ++a 先进行自增运算再赋值
            a = 1; // 重新赋值1
            b = ++a;
            Console.WriteLine("b=++a结果: a={0},b={1}", a, b);

            // a-- 先赋值再进行自减运算
            a = 1;  // 重新赋值1
            b= a--;
            Console.WriteLine("b=a--结果: a={0},b={1}", a, b);

            // --a 先进行自减运算再赋值
            a = 1;  // 重新赋值1
            b= --a;
            Console.WriteLine("b=--a结果: a={0},b={1}", a, b);
        }

        // 例子3
        static void sample3()
        {
            Console.WriteLine("a=21");
            int a = 21;
            int c;

            c = a;
            Console.WriteLine("c = a;c的值 = {0}", c);

            c += a;
            Console.WriteLine("c += a;c的值 = {0}", c);

            c -= a;
            Console.WriteLine("c -= a;c的值 = {0}", c);

            c *= a;
            Console.WriteLine("c *= a;c的值 = {0}", c);

            c /= a;
            Console.WriteLine("c /= a;c的值 = {0}", c);

            Console.WriteLine("c赋值200");
            c = 200;
            c %= a;
            Console.WriteLine("c %= a;c的值 = {0}", c);
        }
    }
}
