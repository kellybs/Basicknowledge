using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeDemo.Inherit
{
    /// <summary>
    /// 继承基础实例
    ///  究竟执行基类，还是子类的方法，就看实例化对象的方法上面是否有override 关键字
    /// 如果有就执行实例化对象的方法，如果没有就执行左边引用变量的方法
    /// </summary>
    class BaseDemo
    {
        static void Main(string[] args)
        {

            ParentClass bc = new ParentClass();
            DerivedClass dc = new DerivedClass();
            ParentClass bcdc = new DerivedClass();

            bc.Method1();
            dc.Method1();
            dc.Method2();
            bcdc.Method1();
            

            Console.ReadKey();
        }
    }

    class ParentClass
    {
        public virtual  void Method1()
        {
            Console.WriteLine("Base - Method1");
        }
    }

    class DerivedClass : ParentClass
    {
        public override void Method1()
        {
            Console.WriteLine("Derived - Method1");
        }
        public void Method2()
        {
            Console.WriteLine("Derived - Method2");
        }
    }

}
