using System;

class Program
{
    public static void Main(string[] args)
    {
        Pesawat pesawat = new Pesawat();
        PesawatTempur pswtTempur = new PesawatTempur();

        pesawat.nama = "Helly";
        pesawat.jumlahRoda = 3;
        pesawat.ketinggian = "1000 kaki";
        pesawat.jumlahPenumpang = "3 Penumpang";
        pswtTempur.nama = "AZ500TPU";
        pswtTempur.jumlahRoda = 5;
        pswtTempur.ketinggian = "200 kaki";
        pswtTempur.jumlahPenumpang = "2 Penumpang plus kopilot dan asistance";

        pesawat.terbang();
        pswtTempur.terbang();
        pswtTempur.terbangtinggi();
        Console.Read();
    }
}
