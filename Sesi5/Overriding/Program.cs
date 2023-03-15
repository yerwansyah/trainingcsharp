using System;

class Program
{
    public static void Main(string[] args)
    {
        Aritmatika overiding = new Aritmatika();
        overiding.Bilangan(10, 5);
        overiding.PenjumlahanPerkalianDll();

        overiding = new AritmatikaOverride();
        overiding.Bilangan(20, 5);
        overiding.PenjumlahanPerkalianDll();
    }
}
