using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM3
{
    class Program
    {
        static void Main(string[] args)
        {
            Struct_Class<int> a = new Struct_Class<int>();
            Struct_Class<Double> b = new Struct_Class<Double>();
            Struct_Class<char> c = new Struct_Class<char>();
            Random rnd = new Random();
            for (int i =a.List_.Length-1; i >= 0; i--)
            {
                a.Add_(rnd.Next(100, 200));
                c.Add_((char)rnd.Next('a', 'z'));
                b.Add_(rnd.Next(100, 200) + rnd.NextDouble());
            }
            //int[] aar = a.Get_List();
            //char[] ar2 = c.Get_List();
            //double[] ar3 = b.Get_List();
            for (int i = 0; i < a.List_.Length; i++)
            {
                Console.WriteLine("arr1[" + i + "]" + " = " + a.List_[i] + " | arr2[" + i + "]" + " = " + c.List_[i] + " | arr3[" + i + "]" + " = " + b.List_[i]);
                //Console.WriteLine("arr1["+i+"]"+" = "+aar[i]+ " | arr2[" + i + "]" + " = " + ar2[i]+" | arr3[" + i + "]" + " = " + ar3[i]);
                //Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
