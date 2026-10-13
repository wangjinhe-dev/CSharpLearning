using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace 浅拷贝和深拷贝
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //浅拷贝
            //浅拷贝只能应用于简单的数组类型，比如string，int
            string[] habits = new string[] { "金铲铲之战", "王者荣耀", "英雄联盟" };
            //拷贝过来的都是object对象类型，必须使用强制转换
            string[] habits1 = (string[])habits.Clone();
            habits1[0] = "和平精英";
            Console.WriteLine("原来的数组：" + string.Join(",", habits));
            Console.WriteLine("改过的数组：" + string.Join(",", habits1));

            //int类型
            int[] one = new int[] { 1, 2, 3, 4, 5, };
            int[] two = (int[])one.Clone();
            two[0] = 20000;
            Console.WriteLine(string.Join(",", one));//1
            Console.WriteLine(string.Join(",", two));//20000

            //深拷贝
            Animals[] animals =
            {
                new Animals{Name="小狗"},
                new Animals{Name="皮皮"}
            };
            Animals[] animalstwo=DeepClone(animals);
            animalstwo[0].Name = "小猫";
            Console.WriteLine("改前：" + string.Join(",", animals[0].Name));
            Console.WriteLine("改后：" + string.Join(",", animalstwo[0].Name));
        }
            //深拷贝
            //
            private static Animals[] DeepClone(Animals[] animals)
        {
            Animals[] animalsOne=new Animals[animals.Length];
            for(int i = 0; i < animals.Length; i++)
            {
                animalsOne[i] = new Animals
                {
                    Name = animals[i].Name
                };
            }
            return animalsOne;
        }

    }
}
