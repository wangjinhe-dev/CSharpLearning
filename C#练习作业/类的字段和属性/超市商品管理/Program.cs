using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市商品管理
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            Console.WriteLine(product.ProductName);

            product.UnitPrice = 5.5M;
            product.Stock = 100;
            product.ShowDetails();

            int a=product.IncreaseStock(50);
            Console.WriteLine("此时入库成功的返回值为："+a);

            product.DecreaseStock(120);

            product.DecreaseStock(50);
            product.DecreaseStock(1);

            product.CalcDiscountPrice(8.5M);

            product.ShowDetails();
        }
    }
}
//创建一个 Product 类，模拟超市商品的库存与价格管理。商品名称一旦创建不可修改，价格和库存可调整但需符合业务规则。

//必须实现的成员
//字段 类型 要求
//ProductName string get; private set;。声明时初始化。
//UnitPrice decimal get; set;，set 时必须 > 0，否则保持不变并控制台提示错误。
//Stock int get; set;，set 时必须 >= 0，否则设为 0。
//ShowDetails() 方法 无参、无返回值。打印商品名称、单价、库存。
//IncreaseStock(int amount) 方法 有参、有返回值(int)。入库 amount 件，返回入库后的总库存。若 amount <= 0 则拒绝操作并返回 -1。
//DecreaseStock(int amount) 方法 有参、有返回值(int)。出库 amount 件。若库存不足，则有多少出多少，返回实际出库的数量。
//CalcDiscountPrice(decimal rate) 方法 有参、有返回值(decimal)。根据 rate（如 0.8 表示八折）计算折后单价并返回，原 UnitPrice 不得被修改。
//Main 方法测试要求
//创建商品 “乌龙茶”，单价 5.5 元，库存 100。
//调用 ShowDetails()。
//入库 50 件，打印返回值；出库 120 件，打印实际出库量与剩余库存。
//再次出库 50 件，验证库存不足时的处理（应只能出 30 件）。
//计算打 8.5 折后的价格并打印，再次调用 ShowDetails() 确认原价未变。