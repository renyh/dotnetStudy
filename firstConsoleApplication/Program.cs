using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("恭喜您！这是一个控制台应用程序");

            Console.WriteLine("请输入用户");
            string userName = Console.ReadLine();

            Console.WriteLine("请输入密码");
            
            string password = Console.ReadLine();

            Console.WriteLine("您输入的用户名是["+userName+"]，密码是["+password+"]，按任意键结束。");
            Console.ReadKey();
        }
    }
}
