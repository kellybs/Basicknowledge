using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KnowledgeDemo
{    
    /// <summary>
    /// yidld示例
    /// </summary>
    class YieldDemo
    {
        static void Main(string[] args)
        {
            var result = Write();
            foreach (int i in result)
            {
                Console.WriteLine("Main:" + i);
            }

            Console.ReadKey();
        }

        private static IEnumerable<int> Write()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
                Thread.Sleep(1000);

                Console.WriteLine("Method:"+i);
                
            }

           
        }
    }

}