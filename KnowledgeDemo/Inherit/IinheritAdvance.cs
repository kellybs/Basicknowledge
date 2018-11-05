using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeDemo.Inherit
{
    /// <summary>
    /// 类的继承、多态
    /// 
    /// 究竟执行基类，还是子类的方法，就看实例化对象的方法上面是否有override 关键字
    /// 如果有就执行实例化对象的方法，如果没有就执行左边引用变量的方法
    /// 
    /// </summary>
    class IinheritAdvance
    {
        static void Main(string[] args)
        {
            var ia = new IinheritAdvance();
            ia.DoTestB();
            ia.DoTest();
            Console.ReadKey();
        }

        public void DoTest()
        {
            PrintOne b1 = new PrintOne();
            PrintTwo b2 = new PrintTwo();
            b1.Print();
            b2.Print();      //按预期应该输出 B1、B2

            PrintA ab1 = new PrintOne();
            PrintA ab2 = new PrintTwo();
            ab1.Print();
            ab2.Print();   //B1 B2

        }

        public void DoTestB()
        {
            AdvanceA a = new AdvanceA();
            AdvanceB b = new AdvanceB();
            //a.func1(1);
            //b.func1(1);

            /*
             * 实例化对象AdvanceA，然后执行 AdvanceA的func2 方法
             * func2 方法： 1:  执行当前传进来的参数（b） func1方法,加1后，在执行基类的func1方法
             *              2:  执行func1方法，由于方法前面没有引用传进来的参数，所以执行的是当前实例化对象  AdvanceA 的fun1方法
             */
            a.func2(b);//2,5

            /*
             * 同上面分析
             */
            b.func2(a);//1,6
        }
    }

    public class AdvanceA
    {
        public virtual void func1(int i)
        {
            Console.WriteLine(i);
        }
        public void func2(AdvanceA a)
        {
            a.func1(1);
            func1(5);
        }
    }
    public class AdvanceB : AdvanceA
    {
        public override void func1(int i)
        {
            base.func1(i + 1);
        }
    }

    public class PrintA
    {
        public virtual void Print() { Console.WriteLine("A"); }
    }
    public class PrintOne : PrintA
    {
        public override void Print() { Console.WriteLine("B1"); }
    }
    public class PrintTwo : PrintA
    {
        public new void Print() { Console.WriteLine("B2"); }
    }
}
