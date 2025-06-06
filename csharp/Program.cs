// See https://aka.ms/new-console-template for more information

using csharp.hashmap;
using csharp.quicksort;

Console.WriteLine("Hello, World!");

int[] test = new []{8, 5, 10, 12, 1, 4, 3, 2};
quicksort.Quicksort(test, 0, test.Length - 1);
foreach (int i in test)
{
    Console.WriteLine(i + " ");
}

