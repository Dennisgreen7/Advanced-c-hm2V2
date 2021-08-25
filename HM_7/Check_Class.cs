using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace HM_7
{
    class Check_Class
    {
        public string   check_obj_name(object obj)
        {
            if (obj.GetType().GetProperty("Name") != null)
            {
                return "The obj type is " + obj.GetType().Name.ToString()+"\n"+"The Name property is "+ obj.GetType().GetProperty("Name").GetValue(obj).ToString();
            }
            else 
            {
                return "This class dosent have a Name property";
            }           
        }
         
       
    }
}
