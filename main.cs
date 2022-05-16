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


        Console.WriteLine("Enter the Lengths of the sides on the triangle");
        Console.WriteLine("to figure out what type of triangle it is...");
        Console.WriteLine("");
      
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
                Console.Write("Your triangle is an equilateral triangle.");
            else if (lengtha == lengthb || lengthb == lengthc || lengtha == lengthc)
                Console.Write("Your triangle is an isosceles triangle.");
            else
                Console.Write("Your triangle is an isosceles triangle.");
        else
            Console.Write("You cannot input negative numbers!");
    }
}