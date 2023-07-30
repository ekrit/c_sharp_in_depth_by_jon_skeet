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
}