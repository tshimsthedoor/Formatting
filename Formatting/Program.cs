﻿using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfApples = 12;
            decimal pricePerApple = 0.35M;

            Console.WriteLine(
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples);

            string formatted = string.Format(
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples);
            Console.WriteLine("This is the second way: " +formatted);
            Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:c}");

            string applesText = "Apples";
            int applesCount = 1234;
            string bananastext = "Bananas";
            int bananasCount = 56789;

            Console.WriteLine(
                format: "{0, -8} {1,6:N0}",
                arg0: "Name",
                arg1: "Count");

            Console.WriteLine(format: "{0, -8}{1,6:N0}",
                arg0: applesText,
                arg1: applesCount);

            Console.WriteLine(format: "{0,-8} {1,6:N0}",
                arg0: bananastext,
                arg1: bananasCount);
        }
    }
}
