using System;

class Makanan 
{
    static void Main(String[] args)
    {
        string namaPelanggan, namaMakanan1, namaMakanan2, namaMakanan3;
        int jumlahMakanan1, hargaMakanan1, jumlahMakanan2, hargaMakanan2, jumlahMakanan3, hargaMakanan3, jumlahSemuaMakanan;


        Console.WriteLine("==================");
        Console.WriteLine("Nama Pelanggan");
        Console.WriteLine("==================");
        Console.Write("Nama: ");
        namaPelanggan = Console.ReadLine();
        Console.WriteLine("==================");
        Console.WriteLine("Data Makanan 1");
        Console.WriteLine("==================");
        Console.Write("Nama Makakan: ");
        namaMakanan1 = Console.ReadLine();
        Console.Write("Harga Makanan: ");
        hargaMakanan1 =int.Parse(Console.ReadLine());
        Console.Write("Jumlah Makanan: ");
        jumlahMakanan1 =int.Parse(Console.ReadLine());
        Console.WriteLine("==================");
        Console.WriteLine("Data Makanan 2");
        Console.WriteLine("==================");
        Console.Write("Nama Makakan: ");
        namaMakanan2 = Console.ReadLine();
        Console.Write("Harga Makanan: ");
        hargaMakanan2 =int.Parse(Console.ReadLine());
        Console.Write("Jumlah Makanan: ");
        jumlahMakanan2 =int.Parse(Console.ReadLine());
        Console.WriteLine("==================");
        Console.WriteLine("Data Makanan 3");
        Console.WriteLine("==================");
        Console.Write("Nama Makakan: ");
        namaMakanan3 = Console.ReadLine();
        Console.Write("Harga Makanan: ");
        hargaMakanan3 =int.Parse(Console.ReadLine());
        Console.Write("Jumlah Makanan: ");
        jumlahMakanan3 =int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("==================");
        Console.WriteLine("Data Pesanan");
        Console.WriteLine("==================");
        Console.WriteLine($"Nama Pelanggan: {namaPelanggan}");
        Console.WriteLine("Detail Pesanan: " + jumlahMakanan1 + " " + namaMakanan1 + ", " + jumlahMakanan2 + " " + namaMakanan2 + ", " + jumlahMakanan3 + " " + namaMakanan3);
        Console.WriteLine($"Total Makanan: {jumlahMakanan1 + jumlahMakanan2 + jumlahMakanan3}");
        Console.WriteLine($"Total Harga: { (hargaMakanan1 * jumlahMakanan1) + (hargaMakanan2 * jumlahMakanan2) + (hargaMakanan3 * jumlahMakanan3)}");
        Console.WriteLine("==================");
        Console.ReadLine();
    }
}
