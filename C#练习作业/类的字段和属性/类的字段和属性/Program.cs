using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类的字段和属性
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string stuName;//变量
            /*PracticeClass student = new PracticeClass();//实例化
            student.Name = "张三";

            PracticeClass.Age = "5";

            Console.WriteLine("年级是：" + student.grade);


            Console.WriteLine("年龄" + student.Age);*/


            PracticeClass student=new PracticeClass();
            //student.Name = "小鹤";
            ////PracticeClass.Age = 21;
            //Console.WriteLine("姓名："+student.Name);
            ////Console.WriteLine("年龄："+PracticeClass.Age);
            //Console.WriteLine("年级:"+student.grade);
            //Console.Write("性别为："+ student.gender);
            //student.gender=Console.ReadLine();
            //Console.WriteLine("年龄" + student.Age);

            student.Test();
            Console.WriteLine(student.Test1());
            
            Console.WriteLine($"年龄为：{student.Test2(10)}");
            student.Test3(18, 200, "张三");
            PracticeClass.Test4();
            student.Test5(10);
            //Console.WriteLine("无返回值有参数，参数为："+student.Test5(10));
            
        }
    }
}
