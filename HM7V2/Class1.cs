using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM7V2
{
    class Class1<T> where T : Interface1
    {

        public void  get_info(T obj)
        {
            Console.WriteLine("Class type is " + obj.GetType().Name.ToString()+" name property = "+obj.Name_ );
        }
    }
}
