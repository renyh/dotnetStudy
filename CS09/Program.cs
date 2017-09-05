using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS09
{
    class Program
    {
        static void Main(string[] args)
        {
            // 小范围的数据类型可能直接隐式转换为大范围的数据类型
            int a = 10;
            double b = a;
            Console.WriteLine("a=" + a + ";b=" + b);


            //大范围的数据类型不能直接隐式转换为小范围的数据类型
            //long a1 = 10.5;
            //int b1 = a1;

            // 使用强制类型转换
            double a1 = 10.5;
            int b1 = (int)a1;
            Console.WriteLine("a1=" + a1 + ";b1=" + b1);


            //隐式转换的左右两个数据类型要兼容，string不能隐式转换为int
            //string text = "15";
            //int n = text;

            // 使用Convert类进行数据类型转换
            string text = "15";
            int n = Convert.ToInt32(text);
            Console.WriteLine("text=" + text + ";n=" + n);

            Console.ReadKey();
        }
    }
}
