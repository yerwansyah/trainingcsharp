using System;

public class array
{
    public static void Main(){
        string[] contoh = new string[4]
        {
            "Motherboard", "Processor", "Power Supply", "Video Card"
        };
        
        Console.WriteLine("Menampilkan semua data dalam array");
        Console.WriteLine("");
        
        foreach(string contoh1 in contoh)
        {
            Console.WriteLine(contoh1);
        }
        Console.Write("Press any key to continue.");
    }
}