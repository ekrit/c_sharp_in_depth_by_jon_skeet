namespace c_sharp_in_depth.Lessons;

public class GenericVariance
{
    
    static IEnumerable<string> strings = new[] { "a", "b", "cdefg", "hij" };
    List<object> list = strings
        .Where(x => x.Length > 1)
        .Cast<object>()
        .ToList();
    
    // transformed to this bellow
    
    static IEnumerable<string> strings2 = new[] { "a", "b", "cdefg", "hij" };
    List<object> list2 = strings2
        .Where(x => x.Length > 1)
        .ToList<object>();
    
     
    
    
    
    
}