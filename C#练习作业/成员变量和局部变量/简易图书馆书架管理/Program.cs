using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简易图书馆书架管理
{
    internal class Program
    {
        /*题目二：简易图书馆书架管理
    设计一个 Book 类和一个 Bookshelf 类，管理书架上的藏书。

    要求：
    Book 类：
    属性：Title（书名），Author（作者）。
    字段：private string _isbn;
            属性 Isbn：get 返回 _isbn；set 时判断长度必须为 13 位纯数字，
    否则赋值为 "0000000000000"
    Bookshelf 类：
    字段：private Book[] _books;（固定容量，例如 10 本），private int _count = 0;（当前实际数量）。

    方法：void AddBook(Book book)，往数组中添加书籍，若已满则输出提示。
    方法：Book[] FindBooksByTitle(string keyword)
    遍历数组，使用字符串的 Contains 方法查找书名包含关键词的所有书籍。
    将结果存入一个新的一维数组并返回

    在 Main 中往书架添加 3~4 本书，测试按关键词查找功能，并打印查找结果。*/
        static void Main(string[] args)
        {
        }
    }
}
