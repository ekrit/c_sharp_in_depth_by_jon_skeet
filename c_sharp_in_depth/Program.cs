// See https://aka.ms/new-console-template for more information

using c_sharp_in_depth.Lessons;

Console.WriteLine("Hello, World!");

List<dynamic> source = new List<dynamic>
{
 "haris",
 5,
 2.75,
 TimeSpan.FromSeconds(45)
};

IEnumerable<dynamic> query = source.Select(x => x);

foreach (dynamic value in query)
{
 Console.WriteLine(value);
}





