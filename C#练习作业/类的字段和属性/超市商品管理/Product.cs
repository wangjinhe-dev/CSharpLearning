using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市商品管理
{
    internal class Product
    {
        private string _productName="乌龙茶";
        private decimal _unitPrice;
        private int _stock;

        public string ProductName
        {
            get { return _productName; }
            private set 
            {
                _productName=value; 
            }
        }
        public decimal UnitPrice
        {
            get {  return _unitPrice; }
            set 
            {
                if(value > 0)
                {
                    _unitPrice= value;
                }else
                {
                    Console.WriteLine("输入价格无效！");
                }
            }
        }
        public int Stock
        {
            get { return _stock; }
            set 
            {
                if( value >= 0)
                {
                    _stock = value; 
                }
                else
                {
                    _stock = 0;
                }
            }
        }

        //方法
        public void ShowDetails()
        {
            Console.WriteLine($"商品名称:{ProductName}，单价{UnitPrice}元，库存{Stock}");
        }

        public int IncreaseStock(int amount)//入库
        {
            
            if (amount>=0)
            {
                Stock += amount;
                Console.WriteLine($"入库{amount}件，当前总库存为{Stock}");
                return 0;
            }
            //Stock = Stock;
            return -1;
        }

        
        public int DecreaseStock(int amount)//出库
        {
            if(amount>Stock)
            {
                Console.WriteLine($"库存不足！当前库存{Stock}件，全部出库。");
                Stock -= Stock;
                return Stock;
            }
            else
            {
                Stock-= amount;
                Console.WriteLine($"出库{amount}件，当前库存为{Stock}");
                return 0;
            }
        }

        public decimal CalcDiscountPrice(decimal rate)
        {
            decimal ratePrice=UnitPrice*rate*0.1M;
            Console.WriteLine($"打完{rate}折后单价为：{ratePrice}");
            return ratePrice;
        }
    }
}
