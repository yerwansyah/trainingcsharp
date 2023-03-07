using System;

public class logika2
{
    public static void Main(){
        int nilai;
        Console.Write("nilai = ");
        nilai = int.Parse(Console.ReadLine());
        
        if (nilai >= 0 && nilai < 60){
            Console.WriteLine("Nilai kamu C");
        }
        else if (nilai >= 60 && nilai < 80){
            Console.WriteLine("Nilai kamu B");
        }
        else if (nilai >= 80 && nilai < 100){
            Console.WriteLine("Nilai kamu A");
        }
        else {
            Console.WriteLine("Nilai yang di input tidak sesuai");
        }
    }
}