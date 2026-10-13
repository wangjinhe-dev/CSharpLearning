using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03基础练习
{
    internal class Menu
    {
        public int num;
        public string name;
        public int price;
        public int total;
        //public void Info()
        //{
        //    Console.WriteLine($"商品名{name},价格{price}");
        //}
        public void zongjia()
        {
            total=num* price;
            Console.WriteLine($"您点了{name}，数量{num},总价{total}元");
        }
    }
}
