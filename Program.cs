using System;

namespace doitien
{
    class Program 
    {
        static void Main(string[] agrs)
        {
            double rate = 23000;
            double tienusd;
            double tienVND;
            Console.Write("nhap so USD ");
            tienusd = double.Parse(Console.ReadLine());
            tienVND = tienusd * rate;
            Console.WriteLine("Doi ra tien Viet la " + tienVND);
        }
    }
}