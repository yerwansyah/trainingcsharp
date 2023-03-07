using System;

class Penduduk 
{
    static void Main(String[] args)
    {
        string nama;
        int umur;

        Console.WriteLine("==================");
        Console.WriteLine("Program Penduduk");
        Console.WriteLine("==================");
        Console.Write("Nama: ");
        nama = Console.ReadLine();
        Console.Write("Umur: ");
        umur =int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("==================");
        Console.WriteLine("Data Penduduk");
        Console.WriteLine("==================");
        Console.WriteLine($"Nama: {nama}");
        Console.WriteLine($"Umur: {umur}");
        Console.ReadLine();
    }
}
