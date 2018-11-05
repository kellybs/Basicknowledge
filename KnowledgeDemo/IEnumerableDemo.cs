using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeDemo
{
    /// <summary>
    /// ienumerable,enumerator
    /// </summary>
    class IEnumerableDemo
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>() { 100, 110, 120, 201, 211, 221 };

            IEnumerable<int> num = li.AsEnumerable();
            Console.WriteLine("----------IEnumerable遍历-----------");
            foreach (int i in num)
            {
                Console.Write(i+",");
            }

            Console.WriteLine("");
            Console.WriteLine("----------IEnumerator遍历-----------");

            IEnumerator<int> rator = li.GetEnumerator();
            while (rator.MoveNext())
            {
                Console.Write(rator.Current+",");
            }
            Console.WriteLine("");
            Console.WriteLine("------IEnumerable 配合IEnumerator 使用 ---------");

            Print100To200(li.GetEnumerator());


            Console.WriteLine("");
            Console.WriteLine("------IEnumerable 嵌套IEnumerator 使用 ---------");
            Show100To200(num);
            Console.ReadKey();
        }

        static void Print100To200(IEnumerator<int> obj)
        {
            while (obj.MoveNext())
            {
                Console.WriteLine(obj.Current+",");

                if (Convert.ToInt16(obj.Current.ToString()) > 200)
                {
                    PrintThan200(obj);
                }
            }
        }

        /// <summary>
        /// 显示大于200
        /// 由于IEnumerator 是只读的，当遍历后，Print100To200 方法遍历也结束了
        /// </summary>
        /// <param name="obj"></param>
        static void PrintThan200(IEnumerator<int> obj)
        {
            while (obj.MoveNext())
            {
                Console.WriteLine(obj.Current + ",");
            }
        }

        static void Show100To200(IEnumerable<int> num)
        {

            foreach (int i in num)
            {
                Console.WriteLine(i);

                if (i > 200)
                {
                    ShowThan200(num);
                }
            }
        }

        /// <summary>
        /// 遍历整个IEnumerable
        /// </summary>
        /// <param name="num"></param>
        static void ShowThan200(IEnumerable<int> num)
        {

            foreach (int i in num)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine("");
        }
    }
}
