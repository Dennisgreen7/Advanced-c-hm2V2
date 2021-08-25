using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_4
{
    class Class_Creatorcs<T>where T:IClassId,new()
    {
        public T new_class { get; set; }
        public void  create_new_class()
        {
            new_class = new T();
        }
    }
}
