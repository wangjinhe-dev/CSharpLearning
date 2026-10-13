using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态类
{
    static class Student
    {
        public static string Day;
        public static void Situation(string Day ,string situ)
        {
            Console.WriteLine("输入日期：");
            Day = Console.ReadLine();
            if (Day == "星期五")
            {
                Console.WriteLine("输入天气：");
                situ = Console.ReadLine();
                if (situ=="晴天")
                {
                    Console.WriteLine("小明不打伞");
                }
                else if (situ == "雨天")
                {
                    Console.WriteLine("小明打伞");
                }
                else
                {
                    Console.WriteLine("爱打不打");
                }
            }
            else
            {
                Console.WriteLine("今天不是星期五。");
            }
            
        }
    }
}
