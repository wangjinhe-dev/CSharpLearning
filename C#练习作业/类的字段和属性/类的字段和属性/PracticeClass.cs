using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类的字段和属性
{
    internal class PracticeClass
    {
        /*//普通字段
        public string Name;
        //公开的静态字段
        public static string Age;
        //只读字段
        public readonly int grade;*/


        //属性--带安全机制
        /* private int _age = 24;//私有，外部访问不了
         public int Age
         {
             get { return _age; }//让外部读取
             set 
             {
                 if (value >= 18 && value <= 22)
                 {
                     _age = value;
                 }
                 else { Console.WriteLine("年龄不符"); }
             }//让外部修改
         }//公开的*/


        public string Name;
        //public static int Age;
        /*public readonly int grade=5;
        public string gender;
        private int _age = 20;
        public int Age
        {
            get
            {
                if(gender="女")
                {

                }//有问题，不会写
            }
            set
            {
                if(value>=18&&value<=22)
                {
                    _age = value;
                }
                else { Console.WriteLine("年龄不符！"); }
            }
        }*/

        //类中的方法
        //void确定方法发返回值类型
        public void Test()//无参数无返回值
        {
            Console.WriteLine("这是一个无参数无返回值的方法");
        }
        public int Test1()//无参数有返回值
        {
            //int num = 666;
            //Console.WriteLine(num);
            Console.WriteLine("这是一个无参数有返回值的方法");
            //return num;
            return 666;
        }
        public int Test2(int a)//有参数有返回值
        {
            int age = a;
            Console.WriteLine("这是一个有参数有返回值的方法");
            return age;
        }
        public void Test3(int n,int s,string b)//有返回值有多个参数
        {
            Console.WriteLine("这是一个有多个参数的方法");
            Console.WriteLine($"姓名{b}，年龄{n}，存款{s}");
        }
        public static void Test4()
        {
            Console.WriteLine("这个是静态方法");
        }
        public void Test5(int x)//无返回值有参数
        {
            int x1 = x;
            Console.WriteLine("这是一个无返回值有参数的方法"+x1);
        }
    }
}
