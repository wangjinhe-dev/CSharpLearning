using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1homework
{
    internal class Person
    {
        //特征
        public string name;
        public int age;
        //行为
        public void PersonInfo()
        {
            Console.WriteLine($"姓名{name},年龄{age}");
        }
    }
}
