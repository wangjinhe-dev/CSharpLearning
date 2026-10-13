using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_游戏装备强化系统
{
    internal class Equipment
    {
        private int _attackPower;
        private int _level;
        public string Name
        {
            get;
            private set;
        }

        public int Level
        {
            get
            {
                return _level;
            }
            private set
            {
                if (value >= 1 && value <= 20)
                {
                    _level = value;
                }
            }
        }
        public int AttackPower
        {
            get
            {
                //return _attackPower + (Level - 1) * 5;
                return _attackPower;
            }
            private set
            {
                _attackPower = value;
            }
        }
        public bool IsBroken
        {
            get;
            private set;
        }
        private int _durability;
        public int Durability
        {
            get { return _durability; }
            set
            {
                if (_durability >= 0 && _durability <= 100)
                {
                    _durability = value;
                }
                if(Durability<=0)
                {
                    IsBroken = true;
                }else IsBroken = false;
            }
        }


        //方法
        public void Initsword(string name,int initAttack)
        {
            Name = name;
            Durability = 100;
            Level = 1;
            AttackPower = initAttack;
        }
        public void ShowStats()
        {
            Console.WriteLine($"装备名：{Name}");
            Console.WriteLine($"等级:{Level}");
            Console.WriteLine($"攻击力：{AttackPower}");
            Console.WriteLine($"耐久度：{Durability}");
            Console.WriteLine($"是否损坏:{(IsBroken ? "损坏" : "未损坏")}");
            Console.WriteLine();
        }
        public void Repair()
        {
            Durability = 100;
            //IsBroken = false;
            Console.WriteLine("修理完成");
        }
        public bool Enhance(int materialLevel)
        {
            if (IsBroken==true)
            {
                Console.WriteLine("当前装备已损坏，无法强化");
                return false;
            }
            else if (Level==20)
            {
                Console.WriteLine("装备已满级，无法强化");
                return false;
            }
            else
            {
                double rate = 0.5 + materialLevel * 0.05;
                if (rate > 0.95) rate = 0.95;
                double compare = 0;
                if (rate >= compare)
                {
                    Level++;
                    AttackPower += 5;
                    Console.WriteLine($"强化成功，当前等级{Level - 1}-->{Level}，当前攻击力{AttackPower - 5}-->{AttackPower}");
                    return true;
                }
                else 
                {
                    Durability -= 20;
                    Console.WriteLine($"强化失败，当前耐久度{Durability + 20}-->{Durability}，装备是否损坏:{(IsBroken ? "损坏" : "未损坏")}");
                    return false;
                }
            }

        }





        //豆包
        /*public string Name
        {
            get;
            private set;
        }
        public int Level
        {
            get;
            private set;
        }
        public int AttackPower
        {
            get;
            private set;
        }
        private int _durability;
        public int Durability
        {
            //get => _durability;
            get
            {
                return _durability;
            }
            set
            {
                //限制0-100。Math.Min(100, value)，取两者中较小的那个，作用： 封顶 。
                //Math.Max(0, 上一步的结果)，取两者中较大的那个。作用： 保底 0。
                _durability = Math.Max(0, Math.Min(100, value));
                //耐久一变就同步更新损坏状态
                IsBroken = _durability <= 0;
            }
        }
        public bool IsBroken
        {
            get;
            private set;
        }
        public Equipment(string name,int initAttack)
        {
            Name = name;
            AttackPower = initAttack;
            Level = 1;
            Durability = 100;
        }
        public void ShowStats()
        {
            Console.WriteLine($" 装备:{Name},等级:{Level},攻击力:{AttackPower}, 耐久:{ Durability}, 是否损坏:{ IsBroken}");
        }
        public void Repair()
        {
            Durability = 100;
            // Durability的set已经自动把IsBroken改成false，这里不用重复写
            Console.WriteLine("修理完成");
        }
        public bool Enhance(int materialLevel)
        {
            if (IsBroken)
            {
                Console.WriteLine("装备已损坏,无法强化");
                return false;
            }
            if (Level>= 20)
            {
                Console.WriteLine("装备已满级，无法强化");
                return false;
            }
            Level++;
            AttackPower += 5; 
            return true;
        }
        public int CalculateDamage(int strength)
        {
            if (IsBroken)
            {
                Console.WriteLine("武器已损坏");
                return 0;
            }
            return AttackPower + strength * 2;
        }*/
    }
}
