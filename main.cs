// Created by:Emmanuel Fofeyin
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        int lengtha;
        int lengthb;
        int lengthc;

        Console.Write("Enter the lengths of the sides of your triangle.");
        Console.WriteLine("");
        Console.Write("Enter length 1: ");
        lengtha = Convert.ToInt32(Console.ReadLine());
        Console.Write("");
        Console.Write("Enter length 2: ");
        lengthb = Convert.ToInt32(Console.ReadLine());
        Console.Write("");
        Console.Write("Enter length 3: ");
        lengthc = Convert.ToInt32(Console.ReadLine());

        if (lengtha > 0 && lengthb > 0 && lengthc > 0)
            if (lengtha == lengthb && lengthb == lengthc)
                Console.Write("It is an equilateral Triangle.");
            else if (lengtha == lengthb || lengthb == lengthc || lengtha == lengthc)
                Console.Write("It is an isosceles Triangle.");
            else if (lengtha != lengthb && lengthb != lengthc && lengthc != lengtha)
                Console.Write("It is a scalene Triangle.");
              else
            Console.Write("You cannot input negative numbers!");
      Console.WriteLine("\nDone.");
    }
}