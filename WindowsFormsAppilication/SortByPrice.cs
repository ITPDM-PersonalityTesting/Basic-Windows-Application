using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SortByPrice : IComparer<Item>
    {
        public int Compare(Item x, Item y)
        {
            return (int)(x.Price - y.Price);
        }
    }
}
