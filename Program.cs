using System;
using Csharp.ExtensionMethod;
using Accord.Math;
using Csharp.Mathnet;

Console.WriteLine("Hello, World!");

int square(int x ) =>x * x;

int y = 50;
var results = square(y);
Console.WriteLine($"square of {y} is {results}");

int[] arr = [1,2,3,4,5,6,7,8,9,10];
arr.PrintArray(); // using my own custom defined extension method 

double[] a = [1,2,3];
double[] b = [4,5,6];
double[] sum = a.Add(b);

sum.PrintArray();

var mat = Mathnet.SimpleMatrix();
Console.WriteLine(mat);