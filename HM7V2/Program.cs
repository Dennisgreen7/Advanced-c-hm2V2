using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM7V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person("Dennis");
            Class1<Person> b = new Class1<Person>();
            b.get_info(a);
            Console.ReadLine();
        }
    }
}
