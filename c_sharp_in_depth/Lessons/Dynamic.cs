namespace c_sharp_in_depth.Lessons;

public class Dynamic
{
    /*
        static void Add(dynamic d)
        {
            Console.WriteLine(d + d); 
        } 
        Add("text");
        Add(10);
        Add(TimeSpan.FromMinutes(45));
        
        As a result this one gives:
        
        - texttext
        - 20
        - 01:30:00
        
        Dynamic is a type where datatype is not defined in compile but in runtime, 
        and can be passed around as an argument
        
        For example this code wouldn't cause an error
        
        dynamic name = "Haris"
        
        name = 10;
        
        Because datatype is not defined in compile, otherwise if
        if we replace dynamic with var, it would cause an error
        
        dynamic name = "Haris";
        Console.WriteLine(name);

        name = 10;
        Console.WriteLine(name);
        
        This would as a result give:
        
        - Haris
        - 10
        
        Another example is that this would give pretty interesting results
        
        static void SampleMethod(int value)
        {
         Console.WriteLine("Method with int parameter");
        }
        static void SampleMethod(decimal value)
        {
         Console.WriteLine("Method with decimal parameter");
        }
        static void SampleMethod(object value)
        {
         Console.WriteLine("Method with object parameter");
        }
        
        static void CallMethod(dynamic d)
        {
         SampleMethod(d); 
        }
        
        CallMethod(10);
        CallMethod(10.5m);
        CallMethod(10L);
        CallMethod("text");
        
        It would give this as an answer
        
        - Method with int parameter
        - Method with decimal parameter
        - Method with decimal parameter
        - Method with object parameter
        
        
     */
}