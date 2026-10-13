using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生成绩统计器111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            Student[] member = new Student[3]
            {
                new Student{Name="张三",Scores=new double[]{ 10, 20, 30, 40, 50 }},
                new Student{Name="李四",Scores=new double[]{ 10, 20, 30, 40, 50 }},
                new Student{Name="王五",Scores=new double[]{ 10, 20, 30, 40, 50 }}
            };
            foreach(Student student1 in member)
            {
                Console.WriteLine(student1.GetReport());
            }
            //student.Name= "小明";
            //Console.WriteLine(student.Name);
            //student.Scores = new double[5] { 10, 20, 30, 40, 50 };
            //Console.WriteLine("平均分数为：" + student.GetAverage());
            //Console.WriteLine(student.GetReport());
        }
    }
}
