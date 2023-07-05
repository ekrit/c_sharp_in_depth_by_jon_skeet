namespace c_sharp_in_depth.Lessons;

public class BonusFeaturesOfCSharp5
{
    public void IterationVariableOfForeachLoop()
    {
        List<string> names = new List<string> { "x", "y", "z" };
        var actions = new List<Action>();
        foreach (string name in names) 
        {
            actions.Add(() => Console.WriteLine(name)); 
        }
        foreach (Action action in actions) 
        { 
            action(); 
        } 
    }
}