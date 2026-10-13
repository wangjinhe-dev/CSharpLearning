using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_对于数组进行去重
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = { 1, 2, 3, 2, 4, 5, 6, 1 }; // 改成有重复的，方便测试
            int[] newArr = new int[numArr.Length];

            int index = 0;//这个下标用于读取新数组的数据

            for (int i = 0;i < numArr.Length;i++)
            {
                int curNum = numArr[i];//获取当前循环的数据（第一遍等于1,第二遍2）
                int num = 0;//用来判断数组中当前数据重复了多少次

                for (int j = 0;j < index;j++)//第一遍外循环这个是不执行的*********
                {
                    if (newArr[j] == curNum)//判断老数组里的数据是否存在于新数组
                    {
                        num++;//用num这个变量来判断老数组里当前数据是否需要添加到新数组
                        break;
                    }                  
                }

                if (num == 0)
                {
                    newArr[index] = curNum;//newArr = {1,2}
                    index++;//跑完第一遍index等于1
                }
            }

            //foreach (int item in newArr)
            //{
            //    Console.WriteLine(item);
            //}

            for (int i = 0;i < index;i++)
            {
                Console.WriteLine($"{newArr[i]}");
            }
        }
    }
}
