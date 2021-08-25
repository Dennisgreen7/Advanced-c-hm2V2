using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> nums_ = new Stack<int>();
            for (int i = 0; i < 10; i++)
            {
                nums_.Push(i);
            }

            Console.WriteLine(nums_.Peek());//סטאק מדפיס את הערך האחרון שקיבל 
            Console.WriteLine(nums_.Pop());//פופ מחזיר ומוחק את הערך האחרון שקיבל
            Console.WriteLine(nums_.Peek());//לאחר שהפעלנו את פופ הערך האחרון נמחק(9) והערך האחרון עכשיו הוא 8
            Console.ReadLine();
        }
    }
}
