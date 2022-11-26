using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_list
    //палиндром меньше чем за 1,5n
    // k-ый с конца за n
{
    internal class List
    {
        public List_Item head;
        public List(int value)
        {
            List_Item l = new List_Item(value);
            head = l;
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
        /*public List_Item k_from_end(int k)
        {
            List_Item[] arr = new List_Item[0];
            List_Item? i = head;
            do
            {
                Array.Resize<List_Item>(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = i;
                i = i.next;
            } while (i != null);
            return arr[arr.Length - k];
        }
        public List_Item k_from_end (int k)
        {
            int size = 1;
            List_Item i = head;
            while (i.next!=null)
            {
                i = i.next;
                size++;
            }
            i = head;
            for (int j=0;j<=size-k-1;j++)
            {
                i = i.next;
            }
            return i;
        }*/
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
        
    }
}
