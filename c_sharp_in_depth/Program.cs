// See https://aka.ms/new-console-template for more information

using c_sharp_in_depth.Lessons;

Console.WriteLine("Hello, World!");

int[] values = { 2, 7, 3, -5, 1, 0, 10 };
var extremes = Tuples.MinMax(values);

var minimal = extremes.min;
var maximal = extremes.max;

Console.WriteLine(minimal); 
Console.WriteLine(maximal);

Console.WriteLine();

