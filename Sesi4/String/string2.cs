using System;
using System.Globalization;

class string2 {
    static void Main() {
        string str1 = "Untuk pemrograman .NET, C# adalah #1";
        string str2 = "Untuk pemrograman .NET, C# adalah #1";
        string str3 = "C# sangat tangguh";
        string strAtas, strBawah;
        int hasil, idx;

        Console.WriteLine("str1 : " +str1);
        Console.WriteLine("panjang str1 : " +str1.Length);
        
        strBawah = str1.ToLower(CultureInfo.CurrentCulture);
        strAtas = str1.ToUpper(CultureInfo.CurrentCulture);

        Console.WriteLine("Versi huruf kecil :\n " +strBawah);
        Console.WriteLine("Versi huruf besar :\n " +strAtas);

        Console.WriteLine();

        Console.WriteLine("Menampilkan str1, char demi char.");
        for(int i = 0; i < str1.Length; i++)
            Console.Write(str1[i]);
        Console.WriteLine("\n");

        //comparing string
        if (str1 == str2)
            Console.WriteLine("str1 == str2");
        else
            Console.WriteLine("str1 != str2");
        
        if (str1 == str3)
            Console.WriteLine("str1 == str3");
        else
            Console.WriteLine("str1 != str3");

        //comparing different culture
        hasil = string.Compare(str1, str3, StringComparison.CurrentCulture);
        if (hasil == 0)
            Console.WriteLine("str1 dan str3 sama");
        else if (hasil < 0)
            Console.WriteLine("str1 kurang dari str3");
        else
            Console.WriteLine("str1 lebih besar dari str3");
        
        Console.WriteLine();

        str2 = "satu dua tida satu";
        idx = str2.IndexOf("satu", StringComparison.Ordinal);
        Console.WriteLine("indeks kemunculan pertama dari satu : " +idx);

        idx = str2.LastIndexOf("satu", StringComparison.Ordinal);
        Console.WriteLine("indeks kemunculan terakhir dari satu : " +idx);

    }
}