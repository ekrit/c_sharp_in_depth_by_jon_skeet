// See https://aka.ms/new-console-template for more information

using c_sharp_in_depth.Lessons;

Console.WriteLine("Hello, World!");

foreach (var one in Iterators.Fibonacci())
{
    Console.WriteLine(one);
    if (one > 1000)
        break;
}


