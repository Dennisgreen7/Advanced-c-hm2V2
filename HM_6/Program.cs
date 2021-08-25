using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> nums = new Queue<int>();
            for (int i = 0; i < 10; i++)
            {
                nums.Enqueue(i);
            }

            Console.WriteLine(nums.Dequeue());//Dequeue מחזיר את הערך הראשון שנכנס ומוחק אותו
            Console.WriteLine(nums.Peek());//כעת נוכל לראות שהערך הראשון נחמק והערך שהיה שני כעת הוא הראשון 
            Console.ReadLine();
        }
    }
}
