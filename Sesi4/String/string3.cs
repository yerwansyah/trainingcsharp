using System;

class string3 {
    static void Main() {
        string[] str = {"ini", "adalah", "sebuah", "test"};
        Console.WriteLine("array asli : ");

        for (int i = 0; i < str.Length; i++)
            Console.Write(str[i] + " ");
        Console.WriteLine("\n");

        str[1] = "merupakan";
        str[3] = "test, juga!";
        Console.WriteLine("array termodifikasi");

        for (int i = 0; i < str.Length; i++)
            Console.Write(str[i] + " ");
    }
}