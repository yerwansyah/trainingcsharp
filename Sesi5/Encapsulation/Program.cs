using System;

class Program
{
    public static void Main(string[] args)
    {
        Pesawat garuda = new Pesawat();
        garuda.nama = "GARUDAKU";
        garuda.Ketinggian = "2500 kaki";

        garuda.terbang();
        garuda.sudahterbang();
        Console.Read();
    }
}
