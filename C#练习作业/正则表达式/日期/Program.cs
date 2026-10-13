using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 日期
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//获取本地时间
            DateTime now= DateTime.Now;
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(now);
            //年 月 日 小时 分钟 秒
            Console.WriteLine(now.Year);
            Console.WriteLine(now.Month);
            Console.WriteLine(now.Day);
            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);
            Console.WriteLine(now.Second);

            Console.WriteLine(now.ToString("yyyy年MM月dd日"));
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss"));

            //距离某个日期还有多久
            TimeSpan time=new DateTime(2027,1,1,1,0,0,0)-DateTime.Now;
            Console.WriteLine("距离2027元旦还有："+time);

            //获取星期几
            DateTime week=DateTime.Now;
            Console.WriteLine(week.DayOfWeek);*/

            
            DateTime date =new DateTime(2026,10,11);

            //Getweek((DayOfWeek)Enum.Parse(typeof(DayOfWeek),Console.ReadLine()));
        }

        //在主程序里声明一个无返回值有参数的方法，必须是静态的才能调用
        public static void Getweek(DateTime dt)
        {
            //DayOfWeek week = dt.DayOfWeek;
            //string week1 = week.ToString();
            string week2 = dt.DayOfWeek.ToString();
            string[] dateweek = new string[] { "星期一", "星期二", "星期三", "星期四", "星期五", "星期六", "星期日" };
            string[] dateweek1 = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            for (int i = 0; i < 7; i++)
            {
                if (week2 == dateweek1[i])
                {
                    Console.WriteLine("这天是" + dateweek[i]);
                    break;
                }
            }
        }
        //public static void Getweek(DateTime dt)
        //{
        //    string[] dateweek = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
        //    Console.WriteLine("这天是" + dateweek[(int)dt.DayOfWeek]);
        //    //因为`dt.DayOfWeek` 本身就能转成整数索引（Sunday = 0, Monday = 1...），一行就能拿到中文星期，完全不用两个数组去循环匹配。
        //}

    }
}
