using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 数组作业
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.遍历与输出
            /*int[] num = new int[] { 10, 20, 30, 40, 50 };
            int index = 0;
            foreach (int i in num)
            {
                Console.Write($"{i}  ");
            }
            Console.WriteLine("");
            for (int j = 0; j < num.Length; j+=2)
            {
                Console.Write($"{num[j]}  ");
            }
            Console.WriteLine();
            for (int j = 0; j < num.Length; j += 2)
            {
                Console.Write($"{num[j] * 2}  ");
            }*/

            //2.成绩统计器
            /*Console.WriteLine("总共几名学生：");
            int num=int.Parse( Console.ReadLine() );
            int[] score = new int[num];
            int s;
            int sum=0;
            int index=0;
            int max = score[0];
            int min= score[0];
            for (int i=0;i<num;i++)
            {
                index++;
                Console.WriteLine($"输入第{index}个学生成绩：");
                s = int.Parse(Console.ReadLine());
                score[i] = s;
            }
            for (int j = 0; j < score.Length; j++)
            {
                sum += score[j];
            }
            Console.WriteLine($"这{index}名学生成绩求和为{sum}");
            Console.WriteLine($"这{index}名学生成绩平均值为{sum/index}");
            for(int k=1;k< score.Length;k++)
            {
                if (score[k] > max)
                {
                    max=score[k];
                }
            }
            Console.WriteLine($"最高分为：{max}");
            for (int k = 1; k < score.Length; k++)
            {
                if (score[k] < min)
                {
                    min = score[k];
                }
            }
            Console.WriteLine($"最低分为：{min}");*/

            //3.查重---线性查找
            /*int[] num1 = new int[] {8,4,2,9,2,5,1,7};
            Console.WriteLine("请输入一个数字：");
            int a = int.Parse(Console.ReadLine());
            bool istrue=false;
            for(int i = 0; i < num1.Length; i++)
            {
                if (num1[i] == a)
                {
                    istrue = true;
                    Console.WriteLine($"找到{a}了，位置是{i+1}");
                }
            }
            if (istrue)
            {
                Console.WriteLine("");
            } else { Console.WriteLine("未找到"); }*/

            //4.数组去重
            int[] num1 = new int[8];
            int[] num2 = new int[num1.Length];
            int j = 0;
             int count = 0;
            Console.WriteLine("请输入8个整数（0-10）：");
            for (int i = 0; i < 8; i++)//i是数组下标
            {
                Console.Write($"输入第{i + 1}个数：");
                num1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < num1.Length; i++)
            {
                j = num1[i];
                bool isExist = false;
                for (int k = 0; k < count; k++)
                {
                    if (num2[k] == j)
                    {
                        isExist = true;
                        break;
                    }
                }
                if (!isExist)
                {
                    num2[count] = j;
                    count++;
                }
            }
            Console.WriteLine("去重后的数组：");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{num2[i]}  ");
            }


            /* int[] arr = {1,2,3,4,3,2,1,5,6 };
             int[] arr2 =new int[arr.Length];
             int count = 0;
             for (int i=0;i<arr.Length;i++)
             {
                 int num = 0;
                 int medium = arr[i];
                 for (int j=0;j<count;j++)
                 {
                     if (arr2[j] == medium)
                     {
                         num++;
                         break;
                     }
                 }
                 if (num==0)
                 {
                     arr2[count]= medium;
                     count++;
                 }
             }
             for (int i=0;i<count;i++)
             {
                 Console.Write($"{arr2[i]}  ");
             }*/




            //AI写的
            /*int[] num1 = new int[8]; 
            int[] num2 = new int[8]; 
            bool[] flag = new bool[11]; // 标记 0~10 是否出现过，默认都是 false
            int count = 0 ; // 去重后实际保留的元素个数
            Console.WriteLine( "请输入8个整数（0-10）：" ); 
            for ( int i = 0 ; i < 8 ; i++)
            {
                Console.Write($"请输入第 {i + 1} 个数：");
                num1[i] = int.Parse(Console.ReadLine());
            } 
            // 去重：只保留第一次出现的数字
            for ( int i = 0 ; i < 8 ; i++)
            {
                if (!flag[num1[i]]) // 如果这个数还没出现过。数组默认值是`false`
                {
                    num2[count] = num1[i]; // 存到结果数组
                    count++; // 结果个数 +1
                    flag[num1[i]] = true ; // 标记已出现
                }
            } 
            // 输出去重后的数组
            Console.WriteLine( "去重后的数组：" );
            for ( int i = 0 ; i < count; i++)
            {
                Console.Write(num2[i] + " ");
            }
            Console.WriteLine();*/

            //第二题自己重新写
            /*double[] scores = new double[5];
            double sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write($"请输入第{i+1}个学生的成绩:");
                double score = double.Parse(Console.ReadLine());
                scores[i] = score;
            }
            for(int i=0;i<5;i++)
            {
                sum += scores[i];
            }
            Console.WriteLine("这几个学生成绩之和为：{0}",sum);
            double average = 0;
            for (int i = 0; i < 5; i++)
            {
                average = sum / scores.Length;
            }
            Console.WriteLine("这几个学生成绩的平均值为：{0}", average);
            double max = scores[0];
            double min = scores[0];
            for (int i = 0; i < 5; i++)
            {
                if (scores[i]>max)
                {
                    max = scores[i];
                }
            }
            Console.WriteLine("这几个学生成绩的最大值为：{0}", max);
            for (int i = 0; i < 5; i++)
            {
                if (scores[i] < min)
                {
                    min = scores[i];
                }
            }
            Console.WriteLine("这几个学生成绩的最小值为：{0}", min);*/


            //第三题重写
            /*int[] arr = new int[] { 8, 4,5, 2, 9, 5, 1, 7 };
            bool isfond = false;
            Console.WriteLine("请输入一个数字：");
            int num = int.Parse(Console.ReadLine());
            int i; 
            for(i = 0; i < arr.Length; i++)
            {
                if (arr[i]==num)
                {
                    isfond = true;
                    Console.WriteLine($"找到了，位置在{i + 1}");
                }
            }
            if (isfond)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("未找到！");
            }*/

            /*int[] arr = { 8, 4, 5, 2, 9, 5, 1, 7 };
            Console.Write("请输入一个数字："); 
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("输入无效，请输入整数！"); 
                return;
            }
            bool isFound = false;
            Console.Write("位置（第几个元素）："); 
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    Console.Write((i + 1) + " "); // 输出所有匹配的位置
                    isFound = true ;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("未找到！");
            }
            else
            {
                Console.WriteLine(); // 换行
            }*/

        }
    }
}
