using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Check_Class test = new Check_Class();
            Person d = new Person("Dennis");
            Car c = new Car(1);
            string str1 = test.check_obj_name(d);
            string str2 = test.check_obj_name(c);
            Console.WriteLine(str1+"\n"+str2);
            Console.ReadLine();
        }
    }
}
