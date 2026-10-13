using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 演示
{
    internal class ChatMessage
    {
        //字段与属性：
        //私有字段 _rawContent（原始内容）。
        private string _rawContent;
        //公开属性 Content：get 返回 _rawContent；set 时赋值给字段。
        public string Content
        {
            get;
            set;
        }
        //字段：private string _sender;（发送者），
        private string _sender;
        //方法：string Censor(string[] bannedWords)
        //接收一个敏感词一维数组。
        //遍历数组，对 _rawContent 中的每个敏感词使用 Replace 替换为 * **
        //返回过滤后的字符串。
        public string Censor(string[] bannedWords)
        {
            foreach (var item in bannedWords)
            {
                if (_rawContent.Contains(item))
                {
                    _rawContent = _rawContent.Replace(item,"***");
                }
            }
            return _rawContent;
        }
        //方法：bool IsTooLong(int maxLength)
        //判断内容长度是否超过限制，使用字符串的 Length 属性。
        public bool IsTooLong(int maxLength)
        {
            Console.WriteLine("请输入发言内容");
            string content=Console.ReadLine();
            if (content.Length>maxLength)
            {
                Console.WriteLine("内容过长，请重新输入");
                return false;
            }
            else
            {
                _rawContent=content;
                return true;
            }
        }
    }
}
