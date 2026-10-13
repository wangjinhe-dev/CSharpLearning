using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数学运算类Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输出pi
            double pi = Math.PI;
            Console.WriteLine(pi);

            //绝对值
            int a=Math.Abs(-30);
            Console.WriteLine(a);

            //向上取整
            double b = Math.Ceiling(3.12);
            Console.WriteLine(b);
            //向下取整
            double c = Math.Floor(2.15);
            Console.WriteLine(c);

            //取两数中较大/小的那位
            Console.WriteLine(Math.Max(4,5));
            Console.WriteLine(Math.Min(4, 5));

            //次幂
            Console.WriteLine($"返回指定次数的次幂:{Math.Pow(2,3)}");

            //开平方根
            Console.WriteLine(Math.Sqrt(8));

            //银行舍入法 取就近偶数
            Console.WriteLine(Math.Round(5.5));
        }
    }
}
