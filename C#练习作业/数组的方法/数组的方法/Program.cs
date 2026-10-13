using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组的方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //一维数组
            int[] nums = { 1, 2, 3, 4, 5 };

            //二维数组
            int[,] nums2 =
            {
                {1,2,3,4,6,7 }  ,
                {1,2,3,4,5,6, }
            };
            //三维数组
            int[,,] nums3 =
            {
                {
                {1,2,3,4,6,7 }  ,
                {1,2,3,4,5,6, },
                {1,2,3,4,5,6 }
                }
            };
            string[] nums4 = new string[] { "小猫", "皮皮", "小狗", "胖虎" };
            string[] nums5 = new string[nums4.Length];
            int index = 0;
            int index1 = nums4.Length;//第一种

            //第一种写法（自己写的）
            /*for (int i = 0; i < nums4.Length; i++)
            {
                index1--;
                nums5[index] = nums4[index1];
                index++;
            }
            foreach (string m in nums5)
            {
                Console.WriteLine(m);
            }*/

            //第二种
            /*for (int i = 0; i < nums4.Length; i++)
            {
                nums5[nums5.Length-i-1] = nums4[i];
            }*/

            //第三种
            for (int i = nums4.Length-1;i>=0;i--)
            {
                nums5[index++] = nums4[i];
            }
            Console.WriteLine(string.Join(",", nums5));
        }
        public static bool Test(int value)
        {
            if (value>100)
            {
                return true;
            }else
                return false;
        }
    }
}
