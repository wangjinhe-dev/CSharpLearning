using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串的方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence1 = "你好，";
            string sentence2 = "今天天气很好。";

            //1.Concat拼接
            string a=string.Concat(sentence1, sentence2);
            Console.WriteLine(a);

            //2.Contains判断字符串是否存在
            bool b=sentence1.Contains($"{sentence2} ");
            Console.WriteLine($"{sentence2}是否在{sentence1}中：{b}");

            //3.EndsWith判断当前字符串结尾是否有目标字符串
            bool c = sentence1.EndsWith(sentence2);
            Console.WriteLine($"{sentence1}末尾是否有{sentence2}:{c}");

            //4.Equals比较两个字符串是否相等
            bool d=sentence1.Equals(sentence2);
            Console.WriteLine($"{sentence1}与{sentence2}是否相等:{d}");

            //5.IndexOf找目标字符串第一次出现的下标索引
            int e=sentence2.IndexOf("好");
            Console.WriteLine($"{sentence2}中第一次出现“好”的下标号为：{e}");

            //6.Insert在指定下标加入指定字符（加在指定下标前面）
            string f = sentence1.Insert(2,"吗");
            Console.WriteLine(f);

            //7.IsNullOrEmpty:判断字符串是否为null或空值"";
            bool g=string.IsNullOrEmpty(sentence1);
            Console.WriteLine($"sentencei is null or empty:{g}");

            //8.Join：使用指定字符将串联起来的数组元素之间进行分割。
            string[] arr1 = { "你", "我", "他", "我们", "他们" };
            Console.WriteLine(string.Join("|",arr1));

            //9.LastIndexOf:返回字符串中指定字符最后一次出现匹配字符的下标索引值，若找不到，则返回-1
            int h=sentence2.LastIndexOf("天");
            Console.WriteLine(h);

            //10.Remove 删除:从指定索引位置（包括该位置）开始删除指定长度的字符串，返回一个全新的字符串
            string i=sentence2.Remove(2,3);
            Console.WriteLine(i);

            //11.Replace 替换:将字符串中指定字符（字符串）替换成新的字符（字符串），并返回一个全新的字符串。
            string j = sentence2.Replace("天气", "阳光");
            Console.WriteLine(j);

            //***12.Split 分割:通过指定字符将字符串分割为多个子字符串然后放到string数组里面。
            string sentence3 = "This is a good day!";
            string[] arr2 = sentence3.Split(' ','!');//单引号？？
            foreach(var s in arr2)//var关键字可以根据右边的值自动推断变量类型
            {
                Console.WriteLine($"示例：{s}");
            }

            //13.StartsWith：判断字符串开头是否包含某个字符串
            bool k=sentence2.StartsWith("今");
            Console.WriteLine(k);

            //14.Substring 截取：从指定索引位置（包含该位置）开始截取指定长度的字符串
            string l=sentence2.Substring(2,4);
            Console.WriteLine(l);

            //15.ToLower :将字符串中所有大写字母转成小写字母
            string m=sentence3.ToLower();
            Console.WriteLine(m);

            //16.ToUpper :将字符串中所有小写字母转成大写字母
            string n = sentence3.ToUpper();
            Console.WriteLine(n);

            //17.Trim: 删除字符串开头和结尾的空格字符。
            string sentence4 = "   You are a good girl!    ";
            string o=sentence4.Trim();
            Console.WriteLine(sentence4);
            Console.WriteLine(o);

            //18.TrimEnd:删除字符串结尾的空格字符。
            string p = sentence4.TrimEnd();
            Console.WriteLine(p);

            //19.TrimStart:删除字符串开头的空格字符
            string q = sentence4.TrimStart();
            Console.WriteLine(q);
        }
    }
}
