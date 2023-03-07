using System;
public class tugas
{
    static void Main (string[] args)
    {
        int nilai = 0;
        string nama = "";
        bool status = true;

        do {
            try
            {
                Console.Write("Masukkan nama : ");
                nama = Console.ReadLine();

                Console.Write("Masukkan nilai = ");
                nilai = int.Parse(Console.ReadLine());

                status = true;
            }
            catch {
                Console.WriteLine("Salah input, Ulangi kembali.");
                status = false;
            }
        
        } while (!status);

        Console.WriteLine();
        Console.WriteLine("Nama anda " +nama);

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
