using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeDemo.Gener
{
    /// <summary>
    /// 泛型排序
    /// </summary>
    class Sort
    {

        static List<Person> listPerson = new List<Person>();
      
        static void Main(string[] args)
        {
            listPerson.Add(new Person() { Age=15,Name="xiaowang"});

            listPerson.Add(new Person() { Age = 25, Name = "xiaoling" });

            listPerson.Add(new Person() { Age = 25, Name = "ll" });

            listPerson.Add(new Person() { Age = 20, Name = "hanyue" });

            listPerson.Add(new Person() { Age = 31, Name = "wb" });

            //listPerson.Sort((a,b)=>a.Age-b.Age);

            listPerson.Sort((a, b) => string.Compare(a.Name, b.Name));
           

            foreach (Person p in listPerson)
            {
                Console.WriteLine("{0}:{1}",p.Name,p.Age);
            }




            Console.ReadKey();
        }
    }

    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
