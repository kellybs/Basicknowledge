using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeDemo.Inherit
{
    
    /// <summary>
    /// 
    /// </summary>
    class InheritCtor
    {
        static void Main(string[] args)
        {
            new TestClassB();
            Console.ReadKey();
        }

    }

    class TestClassA
    {
        public TestClassA()
        {
            /*
             * 该方法被子类重写了，所以实际上执行的是子类的 printFields 方法
             * 
             * 如果没有重写，就执行基类的的虚方法
             */
            printFields();
        }
        public virtual void printFields()
        {
            Console.WriteLine("子类会调用基类的方法么？");
        }
    }

    class TestClassB : TestClassA
    {
        int x = 1; int y;

        /// <summary>
        /// 在执行子类的构造函数前会执行父类的构造函数
        /// </summary>
        public TestClassB()
        {
            y = -1;

        }
        public override void printFields()
        {
            Console.WriteLine("x={0},y={1}", x, y);

        }
    }

}
