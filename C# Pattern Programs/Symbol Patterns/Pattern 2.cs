﻿using System;

class Pattern_10
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    } //end of main
} //end of class
