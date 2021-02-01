//using System表示我们可以使用System名称空间中的类。
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace用于组织代码，它是类和其他名称空间的容器。
namespace _02CSharp语法
{
    //class是数据和方法的容器，它为程序带来功能。
    //在C＃中运行的每一行代码都必须在一个类中。在我们的示例中，我们将类命名为Program
    class Program
    {
        static void Main(string[] args)
        {
            //Console是System名称空间的类，
            //它具有WriteLine()用于输出/打印文本的方法。
            //在我们的示例中，它将输出“ Hello World！”。
            // 备注
            /*
             * 如果省略该using System行，则必须写出 System.Console.WriteLine()打印/输出文本。
             * 
             * 
            注意：每个C＃语句均以分号结尾;。
            注意： C＃区分大小写：“ MyClass”和“ myclass”具有不同的含义。
            与Java不同，C＃文件的名称不必与类名匹配，但是它们经常匹配（为了更好的组织）。
            保存文件时，请使用适当的名称进行保存，并在文件名的末尾添加“ .cs”。
             */
            /*
             WriteLine或Write
               在C＃中最常见的输出方法是WriteLine()，但是您也可以使用Write()。
               不同之处在于，WriteLine()每次在新行上打印输出，
                而Write()在同一行上打印（请注意，为了更好的可读性，您应该记住在需要时添加空格）：

            注释可用于解释C＃代码，并使其更具可读性。在测试备用代码时，它也可用于阻止执行。
            单行注释  以两个正斜杠（//）开头。
            //C＃会忽略行和行尾之间的任何文本（将不执行）。
            多行注释
            //  多行注释以开头/*和结尾*/

           /*和之间的任何文本*///都将被C＃忽略。

            Console.WriteLine("Hello World!");
        }
    }
}
