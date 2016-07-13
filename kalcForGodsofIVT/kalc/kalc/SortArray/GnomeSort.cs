using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalc.SortArray
{
    class GnomeSort : ISortArray
    {

        public int[] sort(int[] Array)
        {

            if (Array.Length == 0)
            {
                return Array;
            }

            int arrayPosition = 1;
            int nextPosition = 2;

            int tempValue;
            while (arrayPosition < Array.Length)
            {
                if (Array[arrayPosition - 1] > Array[arrayPosition])
                {
                    arrayPosition = nextPosition;
                    nextPosition++;
                }
                else
                {
                    tempValue = Array[arrayPosition];
                    Array[arrayPosition] = Array[arrayPosition - 1];
                    Array[arrayPosition - 1] = tempValue;

                    arrayPosition--;
                    if (arrayPosition == 0)
                    {
                        arrayPosition = nextPosition;
                        nextPosition++;
                    }
                }
            }

            return Array;
        }

    }
}
