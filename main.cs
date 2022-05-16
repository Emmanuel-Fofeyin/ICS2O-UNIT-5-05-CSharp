// Created by: Zaida Hammel
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        int side1;
        int side2;
        int side3;

        Console.Write("Enter the lengths of the sides of your triangle.");
        Console.WriteLine("");
        Console.Write("Enter side 1: ");
        side1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("");
        Console.Write("Enter side 2: ");
        side2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("");
        Console.Write("Enter side 3: ");
        side3 = Convert.ToInt32(Console.ReadLine());

        if (side1 > 0 && side2 > 0 && side3 > 0)
            if (side1 == side2 && side2 == side3)
                Console.Write("Your triangle is an equilateral triangle.");
            else if (side1 == side2 || side2 == side3 || side1 == side3)
                Console.Write("Your triangle is an isosceles triangle.");
            else
                Console.Write("Your triangle is an isosceles triangle.");
        else
            Console.Write("You cannot input negative numbers!");
    }
}