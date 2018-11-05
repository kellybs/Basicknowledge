using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeDemo.Gener
{
    

    class BaseDemo
    {
        static void Main(string[] args)
        {
            CheckCompare<int> ck = new CheckCompare<int>();
            Console.WriteLine(ck.Compare(1, 2));

            CheckCompare<string> strCheck = new CheckCompare<string>();
            Console.WriteLine(strCheck.Compare("hi", "hi"));
            Console.ReadKey();
        }
    }

    class CheckCompare<UnkwonType>
    {
        public bool Compare(UnkwonType i, UnkwonType y)
        {
            return i.Equals(y);
        }
    }
}
