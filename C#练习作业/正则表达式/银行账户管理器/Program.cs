using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 银行账户管理器
{
    internal class Program
    {
        //二、Main 方法测试要求
        //请按以下顺序在 Main 中编写测试代码：

        //// 1. 创建两个账户
        //BankAccount acc1 = new BankAccount("10086", "张三");
        //    BankAccount acc2 = new BankAccount("10010", "李四");

        //    // 2. 测试存款
        //    acc1.Deposit(1000);   // 正常存入
        //acc1.Deposit(-100);   // 非法，应给出提示

        //// 3. 测试取款
        //acc1.Withdraw(200);   // 正常取出
        //acc1.Withdraw(2000);  // 余额不足

        //// 4. 测试转账
        //acc1.Transfer(acc2, 300);  // 正常转账
        //acc1.Transfer(acc1, 100);  // 不能转给自己
        //acc1.Transfer(null, 100);  // 目标不能为空

        //// 5. 打印两个账户的最终信息
        //acc1.PrintInfo();
        //acc2.PrintInfo();
        static void Main(string[] args)
        {
            // 1. 创建两个账户
            BankAccount acc1 = new BankAccount ("10086","张三" );
            BankAccount acc2 = new BankAccount ( "168168", "李四"  );
            // 2. 测试存款
            acc1.Deposit(1000);
            acc1.Deposit(-100);
             //3.测试取款
            acc1.Withdraw(200);   // 正常取出
            acc1.Withdraw(2000);  // 余额不足
            // 4. 测试转账
            acc1.Transfer(acc2, 300);  // 正常转账
            acc1.Transfer(acc1, 100);  // 不能转给自己
            acc1.Transfer(null, 100);  // 目标不能为空
            // 5. 打印两个账户的最终信息
            acc1.PrintInfo();
            acc2.PrintInfo();
        }
    }
}
