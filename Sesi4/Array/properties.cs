using System;

class properties
{
    static void Main()
    {
        int[] angka = new int[10];

        Console.WriteLine("Panjang array angka adalah " +angka.Length);

        //inisiasi angka
        for(int i = 0; i < angka.Length; i++)
            angka[i] = i*i;
        Console.Write("Berikut adalah array angka : ");
        
        for(int i = 0; i < angka.Length; i++)
            Console.Write(angka[i] + "");
        
        Console.WriteLine();
    }
}