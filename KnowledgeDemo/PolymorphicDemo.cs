using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeDemo
{
    /// <summary>
    /// 多态
    /// </summary>
    class PolymorphicDemo
    {
        static void Main(string[] args)
        {
            /*
             * 由于方法被重写了，所有执行了实例化对象的方法
             * 如果没有重写，会执行左边对象的方法
             */
            PolymorphicClassB pc = new PolymorphicClassC();
            pc.Info();//重写了，所有会执行 new 对象的方法
            pc.Say();//没重写，会执行左边对象的方法
            Console.ReadKey();
        }
    }

    class PolymorphicClass
    {
        public void Say()
        {
            Console.WriteLine("Say base");
        }
        public virtual void Info()
        {
            Console.WriteLine("base class");
        }
    }

    class PolymorphicClassB:PolymorphicClass
    {
        public void Say()
        {
            Console.WriteLine("Say PolymorphicClassB");
        }

        public override void Info()
        {
            Console.WriteLine("from PolymorphicClassB ");
        }
    }

    class PolymorphicClassC:PolymorphicClassB
    {
        public void Say()
        {
            Console.WriteLine("Say PolymorphicClassC");
        }

        public override void Info()
        {
            Console.WriteLine("PolymorphicClassC ");
        }
    }
}
