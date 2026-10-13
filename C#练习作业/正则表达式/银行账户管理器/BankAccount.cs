using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 银行账户管理器
{
    internal class BankAccount
    {
    //练习题：银行账户管理器 BankAccount
    //一、需求描述
    //请你设计一个 BankAccount（银行账户）类，实现基础的存、取、转账功能。

    //1. 私有字段
        private readonly string _accountNumber="10086";
        //    账号，开户后不允许修改。
        private double _balance=0;
        //    余额，初始为 0，外部不能直接修改。
        //2. 属性
        private string _accountHolderName; // 新增：存户名
        public string AccountHolderName 
        {
            get { return _accountHolderName; }
            set { _accountHolderName = value; }
        }
        //    户名，可读写。
        public string AccountNumber 
        { 
            get { return _accountNumber; }
        }
        //    账号，只读属性（从字段 _accountNumber 返回）。
        public double Balance { get { return _balance; } }
        //    余额，只读属性（从字段 _balance 返回）。

        //初始化账号和户名，余额设为 0。
        //3. 方法

        public BankAccount(string accountNumber, string accountHolderName)
        {
            _accountNumber = accountNumber; // readonly 只能在构造函数里赋值
            _accountHolderName = accountHolderName;
        }
        //存款。如果 amount <= 0，输出 "存款金额必须大于0" 并直接返回；否则增加余额，并输出 "存入 XXX 元，当前余额：XXX"。

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("存款金额必须大于0");
            }
            else
            {
                _balance += amount;
                Console.WriteLine($"存入 {amount} 元，当前余额：{_balance}");
            }
        }

        //取款。如果 amount <= 0，输出错误并返回 false；如果 amount > _balance，输出 "余额不足" 并返回 false；否则扣款并输出成功信息，返回 true。
        public bool Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("错误！");
                return false;
            }else if(amount > _balance)
            {
                Console.WriteLine("余额不足");
                return false;
            }
            else
            {
                _balance-= amount;
                Console.WriteLine($"扣款成功，当前余额{_balance}");
                return true;
            }
        }
        //转账。如果 target 为 null，输出 "目标账户不能为空"；如果 target 和自己是同一个账号，输出 "不能给自己转账"；否则先调用自己的 Withdraw，成功后再调用 target.Deposit(amount)。
        public bool Transfer(BankAccount target, double amount)
        {
            if (target==null)
            {
                Console.WriteLine("目标账户不能为空");
                return false;
            }else if (target.AccountNumber==_accountNumber)
            {
                Console.WriteLine("不能给自己转账");
                return false;
            }
            else
            {
                Console.Write("进入转账：");
                if (this.Withdraw(amount))
                {
                    Console.Write("目标账户资金变动情况：");
                    target.Deposit(amount);
                    return true;
                }
                return false;
            }
        }

        //void PrintInfo() 打印信息。格式：`[账号：10086
        public void PrintInfo()
        {
            Console.WriteLine($"[账号:{_accountNumber}");
        }

        

        //三、预期输出参考
        //存入 1000 元，当前余额：1000
        //存款金额必须大于0
        //取出 200 元，当前余额：800
        //余额不足
        //取出 300 元，当前余额：500
        //存入 300 元，当前余额：300
        //转账成功！张三 向 李四 转账 300 元
        //不能给自己转账
        //目标账户不能为空
        //[账号：10086 | 户名：张三 | 余额：500]
        //[账号：10010 | 户名：李四 | 余额：300]

    }
}
