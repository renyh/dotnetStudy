//using 关键字用于在程序中包含命名空间，可以包含多个 using 语句。
using System;

//名字空间，一个名字空间可以包括多个类，
namespace CS02     
{
    // 类
    class Program
    {
        /*
        Main()函数是个特殊函数，是程序的入口点，整个程序只能有一个。
        写法也是固定的
         */
        static void Main(string[] args)
        {
            #region C#语句

            try
            {

                Console.WriteLine("这是一个计算面积的程序");



                // 获得输入的长度
                Console.WriteLine("请输入长度：");
                string strLength = Console.ReadLine();
                double length = Convert.ToDouble(strLength);

                // 获得输入的宽度
                Console.WriteLine("请输入宽度：");
                string strWidth = Console.ReadLine();
                double width = Convert.ToDouble(strWidth);

                // 创建矩型类，获取面积
                Rectangle rect = new Rectangle();
                rect.Length = length;
                rect.Width = width;
                double area = rect.GetArea();


                Console.WriteLine("面积为：" + area.ToString() + "，按任意键结束。");
            }
            catch (Exception ex)
            {
                Console.WriteLine("输入错误：" + ex.Message + "必须要输入数值型的值。");  
            }


            Console.ReadKey();


            #endregion
        }
    }

    // 矩型类
    class Rectangle
    {
        #region 构造函数

        public Rectangle()
        { }

        #endregion

        #region 成员变量

        // 长度
        private double _length;
        // 宽度
        private double _width;

        #endregion

        #region 属性

        // 长度
        public double Length
        {
            get { return _length; }
            set { _length = value; }
        }

        // 宽度
        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        #endregion

        #region 方法

        /// <summary>
        /// 计算面积
        /// </summary>
        /// <returns>返回面积值</returns>
        public double GetArea()
        {
            return Length * Width;
        }

        #endregion
    }
}
