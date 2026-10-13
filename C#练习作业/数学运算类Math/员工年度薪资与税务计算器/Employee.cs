using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 员工年度薪资与税务计算器
{
    internal class Employee
    {
        public string Name;
        public double BaseSalary=8000;
        private double[] _monthlyRations;
        public double[] MonthlyRatios // 12 个月的绩效系数
        {
            set
            {
                _monthlyRations = value;
            }
            get
            {
                return _monthlyRations;
            }
        }

        //税前总收入
        public double GetAnnualGross()
        {
            double totalcash = 0;
            foreach (var item in MonthlyRatios)
            {
                totalcash += BaseSalary * item;
            }
            return totalcash;
        }

        //需要交的税
        public double GetTax()
        {
            double tax;
            if (GetAnnualGross()<=60000)
            {
                tax = 0;
            }
            else
            {
                double partcash =GetAnnualGross()-60000;
                tax = Math.Max(0, partcash) * 0.1;
            }
            return tax;
        }

        //税后年收入
        public double GetAnnualNet()
        {
            return Math.Round( GetAnnualGross()-GetTax(),2);
        }

        //找出绩效系数最高的月份
        public int FindBestMonth()
        {
            double bestmonth = MonthlyRatios[0];
            int index =0;
            for(int i = 0; i < MonthlyRatios.Length; i++)
            {
                //if (MonthlyRatios[i]>bestmonth)
                //{
                //    bestmonth= MonthlyRatios[i];
                //    index= i;
                //}
                bestmonth = Math.Max(bestmonth, MonthlyRatios[i]);

                if (bestmonth == MonthlyRatios[i])
                {
                index = i + 1;
                }
            }
            return index;
        }

        //返回工资条
        public string GetPayslip()
        {
            Console.WriteLine($"=====员工：{Name}=====");
            Console.WriteLine($"年度税前收入：{GetAnnualGross()}");
            Console.WriteLine($"应交个税：{GetTax()}");
            Console.WriteLine($"年度税后收入：{GetAnnualNet()}");
            Console.WriteLine($"最佳绩效月份：{FindBestMonth()}");
            Console.WriteLine("====================");
            return Console.ReadLine();
        }
    }
}
