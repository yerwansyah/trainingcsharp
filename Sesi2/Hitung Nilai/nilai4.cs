using System;
public class nilai4
{
    static void Main (string[] args)
    {
        Console.Write("Enter your age = ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Password = ");
        string password = Console.ReadLine();

        bool isAdult = age > 18;
        bool isPasswordValid = password == "abc";

        if(isAdult && isPasswordValid)
        {
            Console.WriteLine("welcome to the club");
        }
        else
        {
            Console.WriteLine("Sorry, try again!");
        }
    } 
}
