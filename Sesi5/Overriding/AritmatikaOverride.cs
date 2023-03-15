using System;

public class AritmatikaOverride:Aritmatika
{
    public override void PenjumlahanPerkalianDll()
    {
        Console.WriteLine("Overiding 2......------>>>>");
        Console.WriteLine("Hasil pembagian angka {0} dan angka {1} = {2}", bilangan1, bilangan2, bilangan1 / bilangan2);
        Console.WriteLine("Hasil pengurangan angka {0} dan angka {1} = {2}", bilangan1, bilangan2, bilangan1 - bilangan2);
        Console.WriteLine();
    }
}