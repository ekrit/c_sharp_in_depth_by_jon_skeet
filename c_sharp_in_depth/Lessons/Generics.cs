namespace c_sharp_in_depth.Lessons;

public class Generics<T>
{
    public static List<T> GenerateNames()
    {
        var newList = new List<T>();
        return newList;
    }

    public static void PrintNames(List<T> names) // List<string> names is parameter, when this function is called then names is called argument
    {
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
    
}