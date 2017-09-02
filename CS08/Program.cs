using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 程序调试
// 1）设置断点 
// 2）逐步执行 F11 
// 3）观察变量
namespace CS08
{
    class Program
    {
        static void Main(string[] args)
        {

            // 局部变量定义
            int a = 1;

            // while 循环执行
            while (a <= 3)
            {
                Console.WriteLine("a 的值： {0}", a);
                a++;
            }

            Console.WriteLine("=end=");
        }
    }
}
