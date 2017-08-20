using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("比较运算符：");
            Sample1();

            
            Console.WriteLine("\r\n逻辑运算符：");
            Sample2();

            Console.ReadKey();
        }


        static void Sample1()
        {
            int a = 21;
            int b = 10;
            Console.WriteLine("a=21,b=10");

            bool c = a == b;
            Console.WriteLine("a==b,结果：" + c);

            c = a < b;
            Console.WriteLine("a<b,结果：" + c);

            c = a > b;
            Console.WriteLine("a>b,结果：" + c);

            c = a <= b;
            Console.WriteLine("a<=b,结果：" + c);

            c = a >= b;
            Console.WriteLine("a>=b,结果：" + c);

            // 比较字符串
            string str1="my";
            string str2="My";
            Console.WriteLine("str1=\"my\",str2=\"My\"");
            c = str1 == str2;
            Console.WriteLine("str1==str2,结果：" + c);

            // 修改str2的值    
            Console.WriteLine("修改str2的值为\"my\"");
            str2 = "my";
            
            c = str1 == str2;
            Console.WriteLine("str1==str2,结果：" + c);

        }


        static void Sample2()
        {
            bool a = true;
            bool b = true;
            Console.WriteLine("当 a=true,b=true 时");

            bool c = a && b;
            Console.WriteLine("a&&b,结果：" + c);

            c = a || b;
            Console.WriteLine("a||b,结果：" + c);

            c = !a;
            Console.WriteLine("!a,结果：" + c);


            /* 改变 a 和 b 的值 */
            a = false;
            b = true;
            Console.WriteLine("当 a=false,b=true时");

            c = a && b;
            Console.WriteLine("a&&b,结果：" + c);

            c = a || b;
            Console.WriteLine("a||b,结果：" + c);

            c = !a;
            Console.WriteLine("!a,结果：" + c);

        }

    }
}
