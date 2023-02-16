// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

/// <summary>
/// Gets or sets the name of the sample.
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        int x = 5;
        int y = 10;
        int sum = AddNumbers(x, y);
        Console.WriteLine("The sum of {0} and {1} is {2}", x, y, sum);
    }

    private static int AddNumbers(int a, int b)
    {
        return a + b;
    }
}
