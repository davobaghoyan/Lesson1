using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA.Lesson8.HelloCollections
{
    class MaxSize : IComparer<Airport>
    {
        Dictionary<string, int> str = new Dictionary<string, int> { { "Small", 1 }, { "Medium", 2 }, { "Large", 3 }, { "Mega", 4 }, { "SuperMega", 5 } };
        public int Compare(Airport x, Airport y)
        {
            if (str[x.Size] > str[y.Size])
                return 1;
            if (str[x.Size] < str[y.Size])
                return -1;
            return 0;

        }
    }
}
