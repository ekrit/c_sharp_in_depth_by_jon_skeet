// See https://aka.ms/new-console-template for more information

using c_sharp_in_depth.Lessons;

Console.WriteLine("Hello, World!");

var names = Generics<string>.GenerateNames();

names.Add("Haris");
names.Add("Messi");
names.Add("Ronaldo");
names.Add("Neymar");

Generics<string>.PrintNames(names);


