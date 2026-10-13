using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipment equipment = new Equipment();
            equipment.ShowStats();
            equipment.Repair();
            equipment.ShowStats();
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"第{i+1}次强化");
                equipment.Enhance(1);
                equipment.ShowStats();
                Console.WriteLine();
            }

        }
    }
}
