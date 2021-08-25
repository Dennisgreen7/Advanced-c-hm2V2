using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM7V2
{
    class Person : Interface1
    {
        public string Name_ { get; set; }

        public Person(string name_)
        {
            Name_ = name_;
        }
    }
}
