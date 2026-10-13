using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 深拷贝练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee[] employees =
            //{
            //    new Employee{Name="小明",time=new DateTime(2000,1,1)},
            //    new Employee{Name="小华",time=new DateTime(2026,10,1)},
            //    new Employee{Name="小美",time=new DateTime(2021,10,10)}
            //};
            Employee[] employees = new Employee[3];
            employees[0] = new Employee { Name = "小明", time = new DateTime(2000, 1, 1) };
            employees[1] = new Employee { Name = "小华", time = new DateTime(2026, 10, 1) };
            employees[2] = new Employee { Name = "小美", time = new DateTime(2021, 10, 10) };
            Employee[] employees2 = DeepClone(employees);
            employees2[1].time = DateTime.Now;
            string before = ""; 
            foreach (var a in employees)
            {
                before += a.Name + " "+a.time+"   ";
            }
            Console.WriteLine("改前：" + before); 
            string after = ""; 
            foreach (var a in employees2)
            {
                after += a.Name + " "+a.time + "   ";
            }
            Console.WriteLine("改后：" + after);
            Console.WriteLine($"改前员工入职时间： {employees[1].Name},{ employees[1].time}");
            Console.WriteLine($"改后员工入职时间：{employees2[1].Name},{ employees2[1].time}" );
        }
        public static Employee[] DeepClone(Employee[] employees)
        {
            Employee[] employees1 = new Employee[employees.Length];
            for (int i = 0; i < employees.Length; i++)
            {
                employees1[i] = new Employee
                {
                    Name = employees[i].Name,
                    time = employees[i].time,
                };
            }
            return employees1;
        }
    }
}
