using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生成绩统计器Student2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students[] students = new Students[]
            {
               new Students{Name="张三",Scores=new double[]{55,66,77,88,99} },
               new Students{Name="张三",Scores=new double[]{56,68,79,98,49} }
            };
            foreach(Students student in students)
            {
                Console.WriteLine(student.GetReport());
            }
        }
    }
}
