using System;
class Program
{
    static void Main()
    {
        int[] a = new int[5];
        int tong = 0;
        for(int i = 0; i < 5; i++)
        {
            Console.Write("a[" + i + "] = ");
            a[i] = int.Parse(Console.ReadLine() ?? "0");
        }

        for(int i = 0; i < 5; i++)
        {
            if(a[i] % 2 == 0)
            {
                tong += a[i];
            }
        }

        Console.Write("Tong cac so chan trong mang = " + tong);
    }
}
