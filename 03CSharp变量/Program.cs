using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CSharp变量
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 变量
            /*
             C＃变量
变量是用于存储数据值的容器。
在C＃中，存在不同类型的变量（使用不同的关键字定义），例如：
int -存储整数（整数），不带小数，例如123或-123
double -存储浮点数，带小数，例如19.99或-19.99
char-存储单个字符，例如'a'或'B'。字符值用单引号引起来
string-存储文本，例如“ Hello World”。字符串值用双引号引起来
bool -存储具有两种状态的值：true或false
            语法
              type variableName = value;
             */
            
            string name = "John";
            Console.WriteLine(name);
            int myNum = 15;
            myNum = 20; // myNum is now 20
            Console.WriteLine(myNum);
            #endregion
            #region 常量
            /*
            如果您不希望其他人（或您自己）覆盖现有值，
            则可以添加关键字（这会将变量声明为“ constant”，这意味着不可更改和只读）

            在const当你想要一个变量总是存储相同值的关键字是非常有用的，
            让别人（或自己）不会弄乱你的代码。PI（3.14159 ...）是一个经常称为常量的示例。
            注意：如果不分配值，则不能声明常量。
            如果这样做，将发生错误：const字段需要提供一个值。
             */
            const int number = 15;
            //number = 20;// error
            #endregion

            double myDoubleNum = 5.99;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";
            #region 声明多个变量
            /*
             声明许多变量
             要声明多个相同类型的变量，请使用逗号分隔的列表：
             */
            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z);
            #endregion

            #region  C＃标识符
            /*
            所有C＃变量必须 使用唯一的名称标识。
            这些唯一的名称称为标识符。
            标识符可以是短名称（如x和y），也可以是更具描述性的名称（年龄，总和，总体积）。
            注意：建议使用描述性名称，以创建可理解和可维护的代码

            构造变量名称（唯一标识符）的一般规则是：
            1.名称可以包含字母，数字和下划线字符（_）
            2.名称必须以字母开头
            3.名称应以小写字母开头，并且不能包含空格
            4.名称区分大小写（“ myVar”和“ myvar”是不同的变量）
            5.保留字（如C＃关键字，例如int或 double）不能用作名称
             */
            #endregion
        }
    }
}
