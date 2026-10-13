using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 员工年度薪资与税务计算器
{
    internal class Program
    {
        //需求描述：
        //定义一个类 Employee，包含：

        //自动属性 string Name（员工姓名）
        //自动属性 double BaseSalary（每月基本工资，例如 8000）
        //数组属性 double[] MonthlyRatios（长度为 12 的数组，代表 12 个月的绩效系数，例如 1.0, 1.1, 0.9 等。
        //当月实际工资 = BaseSalary* MonthlyRatios[i]）

        //在类中实现以下方法：

        //double GetAnnualGross()：遍历 MonthlyRatios 数组，计算 12 个月税前总收入。

        //double GetTax()：假设个税规则为：年收入中超过 60000 的部分才需要缴税，税率为 10%。
        //要求使用 Math.Max(0, 年收入 - 60000) * 0.1 计算税款（如果年收入不到 60000，则税款为 0）。
        //double GetAnnualNet()：
        //计算税后年收入，即 GetAnnualGross() - GetTax()。结果使用 Math.Round(值, 2) 保留两位小数。
        //int FindBestMonth()：遍历数组，找出绩效系数最高的月份（返回 1~12），
        //遍历时配合 Math.Max() 来记录当前最大系数。
        //string GetPayslip()：使用字符串插值 $"..." 返回工资条，格式如下：

        //========== 员工：张三 ==========
        //年度税前收入：103200.00 元
        //应缴个税：4320.00 元
        //年度税后收入：98880.00 元
        //最佳绩效月份：第 2 个月
        //===============================

        //在 Main 方法中：
        //创建一个 Employee[] 数组，存放 3 名员工的数据（你可以直接给数组赋固定的系数）。
        //用 foreach 遍历该数组，调用 GetPayslip() 打印每名员工的工资条。

        //额外写一个静态方法 static string GetCompanyTopEarner(Employee[] staff)：
        //遍历数组，比较所有员工的 税后年收入，找出税后收入最高的人，
        //返回字符串 "公司年度税后收入最高的是：XXX"。比较时要求使用 Math.Max()。

        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.Name = "Test1";
            //employee.MonthlyRatios = new double[12] {1.1,1.3,1.5,0.8,2.1,1.5,2.3,0.7,1.1,1.5,1.4,1.0 };
            //employee.GetPayslip();
            Employee[] employees = new Employee[]
            {
                new Employee{Name="张三",MonthlyRatios=new double[]{ 1.1, 1.3, 1.5, 0.8, 2.1, 1.5, 2.3, 0.7, 1.1, 1.5, 1.4, 1.0 } },
                new Employee{Name="李四",MonthlyRatios=new double[]{ 0.7, 1.3, 1.5, 1.8, 1.1, 1.5, 1.5, 0.7, 1.4, 1.5, 1.3, 1.0 } },
                new Employee{Name="王五",MonthlyRatios=new double[]{ 0.9, 2.3, 2.5, 0.8, 2.1, 1.1, 2.3, 1.7, 1.6, 2.5, 1.4, 1.0 } }
            };
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.GetPayslip());
            }
        }
    }
}
