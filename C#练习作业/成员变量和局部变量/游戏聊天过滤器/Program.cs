using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 游戏聊天过滤器
{
    internal class Program
    {
        //题目三：游戏聊天过滤器
        //设计一个 ChatMessage 类，用于处理游戏内玩家发言的过滤与统计。

        //要求：

        //字段与属性：
        //私有字段 _rawContent（原始内容）。
        //公开属性 Content：get 返回 _rawContent；set 时赋值给字段。
        //字段：private string _sender;（发送者），
        //方法：string Censor(string[] bannedWords)
        //接收一个敏感词一维数组。
        //遍历数组，对 _rawContent 中的每个敏感词使用 Replace 替换为 * **
        //返回过滤后的字符串。
        //方法：bool IsTooLong(int maxLength)
        //判断内容长度是否超过限制，使用字符串的 Length 属性。

        //在 Main 中声明一条包含敏感词和多余空格的消息，调用以上方法测试过滤效果、字数统计和长度校验。


        //数组注意越界：添加元素时记得判断 _count<array.Length。
        static void Main(string[] args)
        {
            ChatMessage chat = new ChatMessage();
            string[] words = new string[3] {"喜欢","可爱","你" };
            chat.IsTooLong(6);
            Console.WriteLine(chat.Censor(words));
        }
    }
}
