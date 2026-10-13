using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace 第一次周测上机题
{
    internal class SchoolManager
    {
        public string[] _courseTable;
        public string[] CourseTable
        {
            get { return _courseTable; }
            set { _courseTable = value; }
        }
        public double[] _scores1;
        public double[] Scores1
        {
            get { return _scores1; }
            set {_scores1= value; }
        }
        public double[] _scores2;
        public double[] Scores2
        {
            get { return _scores2; }
            set { _scores2 = value; }
        }
        public double[] _scores3;
        public double[] Scores3
        {
            get { return _scores3; }
            set { _scores3 = value; }
        }
        public DateTime[] _examDates;
        public DateTime[] ExamDates
        {
            get { return _examDates; }
            set { _examDates = value; }
        }
        private DateTime today =new DateTime( 2024 , 01 , 18);

        //打印周一到周五的课程安排
        public void PrintCourseTable()
        {
            Console.WriteLine("=====课程表courseTable=====");
            for(int i=0; i<_courseTable.Length; i++)
            {
                string week=default;
                switch (i)
                {
                    case 0:
                        week = "周一";
                        break;
                    case 1:
                        week = "周二";
                        break;
                    case 2:
                        week = "周三";
                        break;
                    case 3:
                        week = "周四";
                        break;
                    case 4:
                        week = "周五";
                        break;
                }
                Console.WriteLine($"{week}:{_courseTable[i]}");
            }
            //foreach (var course in _courseTable)
            //{
            //    Console.WriteLine(""+course+",");
            //}
        }
        //打印每班成绩，并计算该班平均分（保留两位小数）
        public void PrintClassScores()
        {
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double ave1 = 0;
            double ave2 = 0;
            double ave3 = 0;
            Console.WriteLine("=====各班成绩=====");
            foreach(double one in _scores1)
            {
                sum1 += one;
                ave1 = sum1 / _scores1.Length;
            }
            Console.WriteLine($"1班（{_scores1.Length}人）：{string.Join(",",_scores1)}    平均分：{ave1:f2}");

            foreach (double two in _scores2)
            {
                sum2 += two;
                ave2 = sum2 / _scores2.Length;
            }
            Console.WriteLine($"2班（{_scores2.Length}人）：{string.Join(",", _scores2)}    平均分：{ave2:f2}");

            foreach (double three in _scores3)
            {
                sum3 += three;
                ave3 = sum3 / _scores3.Length;
            }
            Console.WriteLine($"3班（{_scores3.Length}人）：{string.Join(",", _scores3)}    平均分：{ave3:f2}");


        }

        //遍历 examDates，与字段 today（2024-01-18）比较：
        //<br>• 若考试日期<today → 输出 考试X(YYYY-MM-DD): 已结束<br>•
        //若 == today → 输出 考试X(YYYY-MM-DD): 今天考试！<br>•
        //若 > today → 输出 考试X(YYYY-MM-DD): 距离考试还有 X 天<br>
        //（提示：用(examDate - today).Days 得到天数差）
        public void ShowExamStatus()
        {
            Console.WriteLine("======考试日程表=====");
            for(int i=0;i<_examDates.Length;i++)
            {
                if (_examDates[i]<today)
                {
                    Console.WriteLine($"考试{i+1}({_examDates[i].ToString("yyyy年MM月dd日")})：已结束！");
                }
                else if(_examDates[i] == today)
                {
                    
                    Console.WriteLine($"考试{i + 1}({_examDates[i].ToString("yyyy年MM月dd日")})：今天考试！");
                }
                //else if(_examDates[i] > today)
                else
                {
                    TimeSpan span = _examDates[i] - today;
                    Console.WriteLine($"考试{i + 1}({_examDates[i].ToString("yyyy年MM月dd日")})：距离考试还有 {span.Days}天");
                }
            }
        }

        //在三个班的所有学生中，找到最高分。
        //输出格式：全校最高分: XX.XX，位于 X 班（只要求输出第一个找到的班级即可）。
        public void FindHighestScore()
        {
            Console.WriteLine("=====查找三个班最高分=====");
            string room=default;
            double[] scores4 = Scores1.Concat(Scores2).Concat(Scores3).ToArray();
            double max=scores4[0];
            int maxId = 0;
            Console.WriteLine(string.Join(" ", scores4));
            for(int j=0;j<scores4.Length;j++)
            {
                if (scores4[j] > max)
                {
                    max = scores4[j];
                    maxId = j;
                }
            }
            
                if (maxId<_scores1.Length)
                {
                    room = "一班";
                }
                else if (maxId >= _scores1.Length&&maxId<_scores1.Length+_scores2.Length)
                {
                    room = "二班";
                }
                else 
                {
                    room = "三班";
                }
            Console.WriteLine($"全校最高分：{max:f2},位于{room}");
        }

        //提示用户输入一个及格线（如 60），使用 Console.ReadLine() 读取并用 double.Parse() 转换。
        //然后遍历三个成绩数组，统计并输出总共有多少名学生及格。
        public void InputPassLineAndCount()
        {
            Console.WriteLine("=====统计及格学生=====");
            Console.WriteLine("请输入你的及格成绩：");
            double num = double.Parse(Console.ReadLine());
            int index1 = 0;
            int index2 = 0;
            int index3 = 0;
            for(int i=0;i<_scores1.Length; i++)
            {
                if (_scores1[i] >=num)
                {
                    index1++;
                }
            }
            for (int i = 0; i < _scores2.Length; i++)
            {
                if (_scores2[i] >= num)
                {
                    index2++;
                }
            }
            for (int i = 0; i < _scores3.Length; i++)
            {
                if (_scores3[i] >= num)
                {
                    index3++;
                }
            }
            int index = index1 + index2 + index3;
            Console.WriteLine($"这三个班一共有{index}名同学及格。");
        }
    }
}
