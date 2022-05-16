// Created by: Emmanuel Fofeyion
// Created on: May 2022
//
// This program accepts user input


using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int lengtha;
        int lengthb;
        int lengthc;

        Console.WriteLine("Enter the Lengths of the sides on the triangle");
        Console.WriteLine("to figure out what type of triangle it is...");
        Console.WriteLine("");

        Console.Write("Length 1: ");
        lengtha = Convert.ToInt32(Console.ReadLine());
        Console.Write("");
        Console.Write("Length 2: ");
        lengthb = Convert.ToInt32(Console.ReadLine());
        Console.Write("");
        Console.Write("Length 3: ");
        lengthc = Convert.ToInt32(Console.ReadLine());
        Console.Write("");

        if (lengtha <= 0 || lengthb <= 0 || lengthc <= 0 )
        {
            Console.Write("Something went wrong...");
        }
        else
        {
        if (lengtha == lengthb && lengthb == lengthc && lengthc == lengtha)
        {
            Console.Write(" It is an equilateral Triangle.");
        }
        else if (lengtha == lengthb || lengthb == lengthc || lengthc == lengtha)
        {
            Console.Write("It is an isosceles Triangle.");
        }
        else if (lengtha != lengthb && lengthb != lengthc && lengthc != lengtha)
        {
            Console.Write("It is a scalene Triangle.");
        }
        else
        {
            Console.Write("Something went wrong...");
        }

        Console.WriteLine("\nDone.");
        }
    }
}