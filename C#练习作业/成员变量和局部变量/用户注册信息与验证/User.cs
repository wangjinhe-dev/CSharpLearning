using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 用户注册信息与验证
{
    internal class User
    {
        public string UserName { get; set; }
        public string _registerTime = "10月9日";
        public string RegisterTime
        {
            get { return _registerTime; }
            set { _registerTime = value; }
        }
        private string _phone;
        public string Phone 
        { 
            get 
            { 
                return _phone; 
            } 
            set { 
                bool a=value.Contains("-");
                if (a)
                {
                    _phone = value.Replace("-","");
                    Console.WriteLine($"去除-后的电话号码：{_phone}");
                }else
                    _phone= value;

            } 
        }
        
        public bool ValidateEmail(string email)
        {
            if (email.Contains("@")&& email.Contains("."))
            {
                int a = email.IndexOf("@");
                int b=email.IndexOf(".");
                if (a < b)
                {
                    return true;
                }else
                    return false;
            }else
                return false;
        }
        public string GetMaskedPhone()
        {
            //string c = Phone.Remove(3, 4);
            //string d=c.Insert(3, "****");
            string c=Phone.Substring(3,4);
            string d=Phone.Replace(c,"****");
            Console.WriteLine("加密后的电话："+d);
            return d;
        }
    }
}
