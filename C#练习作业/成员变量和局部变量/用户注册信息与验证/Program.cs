using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 用户注册信息与验证
{
    internal class Program
    {
        /*题目一：用户注册信息与验证
        设计一个 User 类，用于处理新用户注册时的信息与基础验证。

        要求：
        属性：UserName（用户名），RegisterTime（注册时间，构造时赋值）。
        字段与属性：包含私有字段 _phone，对外公开属性 Phone，
        要求：
        set 时先调用 Replace("-", "") 去除所有横杠，最后存入字段。
        get 时返回处理后的号码。
        方法：bool ValidateEmail(string email)
        使用字符串方法判断 email 是否同时包含 @ 和.，且 @ 在.之前。
        返回验证结果。
        方法：string GetMaskedPhone()
        将手机号中间 4 位替换为****，例如 13812345678 → 138****5678。
        使用 Substring 实现。

        在 Main 中创建对象，
        测试各种带横杠的手机号输入，并输出掩码后的号码和邮箱验证结果。*/
        static void Main(string[] args)
        {
            User user=new User();
            Console.WriteLine("请输入电话号码：");
            user.Phone=Console.ReadLine();
            user.GetMaskedPhone();
            Console.WriteLine("请输入邮箱：");
            bool istrue=user.ValidateEmail(Console.ReadLine());
            Console.WriteLine("邮箱里是否有@和.字符:"+istrue);
        }
    }
}
