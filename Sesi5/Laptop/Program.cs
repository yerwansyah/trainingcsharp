using System;

class Program
{
    public static void Main(string[] args)
    {
        Laptop lenovo = new Laptop();
        lenovo.merk = "lenovo";
        lenovo.ram = 4;
        lenovo.memory = 128;

        Console.WriteLine("Merk Laptop adalah {0}", lenovo.merk);
        Console.WriteLine("Kapasitas RAM adalah {0}", lenovo.ram);
        Console.WriteLine("Kapasitas Memory adalah {0}", lenovo.memory);

        lenovo.Chatting();
        lenovo.Sosmed();
        lenovo.OnlineShop();

        Console.Read();
    }
}
