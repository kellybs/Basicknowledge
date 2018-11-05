using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeDemo
{
    /// <summary>
    /// 两个数组  [n] [m]  n>m  第一个数组的数字无序排列 第二个数组为空 取出第一个数组的最小值 放到第二个数组中第一个位置, 依次类推. 
    /// 不能改变A数组，不能对之进行排序，也不可以倒到别的数组中。
    /// </summary>
    class ArrayInsert
    {
        static void Main(string[] args)
        {
            int[] a = { -12,-20, -1, 7, -1,  29, };

            int[] b = new int[4];

            int len = b.Length;

            int max = a[0];
            for(int x=1;x<a.Length;x++)
                if (a[x] > max) max = a[x];

            int tmp = max;

            for (int i = 0; i < len; i++)
            {
                for (int x = 0; x < a.Length; x++)
                {
                    if (i == 0)
                    {
                        if (a[x] < tmp) tmp = a[x];
                    }
                    else
                    {
                        if (a[x] < tmp &&a[x]>=b[i-1]) tmp = a[x];
                    }
                    
                }
                b[i] = tmp;
                tmp = max;
            }

            foreach (int i in b)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadLine();
        }
    }
}
