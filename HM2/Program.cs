using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM2
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadOnly<int> a = new ReadOnly<int>();
            a.IsReadOnly = true;
            a.AddToList(1);
            a.AddToList(2);
            a.ToString();
            Console.ReadLine();
        }
    }
}
