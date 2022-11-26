using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_list
{
    internal class List_Item
    {
        public int value;
        public List_Item? next;
        public List_Item(int v)
        {
            value = v;
            next = null;
        }
    }
}
