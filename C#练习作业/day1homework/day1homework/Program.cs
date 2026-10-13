using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///题目1
            /*int age = 21;
            string name = "王金鹤";
            Console.WriteLine($"我叫{name},今年{age}岁");*/

            ///题目2
            /*int a = 5;
            int b = 10;
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a的值为{0},b的值为{1}",a,b);
            Console.WriteLine($"a的值为{a},b的值为{b}");*/

            ///题目3
            /*int i=default;
            bool b=default;
            string s=default;
            double d=default;
            Console.WriteLine($"{i},{b},{s},{d}");*/

            ///题目4
            /*var pi = 3.14159;
            var message = "Hello,World";
            int intpi=(int)pi;
            Console.WriteLine(pi);
*/
            ///题目5
            

            //practice2.Run2();调用practice2的内容

            Person xiaowang = new Person();
            xiaowang.name = "鹤鹤";
            xiaowang.age = 18;

            Person benz = new Person();
            benz.name = "奔驰GL";
            benz.age = 888;

            xiaowang.PersonInfo();
            benz.PersonInfo();

        }
}
}
