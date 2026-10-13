using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._24新学的switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //智能查询系统
            Console.WriteLine("------智能查询系统------");
            Console.WriteLine("1.成绩等级评定");
            Console.WriteLine("2. 季节查询");
            Console.WriteLine("0. 退出程序");
            Console.WriteLine("------------------------");
            Console.WriteLine("请输入选项：");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (id)
            {
                case 1:
                    Console.WriteLine("成绩等级评定：");
                    Console.WriteLine("请输入成绩（0-100）:");
                    int score=Convert.ToInt32(Console.ReadLine());
                    if(score>=0&&score<=100)
                    {
                        switch (score/10)
                        {
                            case 9:
                            case 10:
                                Console.WriteLine("优秀");
                                break;
                            case 8:
                                Console.WriteLine("良好");
                                break;
                            case 7:
                                Console.WriteLine("中等");
                                break;
                            case 6:
                                Console.WriteLine("及格");
                                break;
                            case 5:
                            case 4:
                            case 3:
                            case 2:
                            case 1:
                            case 0:
                                Console.WriteLine("不及格");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("输入无效！");
                    }
                        break;
                case 2:
                    Console.WriteLine("季节查询：");
                    Console.WriteLine("请输入月份（1-12）:");
                    int month = Convert.ToInt32(Console.ReadLine());
                    switch (month)
                    {
                        case 3:
                        case 4:
                        case 5:
                            Console.WriteLine("这是春季");
                            break;
                        case 6:
                        case 7:
                        case 8:
                            Console.WriteLine("这是夏季");
                            break;
                        case 9:
                        case 10:
                        case 11:
                            Console.WriteLine("这是秋季");
                            break;
                        case 12:
                        case 1:
                        case 2:
                            Console.WriteLine("这是冬季");
                            break;
                        default : Console.WriteLine("输入无效！");
                            break;
                    }
                    break;
                case 0:
                    Console.WriteLine("退出程序");
                    Console.WriteLine("感谢使用，再见！");
                    break;
                default:
                    Console.WriteLine("无效选项，请重新输入");
                    break;
            }
        }
    }
}
