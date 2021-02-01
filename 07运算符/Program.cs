using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 算术运算符
            /*
Operator Name	Description	Example	
+	Addition	Adds together two values	x + y	
-	Subtraction	Subtracts one value from another	x - y	
*	Multiplication	Multiplies two values	x * y	
/	Division	Divides one value by another	x / y	
%	Modulus	Returns the division remainder	x % y	
++	Increment	Increases the value of a variable by 1	x++	
--	Decrement	Decreases the value of a variable by 1	x--
             */
            int sum1 = 100 + 50;        // 150 (100 + 50)
            int sum2 = sum1 + 250;      // 400 (150 + 250)
            int sum3 = sum2 + sum2;     // 800 (400 + 400)
            #endregion

            #region 赋值运算符
            /*
             赋值运算符用于为变量赋值
            赋值运算符（=）
             */
            int x = 10;
            /*
             所有赋值运算符的列表
Operator	Example	Same As	
=	x = 5	x = 5	
+=	x += 3	x = x + 3	
-=	x -= 3	x = x - 3	
*=	x *= 3	x = x * 3	
/=	x /= 3	x = x / 3	
%=	x %= 3	x = x % 3	
&=	x &= 3	x = x & 3	
|=	x |= 3	x = x | 3	
^=	x ^= 3	x = x ^ 3	
>>=	x >>= 3	x = x >> 3	
<<=	x <<= 3	x = x << 3
             */
            #endregion

            #region 比较运算符
            /*
             
Operator	Name	Example	
==	Equal to	x == y	
!=	Not equal	x != y	
>	Greater than	x > y	
<	Less than	x < y	
>=	Greater than or equal to	x >= y	
<=	Less than or equal to	x <= y
             */
            #endregion

            #region 逻辑运算符
            /*
Operator	Name	Description	                             Example	
&& 	Logical and	Returns true if both statements are true	x < 5 &&  x < 10	
|| 	Logical or	Returns true if one of the statements is true	x < 5 || x < 4	
!	Logical not	Reverse the result, returns false if the result is true	!(x < 5 && x < 10)	

             */
            #endregion
        }
    }
}
