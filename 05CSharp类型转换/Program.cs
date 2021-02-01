using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05CSharp类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 类型转换
            /*
             类型转换是当您将一种数据类型的值分配给另一种类型时。
             在C＃中，有两种类型的转换：
             隐式转换（自动）-将较小的类型转换为较大的类型
               char-> int-> long-> float->double
             显式转换（手动）-将较大的类型转换为较小的类型
               double-> float-> long-> int->char
             */
            //隐式转换
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double
           
            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9
            //显式强制转换
            double d = 9.78;
            int i = (int)d;    // Manual casting: double to int

            Console.WriteLine(d);   // Outputs 9.78
            Console.WriteLine(i); //9
            #endregion

            #region 类型转换方法
            /*
             通过使用内置的方法，
            如显式转换数据类型Convert.ToBoolean，
              Convert.ToDouble，Convert.ToString，
              Convert.ToInt32（int）和Convert.ToInt64（long）
             */
            int i1 = 10;
            double d1 = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(i1));    // convert int to string
            Console.WriteLine(Convert.ToDouble(i1));    // convert int to double
            Console.WriteLine(Convert.ToInt32(d1));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
            #endregion
            Console.ReadKey();
        }
    }
}
