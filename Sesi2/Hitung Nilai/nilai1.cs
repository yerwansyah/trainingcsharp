using System;
public class nilai1
{
    static void Main (string[] args)
    {
        int pertama, kedua, ketiga, total;
        double rate;

        Console.WriteLine("=== Menghitung Nilai ===");
        Console.Write("Masukkan nilai pertama : ");
        pertama = int.Parse(Console.ReadLine());
        Console.Write("Masukkan nilai kedua : ");
        kedua = int.Parse(Console.ReadLine());
        Console.Write("Masukkan nilai ketiga : ");
        ketiga = int.Parse(Console.ReadLine());

        total = pertama + kedua + ketiga;
        rate = total/3.0;
        Console.WriteLine("Total Niai adalah : " +total);
        Console.WriteLine("Rata rata nilai adalah : " +rate);
        Console.Read();
    } 
}