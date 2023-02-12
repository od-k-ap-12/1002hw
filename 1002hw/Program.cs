using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix arr1 = new Matrix(2, 2);
            Matrix arr2 = new Matrix(2, 2);
            arr1.Input();
            arr2.Input();
            arr1.Print();
            arr2.Print();
            Console.WriteLine(arr1==arr2);
            Console.WriteLine(arr1 + arr2);
            Console.WriteLine(arr1 * 3);
        }
    }
}
