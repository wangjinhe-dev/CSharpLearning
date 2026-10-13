using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一次周测上机题
{
    internal class Program
    {
        //        题目背景
        //学校教务处需要你开发一个控制台小工具，管理一周课程表、三个班级的学生成绩（各班人数不同）以及即将到来的考试安排。
        //本题要求仅使用一维数组，不涉及二维数组与交错数组。

        //要求
        //1. 创建类 SchoolManager
        //在类中定义以下字段：

        //字段 类型 说明
        //courseTable string[] 存储周一到周五、每天第 1 节课的课程名称（共 5 个元素）
        //scores1 double[] 1 班学生成绩
        //scores2 double[] 2 班学生成绩
        //scores3 double[] 3 班学生成绩
        //examDates DateTime[] 存储 3 场考试的日期
        //today DateTime 固定为 2024 - 01 - 18（避免每次运行结果不同）
        //2. 初始化数据赋值：

        //课程表 courseTable：

        //周一：数学
        //周二：语文
        //周三：英语
        //周四：物理
        //周五：化学
        //成绩：

        //1 班（3 人）：85.5, 90.0, 78.0
        //2 班（5 人）：88.0, 92.5, 80.0, 76.5, 85.0
        //3 班（2 人）：90.0, 95.5
        //考试日期 examDates： 2024-01-15, 2024-01-20, 2024-01-25

        //3. 实现以下方法
        //方法 功能要求
        //void PrintCourseTable() 遍历一维数组，打印周一到周五的课程安排。
        //void PrintClassScores() 分别遍历 scores1、scores2、scores3 三个数组，打印每班成绩，并计算该班平均分（保留两位小数）。
        //void ShowExamStatus() 遍历 examDates，与字段 today（2024-01-18）比较：<br>• 若考试日期<today → 输出 考试X(YYYY-MM-DD): 已结束<br>• 若 == today → 输出 考试X(YYYY-MM-DD): 今天考试！<br>• 若 > today → 输出 考试X(YYYY-MM-DD): 距离考试还有 X 天<br>（提示：用(examDate - today).Days 得到天数差）
        //void FindHighestScore() 在三个班的所有学生中，找到最高分。输出格式：全校最高分: XX.XX，位于 X 班（只要求输出第一个找到的班级即可）。
        //void InputPassLineAndCount() 提示用户输入一个及格线（如 60），使用 Console.ReadLine() 读取并用 double.Parse() 转换。然后遍历三个成绩数组，统计并输出总共有多少名学生及格。
        //4. Main 方法
        //在 Main 中：

        //创建 SchoolManager 对象。
        //依次调用上述 5 个方法，查看运行结果。
        static void Main(string[] args)
        {
            SchoolManager schoolsthings=new SchoolManager();
            schoolsthings.CourseTable = new string[5] {"数学","语文","英语","物理" ,"化学"};
            schoolsthings.PrintCourseTable();

            schoolsthings.Scores1 = new double[] { 85.5, 90.0, 78.0 };
            schoolsthings.Scores2 = new double[] { 88.0, 92.5, 80.0, 76.5, 85.0 };
            schoolsthings.Scores3 = new double[] { 90.0, 95.5 };
            schoolsthings.PrintClassScores();

            schoolsthings.ExamDates = new DateTime[3] 
            {
                new DateTime(2024,1,15),
                new DateTime(2024,1,20),
                new DateTime(2024,1,25)
            };
            schoolsthings.ShowExamStatus();

            schoolsthings.FindHighestScore();

            schoolsthings.InputPassLineAndCount();
        }
    }
}
