using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08CSharp数学
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 最大值
            //Math.Max(x,y)
            int maxNumber = Math.Max(5, 7);
            Console.WriteLine(maxNumber);//7
            #endregion

            #region 最小值
            //Math.Min(x,y)
            int minNumber = Math.Min(1, 9);
            Console.WriteLine(minNumber);//1
            #endregion

            #region 平方根
            //Math.Sqrt(x)
            double sqrtNumber = Math.Sqrt(64.0);
            Console.WriteLine(sqrtNumber);// 8
            #endregion

            #region 绝对值
            //Math.Abs(x)
            int absNumber = Math.Abs(-1);
            Console.WriteLine(absNumber);// 1
            #endregion

            #region 四舍五入
            double d1 = Math.Round(3.4);
            double d2 = Math.Round(3.9);
            Console.WriteLine(d1);//3
            Console.WriteLine(d2);//4
            #endregion
            Console.ReadKey();
        }
    }
}
