using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Masukkan nilai a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Masukkan nilai b:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Masukkan nilai c:");
        double c = Convert.ToDouble(Console.ReadLine());

        string hasil = rumus(a,b,c);
        }

        static string rumus (double a,double b,double c) 
        {
            double akar_determinan;
            double determinan = b * b - (4 * a * c);
            akar_determinan = Math.Sqrt(determinan);
            if (determinan < 0) 
            {
            Console.WriteLine("Determinan Negatif. Akar tidak bisa dicari.");
            return "Determinan Negatif. Akar tidak bisa dicari.";
        }
        else if (determinan == 0) 
        {
        double x1 = -b /(2 * a);
        Console.WriteLine("Akar dari persamaan Anda adalah " + x1);
        return $"x1 = {x1}";
        }
        else 
        {
        double x1 = (-1 * b + akar_determinan)/ (-2 * a);
        double x2 = (-1 * b - akar_determinan)/ (-2 * a);
        Console.WriteLine("Akar Pertama dari persamaan anda adalah" + x1);
        Console.WriteLine("Akar Kedua dari persamaan anda adalah" + x2);
        return $"x1 = {x1}, x2 = {x2}";
        }
        Console.ReadKey();
    }
}
