using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 游戏聊天过滤器
{
    internal class ChatMessage
    {
        private string _rawContent;
        public string Content
        {
            get { return _rawContent; }
            set { _rawContent = value; }
        }
        private string _sender;

        public string Censor(string[] bannedWords)
        {
            foreach(string word in bannedWords)
            {
                if (_rawContent.Contains(word))
                {
                    _rawContent = _rawContent.Replace(word, "****");

                }
            }
            return _rawContent;
        }
        public bool IsTooLong(int maxLength)
        {
            Console.WriteLine("请输入你的句子：");
            string juzi=Console.ReadLine();
            if (juzi.Length>maxLength)
            {
                Console.WriteLine("句子过长，请重新输入！");
                return false;
            }
            else
            {
                _rawContent=juzi;
                return true;
            }
        }
    }
}
