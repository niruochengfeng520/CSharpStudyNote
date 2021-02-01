using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04数据类型
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 常见的数据类型
            /*
             数据类型指定变量值的大小和类型。
             为相应的变量使用正确的数据类型很重要；为了避免错误，节省时间和内存，
            但这也将使您的代码更具可维护性和可读性。最常见的数据类型是：
Data Type	Size	Description
int	4 bytes	Stores whole numbers from -2,147,483,648 to 2,147,483,647
long	8 bytes	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
float	4 bytes	Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
double	8 bytes	Stores fractional numbers. Sufficient for storing 15 decimal digits
bool	1 bit	Stores true or false values
char	2 bytes	Stores a single character/letter, surrounded by single quotes
string	2 bytes per character	Stores a sequence of characters, surrounded by double quotes
             */
            #endregion

            #region int类型
            /*
             int数据类型可以从-2147483648到2147483647存储整数
             */
            int myNum = 100000;
            Console.WriteLine(myNum);
            #endregion

            #region long类型
            /*
             long数据类型可以
            从-9223372036854775808存储整数到9223372036854775807时，
            这是用来int不够大，无法存储的值。请注意，您应使用“ L”结尾该值
             */
            long l = 15000000000L;
            Console.WriteLine(l);
            #endregion

            #region float类型
            /*
             float数据类型可以从3.4E-038到3.4E + 038存储小数。
             请注意，您应该以“ F”结尾该值
             */
            float f = 5.75F;
            Console.WriteLine(f);
            #endregion

            #region double类型
            /*
            double数据类型可以从1.7E-308到1.7E + 308存储小数。
            请注意，您可以使用“ D”结尾该值（尽管不是必需的）
             */
            double d = 19.99;
            Console.WriteLine(d);
            #endregion

            #region 使用float还是double？
            /*
             浮点值的精度表示该值在小数点后可以有几位数。
              float的精度只有六到七个十进制数字，
              double的精度约为十五个数字。
              因此，double对于大多数计算而言，使用起来更安全。
             */
            #endregion

            #region 科学数字
            /*
            浮点数也可以是带有“ e”的科学数字，以表示10的幂：
             */
            float f1 = 35e3F;//35000
            double d1 = 12E4D;//120000
            Console.WriteLine(f1);
            Console.WriteLine(d1);
            #endregion

            #region bool类型
            /*
             布尔数据类型使用bool关键字声明，并且只能采用true或false
             默认false
             */
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs Fals
            #endregion

            #region char类型
            /*
             char数据类型被用来存储一个 单个字符。
             字符必须用单引号引起来，例如“ A”或“ c”
             */
            char myGrade = 'B';
            Console.WriteLine(myGrade);
            #endregion

            #region string类型
            /*
             string数据类型被用来存储字符（文本）的序列。
             字符串值必须用双引号引起来
             */
            string greeting = "Hello World";
            Console.WriteLine(greeting);
            #endregion
            Console.ReadKey();
        }
    }
}
