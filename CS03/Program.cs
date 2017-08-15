using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS03
{
    class Program
    {
        static void Main(string[] args)
        {

            //===字符串===

            // 引号括起来的普通字符串
            String str1 = "runoob.com";
            Console.WriteLine(str1);

            //一个 @引号字符串：
            String str2 = @"runoob.com";
            Console.WriteLine(str2);

            //C# string 字符串的前面可以加 @（称作"逐字字符串"）将转义字符（\）当作普通字符对待，比如：
            string str3 = @"C:\Windows";
            Console.WriteLine(str3);
            //等价于：
            string str4 = "C:\\Windows";
            Console.WriteLine(str4);

            //@ 字符串中可以任意换行，换行符及缩进空格都计算在字符串长度之内。 
            string str5 = @"<script type=""text/javascript"">
                                    <!--
                                    -->
                                </script>";
            Console.WriteLine(str5);

            //===变量声明与赋值===

            // 先声明变量
            short a;
            int b;
            double c=10.5; //声明与赋值

            //给变量赋值
            a = 10;
            b = 20;
            double d = a + b + c;

            // 输出
            Console.WriteLine("a = {0}, b = {1}, c = {2}, d= {3}", a, b, c,d);

   


            //===object与值类型转换===

            //装箱：就是 将一个值类型转换成等值的引用类型，例如
            int val = 8;
            object obj = val;//整型数据转换为了对象类型（装箱）
            Console.WriteLine(obj);

            //拆箱：之前由值类型转换而来的对象类型再转回值类型, 只有装过箱的数据才能拆箱
            int val1 = 7;
            object obj1 = val1;//先装箱
            int val2 = (int)obj1;//再拆箱
            Console.WriteLine(val2);


            //===类型转换===
            int i = 10;
            long l = i;
            Console.WriteLine("l="+l);

            double d1 = 5673.74;
            int i1;
            i1 = (int)d1; // 强制转换 double 为 int   
            Console.WriteLine("i1=" + i1);


            //===测试接收数据==
            Console.WriteLine("请输入一个数值：");
            string text = Console.ReadLine();
            int num = Convert.ToInt32(text);
            Console.WriteLine("您输入的数值为："+num);




            Console.ReadKey();


        }

        
    }
}
