using AlgorithmsLibrary;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
class ChooseAlgorithm
{
    static void Main()
    {
        int[] a = new int[10];
        Random rnd = new Random();
        Console.WriteLine("This is a examples of Algorithms on C#");
        Console.WriteLine("Choose a algorithm:");
        Console.WriteLine();
        Console.WriteLine("1. Bynary search");
        Console.WriteLine("2. Selection Sort");

        string option = Console.ReadLine();
        for (int i = 0; i < 10; i++)
        {
            a[i] = rnd.Next(0,100);
            
            }
        switch (option)
        {
            case "1":
                int rez = Bynary.BinarySearch(a, a[9]);
                Console.WriteLine(string.Join(", ", a) + a[9]);
                Console.WriteLine("index " + rez);
                break;
            case "2":
                Console.WriteLine("Before " + string.Join(", ", a));
                SelectionSort.Sort(a);
                Console.WriteLine("After " + string.Join(", ", a));

                break;
        }
    }
}