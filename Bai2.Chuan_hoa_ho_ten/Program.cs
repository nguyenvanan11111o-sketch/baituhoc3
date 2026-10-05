using System;
class Program
{
    static void Main()
    {
        Console.Write("Nhap ho ten: ");
        string ten = Console.ReadLine() ?? "";

        ten = ten.Trim();

        string[] tu = ten.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        string ketqua = "";

        foreach (string t in tu)
        {
            string tuMoi = t.ToLower();
                        
            tuMoi = tuMoi.Substring(0,1).ToUpper() + tuMoi.Substring(1);

            ketqua += tuMoi + " ";
                        
        }
        ketqua = ketqua.Trim();

        Console.Write("Ho ten sau khi chuan hoa: " + ketqua);
    }
}