using System;
public class tugas
{
    static void Main (string[] args)
    {
        Console.Write("Masukkan nilai = ");
        int nilai = int.Parse(Console.ReadLine());

        if(nilai <= 100 && nilai >= 80)
        {
            Console.WriteLine("Sangat Baik");
        }
        else if(nilai <= 79 && nilai >= 70)
        {
            Console.WriteLine("Baik");
        }
        else if(nilai <= 69 && nilai >= 50)
        {
            Console.WriteLine("Cukup");
        }
        else if(nilai <= 49 && nilai >= 40)
        {
            Console.WriteLine("Kurang");
        }
        else if(nilai <= 39 && nilai >= 0)
        {
            Console.WriteLine("Sangat Kurang");
        }
        else
        {
            Console.WriteLine("Data tidak valid");
        }
    } 
}