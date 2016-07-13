using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalc.SortArray
{
    public static class SortFactory
    {
        public static ISortArray getSort(string name)
        {
            switch (name)
            {
                case "gnomeSort":
                    return new GnomeSort();

                case "quickSort":
                    return new QuickSort();

                default:
                    throw new Exception("неизвестная команда");
            }
        }
    }
}
