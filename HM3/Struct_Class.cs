using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM3
{
    class Struct_Class<T> where T : struct
    {
        public T[] List_ = new T[10];
        private int Count_ = 9;
        public void Add_(T obj)
        {
            List_[Count_--] = obj;
            Array.Sort(List_);
        }
       
    }
}
