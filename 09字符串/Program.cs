using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            #region string
            //一个string变量包含双引号括起来的字符的集合
            string greeting = "Hello";
            #endregion

            #region string的长度
            /*
             C＃中的字符串实际上是一个对象，其中包含可以对字符串执行某些操作的属性和方法。
            例如，可以使用以下Length属性找到字符串的长度
             */
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("txt的长度是：" + txt.Length);
            #endregion

            #region 转换为大写或小写字母
            //ToUpper()和ToLower()
            string s = "Hello World";
            Console.WriteLine(s.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(s.ToLower());   // Outputs "hello world"
            #endregion

            #region 字符串拼接
            //方法1：使用 +
            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);//John Doe
            //方法2：string.Concat()方法来拼接两个字符串
            string s1 = "li ";
            string s2 = "tao";
            string s3 = string.Concat(s1,s2);
            Console.WriteLine(s3);//li tao
            #endregion

            #region 字符串插值
            //字符串连接的另一种选择是字符串插值，
            //它可以将变量的值替换为字符串中的占位符。请注意，您不必担心空格
            string firstName1 = "Li";
            string lastName1 = "Tao";
            string name1 = $"我的名字是{firstName1} {lastName1}";
            Console.WriteLine(name1);//我的名字是Li Tao
            #endregion

            #region 通过索引访问字符串
            //索引从0开始
            string myStr = "Hello";
            Console.WriteLine(myStr[0]);  // Outputs "H"
            #endregion

            #region IndexOf()方法 字符串中特定字符的索引位置
            int eIndex = myStr.IndexOf('e');
            Console.WriteLine(eIndex);//1
            #endregion

            #region Substring() 从字符串中提取字符
            string name2 = "John Doe";
            int subIndex = name2.IndexOf('D');
            string name3 = name2.Substring(subIndex,3);//Doe
            Console.WriteLine(name3);
            #endregion

            #region 反斜杠转义字符
            /*
Escape character	Result	Description
\'	'	Single quote
\"	"	Double quote
\\	\	Backslash

Code	Result	
\n	New Line	
\t	Tab	
\b	Backspace	

 */
            string txt1 = "We are the so-called \"Vikings\" from the north.";
            string txt2 = "It\'s alright.";
            string txt3 = "The character \\ is called backslash.";
            #endregion

            #region 加数字和字符串
            //如果将两个数字相加，则结果将是一个数字
            string x = "10";
            string y = "20";
            string z = x + y;  // z will be 1020 (a string)
            #endregion
            Console.ReadKey();

            method2(n1:1,s1:"你好");
        }

        public void method1(string s1 = "1")
        {

        }

        public static void method2(int n1,string s1)
        {

        }
    }
}
