using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 正则表达式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入手机号：");
            string PhoneNumber=Console.ReadLine();
            if (!string.IsNullOrEmpty(PhoneNumber.Trim()))
            {
                //实例化写法
                string regular = "^(13[0-9]|14[5|7]|15[0|1|2|3|5|6|7|8|9]|18[0|1|2|3|5|6|7|8|9])\\d{8}$";
                Regex regex = new Regex(regular);
                if (regex.IsMatch(PhoneNumber))
                {
                    Console.WriteLine("手机号符合规则");
                }
                else
                {
                    Console.WriteLine("手机号不符合规则");
                }
            }
            Console.WriteLine("请输入身份证号：");
            string IdNumber = Console.ReadLine();
            if (!string.IsNullOrEmpty(IdNumber.Trim()))
            {
                //无实例化写法
                string regular1 = "^(\\d{15}$|^\\d{18}$|^\\d{17}(\\d|X|x))$";
                if (Regex.IsMatch(IdNumber, regular1))
                {
                    Console.WriteLine("身份证号符合规则");
                }
                else
                {
                    Console.WriteLine("身份证号不符合规则");
                }
            }
        }
    }
}
