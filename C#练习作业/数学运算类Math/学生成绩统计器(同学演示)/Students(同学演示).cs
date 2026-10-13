using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生成绩统计器Student2
{
    internal class Students
    {
        public string Name { get; set; }
        public double[] Scores {  get; set; }
        public double GetAverage()
        {
            double sum = 0;
            foreach (var student in Scores)
            {
                sum += student;
            }
            double average = sum / Scores.Length;
            return Math.Round(average, 2);
        }
        public double GetMaxScore()
        {
            double max = Scores[0];
            foreach (var student in Scores)
            {
                max= Math.Max(max, student);
            }
            return max;
        }
        public double GetMinScore()
        {
            double min = Scores[0];
            foreach (var student in Scores)
            {
                min = Math.Min(min, student);
            }
            return min;
        }
        public string GetReport()
        {
            /*string x = "";
            foreach (var student in Scores)
            {
                x = student + x + ",";
            }*/
            return $"姓名{Name}|成绩{string.Join(",",Scores)}\n平均分{GetAverage()}|最高{GetMaxScore()}|最低{GetMinScore()}";
        }
    }
}
