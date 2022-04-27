using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    public class Item<T>
    {
        public int Key { get; set; }

        public List<T> Values { get; set; }

        public Item(int key)
        {
            Values = new List<T>();
        }

    }
}
