﻿internal class Program
{
    private static void Main(string[] args)
    {
        //Atama ve işlemli atama 
        int x = 3;
        int y = 3;
        y += 2;
        Console.WriteLine(y);

        //Mantıksal Operatörler ||  &&  !

        bool isSuccess = true;
        bool isCompleted = false;

        if (isSuccess && isCompleted) ;
        Console.WriteLine("perfect");

        //ilişkisel Operatörler

        int a = 3;
        int b = 4;
        bool sonuc = a < b;
        Console.WriteLine(sonuc);
        sonuc = a != b;
        Console.WriteLine(sonuc);

        //Aritmatik Operatörler

        int sayi1 = 10;
        int sayi2 = 5;
        int sonuc1 = sayi1 / sayi2;
        Console.WriteLine(sonuc1);


        // mod %

        int sonuc2 = 20 % 3;

        Console.WriteLine(sonuc2);
    }
}