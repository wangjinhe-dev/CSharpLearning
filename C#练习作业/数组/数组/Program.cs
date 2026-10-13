using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//数组类型
            //int[] string[]
            //索引  int[] array={1,2,3,4,5}
            double[] array;
            array=new double[5];
            array[0] = 1.0;
            array[1] = 2.0;
            array[2] = 3.0;
            array[3] = 4.0;
            array[4] = 5.0;//声明/赋值
            double[] nums1 = new double[] {11,25,31,84,65};//声明并赋值
            double index = 0;
            double index1 = 0;
            foreach (double item in array)
            {
                Console.WriteLine($"数组中下标为{index}的数据"+item);
                index++;
            }
            Console.WriteLine(nums1[2]);
            nums1[2] = 99;
            Console.WriteLine(nums1[2]);
            foreach (double item in nums1)
            {
                Console.WriteLine($"数组中下标为{index1}的数据" + item);
                index1++;
            }

            int index2=0;
            string[] other=new string[] {"你好","早上好","中午好","下午好" };
            foreach (string item in other)
            {
                Console.WriteLine($"数组中下标为{index2}的数据" + item);
                index2++;
            }*/

            /*Console.WriteLine("请输入学生人数：");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第一个学生的成绩：");
            int score1=int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个学生的成绩：");
            int score2 = int.Parse(Console.ReadLine());
            int[] infor=new int[num];
            infor[0] = score1;
            infor[1] = score2;
            int index = 0;
            //Console.WriteLine($"第一个学生的成绩：{infor[0]}\t第二个学生的成绩：{infor[1]}");
            foreach(int i in infor)
            {
                index++;
                Console.WriteLine($"第{index}个学生的成绩：{i}\t");
            }*/

            Console.WriteLine("请输入学生人数：");
            int num = int.Parse(Console.ReadLine());
            int[] infor= new int[num];
            for (int i=0;i<num;i++)
            {
                Console.WriteLine($"请输入第{i+1}个学生的成绩：");
                infor[i] = int.Parse(Console.ReadLine());
                while (infor[i] < 0 || infor[i] > 100)
                {
                    Console.WriteLine("输入无效，请重新输入！");
                    Console.WriteLine($"请输入第{i + 1}个学生的成绩：");
                    infor[i] = int.Parse(Console.ReadLine());
                    //因为 while只判断条件是否合法。如果不合法，循环会一直转，没有新的输入条件就不会变，那就死循环了。所以必须在while里面再写一遍输入，让用户有机会输入一个新的值。
                }

                //另外一种写法
                /*Console.WriteLine($"请输入第{i + 1}个学生的成绩：");
                int a = int.Parse(Console.ReadLine());
                while (a < 0 || a > 100)
                {
                    Console.WriteLine("输入无效，请重新输入！");
                    Console.WriteLine($"请输入第{i + 1}个学生的成绩：");
                    a = int.Parse(Console.ReadLine());
                    //因为 while只判断条件是否合法。如果不合法，循环会一直转，没有新的输入条件就不会变，那就死循环了。所以必须在while里面再写一遍输入，让用户有机会输入一个新的值。
                }
                infor[i] = a;*/
            }
            Console.Clear();
            int index = 1;
            foreach (int i in infor)
            {
                Console.WriteLine($"第{index}个学生的成绩为{i}");
                index++;
            }
        }
    }
}
