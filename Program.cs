using System;
using My_list;
class Program
{
    public static int Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        List l = new List(Convert.ToInt32(Console.ReadLine()));
        for (int i=1;i<n;i++)
        {
            l.add_item(Convert.ToInt32(Console.ReadLine()));
        }

        l.delete_duplicates();
        l.write_all();
        return 0;
    }
}