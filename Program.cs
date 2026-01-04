using System;
using Csharp.ExtensionMethod;
Console.WriteLine("Hello, World!");

int square(int x ) =>x * x;

int y = 50;
var results = square(y);
Console.WriteLine($"square of {y} is {results}");

int[] arr = [1,2,3,4,5,6,7,8,9,10];
arr.PrintArray(); // using my own custom defined extension method 