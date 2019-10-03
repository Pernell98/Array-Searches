using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Searches
{
    class ArrayOfPrimitives
    {
        private int[] numbers = {1,2,3,4,5,6,7,8,9,10 };

        public ArrayOfPrimitives()
        {

        }

        public void findValue(int element)
        {
            Console.WriteLine(numbers[element]);
        }


    }
}
