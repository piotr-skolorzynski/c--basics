using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Swap
    {
        //create method of nongeneric class using generic parameters 
        //method changes indexes 
        public static void SwapElements<T>(ref T first, ref T second)
        { 
            T temp = first;
            first = second;
            second = temp;
        }
    }
}
