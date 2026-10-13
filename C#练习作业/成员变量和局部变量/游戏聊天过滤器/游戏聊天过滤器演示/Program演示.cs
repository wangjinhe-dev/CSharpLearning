using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 演示
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //要求：
            //在 Main 中声明一条包含敏感词和多余空格的消息，调用以上方法测试过滤效果、字数统计和长度校验。
            string[] game = new string[3] { "王者荣耀","原神","三角洲行动" };
            ChatMessage chat = new ChatMessage();
            chat.IsTooLong(30);
            Console.WriteLine(chat.Censor(game));
            //数组注意越界：添加元素时记得判断 _count<array.Length。
        }
    }
}
