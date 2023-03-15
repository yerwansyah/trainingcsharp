using System;

class tugas
{
    static void Main()
    {
        string repeat = "N";
        string input = " ";

        do {
            Console.WriteLine("Tugas 1");
            Console.WriteLine("Nama : Yusrizal Erwansyah");
            Console.WriteLine("No Peserta : NPRG001ONL007");
            Console.WriteLine();

            Console.WriteLine("Daftar Soal : ");
            Console.WriteLine("1. Segitiga Alfabet");
            Console.WriteLine("2. Segitiga Angka");
            Console.WriteLine("3. Faktorial");
            Console.WriteLine("4. Reversed Number");
            Console.WriteLine("5. Number to String");
            Console.WriteLine();

            Console.Write("Masukkan Angka Sesuai Daftar Soal : ");
            input = Console.ReadLine();
            
            switch (input)
            {
                case "1": {
                    Console.WriteLine("Soal Nomor 1");
                    Console.WriteLine("Segitiga Alfabet");

                    int n = 5;
                    for(int i = 0; i < n; i++){
                        for (int j = n-1; j >1; j--)
                            Console.Write(" ");
                        for (int k = 0; k <= i; k++)
                            Console.Write((char)('a' +k));
                        for (int l = i - 1; l >= i; l--)
                            Console.Write((char)('a' +l));
                        Console.WriteLine();
                    }
                    break;
                }
                case "2": {
                    Console.WriteLine("Soal Nomor 2");
                    Console.WriteLine("Segitiga Angka");

                    Console.Write("Masukkan Angka : ");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++){
                        for (int j = n-1; j > 1; j--) 
                            Console.Write(" ");
                        for (int k = 1; k <= i + 1; k++) 
                            Console.Write(k);
                        for (int l = i; l >= 1; l--)
                            Console.Write(l);
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;
                }
                case "3": {
                    Console.WriteLine("Soal Nomor 3");
                    Console.WriteLine("Faktorial");
                    
                    int i, fact = 1, numb;
                    Console.Write("Masukkan angka : ");
                    numb = int.Parse(Console.ReadLine());

                    for(i = 1; i <= numb; i++){
                        fact = fact * i;
                    }
                    Console.Write("Faktorial dari " +numb+ " adalah : " +fact);
                    Console.WriteLine();
                    break;
                }
                case "4": {
                    Console.WriteLine("Soal Nomor 4");
                    Console.WriteLine("Reversed Number");
                    
                    Console.Write("Masukkan Angka : ");
                    int numb = Convert.ToInt32(Console.ReadLine());
                    int reversed_numb = 0;
                    while (numb > 0){
                        int digit = numb % 10;
                        reversed_numb = (reversed_numb * 10) + digit;
                        numb = numb / 10;
                    }
                    Console.WriteLine("Angka terbalik : {0}", reversed_numb);
                    break;
                }
                case "5": {
                    Console.WriteLine("Soal Nomor 5");
                    Console.WriteLine("Number to String");

                    int angka = Convert.ToInt32(Console.ReadLine());
                    string[] angkaTulisan = 
                    {
                        "nol", "satu", "dua", "tiga", "empat", 
                        "lima", "enam", "tujuh", "delapan", "sembilan"
                    };
                    string angkaString = angka.ToString();
                    string angkaTulisanString = "";
                    foreach(char digit in angkaString) {
                        int digitAngka = (int)Char.GetNumericValue(digit);
                        angkaTulisanString += angkaTulisan[digitAngka] + " ";
                    }
                    Console.WriteLine("Angka dalam bentuk tulisan: " + angkaTulisanString);
                    break;
                }
                default: {
                    Console.WriteLine("Invalid number, please try again!");
                    break;
                }

            }

            Console.Write("Kembali ke menu awal (Y/N) ? ");
            repeat = Console.ReadLine();
        }
        while (repeat.ToUpper() == "Y");
    }
}