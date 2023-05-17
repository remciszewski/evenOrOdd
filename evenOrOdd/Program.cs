using evenOrOdd;
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number to check if it's even or odd: ");
        string numberString = Console.ReadLine();
        int number = Convert.ToInt32(numberString);

        Console.Write(EvenOrOdd.EOD(number));


    }
}
