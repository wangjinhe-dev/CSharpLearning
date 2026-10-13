using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字段属性作业
{
    internal class Student
    {
        private string _name;
        private int _age;
        private double _score;

        //属性
        public string Name
        {
            get { return _name; }
            set 
            {
                if (value != null && value!="")
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("姓名无效！");
                } 
            }
        }
       
        public int Age
        {
            get { return _age; }
            set 
            {
                if (value>=18&&value<=25) 
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("年龄无效！");
                }   
            }
        }

        public double Score
        {
            get { return _score; }
            set 
            {
                if (value>=0&&value<=100)
                {
                    _score = value; 
                }
                else
                {
                    Console.WriteLine("成绩无效！");
                }
            }
        }

        //方法
        public void Introduce()
        {
            Console.WriteLine($"大家好，我是{Name}，今年{Age}岁，当前成绩{Score}分。");
        }
        public bool UpdateScore(double delta)
        {
            double score1 = Score + delta;
            
            if (score1 > 100||score1<0)
            {
                return false;
            }
            Score = score1;
            return true;
            
        }
        public bool IsExcellent(double threshold)
        {
            if (Score <= threshold)
            {
                //Console.WriteLine("优秀");
                return true;
            }
            else
            {
                //Console.WriteLine("不优秀");
                return false;
            }
        }
    }
}
