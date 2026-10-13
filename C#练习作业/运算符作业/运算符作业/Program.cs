using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 运算符作业
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //练习1：基础算术运算
            /*Console.WriteLine("请输入第一个数：");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输第二个数：");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"和为：{num1 + num2}");
            Console.WriteLine($"差为：{num1 - num2}");
            Console.WriteLine($"积为：{num1 * num2}");
            Console.WriteLine($"商为：{num1 / num2}");
            Console.WriteLine($"余数为：{num1 % num2}");*/
            
            //练习2：奇偶判断
            /*Console.WriteLine("请输入一个数：");
            int num =int.Parse(Console.ReadLine());
            if (num % 2 == 0) {
                Console.WriteLine("这个数是整数");
            }
            else if(num % 2 == 1) 
            {
                Console.WriteLine("这个数不是整数");
            }
            else
            {
                Console.WriteLine("输入无效");
            }*/
            
            //练习3：成绩评定系统
            /*Console.WriteLine("请输入成绩（0-100）：");
            int score = int.Parse(Console.ReadLine());
            if (score>=90&&score<=100)
            {
                Console.WriteLine("成绩等级为：A");
            }else if (score >= 80 && score <= 89)
            {
                Console.WriteLine("成绩等级为：B");
            }
            else if (score >= 70 && score <= 79)
            {
                Console.WriteLine("成绩等级为：C");
            }
            else if (score >= 60 && score <= 69)
            {
                Console.WriteLine("成绩等级为：D");
            }
            else if (score >= 0 && score <= 59)
            {
                Console.WriteLine("成绩等级为：F");
            }else { Console.WriteLine("输入无效！"); }*/
            
            //练习4：闰年判断
            /*Console.WriteLine("请输入一个年份：");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0)|| year % 400 == 0)
            {
                Console.WriteLine("这一年是闰年。");
            }
            else { Console.WriteLine("这一年不是闰年。"); }*/
            
            //练习5：BMI计算器
            /*Console.WriteLine("请输入身高（米）：");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入体重（千克）：");
            int weight = int.Parse(Console.ReadLine());
            double BMI = weight / (height * height);
            //Console.WriteLine("你的BMI值为："+BMI.ToString("F2"));
            Console.WriteLine($"你的BMI值为： { BMI:F2}");
            if (BMI<18.5)
            {
                Console.WriteLine("偏瘦");
            }else if (BMI>=18.5&&BMI <24)
            {
                Console.WriteLine("正常");
            }
            else if (BMI >= 24 && BMI < 28)
            {
                Console.WriteLine("超重");
            }
            else
            {
                Console.WriteLine("肥胖");
            }*/
            
            //基础练习
            /*Console.WriteLine("打印菜单：");
            Console.WriteLine("1. 汉堡 15元 2. 薯条 8元 3. 可乐 6元 4. 鸡翅 12元");
            Console.WriteLine("请输入编号（1-4）:");
            int id = Convert.ToInt32(Console.ReadLine());
            string name = "";
            int price = 0;
            if (id == 1)
            {
                name = "汉堡";
                price = 15;
                Console.WriteLine($"商品名：{name},价格：{price}");
            }
            else if (id == 2)
            {
                name = "薯条";
                price = 8;
                Console.WriteLine($"商品名：{name},价格：{price}");
            }
            else if (id == 3)
            {
                name = "可乐";
                price = 6;
                Console.WriteLine($"商品名：{name},价格：{price}");
            }
            else if (id == 4)
            {
                name = "鸡翅";
                price = 12;
                Console.WriteLine($"商品名：{name},价格：{price}");
            }
            else
            {
                Console.WriteLine("无效输入！");
            }
            if (id >= 1 && id <= 4)
            {
                Console.WriteLine("请输入购买数量：");
                int num = Convert.ToInt32(Console.ReadLine());
                int total = num * price; // 这里 price 一定已经被赋值
                Console.WriteLine($"您点了{name},数量{num},总价{total}元");
            }*/


        }
    }
}
