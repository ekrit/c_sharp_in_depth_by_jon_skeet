namespace c_sharp_in_depth.Lessons;

public class Lambda
{
    
    // EXAMPLE WITH MULTIPLY
    
    // longest version
    public Func<int, int, int> multiply = 
        (int x, int y) => { return x * y; };
    
    // shorter version 
    public Func<int, int, int> multiply2 = (int x, int y) => x * y;
    
    // even shorter version
    public Func<int, int, int> multipy3 = (x, y) => x * y;
    
    
    // EXAMPLE WITH SQUARE LENGHT
    
    // longest version
    public Func<string, int> squareLenght = (string text) =>
    {
        var lenght = text.Length;
        return lenght * lenght;
    };
    
    // shorter version
    public Func<string, int> squareLenght2 = (text) =>
    {
        var lenght = text.Length;
        return lenght * lenght;
    };
    
    // even shorter version 
    public Func<string, int> squareLenght3 = text =>
    {
        var lenght = text.Length;
        return lenght * lenght;
    };
    
    // the shortest one
    public Func<string, int> squareLenght4 = text => text.Length * text.Length;
    
    
    // both for understanding static and lambda
    public static List<Action> CreateCountingActions()
    {
        List<Action> actions = new List<Action>();
        int outerCounter = 0; 
        for (int i = 0; i < 2; i++)
        {
            int innerCounter = 0; 
            Action action = () =>
            {
                Console.WriteLine( 
                    "Outer: {0}; Inner: {1}", 
                    outerCounter, innerCounter); 
                outerCounter++; 
                innerCounter++; 
            };
            actions.Add(action);
        }
        return actions;
    }
    
    /*
      when something like this is called
      
      actions[0]();
      actions[0]();
      actions[1]();
      actions[1]();
      
      this is output
      
      Outer: 0; Inner: 0
      Outer: 1; Inner: 1
      Outer: 2; Inner: 0
      Outer: 3; Inner: 1
      
      outer counter is counting for every time the actions is called 
      while the inner is counting for every time the specific array is called
      
      for example if i had a line like actions[3] it would be an error
      
      So imagine that this method has created two arrays at declaration
      and what are you saying by action[number]() is specifying which array to enlarge
      and since this is a static method, it will enlarge array based on already being enlarged 
      in the past
      That is why outer is being +1 every time the method is called because it's outside of the 
      loop, and inner is being enlarged only when array is mentioned.
      
      () is an anonymous method that takes no arguments, also known as lambda expression. 
     */
    
    /*
        int Apply(Func<int, int> operation, int input)
        {
            return operation(input);
        }
        
        int AddOne(int x)
        {
            return x + 1;
        }
        
        int result = Apply(AddOne, 5);
        
        This is just a demonstration of how Func can work. It is called a DELEGATE
        
        You can use a Func delegate to specify the operation, 
        without knowing the specific operation in advance.
     */
    
}