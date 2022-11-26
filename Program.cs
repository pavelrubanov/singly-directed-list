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

        //Console.WriteLine("\n"+ l.k_from_end(4).value);
        l.revers();
        l.write_all();

        Console.ReadKey();
        return 0;
    }
}