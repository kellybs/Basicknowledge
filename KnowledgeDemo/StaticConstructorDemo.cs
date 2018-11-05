using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeDemo
{
    /*
     *  静态构造函数具有以下属性：

        静态构造函数不使用访问修饰符或不具有参数。

        在创建第一个实例或引用任何静态成员之前，将自动调用静态构造函数以初始化类。

        不能直接调用静态构造函数。

        用户无法控制在程序中执行静态构造函数的时间。

        静态构造函数的一种典型用法是在类使用日志文件且将构造函数用于将条目写入到此文件中时使用。

        静态构造函数对于创建非托管代码的包装类也非常有用，这种情况下构造函数可调用 LoadLibrary 方法。

        如果静态构造函数引发异常，运行时将不会再次调用该函数，并且类型在程序运行所在的应用程序域的生存期内将保持未初始化。
     */

    /// <summary>
    /// 静态构造函数
    /// </summary>
    class StaticClassB
    {
        public static int Y = StaticClassA.X + 1;
        static StaticClassB()
        {
            Console.WriteLine("StaticClassB");
        }

        static void Main()
        {
            Console.WriteLine("X={0},Y={1}",StaticClassA.X,StaticClassB.Y);
            Console.ReadKey();
        }
    }

    class StaticClassA
    {
        public static int X;
        static StaticClassA()
        {
            X = StaticClassB.Y+1;//StaticClassB.Y值为0
            Console.WriteLine("StaticClassA");  
        }
    }
}
