using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM2
{
    class ReadOnly<T>
    {
        private T[] list_ = new T[10];

        public bool IsReadOnly { get; set; }
        private int Count_ = 0;
        public void AddToList(T data_)
        {
            try
            {
                if (IsReadOnly)
                {
                    throw new InvalidOperationException("when readonly is on you cant add to list");
                }
                else
                {
                    list_[Count_++] = data_;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
