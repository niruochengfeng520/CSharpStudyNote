using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06CSharp用户输入
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 获取用户输入
            //Console.ReadLine()获取用户输入
            Console.WriteLine("请输入你的姓名：");
            string username = Console.ReadLine();
            Console.WriteLine("你的名字是：" + username);
            Console.WriteLine("请输入你的年龄：");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("你的年龄是：" + age);
            Console.ReadKey();
            #endregion
        }
    }
}
