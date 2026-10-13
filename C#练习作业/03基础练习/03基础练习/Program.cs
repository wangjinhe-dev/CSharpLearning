using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03基础练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu hamburg= new Menu();
            {
                hamburg.name = "汉堡";
                hamburg.price = 15;
            }
            Menu chips = new Menu();
            {
                chips.name = "薯条";
                chips.price = 8;
            }
            Menu cola  = new Menu();
            {
                cola.name = "可乐";
                cola.price = 6;
            }
            Menu chicken  = new Menu();
            {
                chicken.name = "炸鸡";
                chicken.price = 12;
            }
            Console.WriteLine("打印菜单：");
            Console.WriteLine("1.汉堡 15元 2.薯条 8元 3.可乐 6元 4.鸡翅 12元");
            Console.Write("请输入编号(1-4)：");
            int id=int.Parse(Console.ReadLine());
            Menu item = new Menu();
            if (id == 1)
            {
                Console.WriteLine($"商品名{hamburg.name},价格{hamburg.price}元");
                item.name = "汉堡";item .price = 15;
                Console.WriteLine("请输入购买数量：");
                item.num = int.Parse(Console.ReadLine());
                item.zongjia();
            }
            else if (id == 2)
            {
                Console.WriteLine($"商品名{chips.name},价格{chips.price}元");
                item.name = "薯条"; item.price = 8;
                Console.WriteLine("请输入购买数量：");
                item.num = int.Parse(Console.ReadLine());
                item.zongjia();
            } else if (id == 3)
            {
                Console.WriteLine($"商品名{cola.name},价格{cola.price}元");
                item.name = "可乐"; item.price = 6;
                Console.WriteLine("请输入购买数量：");
                item.num=int.Parse(Console.ReadLine());
                item.zongjia();
            } else if (id == 4)
            {
                Console.WriteLine($"商品名{chicken.name},价格{chicken.price}元");
                item.name = "炸鸡"; item.price = 12;
                Console.WriteLine("请输入购买数量：");
                item.num = int.Parse(Console.ReadLine());
                item.zongjia();
            } else { Console.WriteLine("无效输入"); }
            //int num = int.Parse(Console.ReadLine());
        }
    }
}
