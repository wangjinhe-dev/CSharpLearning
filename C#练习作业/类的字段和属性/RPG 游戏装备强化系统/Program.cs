using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_游戏装备强化系统
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipment equipment = new Equipment();
            equipment.Initsword("烈焰之剑", 50);
            equipment.ShowStats();
            equipment.Enhance(1);
            equipment.ShowStats();
            equipment.Enhance(10);
            //equipment.ShowStats();
            //for(int i = 0; i < 6; i++)
            //{
            //    equipment.Enhance(1);
            //    equipment.ShowStats();
            //}


            //豆包
            /*Console.WriteLine("===== 创建装备：烈焰之剑(初始攻击50) ===== ");

            Equipment sword =new Equipment("烈焰之剑",50);
            sword.ShowStats();
            Console.WriteLine("\n===== 连续强化3次，参数分别是1、3、10 ===== ");
            sword.Enhance(1);
            sword.ShowStats();
            sword.Enhance(3);
            sword.ShowStats();
            sword.Enhance(10);
            sword.ShowStats();

            Console.WriteLine("\n=====故意把耐久设为0=====");

            sword.Durability = 0;// 直接set,自动触发IsBroken = true
            
            sword.ShowStats();
            Console.WriteLine("\n====损坏状态下调用 CalculateDamage(30) ===== ");
            
            int dmg1=sword.CalculateDamage(30);
            
            Console.WriteLine($"造成伤害:{ dmg1}");
            Console.WriteLine("\n=====调用Repair修复 ===== ");
            sword.Repair();
            sword.ShowStats();
            Console.WriteLine("\n===== 修复后再次计算伤害===== ");
            
            int dmg2 =sword.CalculateDamage(30);
            Console.WriteLine($"造成伤害:{ dmg2}");*/
        }
    }
}



