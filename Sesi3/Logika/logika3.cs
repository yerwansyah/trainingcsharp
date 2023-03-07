using System;

public class logika3
{
    public static void Main(){
        string username;
        string password;
        
        Console.Write("username : ");
        username = Console.ReadLine();
        Console.Write("password : ");
        password = Console.ReadLine();

        if (username == "ocbc" && password == "bootcamp"){
            Console.WriteLine("Anda berhasil login");
        }
        else {
            Console.WriteLine("Username atau Password anda salah");
        }
    }
}