namespace c_sharp_in_depth.Lessons;

public class Tuples
{
        //Tuples act as bags of elements with no encapsulation
        
    public static (int min, int max) MinMax(IEnumerable<int> source)
    {
        using var iterator = source.GetEnumerator();
        
        if (!iterator.MoveNext())
        {
            throw new InvalidOperationException(
                "Cannot find min/max of an empty sequence");
        }
        var result = (min: iterator.Current, 
            max: iterator.Current); 
        while (iterator.MoveNext())
        {
            result.min = Math.Min(result.min, iterator.Current); 
            result.max = Math.Max(result.max, iterator.Current); 
        }
        return result;
    }
    
    public static void Match(object input)
    {
        if (input is "hello")
            Console.WriteLine("Input is string hello");
        else if (input is 5L)
            Console.WriteLine("Input is long 5");
        else if (input is 10)
            Console.WriteLine("Input is int 10");
        else
            Console.WriteLine("Input didn't match hello, long 5 or int 10");
    }
}