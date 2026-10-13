using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生成绩统计器111
{
    internal class Student
    {
        public string Name;
        public double[] Scores;


        public double GetAverage()
        {
            double sum = 0;
            foreach (var score in Scores)
            {
                sum += score;
            }
            double ave = sum / Scores.Length;
            return ave;
        }
        public double GetMaxScore()
        {
            double max = Scores[0];
            foreach (var i in Scores)
            {
                max = Math.Max(max, i);
            }
            return max;
        }
        public double GetMinScore()
        {
            double min = Scores[0];
            foreach (var i in Scores)
            {
                if (i < min)
                {
                    min = Math.Min(i, min);
                }
            }
            return min;
        }
        public string GetReport()
        {
            string a = "姓名:" + Name;
            string b = "成绩：" + string.Join(", ", Scores);
            string c = "平均分：" + GetAverage();
            string d = "最高分：" + GetMaxScore();
            string e = "最低分：" + GetMinScore();
            string report = string.Concat(a, b, c, d, e);
            string f = string.Join("| ", a, b, c, d, e);
            return f;
        }
    }
}
