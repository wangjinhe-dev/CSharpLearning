using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1homework
{
    internal class practice2
    {
        public static void  Run2()
        {
            //类型转换
            int num1=20;
            double num2=num1;
            Console.WriteLine(num2);

            double num3 = 3.1415;
            int a = (int)num3;
            Console.WriteLine(a);

            int num4 = 222;
            string b = num4.ToString();
            Console.WriteLine(b);

            string age = "188";
            int age1 =Convert.ToInt32(age);
            int age2=int.Parse(age);
            Console.WriteLine(age1+age2);
        }
    }
}
