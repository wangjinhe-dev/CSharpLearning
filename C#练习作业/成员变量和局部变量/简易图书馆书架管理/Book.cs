using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简易图书馆书架管理
{
    internal class Book
    {
        private string Title {  get; set; }
        private string Author {  get; set; }
        private string _isbn;
        public string Isbn
        {
            get
            {
                return _isbn;
            }
            set
            {
                bool isAllDigital = true;
                foreach (char s in value)
                {
                    if (Char.IsDigit(s)==false)
                    {
                        isAllDigital = false;
                        break;
                    }
                    if (value.Length==13&&isAllDigital)
                    {
                        _isbn = value;
                    }
                    else
                    {
                        _isbn = "0000000000000";
                    }
                }


            }
        }
    }
}
