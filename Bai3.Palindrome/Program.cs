using System;
class Program
{
    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine() ?? "";

        bool palindrome = true;

        for(int i = 0, j = s.Length - 1; i < j; i++, j--)
        {
            if(s[i] != s[j])
            {
                palindrome = false;
                break;
            }
        }

        if(palindrome)
        {
            Console.Write("Day la chuoi palindrome");
        }
        else
        {
            Console.Write("Day khong phai la chuoi palindrome");
        }
    }
}