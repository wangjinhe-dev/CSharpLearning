using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for循环
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for循环练习
            /*for(int i = 1;i<=10;i++)
            {
                Console.WriteLine("i的值为：{0}",i);
            }
            for (int a = 1; a <10; a ++) 
            {
                for (int b = 1; b <10; b++)
                {
                    Console.Write("{0}*{1}={2}",a,b,a*b);
                }
                Console.WriteLine();
            }*/

            //1.累加器
            /*Console.WriteLine("请输入一个正整数：");
            int N = int.Parse(Console .ReadLine());
            int total = 0;
            for (int n=1;n<=N ;n++)
            {
                total += n;
            }
            Console.WriteLine($"累加：1+2+3+....+{N}={total}");*/

            //2.九九乘法表
            /*for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10 && j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t", j, i, i * j);
                }
                Console.WriteLine();
            }*/

            //3.阶乘计算
            /*Console.WriteLine("请输入一个正整数：");
            int N = int.Parse(Console.ReadLine());
            int mul = 1;
            for (int i = 1; i <= N; i++)
            {
                mul *= i;
            }
            Console.WriteLine($"阶乘：{N}！=1*2*3*...*{N}={mul}");*/

            //4.判断素数（质数）***
            /*Console.WriteLine("请输入一个大于1的整数：");
            int N = int.Parse(Console.ReadLine());
            if (N > 1)
            {
                bool iftrue = true;
                for (int i = 2; i <= N - 1; i++)
                {
                    if (N % i == 0)
                    {
                        iftrue = false;
                        break;
                    }
                }
                if (iftrue)
                {
                    Console.WriteLine("这个数是质数。");
                }
                else { Console.WriteLine("这个数不是质数。"); }
            }
            else { Console.WriteLine("输入无效！"); }*/



            //while循环
            /*int i=10;*/
            /*   while (i<10)
               {
                   //代码在后面，当判断条件为假的时候，一次也不输出
                   Console.WriteLine("{0}",i );
                   i++;
               }
               Console.ReadLine();*/

            /*do
            {
                //代码走在前面，当判断条件为假的时候，至少也输出一次
                Console.WriteLine("{0}", i);
                i++;
            }
            while (i < 10);*/


            //do..while循环
            //ATM取钱***
            int total = 1000;
            int id;
            do
            {
                Console.WriteLine("菜单功能:");
                Console.WriteLine("1.查询余额");
                Console.WriteLine("2.取款");
                Console.WriteLine("3.存款");
                Console.WriteLine("4.退出");
                Console.WriteLine("输入您的业务编号：");
                id = int.Parse(Console.ReadLine());
                Console.Clear();
                if (id == 1)//查询余额
                {
                    Console.WriteLine($"当前余额为：{total}");
                }
                else if (id == 2)//取款
                {
                    int outcome;
                    do
                    {
                        Console.WriteLine("输入取款金额：");
                        outcome = int.Parse(Console.ReadLine());
                        if (outcome < 0)
                        {
                            Console.WriteLine("取款金额必须大于零，请重新输入！");
                        }
                        else if (outcome > total)
                        {
                            Console.WriteLine($"当前余额为：{total}，余额不足！");
                            break;
                        }
                        total = total - outcome;
                        Console.WriteLine($"取款成功，当前余额为：{total}");
                        break;
                    } while (true);
                }
                else if (id == 3)//存款
                {
                    do
                    {
                        Console.WriteLine("输入存款金额：");
                        int income = int.Parse(Console.ReadLine());
                        if (income <= 0)
                        {
                            Console.WriteLine("存款金额必须大于零，请重新输入！");
                        }
                        total = total + income;
                        Console.WriteLine($"存款成功！当前余额为{total}");
                        break;
                    } while (true);
                }
                else if (id == 4)//退出
                {
                    Console.WriteLine("感谢使用，再见！");
                    break;
                }
                //if (id != 4)
                //{
                //    Console.WriteLine("当前余额为" + total);
                //}
                else
                {
                    Console.WriteLine("当前余额为" + total);
                    Console.WriteLine("输入无效，请重新输入！");
                }
            } while (true);

        }
    }
} 
