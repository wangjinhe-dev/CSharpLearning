using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字段属性作业
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "张三";
            student.Age = 21;
            student.Score = 80;
            student.Introduce();

            student.Age = 12;

            bool istrue1=student.UpdateScore(-5);
            Console.WriteLine($"返回值为：{istrue1},当前分数为：{student.Score}");

            bool istrue2=student.UpdateScore(30);
            Console.WriteLine($"返回值为：{istrue2},当前分数为：{student.Score}");

            bool isexcellent=student.IsExcellent(90);
            Console.WriteLine($"是否优秀：{isexcellent}");
            //student.IsExcellent(90);
        }
    }
}
