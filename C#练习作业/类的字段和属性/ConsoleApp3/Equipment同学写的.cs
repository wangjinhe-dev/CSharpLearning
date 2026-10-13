using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Equipment
    {
        public string Name { get; private set; } = "烈焰之剑";
        private int _level = 1;
        public int Level
        {
            get { return _level; }
            private set
            {
                if (value >= 1 && value <= 20) _level = value;
            }
        }
        private int _attackPower = 50;
        public int AttackPower
        {
            get
            {
                return _attackPower + (Level - 1) * 5;
            }
            private set { }
        }
        private int _durability = 0;
        public int Durability
        {
            get {return _durability; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _durability = value;
                }
            }
        }
        public bool IsBrosken
        {
            get
            {
                if (Durability <= 0) return true;
                else return false;
            }
            private set { }
        }

        public void ShowStats()
        {
            Console.WriteLine($"装备名称:{Name}");
            Console.WriteLine($"装备等级:{Level}");
            Console.WriteLine($"装备攻击力:{AttackPower}");
            Console.WriteLine($"装备耐久:{Durability}");
            Console.WriteLine($"装备是否损坏:{(IsBrosken ? "损坏" : "未损坏") }");
        }
       public void Repair()
        {
            Durability = 100;
            Console.WriteLine("修理完成");
            
        }
        public bool Enhance(int materialLevel)
        {
            if (IsBrosken == true)
            {
                Console.WriteLine("装备已损坏，无法强化");
                return false;
            }
            else if (Level == 20)
            {
                Console.WriteLine("装备已满级，无法强化");
                return false;
            }
            else
            {
                double SuccessRate = 0.5 + materialLevel * 0.05;
                if (SuccessRate > 0.95) SuccessRate = 0.95;
                double YuZhi = 1;
                if (SuccessRate >= YuZhi)
                {
                    Level++;
                    Console.WriteLine($"强化成功，等级：{Level-1}-->{Level},攻击力：{AttackPower-5}-->{AttackPower}");
                    return true;
                }
                else
                {
                    Durability -= 20;
                    Console.WriteLine($"强化失败，耐久度：{Durability+20}-->{Durability},装备是否损坏:{(IsBrosken ? "损坏" : "未损坏")}");
                    return false;
                }
            }
        }
    }
}
