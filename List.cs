using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace My_list

{
    internal class List
    {
        public List_Item head;
        public List(int value)
        {
            List_Item l = new List_Item(value);
            head = l;
        }
        public List(List_Item i)
        {
            head = i;
        }
        private List_Item last()
        {
            List_Item l = head;
            while (l.next!=null)
            {
                l = l.next;
            }
            return l;
        }
        public void add_item(int value)
        {
            List_Item l = new List_Item(value);
            last().next = l;
        }
        public void write_all()
        {
            List_Item? i = head;
            do
            {
                Console.Write(i.value + " ");
                i = i.next;
            } while (i != null);
        }
        public static void delete(List_Item i)
        {
            List_Item previous = i;
            while (i.next!=null)
            {
                previous = i;
                i.value = i.next.value;
                i = i.next;
            }
            previous.next = null;
        }
        public void kill_head()
        {
            if (head.next!=null)
            head = head.next;
        }
        public List_Item k_from_end(int k)
        {
            List_Item required = head;
            List_Item i = head;
            int co = 1;
            while (i.next!=null)
            {
                if (co >= k) required = required.next;
                i = i.next;
                co++;
            }
            if (co > 1 && required == head)//k - больше размера листа
            {

            }
            return required;
        }

        public void revers()
        {
            List_Item previous = head;
            List_Item? i = head.next;
            head.next = null;
            while (i.next!=null)
            {
                List_Item? t = i.next;
                i.next = previous;
                previous = i;
                i = t;
            }
            head=i;
            head.next = previous;
        }
        public List get_copy() //builder
        {
            List_Item? j = new List_Item(head.value);
            List copy = new List(j);
            List_Item? i = head.next;
            while (i!=null)
            {
                List_Item t = new List_Item (i.value);
                j.next = t;
                j = j.next;
                i = i.next;
            }

            return copy;
        }
        public bool is_palindrom()
        {
            bool palindrom = true;
            List t = this.get_copy();
            t.revers();
            List_Item? i = this.head;
            List_Item? j = t.head;
            while (i.next!= null)
            {
                if (i.value != j.value) palindrom = false;
                i = i.next;
                j = j.next;
            }
            return palindrom;
        }
        public void delete_duplicates()
        {
            List<int> values = new List<int>();
            values.Add(head.value);
            List_Item? i = head.next;
            List_Item? previous = head;
            while (i!=null)
            {
                if (values.Contains(i.value))
                {
                    previous.next = i.next;
                }
                else
                {
                    values.Add(i.value);
                    previous = previous.next;
                }
                i = i.next;

            }
        }
    }
}
