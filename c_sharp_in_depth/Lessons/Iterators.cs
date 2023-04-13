namespace c_sharp_in_depth.Lessons;

public class Iterators
{
    // An iterator is just a sequence of items in C#, it was intorduced in C# 2
    
    // simple iterator yielding integers
    
    public static IEnumerable<int> CreateSimpleIterator()
    {
        yield return 10;
        for (int i = 0; i < 3; i++)
        {
            yield return i;
        }
        yield return 20;
    }
    
    public static IEnumerable<int> Fibonacci()
    {
        int current = 0;
        int next = 1;
        while (true) 
        {
            yield return current; 
            int oldCurrent = current;
            current = next;
            next += oldCurrent;
        }
    }

    public static IEnumerable<string> Iterator()
    {
        try
        {   
            Console.WriteLine("Before first yield");
            yield return "first";
            Console.WriteLine("Between yields");
            yield return "second";
            Console.WriteLine("After second yield");
        }
        finally
        {
            Console.WriteLine("In finally block");
        }
    } 
    
    public static void GetViaEnumerator()
    {
        IEnumerable<string> enumerable = Iterator();
        using (IEnumerator<string> enumerator = enumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                string value = enumerator.Current;
                Console.WriteLine("Received value: {0}", value);
                if (value != null)
                {
                    break;
                }
            }
        }
    }
}