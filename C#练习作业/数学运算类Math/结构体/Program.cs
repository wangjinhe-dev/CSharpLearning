using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构体
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.name= "小鹤";
            Console.WriteLine(student.name);

            Student student1;
            student1.name = "你好";
            Console.WriteLine(student1.name);
        }
    }
}
